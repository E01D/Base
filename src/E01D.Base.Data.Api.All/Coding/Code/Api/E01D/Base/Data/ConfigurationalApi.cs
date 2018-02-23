using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Root.Coding.Code.Api.E01D.Base.Data.Configurational;

namespace Root.Coding.Code.Api.E01D.Base.Data
{
    public class ConfigurationalApi
    {
        public DataConfigurationBuilderApi_I Builder { get; set; } = new DataConfigurationBuilderApi();
    }
}
