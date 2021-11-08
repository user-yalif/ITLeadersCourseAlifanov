namespace ConsoleApp.WebDriver.Pages.Lesson6AdditionalWindows
{
    using OpenQA.Selenium;

    public class ThirdWindowPage : BasePage
    {
        private IWebElement MessageText => FindElement(By.Id("message"));

        public string GetMessage()
        {
            return MessageText.Text;
        }
    }
}
