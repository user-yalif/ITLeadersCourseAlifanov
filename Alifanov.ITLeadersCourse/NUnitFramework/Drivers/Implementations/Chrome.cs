namespace NUnitFramework.Drivers.Implementations
{
    using NUnitFramework.Drivers.Interfaces;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;

    public class Chrome : IDriver
    {
        private static ChromeOptions GetChromeOptions(string downloadPath)
        {
            var options = new ChromeOptions();

            options.AddArgument("--start-maximized");

            if (!string.IsNullOrEmpty(downloadPath))
            {
                options.AddUserProfilePreference("download.default_directory", downloadPath);
            }

            return options;
        }

        public IWebDriver SetUpDriver(string pathToDriver, string downloadPath) =>
            new ChromeDriver(pathToDriver, GetChromeOptions(downloadPath));
    }
}
