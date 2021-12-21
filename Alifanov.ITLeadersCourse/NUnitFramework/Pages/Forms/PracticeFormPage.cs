using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace NUnitFramework.Pages.Forms.PracticeForms
{
    public class PracticeFormPage : BasePage
    {
        private IWebElement FirstNameInput => FindElement(By.CssSelector("input#firstName"));

        private IWebElement LastNameInput => FindElement(By.CssSelector("input#lastName"));

        private IWebElement EmailInput => FindElement(By.CssSelector("input#userEmail"));

        private IList<IWebElement> RadioButtons => FindElements(By.XPath("//div[contains(@class, 'custom-radio')]"));

        private IWebElement MobileInput => FindElement(By.CssSelector("input#userNumber"));

        private IWebElement DateOfBirthInput => FindElement(By.CssSelector("input#dateOfBirthInput"));

        private IWebElement SubjectsInput => FindElement(By.CssSelector("input#subjectsInput"));

        private IList<IWebElement> CheckBoxes => FindElements(By.XPath("//div[contains(@class, 'custom-checkbox')]"));

        private IWebElement PictureUploadButton => FindElement(By.CssSelector("input#uploadPicture"));

        private IWebElement CurrentAddressInput => FindElement(By.CssSelector("textarea#currentAddress"));

        private IWebElement StateSelect => FindElement(By.XPath("//div[@id='state']//input"));
        private IList<IWebElement> StateSelectOptions => FindElements(By.XPath("//div[contains(@id, 'react-select-3-option')]"));
        private IWebElement CitySelect => FindElement(By.XPath("//div[@id='city']//input"));
        private IList<IWebElement> CitySelectOptions => FindElements(By.CssSelector("//div[contains(@id, 'react-select-4-option')]"));

        private IWebElement SubmitButton => FindElement(By.CssSelector("button#submit"));

        public PracticeFormPage InputFirstName(string firstName)
        {
            FirstNameInput.SendKeys(firstName);

            return this;
        }

        public PracticeFormPage InputLastName(string lastName)
        {
            LastNameInput.SendKeys(lastName);

            return this;
        }

        public PracticeFormPage InputEmail(string email)
        {
            EmailInput.SendKeys(email);

            return this;
        }

        public PracticeFormPage ClickOnRadioButton(string gender)
        {
            foreach (var radioButton in RadioButtons)
            {
                var name = radioButton.FindElement(By.XPath("./label")).Text.Trim();

                if (name.Equals(gender, StringComparison.OrdinalIgnoreCase))
                {
                    radioButton.Click();
                }
            }

            return this;
        }

        public PracticeFormPage InputMobile(string mobile)
        {
            MobileInput.SendKeys(mobile);

            return this;
        }

        public PracticeFormPage InputDateOfBirth(string dateOfBirth)
        {
            DateOfBirthInput.SendKeys(dateOfBirth);

            return this;
        }

        public PracticeFormPage ClickOnCheckBox(string hobby)
        {
            foreach (var checkBox in CheckBoxes)
            {
                var name = checkBox.FindElement(By.XPath("./label")).Text.Trim();

                if (name.Equals(hobby, StringComparison.OrdinalIgnoreCase))
                {
                    checkBox.Click();
                }
            }

            return this;
        }
        public PracticeFormPage InputCurrentAddress(string currentAddress)
        {
            CurrentAddressInput.SendKeys(currentAddress);

            return this;
        }
        public void SelectStateOption(string state)
        {
            string option = null;

            foreach (var stateOption in StateSelectOptions)
            {
                var optionName = stateOption.Text;

                if (state.Equals(optionName, StringComparison.OrdinalIgnoreCase))
                {
                    option = optionName;
                }
            }

            StateSelect.SendKeys(option);
        }

        public void SelectStateOptions(string city)
        {
            foreach (var element in CitySelectOptions)
            {
                if (city.Equals(element.Text, StringComparison.OrdinalIgnoreCase))
                {
                    element.Click();
                }
            }
        }

        public void SelectCityOption(string city)
        {
            string option = null;

            foreach (var cityOption in CitySelectOptions)
            {
                var optionName = cityOption.Text;

                if (city.Equals(optionName, StringComparison.OrdinalIgnoreCase))
                {
                    option = optionName;
                }
            }

            CitySelect.SendKeys(option);
        }

        public void SelectCityOptions(string city)
        {
            foreach (var element in CitySelectOptions)
            {
                if (city.Equals(element.Text, StringComparison.OrdinalIgnoreCase))
                {
                    element.Click();
                }
            }
        }
    }
}
