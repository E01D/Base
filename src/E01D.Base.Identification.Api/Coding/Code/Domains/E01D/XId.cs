using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Root.Coding.Code.Models.E01D.Base.Identification;

namespace Root.Coding.Code.Domains.E01D
{
    public static class XId
    {
        public static Id_I New(object castToLongId)
        {
            return XIdentification.Api.NewId(castToLongId);
        }
    }
}
