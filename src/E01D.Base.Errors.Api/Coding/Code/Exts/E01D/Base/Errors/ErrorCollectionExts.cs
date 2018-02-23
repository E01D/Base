using System;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Errors;

namespace Root.Coding.Code.Exts.E01D.Base.Errors
{
    public static class ErrorCollectionExts
    {

        public static void Add(this ErrorCollection_I errorCollection, Error error)
        {
            XErrors.Api.ErrorCollections.Add(errorCollection, error);
        }

        public static void Enumerate(this ErrorCollection_I errorCollection, Action<Error_I> action)
        {
            XErrors.Api.ErrorCollections.Enumerate(errorCollection, action);
        }
    }
}
