using System.Collections.Generic;

namespace Root.Coding.Code.Models.E01D.Base.Configurational.Settings
{
    public interface SettingNode_I
    {
        /// <summary>
        /// Gets or sets the key of this node.
        /// </summary>
        string Key { get; set; }

        /// <summary>
        /// Gets or sets the value of this node.  It is used if the path terminates on this node.
        /// </summary>
        object Value { get; set; }

        SettingNode_I Parent { get; set; }

        /// <summary>
        /// Gets or sets the source that contributed the value of this node.
        /// </summary>
        SettingSourceNode_I SourceNode { get;  }

        Dictionary<string, SettingNode_I> ChildNodes { get; set; }
    }
}
