using Root.Coding.Code.Models.E01D.Base.Pocos;
using Root.Coding.Code.Models.E01D.Base.Results;
using Root.Coding.Code.Models.E01D.Base.Types;

namespace Root.Coding.Code.Api.E01D.Base.Layers.Containers
{
    public class LogicContainerLayerSystemApi
    {
        /// <summary>
        /// Gets a logic container api based upon a type
        /// </summary>
        public LogicContainerApi_I GetApi<T>()
        {
            // get from DI
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Gets a logic container api based upon a typeid
        /// </summary>
        /// <param name="typeId"></param>
        /// <returns></returns>
        public LogicContainerApi_I GetApi(TypeId_I typeId)
        {
            // get from DI
            throw new System.NotImplementedException();
        }

        public AddResult_I<T> Add<T>(T objectToAdd)
           where T : Poco_I
        {
            switch (objectToAdd.TypeId.Value)
            {
                // dynamically injected
                //case X:
                //{

                //}
                // dynamically injected
                //case Y:
                //{

                //}
                default:
                    {
                        throw new System.NotImplementedException();
                        //var type = typeof(T);

                        ////var context = X.ContextAs<LogicContext_I>();

                        //if (_.ContextAs<LogicContext_I>(out LogicContext_I context))
                        //{
                        //    if (context.Apis.TryGetValue(type.TypeHandle, out object logicObject))
                        //    {
                        //        LogicApi_I<T> logic = (LogicApi_I<T>)logicObject;

                        //        return logic.Add(objectToAdd);
                        //    }
                        //}

                        //return XData.Add(objectToAdd);
                    }
            }

        }

        

        public GetResult_I<T> GetById<T>(long id)
            where T : Poco_I
        {
            //var type = typeof(T);

            //if (_.Context.Layers.Logic.Apis.TryGetValue(type.TypeHandle, out object logicObject))
            //{
            //    LogicApi_I<T> logic = (LogicApi_I<T>)logicObject;

            //    return logic.GetById(id);
            //}

            //return XData.GetById<T>(id);
            throw new System.NotImplementedException();
        }



        /// <summary>
        /// Gets all objects from the system of the specified type.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public GetCollectionResult_I<T> GetAll<T>()
            where T : Poco_I
        {
            //var type = typeof(T);

            //if (_.Context.Layers.Logic.Apis.TryGetValue(type.TypeHandle, out object logicObject))
            //{
            //    LogicApi_I<T> logic = (LogicApi_I<T>)logicObject;

            //    return logic.GetAll();
            //}

            //return XData.GetAll<T>();
            throw new System.NotImplementedException();
        }



        /// <summary>
        /// Removes an object from the system
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="objectToRemove"></param>
        /// <returns></returns>
        public RemoveResult_I<T> Remove<T>(T objectToRemove)
            where T : Poco_I
        {
            //var type = typeof(T);

            //if (_.Context.Layers.Logic.Apis.TryGetValue(type.TypeHandle, out object logicObject))
            //{
            //    LogicApi_I<T> logic = (LogicApi_I<T>)logicObject;

            //    return logic.Remove(objectToRemove);
            //}

            //return XData.Remove<T>(objectToRemove);
            throw new System.NotImplementedException();
        }



        public RemoveResult_I<T> RemoveById<T>(long id)
            where T : Poco_I
        {
            //var type = typeof(T);

            //if (_.Context.Layers.Logic.Apis.TryGetValue(type.TypeHandle, out object logicObject))
            //{
            //    LogicApi_I<T> logic = (LogicApi_I<T>)logicObject;

            //    return logic.RemoveById(id);
            //}

            //return XData.RemoveById<T>(id);
            throw new System.NotImplementedException();
        }



        public RemoveResult_I<T> RemoveAll<T>()
            where T : Poco_I
        {
            //var type = typeof(T);

            //if (_.Context.Layers.Logic.Apis.TryGetValue(type.TypeHandle, out object logicObject))
            //{
            //    LogicApi_I<T> logic = (LogicApi_I<T>)logicObject;

            //    return logic.RemoveAll();
            //}

            //return XData.RemoveAll<T>();
            throw new System.NotImplementedException();
        }



        public UpdateResult_I<T> Update<T>(T objectToUpdate)
            where T : Poco_I
        {
            //var type = typeof(T);

            //if (_.Context.Layers.Logic.Apis.TryGetValue(type.TypeHandle, out object logicObject))
            //{
            //    LogicContainerApi_I<T> logic = (LogicContainerApi_I<T>)logicObject;

            //    return logic.Update(objectToUpdate);
            //}

            //return XData.Update<T>(objectToUpdate);
            throw new System.NotImplementedException();
        }
    }
}
