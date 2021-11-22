namespace NUnitFramework.Drivers
{
    using System;
    using NUnitFramework.Drivers.Implementations;
    using NUnitFramework.Logging;
    using OpenQA.Selenium;
    using static NUnitFramework.AppSettings.SettingsConfigurator;

    public static class WebDriverManager
    {
        private static string PathToDriver { get; } = AppDomain.CurrentDomain.BaseDirectory;

        private static IWebDriver driver;

        public static IWebDriver Driver
        {
            get
            {
                if (driver == null)
                {
                    driver = new DriverFactory()
                        .GetDriver(Settings.Browser)
                        .Setup(PathToDriver);

                    Logger.Log.Info($"WebDriver launched; SessionId: {((WebDriver)driver).SessionId}");
                }

                if (driver == null)
                {
                    Logger.Log.Error("Critical Error! WebDriver instance was not created!");
                }

                return driver;
            }
        }

        public static void DisposeDriver()
        {
            Driver.Close();

            Logger.Log.Info($"Try to close WebDriver; SessionId: {((WebDriver)driver).SessionId}");

            Driver.Quit();

            Logger.Log.Info($"Quit WebDriver: SUCCESS");
        }
    }
}
