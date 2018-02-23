using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Root.Coding.Code.Exts.E01D.Strings;
using Root.Coding.Code.Models.E01D.Collections.Standard;

namespace Root.Coding.Code.Api.E01D.Collections.Standard
{
    public class BidirectionalDictionaryApi
    {
        public BidirectionalDictionary<TFirst, TSecond> New<TFirst, TSecond>()
        {
            return New(EqualityComparer<TFirst>.Default, EqualityComparer<TSecond>.Default);
        }

        public BidirectionalDictionary<TFirst, TSecond> New<TFirst, TSecond>(IEqualityComparer<TFirst> firstEqualityComparer, IEqualityComparer<TSecond> secondEqualityComparer)
        {
            return New(firstEqualityComparer,
                secondEqualityComparer,
                "Duplicate item already exists for '{0}'.",
                "Duplicate item already exists for '{0}'.");
        }

        public BidirectionalDictionary<TFirst, TSecond> New<TFirst, TSecond>(IEqualityComparer<TFirst> firstEqualityComparer, IEqualityComparer<TSecond> secondEqualityComparer,
            string duplicateFirstErrorMessage, string duplicateSecondErrorMessage)
        {
            return new BidirectionalDictionary<TFirst, TSecond>()
            {
                FirstToSecond = new Dictionary<TFirst, TSecond>(firstEqualityComparer),
                SecondToFirst = new Dictionary<TSecond,TFirst > (secondEqualityComparer),
                DuplicateFirstErrorMessage = duplicateFirstErrorMessage,
                DuplicateSecondErrorMessage = duplicateSecondErrorMessage
            };
        }

        public void Set<TFirst, TSecond>(BidirectionalDictionary<TFirst, TSecond> dictionary, TFirst first, TSecond second)
        {
            TFirst existingFirst;
            TSecond existingSecond;

            if (dictionary.FirstToSecond.TryGetValue(first, out existingSecond))
            {
                if (!existingSecond.Equals(second))
                {
                    throw new ArgumentException(dictionary.DuplicateFirstErrorMessage.FormatWith(CultureInfo.InvariantCulture, first));
                }
            }

            if (dictionary.SecondToFirst.TryGetValue(second, out existingFirst))
            {
                if (!existingFirst.Equals(first))
                {
                    throw new ArgumentException(dictionary.DuplicateSecondErrorMessage.FormatWith(CultureInfo.InvariantCulture, second));
                }
            }

            dictionary.FirstToSecond.Add(first, second);
            dictionary.SecondToFirst.Add(second, first);
        }

        public bool TryGetByFirst<TFirst, TSecond>(BidirectionalDictionary<TFirst, TSecond> dictionary, TFirst first, out TSecond second)
        {
            return dictionary.FirstToSecond.TryGetValue(first, out second);
        }

        public bool TryGetBySecond<TFirst, TSecond>(BidirectionalDictionary<TFirst, TSecond> dictionary, TSecond second, out TFirst first)
        {
            return dictionary.SecondToFirst.TryGetValue(second, out first);
        }
    }
}
