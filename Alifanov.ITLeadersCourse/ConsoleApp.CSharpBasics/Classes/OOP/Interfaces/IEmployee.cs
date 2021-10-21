namespace ConsoleApp.CSharpBasics.Classes.OOP.Interfaces
{
    using ConsoleApp.CSharpBasics.Classes.OOP.Enums;

    public interface IEmployee : IPerson
    {
        ulong Id { get; }

        EmployeeRoles Role { get; set; }
    }
}
