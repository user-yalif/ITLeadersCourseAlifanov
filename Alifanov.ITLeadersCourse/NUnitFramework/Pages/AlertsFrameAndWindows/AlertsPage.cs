namespace NUnitFramework.Pages.AlertsFrameAndWindows
{
    using NUnitFramework.Helpers;
    using NUnitFramework.Logging;
    using OpenQA.Selenium;

    public class AlertsPage : BasePage
    {
        private IWebElement AlertWithTimeoutButton => FindElement(By.CssSelector("button#timerAlertButton"));

        public AlertsPage ClickOnAlertWithTimeoutButton()
        {
            Logger.Log.Info("Click on Alert with timeout button");

            AlertWithTimeoutButton.Click();

            return this;
        }

        public string AcceptAlert()
        {
            Logger.Log.Info("Wait for alert");
            var alert = Waiter.WaitUntilAlertIsDisplayed();

            Logger.Log.Info("Accept alert and get message");
            return alert.AcceptAlert();
        }
    }
}
