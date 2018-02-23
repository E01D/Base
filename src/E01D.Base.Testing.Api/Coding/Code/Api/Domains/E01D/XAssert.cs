using System;
using System.Collections.Generic;
using System.Text;
using Root.Coding.Code.Api.E01D.Base.Testing;

namespace Root.Coding.Code.Api.Domains.E01D
{
    public static class XAssert
    {
        public static AssertionApi Api => XTesting.Api.Assertions;

        public static void LengthIs(string result, int length)
        {
            Api.LengthIs(result, length);
        }

        public static void OnlyContains(string result, string tryteAlphabet)
        {
            for (int i = 0; i < result.Length; i++)
            {
                var current = result[i];

                var found = false;

                for (int j = 0; j < tryteAlphabet.Length; j++)
                {
                    if (current == tryteAlphabet[j])
                    {
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    throw new Exception("Contains a character not in the alphabet.");
                }
            }
        }
    }
}
