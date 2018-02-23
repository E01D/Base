using System;
using System.Collections.Generic;
using System.Linq;
using Root.Coding.Code.Api.E01D.Base.Cli.Metadata.Semantic.Elements;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Semantic.Elements;
using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Semantic.Models;
using Root.Coding.Code.Models.E01D.Base.Messaging.Messages;

namespace Root.Coding.Code.Api.E01D.Base.Cli.Metadata.Semantic
{
    public class ElementApi
    {
        public TypeApi Types { get; set; } = new TypeApi();
        public ClassApi Classes { get; set; } = new ClassApi();
        public InterfaceApi Interfaces { get; set; } = new InterfaceApi();
        public EnumApi Enums { get; set; } = new EnumApi();
        public ValueTypeApi ValueTypes { get; set; } = new ValueTypeApi();
        public DelegateApi Delegates { get; set; } = new DelegateApi();
        public ArrayApi Arrays { get; set; } = new ArrayApi();
        public PointerApi Pointers { get; set; } = new PointerApi();

        public List<SemanticClass_I> GetImplementingClasses(SemanticModel_I model, Type type)
        {
            //TypalContextHost_I context = _.ContextAs<TypalContextHost_I>();

            var typeId = XTypes.GetTypeId(type);

            if (!model.Interfaces.TryGetValue(typeId.Value, out SemanticInterface symbol))
            {
                return new List<SemanticClass_I>();
            }

            return symbol.ImplementingClasses.Values.ToList();
        }

        public SemanticType_I GetOrCreateElement(SemanticModel_I model, Type type)
        {
            //SemanticType_I typeSymbol;

            if (XTypes.IsClass(type))
            {
                
                    // Get the long id associated with the type handle; by having this abstraction the semantic model can be built without having to 
                    // rely on runtime types.  Runtime types though can still be mapped to the semantic model.
                    return Classes.GetOrCreateElement(model, type);
                
            }
            else if (XTypes.IsInterface(type))
            {
                // Get the long id associated with the type handle; by having this abstraction the semantic model can be built without having to 
                // rely on runtime types.  Runtime types though can still be mapped to the semantic model.
                return Interfaces.GetOrCreateElement(model, type);
            }
            else if (XTypes.IsEnum(type))
            {
                // Get the long id associated with the type handle; by having this abstraction the semantic model can be built without having to 
                // rely on runtime types.  Runtime types though can still be mapped to the semantic model.
                return Enums.GetOrCreateElement(model, type);
            }
            else if (XTypes.IsValueType(type))
            {
                // Get the long id associated with the type handle; by having this abstraction the semantic model can be built without having to 
                // rely on runtime types.  Runtime types though can still be mapped to the semantic model.
                return ValueTypes.GetOrCreateElement(model, type);
            }
            else if (XTypes.IsDelegate(type))
            {
                // Get the long id associated with the type handle; by having this abstraction the semantic model can be built without having to 
                // rely on runtime types.  Runtime types though can still be mapped to the semantic model.
                return Delegates.GetOrCreateElement(model, type);
            }
            else if (XTypes.IsArray(type))
            {
                // Get the long id associated with the type handle; by having this abstraction the semantic model can be built without having to 
                // rely on runtime types.  Runtime types though can still be mapped to the semantic model.
                return Arrays.GetOrCreateElement(model, type);
            }
            else if (XTypes.IsPointer(type))
            {
                // Get the long id associated with the type handle; by having this abstraction the semantic model can be built without having to 
                // rely on runtime types.  Runtime types though can still be mapped to the semantic model.
                return Pointers.GetOrCreateElement(model, type);
            }
            else
            {
                XLog.LogWarning(new CannotMatchQualifiedNameToClassLogMessage()
                {
                    Message  = new Message()
                    {
                        Value = $"Could not match type '{type.AssemblyQualifiedName}' to an class, interface, enum, struct, delegate, array or pointer.  Could not add it to the semantic model on scan."
                    }
                });

                return null;
            }
        }
    }
}
