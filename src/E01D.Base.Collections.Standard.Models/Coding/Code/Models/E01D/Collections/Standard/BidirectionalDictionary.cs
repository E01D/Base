using System.Collections.Generic;

namespace Root.Coding.Code.Models.E01D.Collections.Standard
{
    public class BidirectionalDictionary<TFirst, TSecond>
    {
        public IDictionary<TFirst, TSecond> FirstToSecond { get; set; }
        public IDictionary<TSecond, TFirst> SecondToFirst { get; set; }
        public string DuplicateFirstErrorMessage { get; set; }
        public string DuplicateSecondErrorMessage { get; set; }

        

        
    }
}
