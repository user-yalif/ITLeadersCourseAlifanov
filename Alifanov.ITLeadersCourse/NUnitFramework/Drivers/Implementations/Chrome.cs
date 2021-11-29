namespace NUnitFramework.Drivers.Implementations
{
    using NUnitFramework.Drivers.Interfaces;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;

    public class Chrome : IDriver
    {
        private static ChromeOptions GetChromeOptions()
        {
            var options = new ChromeOptions();

            options.AddArgument("--start-maximized");

            return options;
        }

        public IWebDriver SetUpDriver(string pathToDriver) =>
            new ChromeDriver(pathToDriver, GetChromeOptions());
    }
}
