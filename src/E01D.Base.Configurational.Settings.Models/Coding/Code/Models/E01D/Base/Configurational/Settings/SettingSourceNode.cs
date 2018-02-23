using System;
using System.Collections.Generic;

namespace Root.Coding.Code.Models.E01D.Base.Configurational.Settings
{
    public abstract class SettingSourceNode<TSource>: SettingSourceNode_I
    {
        public bool IsLoaded { get; set; }

        public Action<SettingModel, List<SettingNode_I>> WriteApiResolver { get; set; }

        public Action<SettingModel> LoadApiResolver { get; set; }

        public TSource Source { get; set; }
        object SettingSourceNode_I.Source => Source;
    }
}
