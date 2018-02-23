using Root.Coding.Code.Api.E01D.Base;

namespace Root.Coding.Code.Domains.E01D
{
    public static class XLayersBase
    {
        public static LayerBaseApi Api { get; set; } = new LayerBaseApi();

        //public LayerContainerApi Containers => Api.Containers;
    }
}
