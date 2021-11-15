namespace ConsoleApp.WebDriver.Pages.Lesson8ComplexActions
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Interactions;

    public class ComplexActionsPage : BasePage
    {
        private IWebElement ClickMeTwiceButton => FindElement(By.Id("clickTwiceButton"));

        private IWebElement MessageField => FindElement(By.Id("doubleClickMessage"));

        public ComplexActionsPage ClickOnClickMeTwiceButton()
        {
            ClickMeTwiceButton.Click();

            return this;
        }

        public ComplexActionsPage DoubleClickOnClickMeTwiceButton()
        {
            //ClickOnClickMeTwiceButton()
            //    .ClickOnClickMeTwiceButton();

            Actions actions = new Actions(Driver);

            actions.DoubleClick(ClickMeTwiceButton);

            actions.Build()
                .Perform();

            return this;
        }

        public string GetMessage() => MessageField.Text;
    }
}
