namespace ConsoleApp.CSharpBasics.IO.Interfaces
{
    using System;

    public abstract class IOutputFactory
    {
        public abstract IOutput GetOutputInstance(Type outputType);
    }
}
