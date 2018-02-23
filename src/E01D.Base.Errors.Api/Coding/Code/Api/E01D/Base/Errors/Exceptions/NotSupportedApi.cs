using System;

namespace Root.Coding.Code.Api.E01D.Base.Errors.Exceptions
{
    public class NotSupportedApi
    {
        public NotSupportedException DefaultEnumValueShouldNotBeUsed()
        {
            return new NotSupportedException();
        }

        public NotSupportedException PropertyIsReadOnly()
        {
            return new NotSupportedException("Property is readonly.");
        }

        public Exception EnumerationValueIsNotValid()
        {
            return new NotSupportedException("Enumeration Value Is Not Valid.");
        }

        public Exception EnumerationValueIsNotValid(object value)
        {
            return new NotSupportedException($@"Enumeration {value} is not a valid value.");
        }
    }
}
