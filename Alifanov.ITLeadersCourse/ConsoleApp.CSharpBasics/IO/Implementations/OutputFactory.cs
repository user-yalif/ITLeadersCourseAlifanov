namespace ConsoleApp.CSharpBasics.IO.Implementations
{
    using System;
    using ConsoleApp.CSharpBasics.IO.Iterfaces;

    public class OutputFactory : IOutputFactory
    {
        public override IOutput GetOutputInstance(Type outpuType)
        {
            switch (outpuType)
            {
                case Type when outpuType == typeof(ConsoleOutput):
                    return new ConsoleOutput();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
