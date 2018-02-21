using System;
using System.Linq;

namespace E01D.Coding.Tools.ProjectCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            string solutionDirectory = @"C:\Dev\Git\E01D\Base\src\";
            string projectListFile = @"C:\Dev\Git\E01D\Base\src\E01D.Coding.Tools.ProjectCreator\ProjectList.txt";
            string solutionListFile = @"C:\Dev\Git\E01D\Base\src\E01D.Coding.Tools.ProjectCreator\solution.txt";

            var projectList = System.IO.File.ReadLines(projectListFile).ToList();

            using (System.IO.FileStream solutionStream = new System.IO.FileStream(solutionListFile, System.IO.FileMode.Create, System.IO.FileAccess.ReadWrite))
            {
                using (System.IO.StreamWriter writer = new System.IO.StreamWriter(solutionStream))
                {
                    for (int i = 0; i < projectList.Count; i++)
                    {
                        var projectName = projectList[i];
                        projectName = projectName.Trim();

                        var projectDirectory = solutionDirectory + projectName + @"\";

                        if (!System.IO.Directory.Exists(projectDirectory))
                        {
                            System.IO.Directory.CreateDirectory(projectDirectory);

                            var projectContents = projectTemplate;

                            var projectFileName = projectDirectory + projectName + ".csproj";

                            System.IO.File.WriteAllText(projectFileName, projectContents);
                        }

                        string projectGuid = Guid.NewGuid().ToString("B");
                        writer.WriteLine(@"Project(""{9A19103F-16F7-4668-BE54-9A1E7A4F7556}"") = """ + projectName + @""", """ + projectName + @"\" + projectName + @".csproj"", """ + projectGuid + @"""");
                        writer.WriteLine("EndProject");
                    }

                    writer.Flush();
                }

                

            }
        }

        static string projectTemplate = @"<Project Sdk=""Microsoft.NET.Sdk"">

  <PropertyGroup>
    <TargetFramework>netcoreapp2.0</TargetFramework>
    <RootNamespace>Root</RootNamespace>
  </PropertyGroup>

</Project>";
    }
}
