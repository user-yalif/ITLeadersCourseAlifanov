namespace ConsoleApp.WebDriver.Drivers
{
    using System;
    using ConsoleApp.WebDriver.Drivers.Implementations;
    using ConsoleApp.WebDriver.Enums;
    using OpenQA.Selenium;
    using static AppSettings.SettingsCongfigurator;

    public class WebDriverManager
    {
        private static IWebDriver driver;

        private static BrowserType BrowserType => Settings.BrowserType;

        private static string PathToDriver => AppDomain.CurrentDomain.BaseDirectory;

        public static IWebDriver Driver
        {
            get
            {
                if (driver == null)
                {
                    driver = new DriverFactory()
                        .GetDriver(BrowserType)
                        .Setup(PathToDriver);
                }

                return driver;
            }
        }

        public static void DisposeDriver()
        {
            driver.Close();
            driver.Dispose();
        }
    }
}
