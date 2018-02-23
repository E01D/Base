using System;
using Root.Coding.Code.Api.E01D.Base;
using Root.Coding.Code.Api.E01D.Base.Containers;
using Root.Coding.Code.Api.E01D.Base.Containers.Collections;
using Root.Coding.Code.Models.E01D.Base.Associations;
using Root.Coding.Code.Models.E01D.Base.Booting;
using Root.Coding.Code.Models.E01D.Base.Clr.Reflection.Typal;
using Root.Coding.Code.Models.E01D.Base.Identification;
using Root.Coding.Code.Models.E01D.Base.Pocos;
using Root.Coding.Code.Models.E01D.Base.Results;
using Root.Coding.Code.Models.E01D.Base.Signalling.Internal;
using Root.Coding.Code.Models.E01D.Base.Types;


namespace Root.Coding.Code.Domains.E01D
{
    /// <summary>
    /// The purpose of this class is to provide general common functionality from a central point.
    /// </summary>
    public static class X
    {
        /// <summary>
        /// Gets the general system api that processes all operations presented by the X class.
        /// </summary>
        public static SystemApi Api { get; set; } = new SystemApi();

        #region Sub System Property Delcarations

        public static AssociationApi_I Associations => Api?.Associations;


        /// <summary>
        /// Gets the api used for configuring the system.
        /// </summary>
        public static ConfigurationalApi Configuration => Api.Configurational;

        public static DebugApi_I Debug => XDebug.Api;

        #endregion


        /// <summary>
        /// Adds the provided object to a container.  
        /// </summary>
        /// <remarks>It is up to the collection implementation to determine how this is done.  This method should be used for business logic and not for low level collection access.</remarks>
        public static AddResult_I<T> Add<T>(CollectionContainer_I container, T objectToAdd)
        {
            return XCollectionContainers.Add(container, objectToAdd);
        }

        public static Association_I Associate(Poco_I from, Poco_I to, long typeId)
        {
            return Associations?.Associate(from, to, typeId);
        }

        /// <summary>
        /// Boots the system.
        /// </summary>
        /// <returns></returns>
        public static BootApi Boot()
        {
            return XBooting.Boot();
        }

        /// <summary>
        /// Boots the system.
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static BootApi Boot(string[] args)
        {
            return XBooting.Boot(args);
        }

        /// <summary>
        /// Boots the system.
        /// </summary>
        /// <typeparam name="TStartup"></typeparam>
        /// <returns></returns>
        public static BootApi Boot<TStartup>() where TStartup : Startup_I
        {
            return XBooting.Boot<TStartup>();
        }

        /// <summary>
        /// Boots the system.
        /// </summary>
        /// <typeparam name="TStartup"></typeparam>
        /// <param name="args"></param>
        /// <returns></returns>
        public static BootApi Boot<TStartup>(string[] args) where TStartup : Startup_I
        {
            return XBooting.Boot<TStartup>(args);
        }

        public static ConfigurationalApiAll Configure() => XConfigurational.Api;

        /// <summary>
        /// Provides a default ToString implementation for classes that choose to override the default .NET method
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static string ConvertToString(object @this)
        {
            return XToString.Api.Convert(@this);
        }

        //public static TData PerformDataOperation<TData, TResult>(Func<Context_I, TResult> func)
        //    where TResult : Result_I<TData>
        //{
        //    return XContextualBase.PerformDataOperation<TData, TResult>(func);
        //}

        //public static TResult Perform<TResult>(Func<Context_I, TResult> func)
        //    where TResult : Result_I
        //{
        //    return XContextualBase.Perform(func);
        //}

        //public static TResult Perform<TResult>(Context_I context, Func<Context_I, TResult> func)
        //    where TResult : Result_I
        //{
        //    return XContextualBase.Perform(context, func);
        //}

        //public static TResult PerformOp<TResult>(Context_I context, Func<Context_I, TResult> func)
        //    where TResult : Result_I
        //{
        //    return XContextualBase.PerformOp(context, func);
        //}

        //public static void PerformOp(Context_I context, Action<Context_I> func)
        //{
        //    XContextualBase.PerformOp(context, func);
        //}

        public static T AssignId<T>(T objectToAssign)
            where T : Ided_I
        {
            return Api.Identification.AssignId(objectToAssign);
        }

        /// <summary>
        /// Commits the current transaction.
        /// </summary>
        public static void Commit()
        {
            Api.Commit();
        }



