namespace NUnitFramework.Drivers
{
    using System;
    using System.Collections.Concurrent;
    using NUnit.Framework;
    using NUnitFramework.Drivers.Implementations;
    using NUnitFramework.Logging;
    using NUnitFramework.Utils;
    using OpenQA.Selenium;
    using static NUnitFramework.AppSettings.SettingsConfigurator;

    public static class WebDriverManager
    {
        private static string PathToDriver { get; } = AppDomain.CurrentDomain.BaseDirectory;

        public static string DownloadPath { get; } = PathUtils.ConfigurePathToBaseDirectory(Settings.Paths.DownloadsDirectory);

        private static ConcurrentDictionary<string, IWebDriver> DriversInUse { get; set; } = new();

        private static string CurrentKey => TestContext.CurrentContext.Test.ID;

        public static IWebDriver Driver
        {
            get
            {
                if (!DriversInUse.ContainsKey(CurrentKey))
                {
                    var driver = new DriverFactory()
                            .GetDriver(Settings.Browser)
                            .SetUpDriver(PathToDriver, DownloadPath);

                    if (driver == null)
                    {
                        Logger.Log.Error("Critical Error! WebDriver instance was not created!");

                        throw new NullReferenceException("Critical Error! WebDriver instance was not created!");
                    }

                    DriversInUse[CurrentKey] = driver;

                    Logger.Log.Info($"WebDriver instance created; Key: {CurrentKey} SessionId: {((WebDriver)driver).SessionId}");
                }

                return DriversInUse[CurrentKey];
            }
        }

        public static void DisposeDriver()
        {
            if (DriversInUse.ContainsKey(CurrentKey))
            {
                var sessionId = ((WebDriver)DriversInUse[CurrentKey]).SessionId;

                DriversInUse[CurrentKey].Quit();

                Logger.Log.Info($"Try to close WebDriver; Key: {CurrentKey} SessionId: {sessionId}");

                if (!DriversInUse.TryRemove(CurrentKey, out _))
                {
                    throw new ArgumentNullException();
                }

                Logger.Log.Info($"WebDriver Quit: SUCCESS");
            }
        }
    }
}
