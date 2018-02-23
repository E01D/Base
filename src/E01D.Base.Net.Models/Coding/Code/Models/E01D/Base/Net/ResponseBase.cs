namespace Root.Coding.Code.Models.E01D.Base.Net
{
    public abstract class ResponseBase:Response_I
    {
        public Request_I Request => GetRequest();

        protected abstract Request_I GetRequest();
    }
}
