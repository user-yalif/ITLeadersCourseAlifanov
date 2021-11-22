namespace NUnitFramework.Tests
{
    using NUnit.Framework;
    using NUnit.Framework.Interfaces;
    using NUnitFramework.Drivers;
    using NUnitFramework.Logging;
    using static NUnitFramework.AppSettings.SettingsConfigurator;

    public class BaseTest
    {
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

            WebDriverManager.DisposeDriver();
        }
    }
}
