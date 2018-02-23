using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Semantic.Models;

namespace Root.Coding.Code.Models.E01D.Base.Clr.Reflection.Typal
{
    public class TypalLibrary: TypalLibrary_I
    {
        /// <summary>
        /// Gets or sets the current semantic model that is associated with this context.
        /// </summary>
        public SemanticModel SemanticModel { get; set; } = new SemanticModel();

        public TypalModel TypalModel { get; set; }
        

        //public SymbolLibrary Symbols { get; set; } = new SymbolLibrary();


        //public TypaLibrary Typas { get; set; } = new TypaLibrary();
    }
}
