using System;
using System.IO;
using System.Reflection;
using System.Text;

using Root.Code.Models.E01D.Core.IO;
using Root.Coding.Code.Api.E01D.Core.IO.Paths;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Domains.E01D.Core;

namespace Root.Coding.Code.Api.E01D.Core.IO
{
    public class PathApi
    {
        public AbsoluteFilePath GetFilePath(Filename fileName)
        {
            if (fileName?.Value == null) return null;

            var assembly = Assembly.GetEntryAssembly();

            var assemblyLocation = assembly?.Location;

            var directory = !string.IsNullOrWhiteSpace(assemblyLocation) ? System.IO.Path.GetDirectoryName(assemblyLocation) : null;

            if (string.IsNullOrWhiteSpace(directory))
            {
                assembly = Assembly.GetExecutingAssembly();

                assemblyLocation = assembly?.Location;
            }

            directory = !string.IsNullOrWhiteSpace(assemblyLocation) ? System.IO.Path.GetDirectoryName(assemblyLocation) : null;

            directory = string.IsNullOrWhiteSpace(directory) ? XBase.Api.Environmental.CurrentDirectory() : null;

            return directory != null ? Filepath(DirectoryPath(directory),fileName):  null;
        }

        public AbsoluteFilePath Filepath(FileInfo file)
        {
            return Filepath(DirectoryPath(file.DirectoryName), XIO.Api.Files.Filename(file.Name, file.Extension));
        }

        public AbsoluteFilePath Filepath(string absolutePathAndFilename)
        {
            var file = new FileInfo(absolutePathAndFilename);

            return Filepath(DirectoryPath(file.DirectoryName), XIO.Api.Files.Filename(file.Name, file.Extension));
        }

        public DirectoryPath DirectoryPath(string value)
        {
            return new DirectoryPath
            {
                Value = value
            };
        }

        public DirectoryPath CurrentDirectoryPath()
        {
            return new DirectoryPath
            {
                Value = System.IO.Directory.GetCurrentDirectory()
            };
        }

        public DirectoryPath DirectoryPath(string value, string localName)
        {
            if (value.EndsWith("\\"))
            {
                value = value + localName;
            }
            else
            {
                value = value +"\\"+ localName;
            }

            return new DirectoryPath
            {
                Value = value 
            };
        }

        public AbsoluteFilePath Filepath(DirectoryPath path, Filename name)
        {
            var value = System.IO.Path.Combine(path.Value, name.Value);

            return new AbsoluteFilePath
            {
                Value = value,
                 Filename = name,
                DirectoryPath = path
            };
        }

        public bool FileExists(DirectoryPath path, Filename fileName)
        {
            if (fileName?.Value == null) return false;

            return File.Exists(Filepath(path, fileName).Value);
        }

        public bool FileExists(AbsoluteFilePath filepath)
        {
            if (filepath?.Value == null) return false;

            return File.Exists(filepath.Value);
        }

        public void AssertFileExists(AbsoluteFilePath absoluteFilePath)
        {
            if (!File.Exists(absoluteFilePath.Value))
            {
                throw new Exception($"File {absoluteFilePath} does not exist.");
            }
        }


        public DirectoryPath GetDirectoryName(string projectPathValue)
        {
            var directoryPath = System.IO.Path.GetDirectoryName(projectPathValue);

            return new DirectoryPath()
            {
                Value = directoryPath
            };
        }

        public DirectoryPath CreateDirectoryPath(DirectoryPath value)
        {
            value = EnsureTerminalDirectorySeperator(value);

            return new DirectoryPath()
            {
                Value = value.Value
            };
        }

