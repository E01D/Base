using System.Collections.Generic;
using System.IO;
using Root.Code.Models.E01D.Core.IO;
using Root.Coding.Code.Api.E01D.Core;
using Root.Coding.Code.Api.E01D.Core.IO;

namespace Root.Coding.Code.Domains.E01D
{
    public static class XIO
    {
        public static IOApi Api { get; set; } = new IOApi();

        public static PathApi Paths => Api.Paths;

        public static Filename GetRandomFileName()
        {
            return Api.Files.GetRandomFilename();
        }

        public static bool FileExists(DirectoryPath path, Filename fileName)
        {
            return Api.Paths.FileExists(path, fileName);
        }

        public static bool FileExists(AbsoluteFilePath path)
        {
            return Api.Paths.FileExists(path);
        }

        public static DirectoryPath DirectoryPath(AbsoluteFilePath argumentsSolutionPath)
        {
            var fileInfo = new FileInfo(argumentsSolutionPath.Value);

            return DirectoryPath(fileInfo.Directory.FullName);
        }

        public static AbsoluteFilePath GetFilePath(Filename fileName)
        {
            return Api.Paths.GetFilePath(fileName);
        }

        public static AbsoluteFilePath AbsoluteFilePath(FileInfo fileInfo)
        {
            return Api.Paths.Filepath(fileInfo);
        }

        public static AbsoluteFilePath AbsoluteFilePath(string absolutePathAndFilename)
        {
            return Api.Paths.Filepath(absolutePathAndFilename);
        }

        public static AbsoluteFilePath AbsoluteFilePath(DirectoryPath path, Filename fileName)
        {
            return Api.Paths.Filepath(path, fileName);
        }

        public static Filename Filename(string fileName)
        {
            return Api.Files.Filename(fileName);
        }

        public static DirectoryPath DirectoryPath(string directoryFullName)
        {
            return Api.Paths.DirectoryPath(directoryFullName);
        }

        public static DirectoryPath DirectoryPath(string directoryFullName, string localName)
        {
            return Api.Paths.DirectoryPath(directoryFullName, localName);
        }

        public static DirectoryPath GetDirectoryName(string projectPathValue)
        {
            return Api.Paths.GetDirectoryName(projectPathValue);
        }

        public static RelativeFilePath RelativeFilePath(string convertToString)
        {
            return Api.Paths.GetRelativePath(convertToString);
        }

        public static DirectoryPath GetTemporaryDirectoryPath()
        {
            return Api.Paths.GetTemporaryDirectoryPath();
        }

        public static DirectoryPath CreateTemporaryDirectoryPath()
        {
            return Api.Paths.CreateTemporaryDirectoryPath();
        }

        public static string ReadAll(AbsoluteFilePath filePath)
        {
            return Api.Files.ReadAll(filePath);
        }

        public static Block CreateBlock()
        {
            return Api.Blocks.CreateBlock();
        }

        public static BlockStream_I CreateBlockStream(int blockSize)
        {
            return Api.Blocks.CreateBlockStream(blockSize);
        }

        public static BlockStream_I CreateBlockStream(System.IO.Stream stream)
        {
            return Api.Blocks.CreateBlockStream(stream);
        }

        public static byte[] CreateByteArray()
        {
            return Api.Bytes.CreateArray();
        }

        public static byte[] CreateByteArray(int size)
        {
            return Api.Bytes.CreateArray(size);
        }

        public static FileStream OpenRead(AbsoluteFilePath path)
        {
            return Api.Files.OpenRead(path);
        }

        public static List<string> CreateList(string projectListFile)
        {
            return Api.Files.CreateList(projectListFile);
        }

        public static DirectoryPath GetDirectory(DirectoryPath sourceDirectory, string projectName)
        {
            //return Api.Paths.Combine(sourceDirectory, projectName);
            throw new System.NotImplementedException();
        }

        public static void ExistsOrThrow(DirectoryPath projectDirectory)
        {
            Api.Paths.ExistsOrThrow(projectDirectory);            
        }

        public static void ExistsOrThrow(AbsoluteFilePath filepath)
        {
            Api.Files.ExistsOrThrow(filepath);
        }

        public static string[] FindFile(DirectoryPath projectDirectory, string projectName)
        {
            var filter = "*" + projectName + "*.*";

            return Directory.GetFiles(projectDirectory.Value, filter, SearchOption.TopDirectoryOnly);
        }

        public static string[] FindDirectory(DirectoryPath sourceDirectory, string projectName)
        {
            return Directory.GetDirectories(sourceDirectory.Value, projectName);
        }


        public static string DirectoryName(DirectoryPath projectAbsoluteDirectoryPath)
        {
            DirectoryInfo directory = new DirectoryInfo(projectAbsoluteDirectoryPath.Value);

            return directory.Name;
        }

        public static string DirectoryFullName(DirectoryPath projectAbsoluteDirectoryPath)
        {
            DirectoryInfo directory = new DirectoryInfo(projectAbsoluteDirectoryPath.Value);

            return directory.FullName;
        }

        public static void CopyDirectory(DirectoryPath sourcePath, DirectoryPath destinationPath)
        {
            if (!Directory.Exists(destinationPath.Value))
            {
                Directory.CreateDirectory(destinationPath.Value);
            }

            foreach (string dirPath in Directory.GetDirectories(sourcePath.Value, "*",  SearchOption.AllDirectories))
                Directory.CreateDirectory(dirPath.Replace(sourcePath.Value, destinationPath.Value));

            
            foreach (string newPath in Directory.GetFiles(sourcePath.Value, "*.*", SearchOption.AllDirectories))
                File.Copy(newPath, newPath.Replace(sourcePath.Value, destinationPath.Value), true);
        }

        public static void CopyFileToDirectory(string settingsFile, string workingDirectory, bool replace)
        {
            Api.CopyFileToDirectory(settingsFile, workingDirectory, replace);
            
        }

        public static string[] GetFiles(string path, string searchPattern, SearchOption searchOption)
        {
            return Api.Files.GetFiles(path, searchPattern, searchOption);
        }


        public static void RemoveDirectory(DirectoryPath tempDirectory)
        {
            Api.Paths.RemoveDirectory(tempDirectory);
        }
    }
}
