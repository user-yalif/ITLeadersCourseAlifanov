namespace ConsoleApp.WebDriver
{
    using ConsoleApp.WebDriver.Drivers;
    using ConsoleApp.WebDriver.Pages;
    using ConsoleApp.WebDriver.Pages.Lesson3Forms;

    public class BaseTest
    {
        protected static FormPage NavigateTo(string uri)
        {
            WebDriverManager.Driver.Navigate().GoToUrl(uri);

            return new FormPage();
        }

        protected static TPage NavigateTo<TPage>(string url) where TPage : BasePage, new()
        {
            WebDriverManager.Driver.Navigate().GoToUrl(url);

            return new TPage();
        }

        protected static void DisposeTest()
        {
            WebDriverManager.DisposeDriver();
        }
    }
}
