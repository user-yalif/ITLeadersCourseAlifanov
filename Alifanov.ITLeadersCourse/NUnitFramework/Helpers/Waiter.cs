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

        public static bool WaitUntilElementToBeDisplayed(By locator) =>
            WebDriverWait.Until(IsDisplayed(locator));

        private static Func<IWebDriver, bool> IsDisplayed(By locator)
        {
            return webDriver =>
            {
                try
                {
                    webDriver.FindElement(locator);
                    return true;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            };
        }
    }
}
