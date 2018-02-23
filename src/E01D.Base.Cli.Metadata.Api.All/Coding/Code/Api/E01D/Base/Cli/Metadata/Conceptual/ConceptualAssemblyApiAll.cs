using System.Collections.Generic;
using E01D.Base.Cli.Metadata.Enums.Coding.Code.Enums.E01D.Base.Cli.Metadata;
using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Conceptual;
using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Conceptual.Elements;

namespace Root.Coding.Code.Api.E01D.Base.Cli.Metadata.Conceptual
{
    public class ConceptualAssemblyApiAll
    {
        /// <summary>
        /// Gets all the classes that are in the assembly.
        /// </summary>
        /// <returns>Returns all the classes in the assembly.</returns>
        public List<ConceptualClass_I> GetClasses(ConceptualAssembly_I assembly)
        {
            throw new System.NotImplementedException();
            //switch (assembly.MetadataKind)
            //{
            //    case MetadataKind.Conceptual:
            //    {
            //        return null;
            //    }
            //    case MetadataKind.Physical:
            //    {
            //        return null;
            //    }
            //    case MetadataKind.Structural:
            //    {
            //        return null;
            //    }
            //}
            //return null;
        }

        /// <summary>
        /// Gets all the interfaces that are in the assembly.
        /// </summary>
        /// <returns>Returns all the types in the assembly.</returns>
        public List<ConceptualInterface_I> GetInterfaces(ConceptualAssembly_I assembly) { return null; }

        /// <summary>
        /// Gets all the types that are in the assembly.
        /// </summary>
        /// <returns>Returns all the types in the assembly.</returns>
        public List<ConceptualType_I> GetTypes(ConceptualAssembly_I assembly) { return null; }
    }
}
