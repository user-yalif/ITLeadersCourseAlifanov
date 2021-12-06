using OpenQA.Selenium;

namespace NUnitFramework.Pages.Elements
{
    public class TextBox : BasePage
    {
        private IWebElement FullNameField => FindElement(By.CssSelector("input#userName"));

        private IWebElement UserEmailField => FindElement(By.CssSelector("input#userEmail"));

        private IWebElement CurrentAddressField => FindElement(By.CssSelector("textarea#currentAddress"));

        private IWebElement PermanentAddressField => FindElement(By.CssSelector("textarea#permanentAddress"));

        private IWebElement SubmitButton => FindElement(By.CssSelector("button#submit"));
    }
}
