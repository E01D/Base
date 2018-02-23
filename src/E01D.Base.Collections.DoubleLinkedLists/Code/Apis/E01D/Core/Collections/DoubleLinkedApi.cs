namespace Root.Code.Apis.E01D.Core.Collections
{
    public class DoubleLinkedApi
    {
        public DoubleLinkedListApi Lists { get; set; } = new DoubleLinkedListApi();

        public DoubleLinkedListNodeApi Nodes { get; set; } = new DoubleLinkedListNodeApi();
    }
}
