using System;
using System.Collections.Generic;

namespace Root.Coding.Code.Models.E01D.Base.Configurational.Settings
{
    public interface SettingSourceNode_I
    {
        object Source { get; }

        bool IsLoaded { get; set; }

        Action<SettingModel> LoadApiResolver { get; set; }

        Action<SettingModel, List<SettingNode_I>> WriteApiResolver { get; set; }

        
    }
}
