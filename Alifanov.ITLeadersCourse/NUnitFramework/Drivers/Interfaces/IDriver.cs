namespace NUnitFramework.Drivers.Interfaces
{
    using OpenQA.Selenium;

    public interface IDriver
    {
        IWebDriver SetUpDriver(string pathToDriver, string downloadPath);
    }
}
