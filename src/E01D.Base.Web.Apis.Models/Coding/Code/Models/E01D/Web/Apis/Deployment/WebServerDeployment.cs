using System.Collections.Generic;
using Root.Code.Models.E01D.Core.IO;

namespace Root.Coding.Code.Models.E01D.Web.Apis.Deployment
{
    public class WebServerDeployment
    {
        public string Name { get; set; }

        public string Server { get; set; }

        public string Port { get; set; }

        public string ProjectTemplate { get; set; }

        public List<NetworkNode> NetworkNodes { get; set; } = new List<NetworkNode>();

        //public List<Project> Projects { get; set; } = new List<Project>();
        public string Type { get; set; }

        public DirectoryPath TemporaryDirectory { get; set; }

        
    }
}
