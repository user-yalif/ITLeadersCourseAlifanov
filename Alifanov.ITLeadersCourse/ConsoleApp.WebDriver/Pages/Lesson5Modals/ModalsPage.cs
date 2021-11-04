namespace ConsoleApp.WebDriver.Pages.Lesson5Modals
{
    using ConsoleApp.WebDriver.Helpers;
    using OpenQA.Selenium;

    public class ModalsPage : BasePage
    {
        private IWebElement UserNameInput => FindElement(By.CssSelector("input#userName"));

        private IWebElement SubmitUserNameButton => FindElement(By.XPath("//input[@value='Submit User Name']"));

        private IWebElement UserNameSubmittedMessage => FindElement(By.CssSelector("p#submittedUserName"));

        private IWebElement NickNameInput => FindElement(By.CssSelector("input#nickName"));

        private IWebElement SubmitNickNameButton => FindElement(By.XPath("//input[@value='Submit Nick Name']"));

        private IWebElement NickNameSubmittedMessage => FindElement(By.CssSelector("p#submittedNickName"));

        public ModalsPage InputUserName(string userName)
        {
            UserNameInput.Clear();
            UserNameInput.SendKeys(userName);

            return this;
        }

        public ModalsPage ClickSubmitUserNameButton()
        {
            SubmitUserNameButton.Click();

            return this;
        }

        public ModalsPage SubmitUserName(string userName)
        {
            this.InputUserName(userName)
                .ClickSubmitUserNameButton();

            return this;
        }

        //public string AcceptUserNameSubmissionAlert()
        //{
        //    var alert = Driver.SwitchTo().Alert();

        //    var alertMessage = alert.Text;
        //    alert.Accept();

        //    Driver.SwitchTo().DefaultContent();

        //    return alertMessage;
        //}

        public string GetUserNameSubmittedMessage()
        {
            return UserNameSubmittedMessage.Text;
        }

        public ModalsPage InputNickName(string userName)
        {
            NickNameInput.Clear();
            NickNameInput.SendKeys(userName);

            return this;
        }

        public ModalsPage ClickSubmitNickNameButton()
        {
            SubmitNickNameButton.Click();

            return this;
        }

        public ModalsPage SubmitNickName(string nickName)
        {
            this.InputNickName(nickName)
                .ClickSubmitNickNameButton();

            return this;
        }

        public string AcceptAlert()
        {
            return AlertHelper.AcceptAlert();
        }

        public string GetNickNameSubmittedMessage()
        {
            return NickNameSubmittedMessage.Text;
        }

        public void DismissAlert() => AlertHelper.DismissAlert();
    }
}
