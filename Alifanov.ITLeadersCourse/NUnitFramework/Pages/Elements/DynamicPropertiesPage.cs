namespace NUnitFramework.Pages.Elements
{
    using NUnitFramework.Helpers;
    using OpenQA.Selenium;

    public class DynamicPropertiesPage : BasePage
    {
        private By VisibleAfterButtonLocator = By.CssSelector("button#visibleAfter");

        private IWebElement EnableAfterButton => FindElement(By.CssSelector("button#enableAfter"));

        private IWebElement ColorChangeButton => FindElement(By.CssSelector("button#colorChange"));

        private IWebElement VisibleAfterButton => FindElement(VisibleAfterButtonLocator);

        public bool IsEnableAfterButtonEnabled()
        {
            return Waiter.WaitUntilElementToBeEnabled(EnableAfterButton);
        }

        public bool IsColorButtonColorChanged()
        {
            return Waiter.WaitUntilElementsAttributeValueContains(ColorChangeButton, "class", "text-danger");
        }

        public bool IsVisibleAfterButtonEnabled()
        {
            Waiter.WaitUntilElementToBePresent(VisibleAfterButtonLocator);

            return Waiter.WaitUntilElementToBeEnabled(VisibleAfterButton);
        }

        public bool IsVisibleAfterButtonClickable()
        {
            return Waiter.WaitUntilElementToBeClickable(VisibleAfterButtonLocator) != null;
        }
    }
}
