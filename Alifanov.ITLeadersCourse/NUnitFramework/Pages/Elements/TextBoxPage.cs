using NUnitFramework.Logging;
using OpenQA.Selenium;

namespace NUnitFramework.Pages.Elements
{
    public class TextBoxPage : BasePage
    {
        private IWebElement FullNameField => FindElement(By.CssSelector("input#userName"));

        private IWebElement UserEmailField => FindElement(By.CssSelector("input#userEmail"));

        private IWebElement CurrentAddressField => FindElement(By.CssSelector("textarea#currentAddress"));

        private IWebElement PermanentAddressField => FindElement(By.CssSelector("textarea#permanentAddress"));

        private IWebElement SubmitButton => FindElement(By.CssSelector("button#submit"));

        private IWebElement NameInOutputUserForm => FindElement(By.CssSelector("p#name"));

        private IWebElement EmailInOutputUserForm => FindElement(By.CssSelector("p#email"));

        private IWebElement CurrentAddressInOutputUserForm => FindElement(By.CssSelector("p#currentAddress"));

        private IWebElement PermanentAddressInOutputUserForm => FindElement(By.CssSelector("p#permanentAddress"));


        public TextBoxPage ClickOnSubmitButton()
        {
            Logger.Log.Info("Click on Submit button");

            SubmitButton.Click();

            return this;
        }

        public string GetNameInUserForm()
        {
            Logger.Log.Info("Get Name after click on Submit button");

            return NameInOutputUserForm.Text;
        }

        public string GetEmailInUserForm()
        {
            Logger.Log.Info("Get Email after click on Submit button");

            return EmailInOutputUserForm.Text;
        }

        public string GetCurrentAddressInUserForm()
        {
            Logger.Log.Info("Get Current Address after click on Submit button");

            return CurrentAddressInOutputUserForm.Text;
        }

        public string GetPermanentAddressInUserForm()
        {
            Logger.Log.Info("Get Permanent Address after click on Submit button");

            return PermanentAddressInOutputUserForm.Text;
        }
    }
}
