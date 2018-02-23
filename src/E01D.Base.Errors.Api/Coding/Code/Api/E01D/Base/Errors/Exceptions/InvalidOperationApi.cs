using System;

namespace Root.Coding.Code.Api.E01D.Base.Errors.Exceptions
{
    public class InvalidOperationApi
    {
        public InvalidOperationException ComparerFailed()
        {
            return new InvalidOperationException("Failed to compare two elements in the array.");
        }

        public InvalidOperationException InconsistentResultsFromICompare(object comparer)
        {
            return
                new InvalidOperationException(
                    $"Unable to sort because the IComparer.Compare() method returns inconsistent results. Either a value does not compare equal to itself, or one value repeatedly compared to another value yields different results. IComparer: '{comparer}'.");
        }

        public InvalidOperationException FailedToCompareTwoElementsInArray()
        {
            return new InvalidOperationException("Failed to compare two elements in the array.");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        // https://github.com/dotnet/corefx/blob/master/src/System.Collections/src/Resources/Strings.resx
        public InvalidOperationException EnumOpCantHappen()
        {
            return new InvalidOperationException("Enumeration has either not started or has already finished.");
        }

        public Exception EnumFailedVersion()
        {
            return new InvalidOperationException("Collection was modified; enumeration operation may not execute.");
        }

        public InvalidOperationException LinkedListNodeIsAttached()
        {
            return new InvalidOperationException("The LinkedList node already belongs to a LinkedList");
        }

        public Exception ExternalLinkedListNode()
        {
            return new InvalidOperationException("The LinkedList node does not belong to current LinkedList.");
        }

        public Exception LinkedListEmpty()
        {
            return new InvalidOperationException("The LinkedList is empty.");
        }
    }
}
