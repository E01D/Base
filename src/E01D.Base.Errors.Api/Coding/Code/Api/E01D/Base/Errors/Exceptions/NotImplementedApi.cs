using System;

namespace Root.Coding.Code.Api.E01D.Base.Errors.Exceptions
{
    public class NotImplementedApi
    {
        public NotImplementedException ByDesign()
        {
            return new NotImplementedException();
        }

        public NotImplementedException ByDesign(string message)
        {
            return new NotImplementedException(message);
        }

        public NotImplementedException CommentedOutTemporarily()
        {
            return new NotImplementedException();
        }

        public NotImplementedException CommentedOutTemporarily(string message)
        {
            return new NotImplementedException(message);
        }

        public NotImplementedException ToBeImplementedAtALaterDate()
        {
            return new NotImplementedException();
        }

        public System.Exception MissingImplementation()
        {
            return new System.NotImplementedException();
        }

        public System.Exception MissingImplementation(string message)
        {
            return new System.NotImplementedException();
        }

        public System.Exception NotYetRequired(string message)
        {
            return new System.NotImplementedException(message);
        }

        public System.Exception NotSureOfRequirement()
        {
            return new System.NotImplementedException();
        }

        public System.Exception NotSureOfRequirement(string message)
        {
            return new System.NotImplementedException(message);
        }
    }
}
