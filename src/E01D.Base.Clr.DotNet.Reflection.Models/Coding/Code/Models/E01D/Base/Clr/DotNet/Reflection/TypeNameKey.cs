using System;

namespace Root.Coding.Code.Models.E01D.Base.Clr.DotNet.Reflection
{
    public struct TypeNameKey : IEquatable<TypeNameKey>
    {
        internal readonly string AssemblyName;
        internal readonly string TypeName;

        public TypeNameKey(string assemblyName, string typeName)
        {
            AssemblyName = assemblyName;
            TypeName = typeName;
        }

        public override int GetHashCode()
        {
            return (AssemblyName?.GetHashCode() ?? 0) ^ (TypeName?.GetHashCode() ?? 0);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is TypeNameKey))
            {
                return false;
            }

            return Equals((TypeNameKey)obj);
        }

        public bool Equals(TypeNameKey other)
        {
            return (AssemblyName == other.AssemblyName && TypeName == other.TypeName);
        }
    }
}
