using System;
using Root.Coding.Code.Models.E01D.Base.Types;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Types.Contexts;

namespace E01D.Base.Types.Api.Coding.Code.Api.E01D.Base
{
    public class TypeApi
    {

        public TypeId_I GetTypeId(System.Type type)
        {
            TypeId_I result;

            EnsureTypeId(type.TypeHandle, out result);

            return result;
        }


        public TypeId_I GetTypeId(RuntimeTypeHandle typeHandle)
        {
            TypeId_I result;

            EnsureTypeId(typeHandle, out result);

            return result;
        }

        public bool GetTypeHandle(long id, out RuntimeTypeHandle typeHandle)
        {
            var context = GetGlobalContext();

            lock (context.SyncRoot)
            {
                return context.TypeHandles.TryGetValue(id, out typeHandle);
            }
        }

        public TypeId_I GetTypeId<T>()
        {
            return GetTypeId(typeof(T));
        }

        public bool GetTypeHandle(TypeId_I id, out RuntimeTypeHandle typeHandle)
        {
            var context = GetGlobalContext();

            lock (context.SyncRoot)
            {
                return context.TypeHandles.TryGetValue(id.Value, out typeHandle);
            }
        }

        public bool EnsureTypeId(RuntimeTypeHandle typeHandle, out TypeId_I id)
        {
            var context = GetGlobalContext();

            lock (context.SyncRoot)
            {
                if (!context.TypeIdsByTypeHandle.TryGetValue(typeHandle, out id))
                {
                    id = AddTypeId(typeHandle);

                    return false;
                }

                return true;
            }
        }

        public TypeId_I AddTypeId(RuntimeTypeHandle typeHandle)
        {
            var context = GetGlobalContext();

            lock (context.SyncRoot)
            {
                var standardType = new StandardTypeId()
                {
                    TypeId = GetStandardTypeIdTypeId(context)
                };

                XIdentification.IssueId(standardType);

                context.TypeIdsByTypeHandle.Add(typeHandle, standardType);

                context.TypeHandles.Add(standardType.Value, typeHandle);

                return standardType;
            }
        }

        private TypeId_I GetStandardTypeIdTypeId(TypeGlobalContext_I context)
        {
            lock (context.SyncRoot)
            {
                if (context.StandardTypeIdTypeId == null)
                {
                    StandardTypeId id = new StandardTypeId();

                    XIdentification.IssueId(id);

                    id.TypeId = id;

                    context.StandardTypeIdTypeId = id;
                }

                return context.StandardTypeIdTypeId;
            }
        }

        public TypeGlobalContext_I GetGlobalContext()
        {
            TypeGlobalContext_I context = XContextualBase.GetGlobal<TypeGlobalContext_I>();

            return context;
        }
    }
}
