namespace ConsoleApp.WebDriver.Drivers.Interfaces
{
    using OpenQA.Selenium;

    public interface IDriver
    {
        IWebDriver Setup(string pathToDriver);
    }
}
