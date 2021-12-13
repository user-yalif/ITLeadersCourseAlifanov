namespace NUnitFramework.Helpers
{
    using NUnitFramework.Drivers;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;
    using System;
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

        public static bool WaitUntilElementToBePresent(By locator) =>
            WebDriverWait.Until(IsElementPresent(locator));
              
        public static IWebElement WaitUntilElementToBeClickable(By locator) =>
            WebDriverWait.Until(ExpectedConditions.ElementToBeClickable(locator));
                      
        private static Func<IWebDriver, bool> IsElementPresent(By locator)
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

        public static bool WaitUntilElementsAttributeValueContains(IWebElement element, string attribute, string parameter) =>
            WebDriverWait.Until(driver =>
            {
                var attributeValue = element.GetAttribute(attribute);

                if (attributeValue.Contains(parameter))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            });
    }
}
