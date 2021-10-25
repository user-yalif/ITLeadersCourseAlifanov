namespace ConsoleApp.WebDriver
{
    using System;
    using ConsoleApp.WebDriver.Drivers;

    class Program
    {
        static void Main(string[] args)
        {
            var url = AppDomain.CurrentDomain.BaseDirectory + @"\Appendix\Lessons\Lesson2_WebDriverIntroduction\index.html";

            WebDriverManager.Driver.Navigate().GoToUrl(url);

            WebDriverManager.DisposeDriver();
        }
    }
}
