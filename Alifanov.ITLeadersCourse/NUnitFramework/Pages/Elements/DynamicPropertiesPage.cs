namespace NUnitFramework.Pages.Elements
{
    using NUnitFramework.Helpers;
    using OpenQA.Selenium;

    public class DynamicPropertiesPage : BasePage
    {
        private IWebElement EnableAfterButton => FindElement(By.CssSelector("button#enableAfter"));

        public bool IsEnableAfterButtonEnabled()
        {
            return Waiter.WaitUntilElementToBeEnabled(EnableAfterButton);
        }
    }
}
