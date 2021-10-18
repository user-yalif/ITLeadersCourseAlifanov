namespace ConsoleApp.CSharpBasics.Classes.OOP.Structs
{
    public struct DateOfBirth
    {
        private readonly int day;
        private readonly int month;
        private readonly int year;

        public DateOfBirth(int year, int month, int day)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public int Day
        {
            get { return day; }
        }
        public int Month
        {
            get { return month; }
        }

        public int Year
        {
            get { return year; }
        }
    }
}
