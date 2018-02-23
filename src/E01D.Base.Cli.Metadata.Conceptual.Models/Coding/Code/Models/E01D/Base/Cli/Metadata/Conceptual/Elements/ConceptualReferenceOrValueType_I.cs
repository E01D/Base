using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Conceptual.Elements
{
    public interface ConceptualReferenceOrValueType_I: ConceptualNamedType_I
    {
        /// <summary>
        /// Returns the type's arity, the number of type parameters it takes.  Note, a non-generic type has zero arity.
        /// </summary>
        int Arity { get; }

        /// <summary>
        /// Gets whether this type or a containing type, has type parameters.
        /// </summary>
        bool IsGenericType { get; }
    }
}
