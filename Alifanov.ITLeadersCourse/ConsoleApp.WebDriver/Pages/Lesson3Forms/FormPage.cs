﻿namespace ConsoleApp.WebDriver.Pages.Lesson3Forms
{
    using OpenQA.Selenium;

    public class FormPage : BasePage
    {
        private IWebElement NameInput => Driver.FindElement(By.Id("firstlast"));

        private IWebElement EmailInput => Driver.FindElement(By.Id("email"));

        private IWebElement SubmitButton => Driver.FindElement(By.CssSelector("input[type='submit']"));

        private IWebElement ResetButton => Driver.FindElement(By.CssSelector("fieldset input[type='reset']"));

        public FormPage InputName(string name)
        {
            NameInput.SendKeys(name);

            return this;
        }

        public FormPage InputEmail(string email)
        {
            EmailInput.SendKeys(email);

            return this;
        }

        public string GetName()
        {
            return NameInput.GetAttribute("value");
        }

        public string GetEmail()
        {
            return EmailInput.GetAttribute("value");
        }

        public SubmitPage ClickSubmitButton()
        {
            SubmitButton.Click();

            return new SubmitPage();
        }

        public FormPage ClickResetButton()
        {
            ResetButton.Click();

            return this;
        }
    }
}