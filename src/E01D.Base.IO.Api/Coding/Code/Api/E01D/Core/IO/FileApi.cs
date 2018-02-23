using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Root.Code.Models.E01D.Core.IO;
using Path = System.IO.Path;

namespace Root.Coding.Code.Api.E01D.Core.IO
{
    public class FileApi
    {
        public Filename GetRandomFilename()
        {
            return Filename(Path.GetRandomFileName());
        }

        public Filename Filename(string fileName)
        {
            return new Filename
            {
                Value = fileName
            };
        }

        public Filename Filename(string fileName, string extension)
        {
            return new Filename
            {
                Value = fileName,
                Extension = extension
            };
        }

        public string ReadAll(AbsoluteFilePath filePath)
        {
            return System.IO.File.ReadAllText(filePath.Value);
        }

        /// <summary>
        /// Gets the last write time in UTC of the specified file.
        /// </summary>
        /// <param name="fullPathToFile"></param>
        /// <returns></returns>
        public DateTime GetTimeStamp(string fullPathToFile)
        {
            try
            {
                return File.GetLastWriteTimeUtc(fullPathToFile);
            }
            catch (Exception e)
            {
                throw new IOException(e.Message);
            }
        }

        public MemoryStream ReadFileToMemoryStream(string pathToFile)
        {
            var memoryStream = new MemoryStream();

            var buffer = new byte[1024];

            using (var stream = OpenRead(pathToFile))
            {
                var bytesRead = 0;

                do
                {
                    bytesRead = stream.Read(buffer, 0, buffer.Length);

                    memoryStream.Write(buffer, 0, bytesRead);
                }
                while (bytesRead > 0);
            }

            memoryStream.Position = 0;

            return memoryStream;
        }

        public async Task<MemoryStream> ReadFileToMemoryStreamAsync(string pathToFile, CancellationToken cancellationToken)
        {
            var memoryStream = new MemoryStream();

            var buffer = new byte[1024];

            using (var stream = OpenReadAsync(pathToFile))
            {
                var bytesRead = 0;

                do
                {
                    // The "configure await" is set to false since we do not care if we come back to the same thread.  No information is being
                    // stored on thread so there is no reason need it back in this case.
                    bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);

                    memoryStream.Write(buffer, 0, bytesRead);
                }
                while (bytesRead > 0);
            }

            memoryStream.Position = 0;

            return memoryStream;
        }

        public FileStream OpenRead(AbsoluteFilePath path)
        {
            return OpenRead(path.Value);
        }

        /// <summary>
        /// Opens a file stream for read and sets the mode to asynchronous read.
        /// </summary>
        /// <param name="fullPathToFile"></param>
        /// <returns>Returns a file stream</returns>
        public FileStream OpenReadAsync(string fullPathToFile)
        {
            try
            {
                return new FileStream(fullPathToFile, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, FileOptions.Asynchronous);
            }
            catch (IOException)
            {
                throw;
            }
            catch (Exception e)
            {
                throw new IOException(e.Message, e);
            }
        }

        /// <summary>
        /// Opens a file stream for read and sets the mode to asynchronous read.
        /// </summary>
        /// <param name="fullPathToFile"></param>
        /// <returns>Returns a file stream</returns>
        public FileStream OpenRead(string fullPathToFile)
        {
            try
            {
                return new FileStream(fullPathToFile, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, FileOptions.None);
            }
            catch (IOException)
            {
                throw;
            }
            catch (Exception e)
            {
                throw new IOException(e.Message, e);
            }
        }

        public List<string> CreateList(string projectListFile)
        {
            using (var stream = OpenRead(projectListFile))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    string content = reader.ReadToEnd();

                    var lines = content.Split('\n');

                    for (int i = 0; i < lines.Length; i++)
                    {
                        lines[i] = lines[i].Trim();
                    }

                    return lines.ToList();
                }
            }
        }

        public void ExistsOrThrow(AbsoluteFilePath filePath)
        {
            if (!System.IO.File.Exists(filePath.Value))
            {
                throw new System.Exception($"File '{filePath.Value}' does not exist.");
            }
        }

        public string[] GetFiles(string path, string searchPattern, SearchOption searchOption)
        {
            string[] searchPatterns = searchPattern.Split('|');

            List<string> files = new List<string>();

            foreach (string sp in searchPatterns)
            {
                files.AddRange(System.IO.Directory.GetFiles(path, sp, searchOption));
            }

            return files.ToArray();
        }

        
    }
}
