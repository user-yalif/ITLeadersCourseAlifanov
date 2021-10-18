using ConsoleApp.CSharpBasics.Classes.OOP.Enums;
using ConsoleApp.CSharpBasics.Classes.OOP.Implementations;
using ConsoleApp.CSharpBasics.Classes.OOP.Interfaces;
using ConsoleApp.CSharpBasics.Classes.OOP.Structs;
using static ConsoleApp.CSharpBasics.IO.Output;

namespace ConsoleApp.CSharpBasics
{
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

    public class Rectungle
    {
        public double width;
        public double height;

        public Rectungle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double CalculatePerimeter()
        {
            return width * height;
        }
    }

    public class Square : Rectungle
    {
        public Square(double side) : base(side, side)
        {
        }
    }
}
