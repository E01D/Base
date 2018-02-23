using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Results;

namespace Root.Coding.Code.Api.E01D.Base
{
    public class TransactionalApi
    {
        //public void StartOperation()
        //{
        //    throw XExceptions.NotImplemented.CommentedOutTemporarily();
        //    //if (context.Transaction != null)
        //    //{
        //    //    throw new TransactionAlreadyPresentException();
        //    //}


        //    //context.Transaction = new TransactionContext()
        //    //{
        //    //    TransactionId = _.IssueId(),
        //    //    TransactionStartTimeUtc = _.NowUtc()
        //    //};



        //    //return context;
        //}

        //public void Commit()
        //{
        //    throw XExceptions.NotImplemented.CommentedOutTemporarily();
        //    //Context_I operationContext;

        //    //if (operationContext.Transaction.CommitTasks == null) return;

        //    //for (int i = 0; i < operationContext.Transaction.CommitTasks.Count; i++)
        //    //{
        //    //    operationContext.Transaction.CommitTasks[i](operationContext);
        //    //}

        //    //operationContext.Transaction.RollbackTasks = null;

        //    //operationContext.Transaction.CommitTasks = null;
        //}

        //public T GetGlobal<T>()
        //{
        //    throw XExceptions.NotImplemented.CommentedOutTemporarily();
        //    //throw new NotImplementedException();
        //}

        //public void Rollback()
        //{
        //    throw XExceptions.NotImplemented.CommentedOutTemporarily();
        //    //Context_I operationContext;

        //    //if (operationContext.Transaction.RollbackTasks == null) return;

        //    //for (int i = 0; i < operationContext.Transaction.RollbackTasks.Count; i++)
        //    //{
        //    //    operationContext.Transaction.RollbackTasks[i](operationContext);
        //    //}

        //    //operationContext.Transaction.RollbackTasks = null;

        //    //operationContext.Transaction.CommitTasks = null;

        //}

        //public TData PerformDataOperation<TData, TResult>(Func<TResult> func)
        //    where TResult : Result_I<TData>
        //{
        //    throw XExceptions.NotImplemented.CommentedOutTemporarily();
        //    //var opResult = Perform(func);

        //    //if (opResult.Successful)
        //    //{
        //    //    return opResult.Data;
        //    //}

        //    //return default(TData);
        //}

        //public TResult Perform<TResult>(Func<TResult> func)
        //    where TResult : Result_I
        //{
        //    throw XExceptions.NotImplemented.CommentedOutTemporarily();
        //    //return Perform(null, func);
        //}

        //public TResult Perform<TResult>(Func<TResult> func)
        //    where TResult : Result_I
        //{
        //    throw XExceptions.NotImplemented.CommentedOutTemporarily();
        //    //var opContext = _.StartOperation(context);

        //    //return PerformOp(opContext, func);
        //}

        //public void PerformOp(Context_I opContext, Action<Context_I> func)
        //{
        //    //try
        //    //{
        //    //    func(opContext);

        //    //    opContext.Transaction.Successful = true;
        //    //}
        //    //catch (System.Exception e)
        //    //{
        //    //    _.LogException(e);

        //    //    opContext.Transaction.Successful = false;
        //    //}
        //    //finally
        //    //{
        //    //    if (opContext.Transaction.Successful)
        //    //    {
        //    //        _.Commit(opContext);
        //    //    }
        //    //    else
        //    //    {
        //    //        _.Rollback(opContext);
        //    //    }
        //    //}
        //}

        //public TResult PerformOp<TResult>(Context_I opContext, Func<Context_I, TResult> func)
        //    where TResult : Result_I
        //{
        //    throw XExceptions.NotImplemented.CommentedOutTemporarily();

        //    //try
        //    //{
        //    //    var result = func(opContext);

        //    //    opContext.Transaction.Successful = result.Successful;

        //    //    return result;
        //    //}
        //    //catch (System.Exception e)
        //    //{
        //    //    _.LogException(e);

        //    //    opContext.Transaction.Successful = false;

        //    //    return default(TResult);
        //    //}
        //    //finally
        //    //{
        //    //    if (opContext.Transaction.Successful)
        //    //    {
        //    //        _.Commit(opContext);
        //    //    }
        //    //    else
        //    //    {
        //    //        _.Rollback(opContext);
        //    //    }
        //    //}
        //}

        //public Context_I CreateContext()
        //{
        //    throw XExceptions.NotImplemented.CommentedOutTemporarily();
        //    //Context context = new Context()
        //    //{
        //    //    Id = _.IssueId(),


