using System;

namespace Root.Coding.Code.Domains.E01D
{
    //
    // This class enables one to throw a NotImplementedException using the following idiom:
    //
    //     throw NotImplemented.ByDesign();
    //
    // It is supposed to be used by methods whose intended implementation is to throw a NotImplementedException (typically
    // virtual methods in public abstract classes that intended to be subclassed by third parties.)
    //
    // This makes it distinguishable both from human eyes and system that read code for not yet implemented methods that actually mean there is work
    // that is not complete yet.
    //
    public static class XNotImplemented
    {
        public static NotImplementedException CommentedOutTemporarily()
        {
            return XExceptions.NotImplemented.CommentedOutTemporarily();
        }

        public static NotImplementedException CommentedOutTemporarily(string message)
        {
            return XExceptions.NotImplemented.CommentedOutTemporarily(message);
        }

        public static NotImplementedException ByDesign()
        {
            return XExceptions.NotImplemented.ByDesign();
        }

        public static NotImplementedException ByDesign(string message)
        {
            return XExceptions.NotImplemented.ByDesign(message);
        }

    }
}
