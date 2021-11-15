namespace ConsoleApp.WebDriver
{
    using System;
    using static ConsoleApp.WebDriver.AppSettings.SettingsCongfigurator;

    class Program : BaseTest
    {
        private static string url = AppDomain.CurrentDomain.BaseDirectory + Settings.Urls.Url1Lesson8;

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
