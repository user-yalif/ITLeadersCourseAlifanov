namespace ConsoleApp.WebDriver
{
    using System;
    using static ConsoleApp.WebDriver.AppSettings.SettingsCongfigurator;

    class Program : BaseTest
    {
        private static readonly string url = AppDomain.CurrentDomain.BaseDirectory + Settings.Urls.UrlLesson7;

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
