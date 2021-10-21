namespace ConsoleApp.CSharpBasics
{
    using System.Collections.Generic;
    using ConsoleApp.CSharpBasics.Classes.OOP.Enums;
    using ConsoleApp.CSharpBasics.Classes.OOP.Implementations;
    using ConsoleApp.CSharpBasics.Classes.OOP.Interfaces;
    using ConsoleApp.CSharpBasics.Classes.OOP.Structs;
    using static ConsoleApp.CSharpBasics.IO.Output;

    class Program
    {
        static void Main(string[] args)
        {
            IPerson anonimus = new Person();
            IPerson woman = new Person(Sex.Woman);
            IPerson man = new Person(Sex.Man, new DateOfBirth(1995, 10, 22));
            IPerson tom = new Person(Sex.Man, new DateOfBirth(1977, 06, 12), "Tom");
            IPerson samanta = new Person(Sex.Woman, new DateOfBirth(2005, 09, 25), "Samanta", 65);

            anonimus.DateOfBirth = new DateOfBirth(1988, 01, 01);
            anonimus.Name = "John";
            ((Person)anonimus).Weight = 75.0;

            IPerson john = new Person(anonimus.Sex, anonimus.DateOfBirth, anonimus.Name, ((Person)anonimus).Weight);

            woman.DateOfBirth = new DateOfBirth(2003, 01, 01);
            woman.Name = "Pamela";
            ((Person)woman).Weight = 64.0;

            IPerson pamela = new Person(woman.Sex, woman.DateOfBirth, woman.Name, ((Person)woman).Weight);

            man.Name = "Stive";
            ((Person)man).Weight = 64.0;

            IPerson stive = new Person(man.Sex, man.DateOfBirth, man.Name, ((Person)man).Weight);

            IPerson[] people = new[]
            {
                tom,
                samanta,
                john,
                pamela,
                stive
            };

            foreach (var person in people)
            {
                Out.WriteLine(person.Name);
                Out.WriteLine(person.Age);
                Out.WriteLine(person.DateOfBirth.Year + " " + person.DateOfBirth.Month + " " + person.DateOfBirth.Day);
                Out.WriteLine(person.Sex);
                Out.WriteLine(((Person)person).Weight);
            }

            var companyStaff = new List<IEmployee>();

            foreach (var person in people)
            {
                if (!(person.Age < 18))
                {
                    IEmployee e = (Employee)person;

                    companyStaff.Add(new Employee(person));
                }
            }

            Task task1 = new Task("Code refactoring");
            Task task2 = new Task("Make PR");
            Task task3 = new Task("Make PR review");

            IManager managerPamela = new Manager(companyStaff[2]);
            IProgrammer programmerTom = new Programmer(companyStaff[0]);
            IProgrammer programmerJohn = new Programmer(companyStaff[1]);

            task1 = programmerTom.TakeTask(task1);
            task1 = managerPamela.ReassignTask(task1, programmerJohn.Id);
            task2 = programmerTom.TakeTask(task2);
            task1 = programmerJohn.CloseTask(task1);

            var analysis = managerPamela.AnalizeTeamWork(new[] { task1, task2, task3 });

            Out.WriteLine("Created: " + analysis.created);
            Out.WriteLine("In Progress: " + analysis.inProgress);
            Out.WriteLine("Closed: " + analysis.closed);

            IEmployee[] employees = new[]
            {
                managerPamela,
                programmerJohn,
                programmerTom,
                companyStaff[3]
            };

            foreach (var employee in employees)
            {
                Out.WriteLine("Id: " + employee.Id + "Name: " + employee.Name + "; Role: " + employee.Role);
            }

            Person person1 = new Person(Sex.Woman, new DateOfBirth(2005, 09, 25), "Samanta", 65);
            IPerson personOne = person1;

            Rectangle rect = new Rectangle(5, 5);
            Square square = new Square(2);
            IShape triangle = new Triangle(5, 2, 3);

            IShape[] shapesArray =
            {
                rect,
                square,
                triangle
            };

            Out.WriteLine(rect.CalculateArea());
            Out.WriteLine(square.GetArea());
            Out.WriteLine(triangle.CalculateArea());
        }

        // Incapsulation
        // Inharitance
        // Polymorphism
        // Abstraction

        public interface IShape
        {
            double CalculateArea();
        }

        public class Rectangle : IShape
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

            public double GetArea()
            {
                return base.CalculateArea();
            }
        }

        public class Triangle : IShape
        {
            private double sideA;
            private double sideB;
            private double hypotenusa;

            public Triangle(double sideA, double sideB, double hypotenusa)
            {
                this.sideA = sideA;
                this.sideB = sideB;
                this.hypotenusa = hypotenusa;
            }

            public double CalculateArea()
            {
                return sideA * sideB * hypotenusa;
            }
        }
    }
}
