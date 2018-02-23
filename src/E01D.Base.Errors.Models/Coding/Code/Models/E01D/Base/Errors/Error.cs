namespace Root.Coding.Code.Models.E01D.Base.Errors
{
    public class Error:Error_I
    {
        public System.Exception Exception { get; set; }

        public string Message { get; set; }
    }
}
