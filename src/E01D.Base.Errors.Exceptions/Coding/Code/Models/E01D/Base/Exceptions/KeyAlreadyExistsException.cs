using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Root.Coding.Code.Models.E01D.Base.Exceptions
{
    public class KeyAlreadyExistsException : Exception
    {
        public string Key { get; set; }
    }
}
