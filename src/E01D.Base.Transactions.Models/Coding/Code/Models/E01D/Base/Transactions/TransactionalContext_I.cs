namespace Root.Coding.Code.Models.E01D.Base.Transactions
{
    public interface TransactionalContext_I
    {
        /// <summary>
        /// Gets or sets the current transaction that is associated with the context.  
        /// </summary>
        /// <remarks>
        /// This takes the place of the OpContxt_I that only had a transaction and a success flag.  The succes flag has been moved to the transaction class, as that is what it really relates too.
        /// Prior to this change, there had to be two perform op calls.
        /// </remarks>
        Transaction_I Current { get; set; }
    }
}
