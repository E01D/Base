using System.Collections.Generic;
using Root.Code.Models.E01D.Core.IO;
using Root.Coding.Code.Models.E01D.Web.Apis.Deployment;

namespace Root.Coding.Code.Domains.E01D.Web.Apis
{
    public static class XWebApi
    {
        public static WebApiDeployment ReadSetup(AbsoluteFilePath setupFile)
        {
            var webServers = new List<WebServerDeployment>
            {
                new WebServerDeployment()
                {
                    Name = "Platform",
                    Type = "platform",
                    Port = "5050",
                    Server="localhost",
                    ProjectTemplate = "E01D.Nodal.Web",
                    
                },
                new WebServerDeployment()
                {
                    Name = "Security",
                    Type = "security",
                    Port = "5051",
                    Server="localhost",
                    ProjectTemplate = "E01D.Nodal.Web"
                },
                new WebServerDeployment()
                {
                    Name = "Ioc",
                    Type = "app",
                    Port = "5052",
                    Server="localhost",
                    ProjectTemplate = "E01D.Nodal.Web"
                }
            };




            return new WebApiDeployment()
            {
                SolutionFolder= XIO.DirectoryPath(@"C:\Dev\VSO\EvolvingGit\Site\src"),
                WebServers = webServers
            };
        }
    }
}
