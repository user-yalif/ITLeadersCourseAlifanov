namespace ConsoleApp.WebDriver.Pages.Lesson7IFrame
{
    using OpenQA.Selenium;

    public class FirstFramePage : BasePage
    {
        private IWebElement NameTextField => FindElement(By.Id("name"));

        public string GetNameTextField() => NameTextField.Text;
    }
}
