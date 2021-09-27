namespace ConsoleApp.CSharpBasics.IO.Iterfaces
{
    using System;

    public abstract class IOutputFactory
    {
        public abstract IOutput GetOutputInstance(Type outpuType);
    }
}
