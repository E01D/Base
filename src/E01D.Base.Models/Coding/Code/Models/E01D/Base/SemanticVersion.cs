namespace Root.Coding.Code.Models.E01D.Base
{
    public class SemanticVersion
    {
        protected bool Equals(SemanticVersion other)
        {
            return Equals(Version, other.Version) && string.Equals(SpecialVersion, other.SpecialVersion);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((SemanticVersion) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((Version?.GetHashCode() ?? 0) * 397) ^ (SpecialVersion?.GetHashCode() ?? 0);
            }
        }

        public Version Version { get; set; } = new Version();

        public string SpecialVersion { get; set; }

        /// <summary>
        /// Gets or sets the original version of the semenatic version.
        /// </summary>
        public string OrginalValue { get; set; }

        /// <summary>
        /// Gets or sets the normalized version of the semantic version.
        /// </summary>
        public string Normalized { get; set; }

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
