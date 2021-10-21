namespace ConsoleApp.CSharpBasics.Classes.OOP.Implementations
{
    using ConsoleApp.CSharpBasics.Classes.OOP.Enums;
    using ConsoleApp.CSharpBasics.Classes.OOP.Interfaces;

    public class Employee : Person, IEmployee
    {
        private static ulong counterId;
        private readonly ulong id;
        private EmployeeRoles role;

        public ulong Id
        {
            get { return id; }
        }

        public EmployeeRoles Role
        {
            get { return role; }
            set { role = value; }
        }

        public Employee(IPerson person) : base(person.Sex, person.DateOfBirth, person.Name)
        {
            counterId++;
            id = counterId;
        }

        public Employee(IEmployee employee) : base(employee.Sex, employee.DateOfBirth, employee.Name)
        {
            id = employee.Id;
        }
    }
}
