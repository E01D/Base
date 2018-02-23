using Root.Code.Models.E01D.Net.Http;
using Root.Coding.Code.Models.E01D.Net.Http.Rest.CallComponents;

namespace Root.Coding.Code.Models.E01D.Net.Http.Rest
{
    public class RestCallDefinition: HttpRequestDefinition
    {
        private RestContext _Context;

        public RestCallDefinition()
        {
            
        }

        /// <summary>
        /// Gets or sets all the components in the in the rest call.
        /// </summary>
        public RestCallComponentContainer Components { get; set; } = new RestCallComponentContainer();

        /// <summary>
        /// Gets or sets the context.
        /// </summary>
        public new RestContext Context
        {
            get
            {
                return _Context;
            }
            set
            {
                _Context = value;

                //base.Context = value;
            }
        }

        
    }
}
