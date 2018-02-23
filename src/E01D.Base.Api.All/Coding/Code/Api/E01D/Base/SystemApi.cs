using System;
using Root.Coding.Code.Api.E01D.Base.Containers;
using Root.Coding.Code.Api.E01D.Base.Containers.Collections;
using Root.Coding.Code.Api.E01D.NetFramework;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Clr.Reflection.Typal;
using Root.Coding.Code.Models.E01D.Base.Identification;
using Root.Coding.Code.Models.E01D.Base.Signalling.Internal;
using Root.Coding.Code.Models.E01D.Base.Types;

namespace Root.Coding.Code.Api.E01D.Base
{
    /// <summary>
    /// The primary api used for interacting with the Evobolics evolving system and its associated APIs.
    /// </summary>
    public class SystemApi
    {
        /// <summary>
        /// Gets the api responsible for associating objects together.
        /// </summary>
        public AssociationApi_I Associations { get; set; }

        /// <summary>
        /// Gets the api responsible for booting the system.
        /// </summary>
        public BootApi Booting => XBooting.Api;

        /// <summary>
        /// Gets the api responsible for configuring the system.
        /// </summary>
        public ConfigurationalApi Configurational => XConfigurationalBase.Api;

        /// <summary>
        /// Gets the api responsible for manipulating containers.
        /// </summary>
        public CollectionContainerApi_I CollectionContainers => XCollectionContainers.Api;

        /// <summary>
        /// Gets the api response for issuing identification numbers.
        /// </summary>
        public IdentificationApi Identification => XIdentification.Api;

        public ObjectCreationApi ObjectCreation => XNew.Api;

        public SignallingApi_I Signalling => XSignals.Api;

        public TransactionalApi Transactional => XTransactional.Api;

        /// <summary>
        /// Commits the current transaction.
        /// </summary>
        public void Commit()
        {
            Transactional.Commit();
        }

        /// <summary>
        /// Enumerates through all the items in the collection and attempts to cast the items to the type T.
        /// </summary>
        public void Enumerate(CollectionContainer_I container, Action<object> action)
        {
            CollectionContainers.Enumerate(container, action);
        }

        /// <summary>
        /// Enumerates through all the items in the collection and attempts to cast the items to the type T.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="container"></param>
        /// <param name="action"></param>
        public void Enumerate<T>(CollectionContainer_I<T> container, Action<T> action)
        {
            CollectionContainers.Enumerate(container, action);
        }

        public EnumerationState_I Enumerate<T>(CollectionContainer_I<T> container)
        {
            return CollectionContainers.Enumerate(container);
        }

        

        /// <summary>
        /// Gets an instance of a specified type from an object pool or by creating it.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T Get<T>()
        {
            if (ObjectCreation == null)
            {
                throw new System.Exception("ObjectCreation api is missing.");
            }

            return ObjectCreation.New<T>();
        }

        public Id_I IssueId()
        {
            return Identification.IssueId();
        }

        

        /// <summary>
        /// Removes the object from the collection.  
        /// </summary>
        /// <remarks>It is up to the collection implementation to determine how this is done.  This method should be used for business logic and not for low level collection access.</remarks>
        /// <typeparam name="T"></typeparam>
        /// <param name="container"></param>
        /// <param name="objectToRemove"></param>
        public void Remove<T>(CollectionContainer_I container, T objectToRemove)
        {
            CollectionContainers.Remove(container, objectToRemove);
        }

        public void Rollback()
        {
            Transactional.Rollback();
        }

        public void Signal<T>(T signal)
        {
            Signalling.Signal(signal);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="iMilliseconds"></param>
        /// <returns>Returns true so it can be used easily in a while loop logic.</returns>
        public bool Sleep(int iMilliseconds)
        {
            System.Threading.Thread.Sleep(iMilliseconds);

            return true;
        }

        

        public SignalSubscription_I Subscribe<T>(Action<T> action, bool isAsync)
            where T : class
        {
            return Signalling.Subscribe(action, isAsync);
        }

        public Typa_I GetTypa(Typed_I typedObject)
        {
            throw new NotImplementedException();
        }

        public object GetDataConnection<T>()
        {
            throw new NotImplementedException();
        }

        public void StartOperation()
        {
            throw new NotImplementedException();
        }
    }
}
