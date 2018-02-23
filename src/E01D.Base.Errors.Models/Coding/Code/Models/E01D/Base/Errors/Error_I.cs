

namespace Root.Coding.Code.Models.E01D.Base.Errors
{
    public interface Error_I
    {
        System.Exception Exception { get; set; }

        string Message { get; set; }
    }
}
