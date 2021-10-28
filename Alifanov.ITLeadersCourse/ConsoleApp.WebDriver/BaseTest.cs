namespace ConsoleApp.WebDriver
{
    using ConsoleApp.WebDriver.Drivers;
    using ConsoleApp.WebDriver.Pages;

    public class BaseTest
    {
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
