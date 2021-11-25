namespace NUnitFramework.Tests
{
    using System;
    using NUnit.Framework;
    using NUnit.Framework.Interfaces;
    using NUnitFramework.Drivers;
    using NUnitFramework.Helpers;
    using NUnitFramework.Logging;
    using static NUnitFramework.AppSettings.SettingsConfigurator;

    public class BaseTest
    {
        private static string PathToScreenshots => AppDomain.CurrentDomain.BaseDirectory + Settings.Paths.ScreenshotsOutput;

        private static TestStatus TestStatus => TestContext.CurrentContext.Result.Outcome.Status;

        private static string TestName => TestContext.CurrentContext.Test.Name;

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

            if (TestStatus == TestStatus.Failed)
            {
                var screenshotName = Screenshoter.TakeScreenshot(WebDriverManager.Driver, PathToScreenshots, TestName.Replace('"', '\''));

                Logger.Log.Info("Screenshot {0} was taken and put to {1}", screenshotName, PathToScreenshots);
            }

            WebDriverManager.DisposeDriver();
        }
    }
}
