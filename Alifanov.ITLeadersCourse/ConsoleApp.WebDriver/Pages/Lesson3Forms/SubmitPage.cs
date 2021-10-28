namespace ConsoleApp.WebDriver.Pages.Lesson3Forms
{
    using OpenQA.Selenium;

    public class SubmitPage : BasePage
    {
        private IWebElement SubmitMessage => Driver.FindElement(By.Id("submitMessage"));

        public string GetSubmitMessage()
        {
            return SubmitMessage.Text;
        }

        public FormPage ReturnToPriviousPage()
        {
            base.NavigateBack();

            return new FormPage();
        }
    }
}
