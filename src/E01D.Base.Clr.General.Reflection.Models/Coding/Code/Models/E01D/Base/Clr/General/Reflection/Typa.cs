using System;
using Root.Coding.Code.Framework.E01D;
using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Conceptual;
using Root.Coding.Code.Models.E01D.Base.Pocos;

namespace Root.Coding.Code.Models.E01D.Base.Clr.Reflection.Typal
{
    /// <summary>
    /// Represents the E01D's version of a type.
    /// </summary>
    public class Typa:Poco, Typa_I
    {
        


        public string Name { get; set; }

        public string FullName { get; set; }

        public string AssemblyQualifiedName { get; set; }

    

        [NotSerialized]
        public RuntimeTypeHandle TypeHandle { get; set; }

        public bool IsMappedToRuntime { get; set; }
        public object Runtime { get; set; }
        public object RuntimeMapping { get; set; }

        /// <summary>
        /// Gets or sets whether this type represents an array.
        /// </summary>
        public bool IsArray { get; set; }

        /// <summary>
        /// Gets or sets whether this type represents a class.
        /// </summary>
        public bool IsClass { get; set; }

        /// <summary>
        /// Gets or sets whether this type represents a delegate.
        /// </summary>
        public bool IsDelegate { get; set; }

        /// <summary>
        /// Gets or sets whether this type represents an enumeration.
        /// </summary>
        public bool IsEnum { get; set; }

        /// <summary>
        /// Gets or sets whether this type represents a interface.
        /// </summary>
        public bool IsInterface { get; set; }

        /// <summary>
        /// Gets or sets whether this type represents a pointer.
        /// </summary>
        public bool IsPointer { get; set; }



        /// <summary>
        /// Gets or sets whether this type represents a struct / value type.
        /// </summary>
        public bool IsStruct { get; set; }

        

        

        

        /// <summary>
        /// Gets or sets whether this type represents a type parameter.
        /// </summary>
        public bool IsTypeParameter { get; set; }

        public bool IsExtern { get; set; }
        public bool IsAbstract { get; set; }
        public bool IsSealed { get; set; }
        public MetadataModifier MetadataModifiers { get; set; }
        public bool IsMember { get; set; }
        public TypeKind TypeKind { get; set; }
    }
}
