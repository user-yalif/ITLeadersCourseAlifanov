namespace NUnitFramework.Drivers.Implementations
{
    using NUnitFramework.Drivers.Interfaces;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;

    public class Chrome : IDriver
    {
        private static ChromeOptions GetChromeOptions()
        {
            ChromeOptions options = new();

            options.AddArgument("--start-maximized");

            return options;
        }

        public IWebDriver Setup(string pathToDriver) =>
            new ChromeDriver(pathToDriver, GetChromeOptions());
    }
}
