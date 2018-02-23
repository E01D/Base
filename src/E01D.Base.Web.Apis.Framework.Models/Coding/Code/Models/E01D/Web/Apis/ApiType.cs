using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Root.Coding.Code.Models.E01D.Web.Apis
{
    public class ApiTypeAttribute : System.Attribute
    {
        public ApiTypeAttribute(string urlName)
        {
            UrlName = urlName;
        }

        public string UrlName { get; set; }
    }
}
