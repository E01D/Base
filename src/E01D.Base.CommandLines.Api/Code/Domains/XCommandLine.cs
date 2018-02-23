using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E01D.Core.CommandLines.Api.Code.Api.Core;

namespace E01D.Core.CommandLines.Api.Code.Domains
{
    public static class XCommandLine
    {
        public static CommandLineApi Api { get; set; } = new CommandLineApi();

        public static int GetArgumentOrDefault(string[] args, int argumentIndex, int defaultValue)
        {
            return Api.GetArgumentOrDefault(args, argumentIndex, defaultValue);
        }

        public static string GetArgumentOrDefault(string[] args, int argumentIndex, string defaultValue)
        {
            return Api.GetArgumentOrDefault(args, argumentIndex, defaultValue);
        }

        public static string GetArgumentOrThrow(string[] args, int argumentIndex, string errorMessage)
        {
            return Api.GetArgumentOrThrow(args, argumentIndex, errorMessage);
        }
    }
}
