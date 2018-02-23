using System.Collections.Generic;

namespace Root.Coding.Code.Models.E01D.Base.Configurational.Settings
{
    /// <summary>
    /// Represents a setting node that contains data only. 
    /// </summary>
    /// <typeparam name="TSource"></typeparam>
    public class SettingNode: SettingNode_I
    {
        /// <summary>
        /// Gets or sets the key of this node.
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets the value of this node.  It is used if the path terminates on this node.
        /// </summary>
        public object Value { get; set; }

        public SettingNode_I Parent { get; set; }

        /// <summary>
        /// Gets or sets the source that contributed the value of this node.
        /// </summary>
        public SettingSourceNode_I SourceNode { get; set; }

        public Dictionary<string, SettingNode_I> ChildNodes { get; set; } = new Dictionary<string, SettingNode_I>();
    }
}
