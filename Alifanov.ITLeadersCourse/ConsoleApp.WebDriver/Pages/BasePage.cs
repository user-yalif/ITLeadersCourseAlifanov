namespace ConsoleApp.WebDriver.Pages
{
    using System;
    using System.Collections.Generic;
    using ConsoleApp.WebDriver.Drivers;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;

    public class BasePage
    {
        protected int DefaultTimeoutMilliseconds { get; } = 2000;

        protected int DefaultTimeoutSeconds { get; set; } = 30;

        protected IWebDriver Driver { get; }

        protected WebDriverWait WebDriverWait =>
            new(Driver, TimeSpan.FromSeconds(DefaultTimeoutSeconds));

        public BasePage()
        {
            this.Driver = WebDriverManager.Driver;

            // Implicit wait
            //Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }

        protected void NavigateBack()
        {
            Driver.Navigate().Back();
        }

        protected IWebElement FindElement(By locator)
        {
            return Driver.FindElement(locator);
        }

        protected IList<IWebElement> FindElements(By locator)
        {
            return Driver.FindElements(locator);
        }
    }
}
