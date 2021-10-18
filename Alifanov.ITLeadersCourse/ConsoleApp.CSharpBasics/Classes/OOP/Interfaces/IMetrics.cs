namespace ConsoleApp.CSharpBasics.Classes.OOP.Interfaces
{
    using ConsoleApp.CSharpBasics.Classes.OOP.Structs;

    public interface IMetrics
    {
        DateOfBirth DateOfBirth { get; set; }

        ushort Age { get; }

        string Name { get; set; }
    }
}
