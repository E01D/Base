using Root.Coding.Code.Api.E01D.Base.Cli.Metadata.Conceptual.Elements;

namespace Root.Coding.Code.Api.E01D.Base.Cli.Metadata.Conceptual
{
    public class ElementsApi
    {
        /// <summary>
        /// Gets or sets the api used to manipulate conceptual attributes.
        /// </summary>
        public ConceptualAttributeApi Attributes { get; set; } = new ConceptualAttributeApi();

        /// <summary>
        /// Gets or sets the api used to manipulate conceptual constants.
        /// </summary>
        public ConceptualConstantApi Constants { get; set; } = new ConceptualConstantApi();

        /// <summary>
        /// Gets or sets the api used to manipulate conceptual constructors.
        /// </summary>
        public ConceptualConstructorApi Constructors { get; set; } = new ConceptualConstructorApi();

        /// <summary>
        /// Gets or sets the api used to manipulate conceptual events.
        /// </summary>
        public ConceptualEventApi Events { get; set; } = new ConceptualEventApi();

        /// <summary>
        /// Gets or sets the api used to manipulate conceptual fields.
        /// </summary>
        public ConceptualFieldApi Fields { get; set; } = new ConceptualFieldApi();

        /// <summary>
        /// Gets or sets the api used to manipulate conceptual finalizers.
        /// </summary>
        public ConceptualFinalizerApi Finalizers { get; set; } = new ConceptualFinalizerApi();

        /// <summary>
        /// Gets or sets the api used to manipulate conceptual indexers.
        /// </summary>
        public ConceptualIndexerApi Indexers { get; set; } = new ConceptualIndexerApi();

        /// <summary>
        /// Gets or sets the api used to manipulate conceptual metadata.
        /// </summary>
        public ConceptualMetadataApi Metadata { get; set; } = new ConceptualMetadataApi();

        /// <summary>
        /// Gets or sets the api used to manipulate conceptual methods.
        /// </summary>
        public ConceptualMethodApi Methods { get; set; } = new ConceptualMethodApi();

        /// <summary>
        /// Gets or sets the api used to manipulate conceptual operators.
        /// </summary>
        public ConceptualOperatorApi Operators { get; set; } = new ConceptualOperatorApi();

        /// <summary>
        /// Gets or sets the api used to manipulate conceptual properties.
        /// </summary>
        public ConceptualPropertyApi Properties { get; set; } = new ConceptualPropertyApi();

        /// <summary>
        /// Gets or sets the api used to manipulate conceptual types.
        /// </summary>
        public ConceptualTypeApi Types { get; set; } = new ConceptualTypeApi();
    }
}
