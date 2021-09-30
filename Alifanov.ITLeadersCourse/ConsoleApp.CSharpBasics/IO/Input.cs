namespace ConsoleApp.CSharpBasics.IO
{
    using ConsoleApp.CSharpBasics.IO.Implementations;
    using ConsoleApp.CSharpBasics.IO.Interfaces;

    public class Input
    {
        private static IInput input;

        public static IInput In
        {
            get
            {
                if (input == null)
                {
                    input = new InputFactory().GetOutputInstance(typeof(ConsoleInput));
                }

                return input;
            }
        }
    }
}
