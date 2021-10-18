namespace ConsoleApp.CSharpBasics.Classes.OOP.Interfaces
{
    using ConsoleApp.CSharpBasics.Classes.OOP.Enums;

    public interface IPerson : IMetrics
    {
        Sex Sex { get; }
    }
}
