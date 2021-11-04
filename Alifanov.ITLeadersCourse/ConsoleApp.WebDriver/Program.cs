namespace ConsoleApp.WebDriver
{
    using System;

    class Program : BaseTest
    {
        public readonly static string url = AppDomain.CurrentDomain.BaseDirectory
            + @"\Appendix\Lessons\Lesson5_Modals\modals.html";

        static void Main(string[] args)
        {
            try
            {

            }
            catch (Exception)
            {
            }
            finally
            {
                DisposeTest();
            }
        }
    }
}
