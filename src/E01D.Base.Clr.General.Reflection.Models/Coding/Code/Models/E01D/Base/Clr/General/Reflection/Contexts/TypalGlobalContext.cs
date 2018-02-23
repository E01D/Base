namespace Root.Coding.Code.Models.E01D.Base.Clr.Reflection.Typal.Contexts
{
    public class TypalGlobalContext: TypalGlobalContext_I
    {
        public TypalLibrary_I Library { get; set; } = new TypalLibrary();
        public TypeLoadingContext_I TypeLoading { get; set; } = new TypeLoadingContext();
        
    }
}