        //    //};

        //    //return context;
        //}

        //public Context_I StartOperation(Context_I context)
        //{
        //    throw XExceptions.NotImplemented.CommentedOutTemporarily();
        //    //if (context.Transaction != null)
        //    //{
        //    //    throw new TransactionAlreadyPresentException();
        //    //}


        //    //context.Transaction = new TransactionContext()
        //    //{
        //    //    TransactionId = _.IssueId(),
        //    //    TransactionStartTimeUtc = _.NowUtc()
        //    //};



        //    //return context;
        //}

        //public void Commit(Context_I operationContext)
        //{
        //    throw XExceptions.NotImplemented.CommentedOutTemporarily();
        //    //if (operationContext.Transaction.CommitTasks == null) return;

        //    //for (int i = 0; i < operationContext.Transaction.CommitTasks.Count; i++)
        //    //{
        //    //    operationContext.Transaction.CommitTasks[i](operationContext);
        //    //}

        //    //operationContext.Transaction.RollbackTasks = null;

        //    //operationContext.Transaction.CommitTasks = null;
        //}

        //public T GetGlobal<T>()
        //{
        //    throw XExceptions.NotImplemented.CommentedOutTemporarily();
        //    //throw new NotImplementedException();
        //}

        //public void Rollback(Context_I operationContext)
        //{
        //    throw XExceptions.NotImplemented.CommentedOutTemporarily();
        //    //if (operationContext.Transaction.RollbackTasks == null) return;

        //    //for (int i = 0; i < operationContext.Transaction.RollbackTasks.Count; i++)
        //    //{
        //    //    operationContext.Transaction.RollbackTasks[i](operationContext);
        //    //}

        //    //operationContext.Transaction.RollbackTasks = null;

        //    //operationContext.Transaction.CommitTasks = null;

        //}

        //public TData PerformDataOperation<TData, TResult>(Func<Context_I, TResult> func)
        //    where TResult : Result_I<TData>
        //{
        //    throw XExceptions.NotImplemented.CommentedOutTemporarily();
        //    //var opResult = Perform(func);

        //    //if (opResult.Successful)
        //    //{
        //    //    return opResult.Data;
        //    //}

        //    //return default(TData);
        //}

        //public TResult Perform<TResult>(Func<Context_I, TResult> func)
        //    where TResult : Result_I
        //{
        //    throw XExceptions.NotImplemented.CommentedOutTemporarily();
        //    //return Perform(null, func);
        //}

        //public TResult Perform<TResult>(Context_I context, Func<Context_I, TResult> func)
        //    where TResult : Result_I
        //{
        //    throw XExceptions.NotImplemented.CommentedOutTemporarily();
        //    //var opContext = _.StartOperation(context);

        //    //return PerformOp(opContext, func);
        //}

        //public void PerformOp(Context_I opContext, Action<Context_I> func)
        //{
        //    throw XExceptions.NotImplemented.CommentedOutTemporarily();
        //    //try
        //    //{
        //    //    func(opContext);

        //    //    opContext.Transaction.Successful = true;
        //    //}
        //    //catch (System.Exception e)
        //    //{
        //    //    _.LogException(e);

        //    //    opContext.Transaction.Successful = false;
        //    //}
        //    //finally
        //    //{
        //    //    if (opContext.Transaction.Successful)
        //    //    {
        //    //        _.Commit(opContext);
        //    //    }
        //    //    else
        //    //    {
        //    //        _.Rollback(opContext);
        //    //    }
        //    //}
        //}

        //public TResult PerformOp<TResult>(Context_I opContext, Func<Context_I, TResult> func)
        //    where TResult : Result_I
        //{
        //    throw XExceptions.NotImplemented.CommentedOutTemporarily();

        //    //try
        //    //{
        //    //    var result = func(opContext);

        //    //    opContext.Transaction.Successful = result.Successful;

        //    //    return result;
        //    //}
        //    //catch (System.Exception e)
        //    //{
        //    //    _.LogException(e);

        //    //    opContext.Transaction.Successful = false;

        //    //    return default(TResult);
        //    //}
        //    //finally
        //    //{
        //    //    if (opContext.Transaction.Successful)
        //    //    {
        //    //        _.Commit(opContext);
        //    //    }
        //    //    else
        //    //    {
        //    //        _.Rollback(opContext);
        //    //    }
        //    //}
        //}
        public void Commit()
        {
            throw new NotImplementedException();
        }

        public void Rollback()
        {
            throw new NotImplementedException();
        }
    }
}
