using System;
using System.Collections.Generic;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Clr.Reflection.Typal.Contexts;

namespace Root.Coding.Code.Api.E01D.Base
{
    public class ApiApi
    {
        public void LoadApis(System.Type interfaceType, Dictionary<long, object> dictionary)
        {
            TypalGlobalContext_I typal = XContextual.GetGlobal<TypalGlobalContext_I>();

            var y = XSemanticMetadata.Api.Elements.GetImplementingClasses(typal.Library.SemanticModel, interfaceType);

            foreach (var z in y)
            {
                var handle = XTypes.GetTypeHandle(z.TypeId);

                var type = System.Type.GetTypeFromHandle(handle);

                if (type.IsAbstract) continue;

                if (type.ContainsGenericParameters) continue;

                var implementedInterfaces = type.GetInterfaces();

                for (int i = 0; i < implementedInterfaces.Length; i++)
                {
                    //var implementedInterface = implementedInterfaces[i];

                    //if (!implementedInterface.IsGenericType) continue;

                    //var genericTypeDefinition = implementedInterface.GetGenericTypeDefinition();

                    //if (genericTypeDefinition != interfaceType) continue;

                    var instance = XNew.New(type);

                    //var arguments = implementedInterface.GenericTypeArguments;

                    //if (arguments.Length != 1) continue;

                    //XTypal.Api.Types.

                    if (!dictionary.ContainsKey(z.TypeId.Value))
                    {
                        dictionary.Add(z.TypeId.Value, instance);
                    }
                }
            }

            
        }

        public void LoadAttributedApis(Type attributeType, Dictionary<long, object> dictionary)
        {
            //var y = XTypal.GetAttributedClasses(attributeType);

            //foreach (var attributedClassSymbol in y)
            //{
            //    var classType = System.Type.GetTypeFromHandle(attributedClassSymbol.ClassSymbol.TypeHandle);

            //    if (classType.IsAbstract) continue;

            //    if (classType.ContainsGenericParameters) continue;

            //    var instance = XNew.New(classType);

            //    var attribute = (DataApiAttribute)attributedClassSymbol.Attribute;

            //    dictionary.Add(attribute.Type.TypeHandle, instance);
            //}

            throw XExceptions.NotImplemented.MissingImplementation();
        }

        public TApi GetApi<TApi, TargetTypeT>()
        {
            throw new NotImplementedException();
        }

        public TApi GetApi<TApi>()
        {
            throw new NotImplementedException();
        }
    }
}
