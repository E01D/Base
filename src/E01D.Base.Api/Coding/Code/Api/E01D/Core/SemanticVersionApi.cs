using System;
using System.Text;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Domains.E01D.Core;
using Root.Coding.Code.Exts.E01D.Core;
using Root.Coding.Code.Models.E01D.Base;
using Version = Root.Coding.Code.Models.E01D.Base.Version;

namespace Root.Coding.Code.Api.E01D.Core
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>http://blog.nuget.org/20140924/supporting-semver-2.0.0.html</remarks>
    public class SemanticVersionApi
    {
        

        

        public bool AreEqual(SemanticVersion versionA, SemanticVersion versionB)
        {
            if (ReferenceEquals(versionA, null))
            {
                return ReferenceEquals(versionB, null);
            }

            if (ReferenceEquals(null, versionB)) return false;

            if (!versionA.Version.Equals(versionB.Version)) return false;
            
            return string.Compare(versionA.SpecialVersion, versionB.SpecialVersion, StringComparison.OrdinalIgnoreCase) == 0;
        }

        public bool AreNotEqual(SemanticVersion versionA, SemanticVersion versionB)
        {
            return !AreEqual(versionA, versionB);
        }

        public SemanticVersion Create(string versionAsString)
        {
            var version = new SemanticVersion()
            {
                OrginalValue = versionAsString
            };

            return version;
        }

        public SemanticVersion Create(int major, int minor, int build, int revision)
        {
            return Create(XBase.Api.Versions.Create(major, minor, build, revision));
        }

        public SemanticVersion Create(Version version)
        {
            return Create(version, string.Empty);
        }

        public SemanticVersion Create(Version version, string specialVersion)
        {
            return Create(version, specialVersion, null);
        }

        public SemanticVersion Create(Version version, string specialVersion, string orginalValue)
        {
            if (version == null)
            {
                throw XArgumentException.IsNull(nameof(version));
            }

            var semanticVersion = new SemanticVersion
            {
                SpecialVersion = specialVersion ?? string.Empty,
                OrginalValue = string.IsNullOrEmpty(orginalValue) ? version + (!string.IsNullOrEmpty(specialVersion) ? '-' + specialVersion : null) : orginalValue,
                
            };

            XNotImplemented.CommentedOutTemporarily("Need to revist the source documentation and complete the algorithm.");
            

            return semanticVersion;
        }

        public SemanticVersion Create(SemanticVersion semanticVersion)
        {
            return new SemanticVersion
            {
                OrginalValue = semanticVersion.ToString(),
                Version = semanticVersion.Version,
                SpecialVersion = semanticVersion.SpecialVersion
            };
        }

        public int Compare(SemanticVersion versionA, SemanticVersion versionB)
        {
            if (ReferenceEquals(versionA, versionB)) return 0;

            if (ReferenceEquals(versionB, null)) return 1;

            if (ReferenceEquals(versionA, null)) return -1;

            var compareValue = XBase.Api.Versions.Compare(versionA.Version, versionB.Version);

            if (compareValue != 0)
            {
                return compareValue;
            }

            var versionASpecialVersionIsNullOrEmpty = string.IsNullOrEmpty(versionA.SpecialVersion);

            var versionBSpecialVersionIsNullOrEmpty = string.IsNullOrEmpty(versionB.SpecialVersion);

            if (versionASpecialVersionIsNullOrEmpty && versionBSpecialVersionIsNullOrEmpty)
            {
                return 0;
            }

            if (versionASpecialVersionIsNullOrEmpty)
            {
                return 1;
            }

            if (versionBSpecialVersionIsNullOrEmpty)
            {
                return -1;
            }

            return StringComparer.OrdinalIgnoreCase.Compare(versionA.SpecialVersion, versionB.SpecialVersion);
        }

        public string ConvertToString(SemanticVersion version)
        {
            return version.OrginalValue;
        }

        /// <summary>
        /// Generates the hash code for a semantic version.
        /// </summary>
        /// <param name="version"></param>
        /// <returns></returns>
        public int GetHash(SemanticVersion version)
        {
            if (version == null) return 0;

            return (version.Version?.GetHash() ?? 0) * 4567 + (version?.SpecialVersion?.GetHashCode() ?? 0);
        }

        public string ToNormalizedString(SemanticVersion semanticVersion)
        {
            if (semanticVersion.Normalized != null) return semanticVersion.Normalized;
            
            var builder = new StringBuilder();

            var buildNumber = Math.Max(0, semanticVersion.Version.Build);

            builder.Append(semanticVersion.Version.Major)
                    .Append('.')
                    .Append(semanticVersion.Version.Minor)
                    .Append('.')
                    .Append(buildNumber);

            // do not add a zero to the end of the version if it is not needed.
            if (semanticVersion.Version.Revision > 0)
            {
                builder.Append('.').Append(semanticVersion.Version.Revision);
            }

            // only add the special version if the special version is not null
            if (!string.IsNullOrEmpty(semanticVersion.SpecialVersion))
            {
                builder.Append('-').Append(semanticVersion.SpecialVersion);
            }

            semanticVersion.Normalized = builder.ToString();
            

            return semanticVersion.Normalized;
        }

        public bool IsLess(SemanticVersion versionA, SemanticVersion versionB)
        {
            return Compare(versionA, versionB) < 0;   
        }

        public bool IsLessOrEqual(SemanticVersion versionA, SemanticVersion versionB)
        {
            return AreEqual(versionA, versionB) || IsLess(versionA, versionB);
        }

        public bool IsGreater(SemanticVersion versionA, SemanticVersion versionB)
        {
            // swap on purpose
            return IsLess(versionB, versionA);
        }

        public bool IsGreaterOrEqual(SemanticVersion versionA, SemanticVersion versionB)
        {
            return AreEqual(versionA, versionB) || IsGreater(versionA, versionB);       
        }

        //public static bool operator ==(SemanticVersion versionA, SemanticVersion versionB)
        //{
        //    //return _.ResolveApi<SemanticVersionBridge_I>().AreEqual(versionA, versionB);
        //    throw new System.NotImplementedException();
        //}

        //public static bool operator !=(SemanticVersion versionA, SemanticVersion versionB)
        //{
        //    //return _.ResolveApi<SemanticVersionBridge_I>().AreNotEqual(versionA, versionB);
        //    throw new System.NotImplementedException();
        //}
    }
}
