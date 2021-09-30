namespace ConsoleApp.CSharpBasics.IO.Implementations
{
    using System;
    using ConsoleApp.CSharpBasics.IO.Interfaces;

    public class ConsoleInput : IInput
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
