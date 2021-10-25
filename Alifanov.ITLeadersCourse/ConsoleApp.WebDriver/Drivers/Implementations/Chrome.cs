namespace ConsoleApp.WebDriver.Drivers.Implementations
{
    using System;
    using ConsoleApp.WebDriver.Drivers.Interfaces;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;

    public class Chrome : IDriver
    {
        public IWebDriver Setup(string pathToDriver)
        {
            IWebDriver driver = new ChromeDriver(pathToDriver);
            driver.Manage().Window.Maximize();

            return driver;
        }
    }
}
