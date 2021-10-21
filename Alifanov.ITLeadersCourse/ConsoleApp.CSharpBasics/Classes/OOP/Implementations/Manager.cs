namespace ConsoleApp.CSharpBasics.Classes.OOP.Implementations
{
    using System;
    using ConsoleApp.CSharpBasics.Classes.OOP.Enums;
    using ConsoleApp.CSharpBasics.Classes.OOP.Interfaces;
    using ConsoleApp.CSharpBasics.Classes.OOP.Structs;

    public class Manager : Employee, IManager
    {
        public Manager(IEmployee employee) : base(employee)
        {
            base.Role = EmployeeRoles.Manager;
        }

        public (int created, int inProgress, int closed) AnalyzeTeamWork(Task[] tasks)
        {
            int created = 0;
            int inProgress = 0;
            int closed = 0;

            foreach (var task in tasks)
            {
                switch (task.TaskStatus)
                {
                    case TaskStatus.Created:
                        created++;
                        break;
                    case TaskStatus.InProgress:
                        inProgress++;
                        break;
                    case TaskStatus.Closed:
                        closed++;
                        break;
                    default:
                        throw new NotImplementedException($"{task.TaskStatus} is not emplemented!");
                }
            }

            return (created, inProgress, closed);
        }

        public Task ReassignTask(Task task, ulong assigneeId)
        {
            if (task.TaskStatus != TaskStatus.Closed)
            {
                task.TaskStatus = TaskStatus.InProgress;
            }

            task.AssaigneeId = assigneeId;

            return task;
        }
    }
}
