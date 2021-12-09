using NUnitFramework.Logging;
using OpenQA.Selenium;

namespace NUnitFramework.Pages.Elements
{
    public class TextBoxPage : BasePage
    {
        private IWebElement FullNameInput => FindElement(By.CssSelector("input#userName"));

        private IWebElement EmailInput => FindElement(By.CssSelector("input#userEmail"));

        private IWebElement CurrentAddressTextArea => FindElement(By.CssSelector("textarea#currentAddress"));

        private IWebElement PermanentAddressTextArea => FindElement(By.CssSelector("textarea#permanentAddress"));

        private IWebElement SubmitButton => FindElement(By.CssSelector("button#submit"));

        private IWebElement NameOutputMessage => FindElement(By.CssSelector("p#name"));

        private IWebElement EmailOutputMessage => FindElement(By.CssSelector("p#email"));

        private IWebElement CurrentAddressOutputMessage => FindElement(By.CssSelector("p#currentAddress"));

        private IWebElement PermanentAddressOutputMessage => FindElement(By.CssSelector("p#permanentAddress"));

        public TextBoxPage InputFullName(string fullName)
        {
            Logger.Log.Info("Input Name {0}", fullName);

            FullNameInput.Clear();
            FullNameInput.SendKeys(fullName);

            return this;
        }

        public TextBoxPage InputEmail(string email)
        {
            EmailInput.Clear();
            EmailInput.SendKeys(email);

            return this;
        }

        public TextBoxPage InputCurrentAddress(string currentAddress)
        {
            CurrentAddressTextArea.Clear();
            CurrentAddressTextArea.SendKeys(currentAddress);

            return this;
        }

        public TextBoxPage InputPermanentAddress(string permanentAddress)
        {
            PermanentAddressTextArea.Clear();
            PermanentAddressTextArea.SendKeys(permanentAddress);

            return this;
        }

        public TextBoxPage ClickOnSubmitButton()
        {
            Logger.Log.Info("Click on Submit button");

            SubmitButton.Click();

            return this;
        }

        public string GetNameOutputMessage()
        {
            Logger.Log.Info("Try to get Name output message");

            return NameOutputMessage.Text;
        }

        public string GetEmailOutputMessage()
        {
            Logger.Log.Info("Try to get Email output message");

            return EmailOutputMessage.Text;
        }

        public string GetCurrentAddressMessage()
        {
            Logger.Log.Info("Try to get Current Address output message");

            return CurrentAddressOutputMessage.Text;
        }

        public string GetPermanentAddressMessage()
        {
            Logger.Log.Info("Try to get Permanent Address output message");

            return PermanentAddressOutputMessage.Text;
        }

        public TextBoxPage SubmitInputedData(string fullName, string email, string currentAddress, string permanentAddress)
        {
            InputFullName(fullName)
                    .InputEmail(email)
                    .InputCurrentAddress(currentAddress)
                    .InputPermanentAddress(permanentAddress)
                    .ClickOnSubmitButton();

            return this;
        }
    }
}