        //public static void Foreach<T>(object collection, Action<T> action)
        //{
        //    Instance.CodePatternResolver?.Foreach(collection, action);
        //}

        /// <summary>
        /// Gets an instance of a specified type from an object pool or by creating it.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Get<T>()
        {
            return Api.Get<T>();
        }

        /// <summary>
        /// Converts an exception to a string message.
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="getInnerException"></param>
        /// <returns></returns>
        public static string GetExceptionMessage(System.Exception exception, bool getInnerException)
        {
            var message = exception.Message;

            if (!getInnerException || exception.InnerException == null) return message;

            var innerExceptionMessage = GetExceptionMessage(exception.InnerException, true);

            message += $"\tInner Exception: {innerExceptionMessage}";

            return message;
        }

        public static Id_I IssueId()
        {
            return Api.IssueId();
        }

       

        /// <summary>
        /// Enumerates through all the items in the collection and attempts to cast the items to the type T.
        /// </summary>
        public static void Enumerate(CollectionContainer_I container, Action<object> action)
        {
            Api.Enumerate(container, action);
        }

        /// <summary>
        /// Enumerates through all the items in the collection and attempts to cast the items to the type T.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="container"></param>
        /// <param name="action"></param>
        public static void Enumerate<T>(CollectionContainer_I<T> container, Action<T> action)
        {
            Api.Enumerate(container, action);
        }


        public static T New<T>()
        {
            return XNew.New<T>();
        }

        public static object New(Type type)
        {
            return XNew.New(type);
        }

        public static DateTime NowUtc()
        {
            return System.DateTime.UtcNow;
        }



        /// <summary>
        /// Removes the object from the collection.  
        /// </summary>
        /// <remarks>It is up to the collection implementation to determine how this is done.  This method should be used for business logic and not for low level collection access.</remarks>
        /// <typeparam name="T"></typeparam>
        /// <param name="container"></param>
        /// <param name="objectToRemove"></param>
        public static void Remove<T>(this CollectionContainer_I container, T objectToRemove)
        {
            Api.Remove(container, objectToRemove);
        }

        ///// <summary>
        ///// Attempts to resolve an API.
        ///// </summary>
        ///// <typeparam name="TApi">Gets or sets the type of the api to resolve.</typeparam>
        ///// <returns>Returns an API if the API is successfully resolved.</returns>
        //public static TApi ResolveApi<TApi>()
        //{
        //    if (Instance.ApiResolver != null) return Instance.ApiResolver.GetApi<TApi>();

        //    throw new System.Exception("The functionality being accessed requires the use of an api resolver.  No api resolver has been configured.  The functionality cannot be located or accessed.");
        //}

        ///// <summary>
        ///// Attempts to resolve an API.
        ///// </summary>
        ///// <returns>Returns an API if the API is successfully resolved.</returns>
        //public static object ResolveApi(System.Type type)
        //{
        //    if (Instance.ApiResolver != null) return Instance.ApiResolver.GetApi(type);

        //    throw new System.Exception("The functionality being accessed requires the use of an api resolver.  No api resolver has been configured.  The functionality cannot be located or accessed.");
        //}

        public static void Rollback()
        {
            Api.Rollback();
        }

        public static void Signal<T>(T signal)
        {
            Api.Signal(signal);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="iMilliseconds"></param>
        /// <returns>Returns true so it can be used easily in a while loop logic.</returns>
        public static bool Sleep(int iMilliseconds)
        {
            return Api.Sleep(iMilliseconds);
        }

        

        public static SignalSubscription_I Subscribe<T>(Action<T> action, bool isAsync)
            where T : class
        {
            return Api.Subscribe(action, isAsync);
        }

        public static void StartOperation()
        {
            Api.StartOperation();
        }

        public static Root.Coding.Code.Models.E01D.Base.Exceptions.Exception WrapException(System.Exception exception)
        {
            return new Root.Coding.Code.Models.E01D.Base.Exceptions.Exception(exception.Message, exception);
        }

        public static object GetDataConnection<T>()
        {
            return Api.GetDataConnection<T>();
        }

        public static Container_I<T> GetCollection<T>(System.Collections.Generic.List<T> resultList)
        {
            throw new NotImplementedException();
        }

        public static Typa_I GetTypa(Typed_I typedObject)
        {
            return Api.GetTypa(typedObject);
        }

        

        
    }
}
