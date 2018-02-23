using System;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Configurational.Settings;

namespace Root.Coding.Code.Api.E01D.Base.Configurational.Settings.Building
{
    public class SettingBuilderApi : SettingBuilderApi_I
    {


        public void AddSetting(SettingSourceNode_I node)

        {
            // Gets the current object registered as a SettingGlobalContext_I or creates a registration based upon the type SettingGlobalContext.
            var globalContext = XSettings.Api.Contexts.Get();

            globalContext.SettingSources.Add(node);
        }

        public SettingModel Build()
        {
           

            SettingModel model = new SettingModel()
            {
                Root = XSettings.Api.Nodes.CreateSectionNode(null, "Root")
            };

            var globalContext = XSettings.Api.Contexts.Get();

            // ReSharper disable once ForCanBeConvertedToForeach
            for (var i = 0; i < globalContext.SettingSources.Count; i++)
            {
                globalContext.SettingSources[i].LoadApiResolver.Invoke(model);

                globalContext.SettingSources[i].IsLoaded = true;
            }

            var context = XSettings.Api.Contexts.Get();

            context.CurrentModel = model;

            return model;

        }

        public SettingModel Update()
        {
            var globalContext = XSettings.Api.Contexts.Get();

            SettingModel model = globalContext.CurrentModel;

            // ReSharper disable once ForCanBeConvertedToForeach
            for (var i = 0; i < globalContext.SettingSources.Count; i++)
            {
                if (globalContext.SettingSources[i].IsLoaded) continue;

                globalContext.SettingSources[i].LoadApiResolver.Invoke(model);

                globalContext.SettingSources[i].IsLoaded = true;
            }

            return model;

        }


    }
}
