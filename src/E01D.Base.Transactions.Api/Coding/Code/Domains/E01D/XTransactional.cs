﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Root.Coding.Code.Api.E01D.Base;

namespace Root.Coding.Code.Domains.E01D
{
    public static class XTransactional
    {
        public static TransactionalApi Api { get; set; } = new TransactionalApi();
    }
}
