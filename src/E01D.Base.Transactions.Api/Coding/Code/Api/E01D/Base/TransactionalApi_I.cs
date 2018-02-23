using System;

namespace Root.Coding.Code.Api.E01D.Base
{
    public interface TransactionalApi_I
    {
        void StartOperation();

        void Commit();

        void Rollback();

        TData PerformDataOperation<TData, TResult>(Func<TResult> func);

        TResult Perform<TResult>(Func<TResult> func);

        void PerformOp(Action func);
    }
}
