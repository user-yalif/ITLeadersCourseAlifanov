namespace NUnitFramework.Pages
{
    using System.Collections.Generic;
    using NUnitFramework.Drivers;
    using OpenQA.Selenium;

    public class BasePage
    {
        protected IWebDriver Driver { get; }

        public BasePage()
        {
            Driver = WebDriverManager.Driver;
        }

        protected IWebElement FindElement(By by) => Driver.FindElement(by);

        protected IList<IWebElement> FindElements(By by) => Driver.FindElements(by);
    }
}
