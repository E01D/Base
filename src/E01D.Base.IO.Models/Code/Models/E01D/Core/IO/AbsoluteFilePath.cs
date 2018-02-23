namespace Root.Code.Models.E01D.Core.IO
{
    public class AbsoluteFilePath
    {
        public DirectoryPath DirectoryPath { get; set; }

        public Filename Filename { get; set; }

        public string Value { get; set; }

        public (DirectoryPath Directory, Filename Filename) Deconstruct()
        {
            return (DirectoryPath, Filename);
        }
    }
}
