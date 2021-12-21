using NUnitFramework.Pages.Forms.PracticeForms;
using OpenQA.Selenium;

namespace NUnitFramework.Pages.Forms.PracticeFormElements
{
    class ThanksForSubmittingForm
    {
        private IWebElement ThanksForSubmittingFormElements { get; }

        private IWebElement Title => ThanksForSubmittingFormElements.FindElement(By.CssSelector("div#example-modal-sizes-title-lg"));

        private IWebElement StudentNameValue => ThanksForSubmittingFormElements.FindElement(By.XPath("//tr[1]/td[2]"));

        private IWebElement StudentEmailValue => ThanksForSubmittingFormElements.FindElement(By.XPath("//tr[2]/td[2]"));

        private IWebElement GenderRadioValue => ThanksForSubmittingFormElements.FindElement(By.XPath("//tr[3]/td[2]"));

        private IWebElement MobileValue => ThanksForSubmittingFormElements.FindElement(By.XPath("//tr[4]/td[2]"));

        private IWebElement DateOfBirthValue => ThanksForSubmittingFormElements.FindElement(By.XPath("//tr[5]/td[2]"));

        private IWebElement SubjectsValue => ThanksForSubmittingFormElements.FindElement(By.XPath("//tr[6]/td[2]"));

        private IWebElement HobbiesCheckBoxValue => ThanksForSubmittingFormElements.FindElement(By.XPath("//tr[7]/td[2]"));

        private IWebElement UploadPicturePreview => ThanksForSubmittingFormElements.FindElement(By.XPath("//tr[8]/td[2]"));

        private IWebElement AddressValue => ThanksForSubmittingFormElements.FindElement(By.XPath("//tr[9]/td[2]"));

        private IWebElement StateAndCityValue => ThanksForSubmittingFormElements.FindElement(By.XPath("//tr[10]/td[2]"));

        private IWebElement CloseButton => ThanksForSubmittingFormElements.FindElement(By.CssSelector("button#closeLargeModal"));

        public string GetStudentName()
        {
            return StudentNameValue.GetAttribute("value");
        }

        public string GetStudentEmail()
        {
            return StudentEmailValue.GetAttribute("value");
        }
        public string GetStudentGender()
        {
            return GenderRadioValue.GetAttribute("value");
        }

        public string GetStudentMobile()
        {
            return MobileValue.GetAttribute("value");
        }

        public string GetStudentDateOfBirth()
        {
            return DateOfBirthValue.GetAttribute("value");
        }

        public string GetStudentSubjects()
        {
            return SubjectsValue.GetAttribute("value");
        }

        public string GetStudentHobbies()
        {
            return HobbiesCheckBoxValue.GetAttribute("value");
        }

        public string GetStudentAddress()
        {
            return AddressValue.GetAttribute("value");
        }

        public string GetStudentStateAndCity()
        {
            return StateAndCityValue.GetAttribute("value");
        }
        public ThanksForSubmittingForm ClickCloseButton()
        {
            CloseButton.Click();

            return new PracticeFormPage();
        }
    }
}
