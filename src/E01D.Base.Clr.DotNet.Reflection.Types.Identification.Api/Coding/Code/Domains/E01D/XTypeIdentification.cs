using System;
using E01D.Base.Types.Api.Coding.Code.Api.E01D.Base;
using Root.Coding.Code.Models.E01D.Base.Types;

namespace Root.Coding.Code.Domains.E01D
{
    public static class XTypeIdentification
    {
        public static TypeApi Api { get; set; } = new TypeApi();

        public static TypeId_I GetTypeId(System.Type type)
        {
            return Api.GetTypeId(type);
        }

        public static TypeId_I GetTypeId(RuntimeTypeHandle handle)
        {
            return Api.GetTypeId(handle);
        }

        public static bool GetTypeId(RuntimeTypeHandle typeHandle, out TypeId_I id)
        {
            return Api.EnsureTypeId(typeHandle, out id);
        }

        public static TypeId_I GetTypeId<T>()
        {
            return Api.GetTypeId<T>();
        }

        public static bool GetTypeHandle(long id, out RuntimeTypeHandle typeHandle)
        {
            return Api.GetTypeHandle(id, out typeHandle);
        }

        public static bool GetTypeHandle(TypeId_I id, out RuntimeTypeHandle typeHandle)
        {
            return Api.GetTypeHandle(id, out typeHandle);
        }

        


    }
}
