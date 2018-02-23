namespace Root.Code.Models.E01D.Net.Http.Standard
{
    public class HttpRequest:Base.HttpRequestBase<System.Net.Http.HttpClient>, HttpRequest_I
    {
        

        
    }

    public abstract class HttpRequest<TDefinition> : Base.HttpRequestBase<TDefinition, System.Net.Http.HttpClient>, HttpRequest_I
    {



    }
}
