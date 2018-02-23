namespace Root.Coding.Code.Models.E01D.Core.Reflection.Emit.DelegateFactories
{
    public class DynamicReflectionDelegateFactory: ReflectionDelegateFactory
    {
        public override Root.Coding.Code.Enums.E01D.Core.Reflection.Emit.DelegateFactories.ReflectionDelegateFactoryKind Kind { get; } = Root.Coding.Code.Enums.E01D.Core.Reflection.Emit.DelegateFactories.ReflectionDelegateFactoryKind.Dynamic;
    }
}
