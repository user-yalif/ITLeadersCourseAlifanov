namespace ConsoleApp.CSharpBasics.IO.Implementations
{
    using System;
    using ConsoleApp.CSharpBasics.IO.Interfaces;

    public class InputFactory : IInputFactory
    {

        public override IInput GetOutputInstance(Type inputType)
        {
            switch (inputType)
            {
                case Type when inputType == typeof(ConsoleInput):
                    return new ConsoleInput();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
