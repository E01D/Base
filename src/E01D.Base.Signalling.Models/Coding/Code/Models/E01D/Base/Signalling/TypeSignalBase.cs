namespace Root.Coding.Code.Models.E01D.Base.Signalling
{
    public class TypeReferencedSignalBase:SignalBase
    {
        /// <summary>
        /// Gets or sets the type name of the signal. 
        /// </summary>
        public string TypeName { get; set; }

        /// <summary>
        /// Gets or sets the version of the signal.
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets the type id of the signal relative to the sender.
        /// </summary>
        public long TypeId { get; set; }
    }
}
