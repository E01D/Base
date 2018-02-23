using System;
using System.Collections.Generic;

namespace Root.Coding.Code.Models.E01D.Base.Transactions
{
    public class Transaction : Transaction_I
    {
        public long TransactionId { get; set; }
        public DateTime TransactionStartTimeUtc { get; set; }

        public List<Action> CommitTasks { get; set; } = new List<Action>();

        public List<Action> RollbackTasks { get; set; } = new List<Action>();

        /// <summary>
        /// Gets or sets whether the transaction was successful.
        /// </summary>
        public bool Successful { get; set; }
    }
}
