using ConsoleApp.CSharpBasics.Classes.OOP.Enums;

namespace ConsoleApp.CSharpBasics.Classes.OOP.Structs
{
    public struct Task
    {
        private static ulong counterId;
        private ulong id;
        private ulong assaigneeId;
        private string description;
        private TaskStatus taskStatus;

        public Task(string description)
        {
            counterId++;
            id = counterId;
            assaigneeId = default;
            taskStatus = TaskStatus.Created;
            this.description = description;
        }

        public ulong Id
        {
            get { return id; }
        }

        public ulong AssaigneeId
        {
            get { return assaigneeId; }
            set { assaigneeId = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public TaskStatus TaskStatus
        {
            get { return taskStatus; }
            set { taskStatus = value; }
        }
    }
}
