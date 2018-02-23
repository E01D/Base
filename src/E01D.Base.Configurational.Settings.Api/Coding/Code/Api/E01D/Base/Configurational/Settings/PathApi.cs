using System;
using System.Collections.Generic;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Configurational.Settings;

namespace Root.Coding.Code.Api.E01D.Base.Configurational.Settings
{
    public class PathApi
    {
        public string KeyDelimiter()
        {
            var globalContext = XSettings.Api.Contexts.Get();

            return globalContext.KeyDelimiter;
        }

        /// <summary>
        /// Combines path segments into one path.
        /// </summary>
        /// <param name="pathSegments">The path segments to combine.</param>
        /// <returns>The combined path.</returns>
        public string Combine(params string[] pathSegments)
        {
            if (pathSegments == null)
            {
                throw new ArgumentNullException(nameof(pathSegments));
            }
            return string.Join(KeyDelimiter(), pathSegments);
        }

        /// <summary>
        /// Combines path segments into one path.
        /// </summary>
        /// <param name="pathSegments">The path segments to combine.</param>
        /// <returns>The combined path.</returns>
        public string Combine(IEnumerable<string> pathSegments)
        {
            if (pathSegments == null)
            {
                throw new ArgumentNullException(nameof(pathSegments));
            }
            return string.Join(KeyDelimiter(), pathSegments);
        }

        /// <summary>
        /// Extracts the last path segment from the path.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns>The last path segment of the path.</returns>
        public string GetSectionKey(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                return path;
            }

            var lastDelimiterIndex = path.LastIndexOf(KeyDelimiter(), StringComparison.OrdinalIgnoreCase);
            return lastDelimiterIndex == -1 ? path : path.Substring(lastDelimiterIndex + 1);
        }

        public string[] SplitPath(string path)
        {
            return path.Split(new string[]{ KeyDelimiter() }, StringSplitOptions.None);
        }

        /// <summary>
        /// Extracts the path corresponding to the parent node for a given path.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns>The original path minus the last individual segment found in it. Null if the original path corresponds to a top level node.</returns>
        public string GetParentPath(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                return null;
            }

            var lastDelimiterIndex = path.LastIndexOf(KeyDelimiter(), StringComparison.OrdinalIgnoreCase);
            return lastDelimiterIndex == -1 ? null : path.Substring(0, lastDelimiterIndex);
        }

        public string GetFullKey(SettingNode_I node)
        {
            var seperator = KeyDelimiter();

            string fullKey = node.Key;

            while (node.Parent?.Parent != null)
            {
                node = node.Parent;

                fullKey = node.Key + seperator + fullKey;
            }

            return fullKey;
        }
    }
}
