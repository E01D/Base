using Root.Code.Models.E01D.Composition.Assemblies;
using Root.Code.Models.E01D.Composition.Typing;

namespace Root.Code.Models.E01D.Composition
{
    public class CompositionContext
    {
        public AssemblyContext Assemblies { get; set; } = new AssemblyContext();

        public TypingContext Typing { get; set; } = new TypingContext();
    }

    
}
