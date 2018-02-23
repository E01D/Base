using Root.Coding.Code.Models.E01D.Base.Types;

namespace Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Conceptual.Elements
{
    public interface ConceptualType_I:ConceptualNamespaceOrType_I
    {
        
        //TypeId_I TypeId { get; }
       
        
        

        /// <summary>
        /// Gets the kind of type this instance represents.  It can be a class, interface, delegate, struct, enum, pointer, array, or type parameter.
        /// </summary>
        /// <designNotes>The use of this enum enables the IsClass, IsInterface, etc, to become methods instead of properties, and thus simplifies the </designNotes>
        TypeKind TypeKind { get; }

       
    }
}
