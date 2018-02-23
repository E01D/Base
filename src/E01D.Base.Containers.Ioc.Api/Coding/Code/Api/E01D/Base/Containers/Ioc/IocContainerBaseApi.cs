using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Root.Coding.Code.Api.E01D.Base.Containers.Ioc
{
    public abstract class IocContainerBaseApi<TContainer>: IocContainerBaseApi_I<TContainer>
    {
        public abstract T Get<T>(TContainer container);

        public abstract bool Get<T>(TContainer container, out T result);

        public T GetService<T>(TContainer container)
        {
            return Get<T>(container);
        }
    }
}
