using System;
using System.Collections.Generic;


namespace Root.Coding.Code.Models.E01D.Base.Transactions
{
    public interface Transaction_I
    {
        long TransactionId { get; set; }

        DateTime TransactionStartTimeUtc { get; set; }
        List<Action> CommitTasks { get; set; }

        List<Action> RollbackTasks { get; set; }

        bool Successful { get; set; }
    }
}
