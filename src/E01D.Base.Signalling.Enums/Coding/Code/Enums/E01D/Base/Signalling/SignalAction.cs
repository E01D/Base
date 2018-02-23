namespace Root.Code.Enums.E01D.Signalling
{
    public enum SignalAction
    {
        /// <summary>
        /// Indicates no action was specified.
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// Indicates that the signal action should be performed.
        /// </summary>
        Perform = 1,

        /// <summary>
        /// Indicates that the object specified should be added.
        /// </summary>
        Add = 2,

        /// <summary>
        /// Indicates the object specified should be updated.
        /// </summary>
        Update = 3,

        /// <summary>
        /// Indicates that the object specified should be removed.
        /// </summary>
        Remove = 4,
        /// <summary>
        /// Indicates that an object should be fetched based upon the criteria provided.
        /// </summary>
        Get = 5,

        /// <summary>
        /// Indicates that all objects of the type specified should be fetched.
        /// </summary>
        GetAll = 6,
        /// <summary>
        /// Indicates all objects of the type specified should be removed.  
        /// </summary>
        RemoveAll = 7
    }
}
