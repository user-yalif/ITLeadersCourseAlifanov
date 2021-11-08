namespace ConsoleApp.WebDriver.Pages.Lesson6AdditionalWindows
{
    using OpenQA.Selenium;

    public class SecondWindowPage : BasePage
    {
        private IWebElement ThirdPageLink => FindElement(By.Id("thirdWindowLink"));

        public ThirdWindowPage ClickThirdPageLink()
        {
            ThirdPageLink.Click();

            return new ThirdWindowPage();
        }
    }
}
