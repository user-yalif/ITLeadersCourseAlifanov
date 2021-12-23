namespace ConsoleApp.WebDriver.Pages.Lesson3Forms
{
    using System;
    using System.Collections.Generic;
    using OpenQA.Selenium;

    public class FormPage : BasePage
    {
        private IWebElement NameInput => Driver.FindElement(By.Id("firstlast"));

        private IWebElement EmailInput => Driver.FindElement(By.Id("email"));

        private IWebElement SubmitButton => Driver.FindElement(By.CssSelector("input[type='submit']"));

        private IWebElement ResetButton => Driver.FindElement(By.CssSelector("fieldset input[type='reset']"));

        private IWebElement EducationCompletedInput => Driver.FindElement(By.CssSelector("input[name='education']"));

        private IList<IWebElement> EducationCompletedOptions => Driver.FindElements(By.CssSelector("datalist#edulevel option"));

        private IWebElement EducationCompletedResetButton => Driver.FindElement(By.CssSelector("form p input[type='reset']"));

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

        public void ChooseEducationCompletedOption(string option, bool moveFocus = true)
        {
            foreach (var opt in EducationCompletedOptions)
            {
                var optionValue = opt.GetAttribute("value");

                if (option.Equals(optionValue, StringComparison.OrdinalIgnoreCase))
                {
                    EducationCompletedInput.Clear();
                    EducationCompletedInput.SendKeys(optionValue);

                    if (moveFocus)
                    {
                        EducationCompletedInput.SendKeys(Keys.Tab);
                    }
                }
            }
        }
    }
}
