namespace ConsoleApp.WebDriver.Pages.Lesson6AdditionalWindows
{
    using OpenQA.Selenium;

    public class FirstWindowPage : BasePage
    {
        private IWebElement SecondPageLink => FindElement(By.Id("secondWindowLink"));

        public SecondWindowPage ClickSecondPageLink()
        {
            SecondPageLink.Click();

            return new SecondWindowPage();
        }
    }
}
