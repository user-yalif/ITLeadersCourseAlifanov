namespace ConsoleApp.WebDriver.Pages.Lesson9WebDriverWait
{
    using OpenQA.Selenium;
    using ExpectedCondition = SeleniumExtras.WaitHelpers.ExpectedConditions;

    public class WaitPage : BasePage
    {
        private By MessageLocator => By.Id("message");

        private IWebElement ClickAndWaitButton => FindElement(By.Id("waitButton"));

        private IWebElement MessageElement => FindElement(MessageLocator);

        public WaitPage ClickOnClickAndWaitButton()
        {
            ClickAndWaitButton.Click();

            return this;
        }

        public string GetMessage()
        {
            //Thread.Sleep(DefaultTimeoutMilliseconds);

            //base.DefaultTimeoutSeconds = 2;
            base.WebDriverWait.Until(ExpectedCondition.ElementIsVisible(MessageLocator));

            string message = string.Empty;

            if (base.WebDriverWait.Until(ExpectedCondition.TextToBePresentInElement(MessageElement, "Get me! I've appeared!")))
            {
                message = MessageElement.Text;
            }

            return message;
        }
    }
}
