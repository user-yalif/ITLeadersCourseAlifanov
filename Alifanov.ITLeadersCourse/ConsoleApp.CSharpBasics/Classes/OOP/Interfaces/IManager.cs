namespace ConsoleApp.CSharpBasics.Classes.OOP.Interfaces
{
    using ConsoleApp.CSharpBasics.Classes.OOP.Structs;

    public interface IManager : IEmployee
    {
        (int created, int inProgress, int closed) AnalizeTeamWork(Task[] tasks);

        Task ReassignTask(Task task, ulong assigneeId);
    }
}
