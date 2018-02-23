using Root.Code.Models.E01D.Composition.Typing.Classificational.Trees;

namespace Root.Code.Models.E01D.Types
{
    public class ClassificationLibrary
    {
        public ApiTypeTree Apis { get; set; } = new ApiTypeTree(); // lookup by type, lookup by interface, then go to type

        public ModelTypeTree Models { get; set; } = new ModelTypeTree();

        public EnumTypeTree Enums { get; set; } = new EnumTypeTree();

        public ComponentTypeTree Components { get; set; } = new ComponentTypeTree();
    }
}
