using OpenQA.Selenium;

namespace NUnitFramework.Pages.Forms.PracticeForms
{
    public class PracticeFormPage : BasePage
    {
        private IWebElement FirstNameInput => FindElement(By.CssSelector("input#firstName"));

        private IWebElement LastNameInput => FindElement(By.CssSelector("input#lastName"));

        private IWebElement EmailInput => FindElement(By.CssSelector("input#userEmail"));

        private IWebElement GenderRadioMale => FindElement(By.CssSelector("input#gender-radio-1"));

        private IWebElement GenderRadioFemale => FindElement(By.CssSelector("input#gender-radio-2"));

        private IWebElement GenderRadioOther => FindElement(By.CssSelector("input#gender-radio-3"));

        private IWebElement MobileInput => FindElement(By.CssSelector("input#userNumber"));

        private IWebElement DateOfBirthInput => FindElement(By.CssSelector("input#dateOfBirthInput"));

        private IWebElement SubjectsInput => FindElement(By.CssSelector("input#subjectsInput"));

        private IWebElement HobbiesWrapperSports => FindElement(By.CssSelector("input#hobbies-checkbox-1"));

        private IWebElement HobbiesWrapperReading => FindElement(By.CssSelector("input#hobbies-checkbox-2"));

        private IWebElement HobbiesWrapperMusic => FindElement(By.CssSelector("input#hobbies-checkbox-3"));

        private IWebElement PictureUploadButton => FindElement(By.CssSelector("input#uploadPicture"));

        private IWebElement CurrentAddressInput => FindElement(By.CssSelector("textarea#currentAddress"));

        private IWebElement SelectStateContainer => FindElement(By.CssSelector("div#state.css-tlfecz-indicatorContainer"));

        private IWebElement SelectCityContainer => FindElement(By.CssSelector("div#city.css-tlfecz-indicatorContainer"));

        private IWebElement SubmitButton => FindElement(By.CssSelector("button#submit"));
    }
}
