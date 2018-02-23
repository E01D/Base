using System;
using Root.Coding.Code.Models.E01D.Base.Primitives.Strings;

namespace Root.Coding.Code.Api.E01D.Base.Primitives.Strings
{
    public class StringReferenceApi
    {
        

        public string ConvertToString(StringReference stringReference)
        {
            return new string(stringReference.Chars, stringReference.StartIndex, stringReference.Length);
        }

        

        public bool EndsWith(StringReference s, string text)
        {
            if (text.Length > s.Length)
            {
                return false;
            }

            char[] chars = s.Chars;

            int start = s.StartIndex + s.Length - text.Length;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != chars[i + start])
                {
                    return false;
                }
            }

            return true;
        }

        public int IndexOf(StringReference s, char c, int startIndex, int length)
        {
            int index = Array.IndexOf(s.Chars, c, s.StartIndex + startIndex, length);
            if (index == -1)
            {
                return -1;
            }

            return index - s.StartIndex;
        }

        public char Get(StringReference stringReference, int i)
        {
            return stringReference.Chars[i];
        }

        public bool StartsWith(StringReference s, string text)
        {
            if (text.Length > s.Length)
            {
                return false;
            }

            char[] chars = s.Chars;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != chars[i + s.StartIndex])
                {
                    return false;
                }
            }

            return true;
        }

        public StringReference StringReference(char[] chars, int startIndex, int length)
        {
            return new StringReference()
            {
                Chars = chars,
                StartIndex = startIndex,
                Length = length
            };
        }
    }
}
