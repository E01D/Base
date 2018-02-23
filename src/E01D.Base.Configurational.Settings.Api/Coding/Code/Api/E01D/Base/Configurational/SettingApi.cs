using System;
using System.Collections.Generic;
using Root.Coding.Code.Api.E01D.Base.Configurational.Settings;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Configurational.Settings;

namespace Root.Coding.Code.Api.E01D.Base.Configurational
{
    public class SettingApi
    {
        public ContextApi Contexts { get; set; } = new ContextApi();

        public ErrorApi Errors { get; set; } = new ErrorApi();

        public PathApi Paths { get; set; } = new PathApi();
        public NodeApi Nodes { get; set; } = new NodeApi();

        public int GetInt32(string keyPath)
        {
            var result = GetString(keyPath);

            if (result == null) return 0;

            if (Int32.TryParse(result, out int numericResult))
            {
                return numericResult;
            }

            return 0;
        }

        public string GetString(string keyPath)
        {
            var current = GetNode(keyPath);

            if (current == null) return null;

            return XToString.Convert(current.Value);
        }

        public bool GetString(string keyPath, out string result)
        {
            var current = GetNode(keyPath);

            if (current == null)
            {
                result = null;
                return false;
            }

            result = XToString.Convert(current.Value);

            return true;
        }


        

        public SettingNode_I Set(string keypath, string valueToSet)
        {
            var current = GetNode(keypath);

            if (current == null) return null;

            current.Value = valueToSet;

            return current;
        }

        public SettingNode_I SetAndPersist(string keypath, string valueToSet)
        {
            var current = Set(keypath, valueToSet);

            if (current == null) return null;

            // Persist Code here

            List<SettingNode_I> nodesToWrite = new List<SettingNode_I> {current};

            var context = Contexts.Get();

            var model = context.CurrentModel;

            current.SourceNode.WriteApiResolver(model, nodesToWrite);

            return current;
        }

        public SettingNode_I GetNode(string keyPath)
        {
            var pathPieces = Paths.SplitPath(keyPath);

            var context = Contexts.Get();

            var model = context.CurrentModel;

            var current = model.Root;

            // ReSharper disable once ForCanBeConvertedToForeach
            for (var i = 0; i < pathPieces.Length; i++)
            {
                var piece = pathPieces[i];

                SettingNode_I node;

                if (current.ChildNodes.TryGetValue(piece, out node))
                {
                    current = node;
                }
                else
                {
                    return null;
                }
            }

            return current;
        }



        

        //public SettingProviderApi_I Provider { get; set; }



        //public bool Get(string name, out string value)
        //{
        //    return Get(GetDefaultSettingConnectionString(), name, out value);
        //}



        //public void Set(string name, string value)
        //{
        //    Set(GetDefaultSettingConnectionString(), name, value);
        //}



        ///// <summary>
        ///// Sets up the XSettings system by the caller providing a settings provider to use.  
        ///// </summary>
        ///// <typeparam name="TProvider"></typeparam>
        //public void Setup<TProvider>() where TProvider : SettingProviderApi_I
        //{
        //    Provider = XNew.New<TProvider>();
        //}

        //public void Setup(System.Type type)
        //{
        //    var instance = XNew.New(type);

        //    //  If null or is not the setting providerapi type, then it will be null.
        //    var provider = instance as SettingProviderApi_I;

        //    if (provider == null) return;

        //    Provider = provider;

        //}
        
    }
}
