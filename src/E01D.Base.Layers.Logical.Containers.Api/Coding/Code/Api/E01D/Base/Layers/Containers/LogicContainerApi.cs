using Root.Coding.Code.Models.E01D.Base.Pocos;
using Root.Coding.Code.Models.E01D.Base.Results;

namespace Root.Coding.Code.Api.E01D.Base.Layers.Containers
{
    public class LogicContainerApi: LogicContainerApi_I
    {
        public AddResult_I<T> Add<T>(T objectToAdd)
            where T : Poco_I
        {
            throw new System.NotImplementedException();
            //switch (objectToAdd.TypaId)
            //{
            //    // dynamically injected
            //    //case X:
            //    //{

            //    //}
            //    // dynamically injected
            //    //case Y:
            //    //{

            //    //}
            //    default:
            //    {
            //        var type = typeof(T);

            //        //var context = X.ContextAs<LogicContext_I>();

            //        if (_.ContextAs<LogicContext_I>(out LogicContext_I context))
            //        {
            //            if (context.Apis.TryGetValue(type.TypeHandle, out object logicObject))
            //            {
            //                LogicApi_I<T> logic = (LogicApi_I<T>)logicObject;

            //                return logic.Add(objectToAdd);
            //            }
            //        }

            //        return XData.Add(objectToAdd);
            //    }
            //}

        }

        public AddResult_I<T> Add<C, T>(C context, T objectToAdd)
            where T : Poco_I
            
        {
            throw new System.NotImplementedException();
            //var type = typeof(T);

            //if (_.Context.Layers.Logic.Apis.TryGetValue(type.TypeHandle, out object logicObject))
            //{
            //    LogicApi_I<T> logic = (LogicApi_I<T>)logicObject;

            //    return logic.Add(context, objectToAdd);
            //}

            //return XData.Add(context, objectToAdd);
        }

        public GetResult_I<T> GetById<T>(long id)
            where T : Poco_I
        {
            throw new System.NotImplementedException();
            //var type = typeof(T);

            //if (_.Context.Layers.Logic.Apis.TryGetValue(type.TypeHandle, out object logicObject))
            //{
            //    LogicApi_I<T> logic = (LogicApi_I<T>)logicObject;

            //    return logic.GetById(id);
            //}

            //return XData.GetById<T>(id);
        }

        

        /// <summary>
        /// Gets all objects from the system of the specified type.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public GetCollectionResult_I<T> GetAll<T>()
            where T : Poco_I
        {
            throw new System.NotImplementedException();
            //var type = typeof(T);

            //if (_.Context.Layers.Logic.Apis.TryGetValue(type.TypeHandle, out object logicObject))
            //{
            //    LogicApi_I<T> logic = (LogicApi_I<T>)logicObject;

            //    return logic.GetAll();
            //}

            //return XData.GetAll<T>();
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
            throw new System.NotImplementedException();
            //var type = typeof(T);

            //if (_.Context.Layers.Logic.Apis.TryGetValue(type.TypeHandle, out object logicObject))
            //{
            //    LogicApi_I<T> logic = (LogicApi_I<T>)logicObject;

            //    return logic.Remove(objectToRemove);
            //}

            //return XData.Remove<T>(objectToRemove);
        }

       

        public RemoveResult_I<T> RemoveById<T>(long id)
            where T : Poco_I
        {
            throw new System.NotImplementedException();
            //var type = typeof(T);

            //if (_.Context.Layers.Logic.Apis.TryGetValue(type.TypeHandle, out object logicObject))
            //{
            //    LogicApi_I<T> logic = (LogicApi_I<T>)logicObject;

            //    return logic.RemoveById(id);
            //}

            //return XData.RemoveById<T>(id);
        }

        

        public RemoveResult_I<T> RemoveAll<T>()
            where T : Poco_I
        {
            throw new System.NotImplementedException();
            //var type = typeof(T);

            //if (_.Context.Layers.Logic.Apis.TryGetValue(type.TypeHandle, out object logicObject))
            //{
            //    LogicApi_I<T> logic = (LogicApi_I<T>)logicObject;

            //    return logic.RemoveAll();
            //}

            //return XData.RemoveAll<T>();
        }

        

        public UpdateResult_I<T> Update<T>(T objectToUpdate)
            where T : Poco_I
        {
            throw new System.NotImplementedException();
            //var type = typeof(T);

            //if (_.Context.Layers.Logic.Apis.TryGetValue(type.TypeHandle, out object logicObject))
            //{
            //    LogicApi_I<T> logic = (LogicApi_I<T>)logicObject;

            //    return logic.Update(objectToUpdate);
            //}

            //return XData.Update<T>(objectToUpdate);
        }

        
    }
}
