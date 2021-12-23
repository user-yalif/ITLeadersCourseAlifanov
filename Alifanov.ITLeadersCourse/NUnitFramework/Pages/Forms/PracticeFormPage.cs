namespace NUnitFramework.Pages.Forms
{
    using System;
    using System.Collections.Generic;
    using NUnitFramework.Pages.Forms.PracticeFormElements;
    using OpenQA.Selenium;

    public class PracticeFormPage : BasePage
    {
        private IWebElement FirstNameInput => FindElement(By.CssSelector("input#firstName"));

        private IWebElement LastNameInput => FindElement(By.CssSelector("input#lastName"));

        private IWebElement EmailInput => FindElement(By.CssSelector("input#userEmail"));

        private IList<IWebElement> GenderRadioButtons => FindElements(By.XPath("//div[contains(@class, 'custom-radio')]"));

        private IWebElement MobileNumberInput => FindElement(By.CssSelector("input#userNumber"));

        private IWebElement DateOfBirthInput => FindElement(By.CssSelector("input#dateOfBirthInput"));

        private IWebElement SubjectsInput => FindElement(By.CssSelector("input#subjectsInput"));

        private IList<IWebElement> HobbiesCheckBoxes => FindElements(By.XPath("//div[contains(@class, 'custom-checkbox')]"));

        private IWebElement CurrentAddressInput => FindElement(By.CssSelector("textarea#currentAddress"));

        private IWebElement StateInput => FindElement(By.XPath("//div[@id='state']"));

        private IList<IWebElement> StateOptions => FindElements(By.XPath("//div[contains(@id, 'react-select-3-option')]"));

        private IWebElement CityInput => FindElement(By.XPath("//div[@id='city']"));

        private IList<IWebElement> CityOptions => FindElements(By.XPath("//div[contains(@id, 'react-select-4-option')]"));

        private IWebElement SubmitButton => FindElement(By.CssSelector("button#submit"));

        public PracticeFormPage() => base.CloseBan();

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
            EmailInput.SendKeys(email)
;

            return this;
        }

        public PracticeFormPage ClickOnGenderRadioButton(string gender)
        {
            foreach (var radioButton in GenderRadioButtons)
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
            MobileNumberInput.SendKeys(mobile);

            return this;
        }

        public PracticeFormPage InputDateOfBirth(string dateOfBirth)
        {
            DateOfBirthInput.SendKeys(Keys.LeftControl + "A");
            DateOfBirthInput.SendKeys(dateOfBirth);
            DateOfBirthInput.SendKeys(Keys.Escape);

            return this;
        }

        public PracticeFormPage InputSubject(string subject)
        {
            SubjectsInput.SendKeys(subject);
            SubjectsInput.SendKeys(Keys.Enter);

            return this;
        }

        public PracticeFormPage ClickOnHobbiesCheckBox(string hobby)
        {
            foreach (var checkBox in HobbiesCheckBoxes)
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

        public PracticeFormPage SelectStateOption(string state)
        {
            StateInput.Click();

            foreach (var stateOption in StateOptions)
            {
                var optionName = stateOption.Text;

                if (state.Equals(optionName, StringComparison.OrdinalIgnoreCase))
                {
                    stateOption.Click();
                }
            }

            return this;
        }

        public PracticeFormPage SelectCityOption(string city)
        {
            CityInput.Click();

            foreach (var cityOption in CityOptions)
            {
                var optionName = cityOption.Text;

                if (city.Equals(optionName, StringComparison.OrdinalIgnoreCase))
                {
                    cityOption.Click();
                }
            }

            return this;
        }

        public ThanksForSubmittingFormElement ClickSubmitButton()
        {
            SubmitButton.Click();

            return new ThanksForSubmittingFormElement(Driver);
        }

        public ThanksForSubmittingFormElement SubmitForm(string firstName,
                                                         string lastName,
                                                         string email,
                                                         string gender,
                                                         string mobileNumber,
                                                         string dateOfBirth,
                                                         string subject,
                                                         string hobby,
                                                         string currentAddress,
                                                         string state,
                                                         string city)
        {
            return InputFirstName(firstName)
                .InputLastName(lastName)
                .InputEmail(email)
                .ClickOnGenderRadioButton(gender)
                .InputMobile(mobileNumber)
                .InputDateOfBirth(dateOfBirth)
                .InputSubject(subject)
                .ClickOnHobbiesCheckBox(hobby)
                .InputCurrentAddress(currentAddress)
                .SelectStateOption(state)
                .SelectCityOption(city)
                .ClickSubmitButton();
        }
    }
}
