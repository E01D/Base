namespace Root.Coding.Code.Api.E01D.Base.Containers
{
#pragma warning disable IDE1006 // Naming Styles
    public interface QueryableContainerBaseApi_I<TContainer>: ContainerApi_I
#pragma warning restore IDE1006 // Naming Styles
    {
        T Get<T>(TContainer container);

        bool Get<T>(TContainer container, out T result);
    }
}
