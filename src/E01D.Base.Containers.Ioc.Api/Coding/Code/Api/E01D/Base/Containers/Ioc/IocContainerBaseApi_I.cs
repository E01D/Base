namespace Root.Coding.Code.Api.E01D.Base.Containers.Ioc
{
    public interface IocContainerBaseApi_I<TContainer>: QueryableContainerBaseApi_I<TContainer>
    {
        T GetService<T>(TContainer container);
    }
}
