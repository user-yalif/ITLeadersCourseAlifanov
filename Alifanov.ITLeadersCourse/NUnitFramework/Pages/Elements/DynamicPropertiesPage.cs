namespace NUnitFramework.Pages.Elements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using OpenQA.Selenium;

    public class DynamicPropertiesPage : BasePage
    {
        private IWebElement EnableAfterButton => FindElement(By.CssSelector("button#enableAfter"));

        public bool IsEnableAfterButtonEnabled()
        {
            return Helpers.Waiter.WaitUntilElementToBeEnabled(EnableAfterButton);
        }
    }
}
