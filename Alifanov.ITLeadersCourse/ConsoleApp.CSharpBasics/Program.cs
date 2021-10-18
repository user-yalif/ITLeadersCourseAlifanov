namespace ConsoleApp.CSharpBasics
{
    using ConsoleApp.CSharpBasics.Classes.OOP.Enums;
    using ConsoleApp.CSharpBasics.Classes.OOP.Implementations;
    using ConsoleApp.CSharpBasics.Classes.OOP.Interfaces;
    using ConsoleApp.CSharpBasics.Classes.OOP.Structs;
    using static ConsoleApp.CSharpBasics.IO.Output;

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "John";
            person.Weight = 3.9;
            person.DateOfBirth = new DateOfBirth(2021, 09, 01);

            Person person2 = new Person(Sex.Woman, new DateOfBirth(1980, 5, 12), "Sarah", 55);

            IMetrics[] metrics = new[] { person, person2 };

            double averageAge = 0.0;

            foreach (var metric in metrics)
            {
                averageAge += metric.Age;
            }

            Out.WriteLine(averageAge);
        }
    }

    // Incapsulation
    // Inharitance
    // Polymorphism
    // Abstraction

    public class Rectangle
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double CalculateArea()
        {
            return width * height;
        }
    }

    public class Square : Rectangle
    {
        public Square(double side) : base(side, side)
        {
        }
    }
}
