namespace NUnitFramework.Tests
{
    using System;
    using System.IO;
    using NUnit.Framework;
    using NUnit.Framework.Interfaces;
    using NUnitFramework.Drivers;
    using NUnitFramework.Helpers;
    using NUnitFramework.Logging;
    using NUnitFramework.Utils;
    using static NUnitFramework.AppSettings.SettingsConfigurator;

    public class BaseTest
    {
        private static string PathToScreenshots => PathUtils.ConfigurePathToBaseDirectory(Settings.Paths.ScreenshotsOutput);

        protected static string DownloadDirectory => WebDriverManager.DownloadPath;

        private static TestStatus TestStatus => TestContext.CurrentContext.Result.Outcome.Status;

        private static string TestName => TestContext.CurrentContext.Test.MethodName;

        [SetUp]
        public void SetUpTest()
        {
            Logger.Log.Info("{0} test started", TestName);
            Logger.Log.Info("Go to {0}", Settings.BaseUrl);

            WebDriverManager.Driver.Navigate().GoToUrl(Settings.BaseUrl);
        }

        [TearDown]
        public void DisposeTest()
        {
            Logger.Log.Info("{0} test finished with status: {1}", TestName, TestStatus.ToString().ToUpper());

            try
            {
                if (TestStatus == TestStatus.Failed)
                {
                    if (!Directory.Exists(PathToScreenshots))
                    {
                        Directory.CreateDirectory(PathToScreenshots);
                    }

                    var screenshotName = Screenshoter.TakeScreenshot(WebDriverManager.Driver, PathToScreenshots, TestName);

                    Logger.Log.Info("Screenshot {0} was taken and put to {1}", screenshotName, PathToScreenshots);
                }

                FileUtils.RemoveAll(DownloadDirectory);
            }
            finally
            {
                WebDriverManager.DisposeDriver();
            }
        }
    }
}
