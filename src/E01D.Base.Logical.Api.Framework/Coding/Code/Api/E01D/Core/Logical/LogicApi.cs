using Root.Coding.Code.Models.E01D.Base.Pocos;
using Root.Coding.Code.Models.E01D.Base.Results;

namespace Root.Coding.Code.Api.E01D.Core.Logical
{
    /// <summary>
    /// This is useful for permission and checks that need to happen across the board.   Individual logic pieces are useful for specific business cases, e.g. when X is operated upon, do y as well.
    /// </summary>
    /// <designNotes>Due to needing security, permissions and exceptions, this logic needs to be moved to its own assembly, and added by the E01D booter.</designNotes>
    public class LogicApi : LogicApi_I
    {


        public AddResult_I<T> Add<T>(T objectToAdd)
            where T : Poco_I
            
        {
            //var type = typeof(T);

            //if (_.Context.Layers.Logic.Apis.TryGetValue(type.TypeHandle, out object logicObject))
            //{
            //    LogicApi_I<T> logic = (LogicApi_I<T>)logicObject;

            //    return logic.Add(context, objectToAdd);
            //}

            //return XData.Add(context, objectToAdd);
            throw new System.NotImplementedException();
        }



        public GetResult_I<T> GetById<T>(long id)
            where T : Poco_I
            
        {
            var type = typeof(T);

            //if (_.Context.Layers.Logic.Apis.TryGetValue(type.TypeHandle, out object logicObject))
            //{
            //    LogicApi_I<T> logic = (LogicApi_I<T>)logicObject;

            //    return logic.GetById(context, id);
            //}

            //return XData.GetById<T>(context, id);
            throw new System.NotImplementedException();
        }



        /// <summary>
        /// Gets all objects from the system of the specified type.
        /// </summary>
        /// <typeparam name="C"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <param name="context"></param>
        /// <returns></returns>
        public GetCollectionResult_I<T> GetAll<T>()
            where T : Poco_I
            
        {
            //var type = typeof(T);

            ////if (!X.CanPerformOp<C, T, GetAllOp>(context))
            ////{
            ////    XExceptions.
            ////}

            //if (_.Context.Layers.Logic.Apis.TryGetValue(type.TypeHandle, out object logicObject))
            //{
            //    LogicApi_I<T> logic = (LogicApi_I<T>)logicObject;

            //    return logic.GetAll(context);
            //}

            //return XData.GetAll<T>(context);
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Removes an object from the system.
        /// </summary>
        /// <typeparam name="C">The type of the context being supplied.</typeparam>
        /// <typeparam name="T"></typeparam>
        /// <param name="context"></param>
        /// <param name="objectToRemove"></param>
        /// <returns></returns>
        public RemoveResult_I<T> Remove<T>(T objectToRemove)
            where T : Poco_I
            
        {
            //var type = typeof(T);

            //if (_.Context.Layers.Logic.Apis.TryGetValue(type.TypeHandle, out object logicObject))
            //{
            //    LogicApi_I<T> logic = (LogicApi_I<T>)logicObject;

            //    return logic.Remove(context, objectToRemove);
            //}

            //return XData.Remove<T>(context, objectToRemove);
            throw new System.NotImplementedException();
        }



        public RemoveResult_I<T> RemoveById<T>(long id)
            where T : Poco_I
            
        {
            //var type = typeof(T);

            //if (_.Context.Layers.Logic.Apis.TryGetValue(type.TypeHandle, out object logicObject))
            //{
            //    LogicApi_I<T> logic = (LogicApi_I<T>)logicObject;

            //    return logic.RemoveById(context, id);
            //}

            //return XData.RemoveById<T>(context, id);

            throw new System.NotImplementedException();
        }



        public RemoveResult_I<T> RemoveAll<T>()
            where T : Poco_I
            
        {
            //var type = typeof(T);

            //if (_.Context.Layers.Logic.Apis.TryGetValue(type.TypeHandle, out object logicObject))
            //{
            //    LogicApi_I<T> logic = (LogicApi_I<T>)logicObject;

            //    return logic.RemoveAll(context);
            //}

            //return XData.RemoveAll<T>(context);
            throw new System.NotImplementedException();
        }

        public UpdateResult_I<T> Update<T>(T objectToUpdate)
            where T : Poco_I
            
        {
            //var type = typeof(T);

            //if (_.Context.Layers.Logic.Apis.TryGetValue(type.TypeHandle, out object logicObject))
            //{
            //    LogicApi_I<T> logic = (LogicApi_I<T>)logicObject;

            //    return logic.Update(context, objectToUpdate);
            //}

            //return XData.Update<T>(context, objectToUpdate);
            throw new System.NotImplementedException();
        }
    }
}
