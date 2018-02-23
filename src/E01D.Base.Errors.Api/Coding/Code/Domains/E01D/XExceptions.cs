using Root.Coding.Code.Api.E01D.Base.Errors;
using Root.Coding.Code.Api.E01D.Base.Errors.Exceptions;

namespace Root.Coding.Code.Domains.E01D
{
    public static class XExceptions
    {
        public static ExceptionApi Api => XErrors.Api.Exceptions;

        public static GeneralApi General => Api.General;

        public static InvalidOperationApi InvalidOperation => Api.InvalidOperation;
        public static ArgumentApi Argument => Api.Argument;

        public static NotSupportedApi NotSupported => Api.NotSupported;
        public static NotImplementedApi NotImplemented => Api.NotImplemented;
        public static ResourceApi Resource => Api.ResourceApi;

        public static PropertiesApi Properties => Api.Properites;


        public static Root.Coding.Code.Models.E01D.Base.Exceptions.Exception Exception(string message)
        {
            return General.Exception(message);
        }
    }
}
