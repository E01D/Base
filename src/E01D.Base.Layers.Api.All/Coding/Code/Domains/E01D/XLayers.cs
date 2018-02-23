using Root.Coding.Code.Api.E01D.Base;

namespace Root.Coding.Code.Domains.E01D
{
    public static class XLayers
    {
        public static LayerAllApi Api { get; set; } = new LayerAllApi();

        //public LayerContainerApi Containers => Api.Containers;
    }
}
