using System.Collections.Generic;
using Root.Code.Models.E01D.Core.IO;

namespace Root.Coding.Code.Models.E01D.Web.Apis.Deployment
{
    public class WebApiDeployment
    {
        public List<WebServerDeployment> WebServers { get; set; } = new List<WebServerDeployment>();
        public DirectoryPath SolutionFolder { get; set; }
    }
}
