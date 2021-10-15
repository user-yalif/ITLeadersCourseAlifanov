namespace ConsoleApp.CSharpBasics.Classes
{
    public class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Person()
        {
            name = "Icognito";
        }

        public Person(string name)
        {
            this.name = name;
        }

        public string GetIntroduction()
        {
            return $"Hi! My name is {name}";
        }
    }

    public struct Screen
    {
        public uint width;
        public uint height;
    }

    public class TVSet
    {
        public Screen screen;

        public TVSet(uint width, uint height)
        {
            screen = new Screen();
            screen.width = width;
            screen.height = height;
        }

        public string Display()
        {
            return "I display something!";
        }
    }

}
