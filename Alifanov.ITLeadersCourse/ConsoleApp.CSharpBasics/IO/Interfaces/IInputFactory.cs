namespace ConsoleApp.CSharpBasics.IO.Interfaces
{
    using System;

    public abstract class IInputFactory
    {
        public abstract IInput GetOutputInstance(Type outpuType);
    }
}
