namespace ConsoleApp.WebDriver.Pages
{
    using ConsoleApp.WebDriver.Drivers;
    using OpenQA.Selenium;

    public class BasePage
    {
        protected IWebDriver Driver { get; }

        public BasePage()
        {
            this.Driver = WebDriverManager.Driver;
        }

        protected void NavigateBack()
        {
            Driver.Navigate().Back();
        }
    }
}
