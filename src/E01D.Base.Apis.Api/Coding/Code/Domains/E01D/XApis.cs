
using System;
using System.Collections.Generic;
using Root.Coding.Code.Api.E01D.Base;

namespace Root.Coding.Code.Domains.E01D
{
    public static class XApis
    {
        public static ApiApi Api { get; set; } = new ApiApi();


        public static void LoadApis(Type typex, Dictionary<long, object> dictionary)
        {
            Api.LoadApis(typex, dictionary);
        }

        public static void LoadAttributedApis(Type type, Dictionary<long, object> dictionary)
        {
            Api.LoadAttributedApis(type, dictionary);
        }
    }
}
