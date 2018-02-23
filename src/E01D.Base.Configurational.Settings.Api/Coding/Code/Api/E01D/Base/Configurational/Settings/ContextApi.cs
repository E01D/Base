using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Configurational.Settings;

namespace Root.Coding.Code.Api.E01D.Base.Configurational.Settings
{
    public class ContextApi
    {
        public SettingGlobalContext_I Get()
        {
            // Gets the current object registered as a SettingGlobalContext_I or creates a registration based upon the type SettingGlobalContext.
            return XContextual.GetGlobal<SettingGlobalContext_I, SettingGlobalContext>();
        }
    }
}
