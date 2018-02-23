using System;
using System.Collections;
using System.Collections.Generic;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Exts.E01D.Base.Cli.Metadata.Conceptual.Elements;
using Root.Coding.Code.Exts.E01D.Base.Cli.Metadata.Semantic;
using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Semantic.Elements;
using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Semantic.Models;
using Root.Coding.Code.Models.E01D.Base.Types;

namespace Root.Coding.Code.Api.E01D.Base.Cli.Metadata.Semantic.Elements
{
    public abstract class TypeBaseApi<TTypeElement> where TTypeElement : SemanticType_I
    {
        public abstract Dictionary<long, TTypeElement> GetModelStorage(SemanticModel_I model);

        public abstract TTypeElement CreateNewElement(SemanticModel_I model, System.Type type);

        private TTypeElement CreateAndAddElement(SemanticModel_I semanticModel, Type type, RuntimeTypeHandle typeHandle, Dictionary<long, TTypeElement> storage)
        {
            TTypeElement element = CreateElement(semanticModel, type);

            AddElement(semanticModel, typeHandle, storage, element);

            AddCustomElementsOnElementCreate(semanticModel, element, type);

            AddInterfacesOnElementCreate(semanticModel, element, type);

            return element;
        }

        public TTypeElement CreateElement(SemanticModel_I semanticModel, System.Type type)
        {
            var element = CreateNewElement(semanticModel, type);

            element.RuntimeMapping = type.TypeHandle;
            element.TypeId = GetTypeId(type);

            OnCreateElement(semanticModel, element, type);

            return element;
        }

        private TypeId_I GetTypeId(Type type)
        {
            return XTypes.GetTypeId(type);
        }

        private void AddInterfacesOnElementCreate(SemanticModel_I semanticModel, TTypeElement element, Type type)
        {
            if (XTypes.IsClass(type) || XTypes.IsInterface(type))
            {
                Type[] interfaces = type.GetInterfaces();

                List<Type> interfaceQueue = new List<Type>();

                interfaceQueue.AddRange(interfaces);

                if (type.Name == "UserSqlDataLayer")
                {
                    
                }

                //for (var baseType = type.BaseType; baseType != null; baseType = baseType?.BaseType)
                //{
                //    if (baseType == null) continue;

                //    interfaces = baseType.GetInterfaces();

                //    interfaceQueue.AddRange(interfaces);
                //}
                
                Dictionary<RuntimeTypeHandle, Type> seenTypes = new Dictionary<RuntimeTypeHandle, Type>();

                while (interfaceQueue.Count > 0)
                {
                    var activeInterfaces = interfaceQueue.ToArray();

                    interfaceQueue.Clear();

                    // ReSharper disable once ForCanBeConvertedToForeach
                    for (var i = 0; i < activeInterfaces.Length; i++)
                    {
                        var interfaceType = activeInterfaces[i];

                        if (seenTypes.ContainsKey(interfaceType.TypeHandle)) continue;

                        seenTypes.Add(interfaceType.TypeHandle, interfaceType);

                        AddInterface(semanticModel, element, interfaceType);

                        if (interfaceType.IsGenericType)
                        {
                            var interfaceGenericTypeDefinition = interfaceType.GetGenericTypeDefinition();

                            AddInterface(semanticModel, element, interfaceGenericTypeDefinition);
                        }

                        interfaces = type.GetInterfaces();

                        interfaceQueue.AddRange(interfaces);
                    }
                }
            }
        }

        private void AddInterface(SemanticModel_I semanticModel, SemanticType_I implementingTypeSymbol, Type interfaceType)
        {
            var interfaceElement = (SemanticInterface_I)semanticModel.GetOrCreateElement(interfaceType);

            if (implementingTypeSymbol != null)
            {
                if (implementingTypeSymbol.IsClass())
                {
                    if (!interfaceElement.ImplementingClasses.TryGetValue(implementingTypeSymbol.TypeId.Value, out SemanticClass_I classSymbol))
                    {
                        classSymbol = (SemanticClass_I)implementingTypeSymbol;

                        interfaceElement.ImplementingClasses.Add(classSymbol.TypeId.Value, classSymbol);
                    }
                }

                if (!interfaceElement.ImplementingTypes.TryGetValue(implementingTypeSymbol.TypeId.Value, out SemanticType_I existingTypeSymbol))
                {
                    interfaceElement.ImplementingTypes.Add(implementingTypeSymbol.TypeId.Value, implementingTypeSymbol);
                }
            }
        }

        private void AddCustomElementsOnElementCreate(SemanticModel_I semanticModel, TTypeElement element, Type type)
        {
            // put all of this into semantic model code base.
            object[] categorizedAttributes = XTypes.GetCustomAttributes(type);

            for (int i = 0; i < categorizedAttributes.Length; i++)
            {
                var categorizedAttribute = categorizedAttributes[i];

                var attributeType = categorizedAttribute.GetType();

                var attributeClass = (SemanticAttributeClass)semanticModel.GetOrCreateElement(attributeType);

                if (!attributeClass.ImplementingTypes.ContainsKey(element.TypeId.Value))
                {
                    attributeClass.ImplementingTypes.Add(element.TypeId.Value, element);
                }

                if (element.IsClass())
                {
                    if (!attributeClass.ImplementingClasses.ContainsKey(element.TypeId.Value))
                    {
                        attributeClass.ImplementingClasses.Add(element.TypeId.Value, (SemanticClass_I) element);
                    }
                }

                if (element.IsInterface())
                {
                    if (!attributeClass.ImplementingInterfaces.ContainsKey(element.TypeId.Value))
                    {
                        attributeClass.ImplementingInterfaces.Add(element.TypeId.Value, (SemanticInterface_I) element);
                    }
                }

                SemanticAttributeTypeMapping mapping = XNew.New<SemanticAttributeTypeMapping>();
                mapping.ImplementingType = element;
                mapping.AttributeClass = attributeClass;
                mapping.Instance = categorizedAttribute;

                attributeClass.Instances.Add(mapping);
            }
        }

        private SemanticAttribute CreateAttribute(object categorizedAttribute, TTypeElement element)
        {
            SemanticAttribute attribute = XNew.New<SemanticAttribute>();

            attribute.RuntimeMapping = categorizedAttribute;

            return attribute;
        }

        public abstract void OnCreateElement(SemanticModel_I semanticModel, TTypeElement element, Type type);

        public TTypeElement GetOrCreateElement(SemanticModel_I semanticModel, System.Type type)
        {
            TTypeElement typeElement;

            var storage = GetModelStorage(semanticModel);

            var typeHandle = type.TypeHandle;

            var typeId = XTypes.GetTypeId(type);

            if (!storage.TryGetValue(typeId.Value, out typeElement))
            {
                typeElement = CreateAndAddElement(semanticModel, type, typeHandle, storage);
            }

            return typeElement;
        }

        

        public void AddElement(SemanticModel_I semanticModel, RuntimeTypeHandle typeHandle, Dictionary<long, TTypeElement> storage, TTypeElement classElement)
        {
            storage.Add(classElement.TypeId.Value, classElement);

            semanticModel.Types.Add(classElement.TypeId.Value, classElement);
            
        }
    }
}
