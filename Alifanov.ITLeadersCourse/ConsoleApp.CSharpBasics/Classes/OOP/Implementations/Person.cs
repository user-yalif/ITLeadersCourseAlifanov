namespace ConsoleApp.CSharpBasics.Classes.OOP.Implementations
{
    using System;
    using ConsoleApp.CSharpBasics.Classes.OOP.Enums;
    using ConsoleApp.CSharpBasics.Classes.OOP.Interfaces;
    using ConsoleApp.CSharpBasics.Classes.OOP.Structs;

    public class Person : IPerson
    {
        private readonly Sex sex;
        private DateTime dateOfBirth;
        private string name;
        private double weight;

        private static ushort GetLeapYearCorrelation(TimeSpan age)
        {
            return (ushort)(age.Days / 365 / 4 / 365);
        }

        public Sex Sex
        {
            get
            {
                return sex;
            }
        }

        public DateOfBirth DateOfBirth
        {
            get { return new DateOfBirth(dateOfBirth.Year, dateOfBirth.Month, dateOfBirth.Day); }
            set
            {
                dateOfBirth = new DateTime(value.Year, value.Month, value.Day);
            }
        }

        public ushort Age
        {
            get
            {
                if (dateOfBirth == default)
                {
                    return 0;
                }
                else
                {
                    var currentAge = DateTime.Now - dateOfBirth.AddDays(10);

                    return (ushort)((currentAge.Days / 365) - GetLeapYearCorrelation(currentAge));
                }
            }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        //public Person()
        //{
        //    this.sex = sex;
        //    this.dateOfBirth = default;
        //    this.name = name;
        //    this.weight = weight;
        //}

        //public Person(Sex sex)
        //{
        //    this.sex = sex;
        //    this.dateOfBirth = default;
        //    this.name = "Unnamed";
        //    this.weight = 0.0;
        //}

        //public Person(Sex sex, DateOfBirth dateOfBirth)
        //{
        //    this.sex = sex;
        //    this.dateOfBirth = new DateTime(dateOfBirth.Year, dateOfBirth.Month, dateOfBirth.Day);
        //    this.name = "Unnamed";
        //    this.weight = 0.0;
        //}

        //public Person(Sex sex, DateOfBirth dateOfBirth, string name)
        //{
        //    this.sex = sex;
        //    this.dateOfBirth = new DateTime(dateOfBirth.Year, dateOfBirth.Month, dateOfBirth.Day);
        //    this.name = name;
        //    this.weight = 0.0;
        //}

        //public Person(Sex sex, DateOfBirth dateOfBirth, string name, double weight)
        //{
        //    this.sex = sex;
        //    this.dateOfBirth = new DateTime(dateOfBirth.Year, dateOfBirth.Month, dateOfBirth.Day);
        //    this.name = name;
        //    this.weight = weight;
        //}

        public Person() : this(Sex.Man)
        {
        }

        public Person(Sex sex) : this(sex, new DateOfBirth(0001, 1, 1))
        {
        }

        public Person(Sex sex, DateOfBirth dateOfBirth) : this(sex, dateOfBirth, "Unnamed")
        {
        }

        public Person(Sex sex, DateOfBirth dateOfBirth, string name) : this(sex, dateOfBirth, name, 0.0)
        {
        }

        public Person(Sex sex, DateOfBirth dateOfBirth, string name, double weight)
        {
            this.sex = sex;
            this.dateOfBirth = new DateTime(dateOfBirth.Year, dateOfBirth.Month, dateOfBirth.Day);
            this.name = name;
            this.weight = weight;
        }
    }
}
