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

        //private IWebElement NameInOutputUserForm => FindElement(By.CssSelector("p#name"));

        private IWebElement NameInOutputUserForm => FindElement(By.CssSelector("p#name.mb-1"));

        //private IWebElement NameInOutputUserForm => FindElement(By.XPath("//div[@class='mb-1'][@id='name']"));

        private IWebElement EmailInOutputUserForm => FindElement(By.CssSelector("p#email"));

        private IWebElement CurrentAddressInOutputUserForm => FindElement(By.CssSelector("p#currentAddress"));

        private IWebElement PermanentAddressInOutputUserForm => FindElement(By.CssSelector("p#permanentAddress"));

        public TextBoxPage InputFullName(string expectedFullNameMessage)
        {
            FullNameField.Clear();
            FullNameField.SendKeys(expectedFullNameMessage);

            return this;
        }

        public TextBoxPage InputUserEmail(string expectedUserEmailMessage)
        {
            UserEmailField.Clear();
            UserEmailField.SendKeys(expectedUserEmailMessage);

            return this;
        }
        public TextBoxPage InputCurrentAddress(string expectedCurrentAddressMessage)
        {
            CurrentAddressField.Clear();
            CurrentAddressField.SendKeys(expectedCurrentAddressMessage);

            return this;
        }

        public TextBoxPage InputPermanentAddress(string expectedPermanentAddressMessage)
        {
            PermanentAddressField.Clear();
            PermanentAddressField.SendKeys(expectedPermanentAddressMessage);

            return this;
        }

        public TextBoxPage ClickOnSubmitButton()
        {
            Logger.Log.Info("Click on Submit button");

            SubmitButton.Click();

            return this;
        }

        public string GetNameInUserForm()
        {
            Logger.Log.Info("Get Name after click on Submit button");

            return NameInOutputUserForm.Text.Split(":")[1];
            //return NameInOutputUserForm.Text.Split(":")[1].TrimStart().TrimEnd();
        }

        public string GetEmailInUserForm()
        {
            Logger.Log.Info("Get Email after click on Submit button");

            return EmailInOutputUserForm.Text.Split(":")[1];
        }

        public string GetCurrentAddressInUserForm()
        {
            Logger.Log.Info("Get Current Address after click on Submit button");

            return CurrentAddressInOutputUserForm.Text.Split(":")[1];
        }

        public string GetPermanentAddressInUserForm()
        {
            Logger.Log.Info("Get Permanent Address after click on Submit button");

            return PermanentAddressInOutputUserForm.Text.Split(":")[1];
        }
    }
}
