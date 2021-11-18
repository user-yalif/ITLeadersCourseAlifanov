﻿namespace ConsoleApp.WebDriver
{
    using System;
    using ConsoleApp.WebDriver.Pages.Lesson9WebDriverWait;
    using static ConsoleApp.WebDriver.AppSettings.SettingsCongfigurator;

    class Program : BaseTest
    {
        private static string url = AppDomain.CurrentDomain.BaseDirectory + Settings.Urls.UrlLesson9;

        static void Main(string[] args)
        {
            try
            {
                var waitPage = NavigateTo<WaitPage>(url);

                var message = waitPage.ClickOnClickAndWaitButton()
                    .GetMessage();
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
