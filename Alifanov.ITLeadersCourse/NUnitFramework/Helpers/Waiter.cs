namespace NUnitFramework.Helpers
{
    using System;
    using NUnitFramework.Drivers;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;
    using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

    public static class Waiter
    {
        private static TimeSpan DefaultTimeout { get; } = TimeSpan.FromSeconds(15);

        private static WebDriverWait WebDriverWait =>
            new(WebDriverManager.Driver, DefaultTimeout);

        public static IAlert WaitUntilAlertIsDisplayed() =>
            WebDriverWait.Until(ExpectedConditions.AlertIsPresent());

        public static bool WaitUntilElementToBeEnabled(IWebElement element) =>
            WebDriverWait.Until(driver => element.Enabled);
    }
}
