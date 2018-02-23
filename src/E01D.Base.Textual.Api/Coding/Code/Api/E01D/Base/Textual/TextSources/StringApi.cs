using System;
using Root.Coding.Code.Exts.E01D.Base.Textual;
using Root.Coding.Code.Models.E01D.Base.Textual;

namespace Root.Coding.Code.Api.E01D.Base.Textual.TextSources
{
    public class StringApi
    {
        public string GetValue(TextSegment_I segment, TextSourceString source)
        {
            if (segment.CachedValue != null)
            {
                return segment.CachedValue;
            }

            string substringValue;

            if (segment.StartPosition <= int.MaxValue && segment.Length() <= int.MaxValue)
            {
                substringValue = source.Content.Substring((int) segment.StartPosition, (int) segment.Length());
            }
            else
            {
                throw new NotSupportedException("Strings do not support sizes greather than Int32.Max or 2,147,483,647.");
            }

            

            return substringValue;
        }

        public bool GetLookAhead(TextSourceString textSourceBase, out char lexChar)
        {
            var position = textSourceBase.Position;

            if (textSourceBase.Content.Length > position+1)
            {
                lexChar = textSourceBase.Content[(int)position + 1];

                return true;
            }

            lexChar = '\0';

            return false;
        }

        public bool GetCurrent(TextSourceString textSourceBase, out char lexChar)
        {
            var position = textSourceBase.Position;

            if (textSourceBase.Content.Length > position)
            {
                lexChar = textSourceBase.Content[(int)position];

                return true;
            }

            lexChar = '\0';

            return false;
        }
    }
}
