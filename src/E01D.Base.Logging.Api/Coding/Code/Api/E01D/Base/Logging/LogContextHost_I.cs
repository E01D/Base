﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Root.Coding.Code.Api.E01D.Base.Logging
{
    public interface LogContextHost_I
    {
        LogContext_I Logging { get; set; }
    }
}
