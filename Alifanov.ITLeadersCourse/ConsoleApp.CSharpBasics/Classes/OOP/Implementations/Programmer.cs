namespace ConsoleApp.CSharpBasics.Classes.OOP.Implementations
{
    using ConsoleApp.CSharpBasics.Classes.OOP.Enums;
    using ConsoleApp.CSharpBasics.Classes.OOP.Interfaces;
    using ConsoleApp.CSharpBasics.Classes.OOP.Structs;

    public class Programmer : Employee, IProgrammer
    {
        public Programmer(IEmployee employee) : base(employee)
        {
            base.Role = EmployeeRoles.Programmer;
        }

        public Task TakeTask(Task task)
        {
            if (task.AssaigneeId != Id)
            {
                task.AssaigneeId = Id;
            }

            task.TaskStatus = TaskStatus.InProgress;

            return task;
        }

        public Task CloseTask(Task task)
        {
            if (task.AssaigneeId == Id && task.TaskStatus != TaskStatus.Closed)
            {
                task.TaskStatus = TaskStatus.Closed;
            }

            return task;
        }
    }
}
