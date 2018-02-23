using System;
using System.Collections.Generic;
using System.Reflection;
using Root.Coding.Code.Domains.E01D;

namespace Root.Coding.Code.Exts.E01D.Base.Clr.DotNet.Reflection.Types
{
    public static class BasicTypeExts
    {
        

        public static bool IsDictionaryType(Type type)
        {
            return XBaseTypes.IsDictionaryType(type);
        }
    }
}
