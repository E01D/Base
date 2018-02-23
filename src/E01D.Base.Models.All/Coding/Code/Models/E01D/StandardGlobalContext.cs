using System.Collections.Generic;
using Root.Coding.Code.Framework.E01D;
using Root.Coding.Code.Models.E01D.Base;
using Root.Coding.Code.Models.E01D.Base.Booting;
using Root.Coding.Code.Models.E01D.Base.Clr.Reflection.Typal.Contexts;
using Root.Coding.Code.Models.E01D.Base.Configurational;
using Root.Coding.Code.Models.E01D.Base.Configurational.Data;
using Root.Coding.Code.Models.E01D.Base.Data.Contexts;
using Root.Coding.Code.Models.E01D.Base.Identification;
using Root.Coding.Code.Models.E01D.Base.Logging;
using Root.Coding.Code.Models.E01D.Base.Types.Contexts;


namespace Root.Coding.Code.Models.E01D
{
    public class StandardGlobalContext: 
        BootContextHost_I, 
        DebugContextHost_I, 
        IdContextHost_I, 
        LogContextHost_I, 
        SyncRooted_I,
        ConnectionStringGlobalContextHost_I,
        ConfigurationalGlobalContextHost_I,
        TypalGlobalContextHost_I,
        TypeGlobalContextHost_I,
        DataGlobalContextHost_I
    {
        /// <summary>
        /// Gets or sets the boot context that is associated with this global ambient context.
        /// </summary>
        BootContext_I BootContextHost_I.Booting { get; set; } = new BootContext();


        ConnectionStringGlobalContext_I ConnectionStringGlobalContextHost_I.ConnectionStrings { get; set; } = new ConnectionStringGlobalContext();

        /// <summary>
        /// Gets or sets the debug context that is associated with this global ambient context.
        /// </summary>
        DebugContext_I DebugContextHost_I.Debug { get; set; }

        /// <summary>
        /// Gets or sets the identification context that is associated with this ambient context.
        /// </summary>
        IdContext_I IdContextHost_I.Identification { get; set; } = new IdContext();

        //public LayerContext_I Layers { get; set; } = new LayerContext();

        /// <summary>
        /// Gets or sets the logging context that is aassociated with this global ambient context.
        /// </summary>
        LogContext_I LogContextHost_I.Logging { get; set; }

        //public Root.Code.Models.E01D.Signalling.Internal.SignalingContext Signaling { get; set; } = new Root.Code.Models.E01D.Signalling.Internal.SignalingContext();

        /// <summary>
        /// Gets or sets the sync root associated with this global ambient context.
        /// </summary>
        object SyncRooted_I.SyncRoot { get; } = new object();

        /// <summary>
        /// Gets or sets the global ambient typal context
        /// </summary>
        TypalGlobalContext_I TypalGlobalContextHost_I.Typal { get; set; } = new TypalGlobalContext();

        /// <summary>
        /// Gets or sets the global ambient configurational context
        /// </summary>
        ConfigurationalGlobalContext_I ConfigurationalGlobalContextHost_I.Configurational { get; set; } = new ConfigurationalGlobalContext();

        /// <summary>
        /// Gets or sets the global ambient type context
        /// </summary>
        TypeGlobalContext_I TypeGlobalContextHost_I.Types { get; set; } = new TypeGlobalContext();

        DataGlobalContext_I DataGlobalContextHost_I.Data { get; set; } = new DataGlobalContext();
    }
}