        public DirectoryPath CombineDirectory(DirectoryPath solutionPath, string relativePath)
        {
            solutionPath = EnsureTerminalDirectorySeperator(solutionPath);

            return XIO.DirectoryPath(solutionPath.Value += relativePath + @"\");
        }

        public string RemoveLeadingSlash(string directory)
        {
            throw new NotImplementedException();
        }

        public string GetDirectorySeperator()
        {
            return new string(new[]{System.IO.Path.DirectorySeparatorChar});
        }

        private DirectoryPath EnsureTerminalDirectorySeperator(DirectoryPath path)
        {
            //System.IO.Path.
            if (XStrings.EndsWith(path.Value, System.IO.Path.DirectorySeparatorChar))
            {
                return path;
            }

            return new DirectoryPath()
            {
                Value = path.Value + System.IO.Path.DirectorySeparatorChar
            };
        }

        public AbsoluteFilePath Combine(DirectoryPath solutionPath, RelativeFilePath projectRelativePath)
        {
            var combinedPath = System.IO.Path.Combine(solutionPath.Value, projectRelativePath.Value);

            var file = new FileInfo(combinedPath);

            return new AbsoluteFilePath()
            {
                DirectoryPath = new DirectoryPath()
                {
                    Value = file.Directory?.FullName
                },
                Filename = new Filename()
                {
                    Value = file.Name
                },
                Value = System.IO.Path.Combine(solutionPath.Value, projectRelativePath.Value)
            };
        }

        public DirectoryPath Combine(DirectoryPath solutionPath, DirectoryPath secondPath)
        {
            return new DirectoryPath()
            {
                Value = System.IO.Path.Combine(solutionPath.Value, secondPath.Value)
            };
        }

        public RelativeFilePath GetRelativePath(string convertToString)
        {
            if (convertToString == null) return null;

            return  new RelativeFilePath()
            {
                Value = convertToString
            };
        }

        public RelativeFilePath GetRelativePath(AbsoluteFilePath filePath, DirectoryPath directoryPath)
        {
            var difference2 = XIO.Api.Paths.CalculatePathDifference(filePath, directoryPath, true);

            var result2 = filePath.Value.Substring(difference2.Length, directoryPath.Value.Length - difference2.Length);

            var relativePath = new RelativeFilePath()
            {
                Value = result2
            };

            return relativePath;
        }

        public string CalculatePathDifference(AbsoluteFilePath filePath, DirectoryPath directoryPath, bool caseSensitive)
        {
            var path1 = filePath.Value;
            var path2 = directoryPath.Value;

            int divergenceIndex;
            int lastPathSeperator = -1;
            char pathSeperator = System.IO.Path.DirectorySeparatorChar;

            for (divergenceIndex = 0;
                (divergenceIndex < path1.Length) && (divergenceIndex < path2.Length);
                ++divergenceIndex)
            {
                if(path1[divergenceIndex] != path2[divergenceIndex] && (caseSensitive || (char.ToLowerInvariant(path1[divergenceIndex]) != char.ToLowerInvariant(path2[divergenceIndex]))))
                {
                    break;
                }

                if (path1[divergenceIndex] == '/')
                {
                    lastPathSeperator = divergenceIndex;
                }
            }

            if (divergenceIndex == 0)
            {
                return path2;
            }
            if ((divergenceIndex == path1.Length) && (divergenceIndex == path2.Length))
            {
                return string.Empty;
            }

            StringBuilder relPath = new StringBuilder();
            // Walk down several dirs
            for (; divergenceIndex < path1.Length; ++divergenceIndex)
            {
                if (path1[divergenceIndex] == '/')
                {
                    relPath.Append("../");
                }
            }
            // Same path except that path1 ended with a file name and path2 didn't
            if (relPath.Length == 0 && path2.Length - 1 == lastPathSeperator)
                return "./"; // Truncate the file name
            return relPath.ToString() + path2.Substring(lastPathSeperator + 1);

            
        }
        

        public DirectoryPath GetTemporaryDirectoryPath()
        {
            var path = new Root.Code.Models.E01D.Core.IO.DirectoryPath()
            {
                Value = System.IO.Path.GetTempPath()
            };

            return path;
        }

        public DirectoryPath CreateTemporaryDirectoryPath()
        {
            var path = GetTemporaryDirectoryPath();

            var result =  Combine(path, XIO.DirectoryPath(Guid.NewGuid().ToString("N")));

            if (!System.IO.Directory.Exists(result.Value))
            {
                System.IO.Directory.CreateDirectory(result.Value);
            }

            return result;

        }

        public string NormalizePath(string pathName)
        {
            if (string.IsNullOrEmpty(pathName)) return pathName;

            var isRelativePath = false;

            var caretPosition = 0;

            var isWebPath = IsWebBasedPath(pathName);

            var directorySeparator = isWebPath ? '/' : System.IO.Path.DirectorySeparatorChar;

            var builder = new StringBuilder();

            if (!isWebPath)
            {
                if (IsUNCPath(pathName))
                {
                    // skip the first two characters
                    caretPosition = 2;

                    builder.Append(directorySeparator);
                }
                else
                {
                    // IF the length is just one character, or second letter is not a colon, as in C:\
                    isRelativePath = (pathName.Length < 2 || pathName[1] != ':');
                }
            }

            var relativeLevelsBack = 0;

            var currentSegmentStartPosition = caretPosition;

            while (caretPosition <= pathName.Length)
            {
                var currentCharacter = caretPosition < pathName.Length ? pathName[caretPosition] : '\0';

                // If not at the end of the path name or not at a seperator, keep going till all characters are examined.
                if (caretPosition != pathName.Length && !IsSeperatorCharacter(currentCharacter))
                {
                    // move to the next character.
                    caretPosition++;

                    continue;
                }

                var firstSegmentChar = currentSegmentStartPosition < pathName.Length ? pathName[currentSegmentStartPosition] : '\0';

                var secondSegmentChar = currentSegmentStartPosition + 1 < (pathName.Length) ? pathName[currentSegmentStartPosition + 1] : '\0';

                var segmentLength = caretPosition - currentSegmentStartPosition;

                var segmentHandled = false;

                switch (segmentLength)
                {
                    case 0:
                        {
                            // we only care about empty segments if this is web based path
                            if (isWebPath)
                            {
                                builder.Append(directorySeparator);
                            }

                            segmentHandled = true;

                            break;
                        }
                    case 1:
                        {
                            // If just a current directory character, it is ignored, as we are "already current" when this process is over.
                            if (IsCurrentDirectoryCharacter(firstSegmentChar))
                            {
                                segmentHandled = true;

                                break;
                            }


                            // only add a spacer if there is already text present
                            if (builder.Length > 0) builder.Append(directorySeparator);

                            // add the character that is not a period.
                            builder.Append(currentCharacter);

                            segmentHandled = true;

                            break;
                        }
                    case 2:
                        {
                            if (!IsParentDirectorySequence(firstSegmentChar, secondSegmentChar))
                            {
                                break;
                            }

                            // remove previous segment by searching for the previous directory seperator

                            // at a minimum we need to erase the current seperator we are on
                            var newBuilderLength = builder.Length - 1;

                            while (newBuilderLength >= 0 && builder[newBuilderLength] != directorySeparator)
                            {
                                newBuilderLength--;
                            }

                            if (newBuilderLength > 0)
                            {
                                builder.Length = newBuilderLength;
                            }
                            else if (isRelativePath)
                            {
                                if (builder.Length == 0)
                                {
                                    relativeLevelsBack++;
                                }
                                else
                                {
                                    builder.Length = 0;
                                }
                            }

                            segmentHandled = true;

                            break;
                        }
                }

                // default implementation - just a normal segment like "Program Files"
                if (!segmentHandled)
                {
                    if (builder.Length > 0) builder.Append(directorySeparator);

                    builder.Append(pathName, currentSegmentStartPosition, segmentLength);
                }

                // set the segment start position for the next 
                currentSegmentStartPosition = caretPosition + 1;

                // move to the next character.
                caretPosition++;
            }

            if (isWebPath)
            {
                return builder.ToString();
            }

            if (isRelativePath)
            {
                for (var j = 0; j < relativeLevelsBack; j++)
                {
                    builder.Insert(0, ".." + directorySeparator);
                }
            }

            if (builder.Length > 0 && builder[builder.Length - 1] == directorySeparator)
            {
                builder.Length -= 1;
            }
            if (builder.Length == 2 && builder[1] == ':')
            {
                builder.Append(directorySeparator);
            }
            if (builder.Length == 0)
            {
                return ".";
            }

            return builder.ToString();
        }

        public bool IsCurrentDirectoryCharacter(char currentCharacter)
        {
            return currentCharacter == '.';
        }

        public bool IsCurrentDirectoryCharacter(string currentCharacter)
        {
            return currentCharacter == ".";
        }

        public bool IsParentDirectorySequence(char currentCharacter, char nextCharacter)
        {
            return currentCharacter == '.' && nextCharacter == '.';
        }

        public bool IsUNCPath(string pathName)
        {
            return (pathName.StartsWith(@"\\", StringComparison.Ordinal) ||
                    pathName.StartsWith("//", StringComparison.Ordinal));
        }
        public bool IsSeperatorCharacter(char currentCharacter)
        {
            return currentCharacter == '/' || currentCharacter == '\\';
        }

        public bool IsWebBasedPath(string pathName)
        {
            for (var pathNamePosition = 0; pathNamePosition < pathName.Length; pathNamePosition++)
            {
                var currentCharacter = pathNamePosition < pathName.Length ? pathName[pathNamePosition] : '\0';

                // we are looking for the : before any slashes.  If any slashes are found before the 
                // : is found, then we know it is not a web based path.
                if (IsSeperatorCharacter(currentCharacter))
                {
                    break;
                }

                if (pathName[pathNamePosition] == ':')
                {
                    if (pathNamePosition > 1)
                    {
                        return true;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return false;
        }

        public void ExistsOrThrow(DirectoryPath projectDirectory)
        {
            if (!Directory.Exists(projectDirectory.Value))
            {
                throw new System.Exception($"Directory '{projectDirectory.Value}' does not exist.");
            }
        }

        public DirectoryPathApi Directories { get; set; } = new DirectoryPathApi();

        public void RemoveDirectory(DirectoryPath directory)
        {
            if (directory == null) return;

            if (Directory.Exists(directory.Value))
            {
                Directory.Delete(directory.Value, true);
            }
        }

        public void CopyFiles(DirectoryPath sourceDir, DirectoryPath targetDir)
        {
            Directory.CreateDirectory(targetDir.Value);

            foreach (var file in Directory.GetFiles(sourceDir.Value))
                File.Copy(file, System.IO.Path.Combine(targetDir.Value, System.IO.Path.GetFileName(file)));

            foreach (var directory in Directory.GetDirectories(sourceDir.Value))
                CopyFiles(XIO.DirectoryPath(directory), XIO.DirectoryPath(System.IO.Path.Combine(targetDir.Value, System.IO.Path.GetFileName(directory))));
        }
    }
}
