namespace NUnitFramework.Pages.Elements
{
    using NUnitFramework.Helpers;
    using NUnitFramework.Logging;
    using OpenQA.Selenium;

    public class DynamicPropertiesPage : BasePage
    {
        private IWebElement EnableAfterButton => FindElement(By.CssSelector("button#enableAfter"));

        private IWebElement ColorChangeButton => FindElement(By.CssSelector("button#colorChange"));

        public bool IsEnableAfterButtonEnabled()
        {
            return Waiter.WaitUntilElementToBeEnabled(EnableAfterButton);
        }

        public bool IsColorButtonColorChanged()
        {
            return Waiter.WaitUntilElementsAttributeValueContains(ColorChangeButton, "class", "text-danger");
        }
    }
}
