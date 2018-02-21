using System;

namespace E01D.Coding.Tools.RootNamespaceChanger
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static void ChangeNamespace(string projectFile)
        {
            var contents = System.IO.File.ReadAllText(projectFile);
        }
    }
}
