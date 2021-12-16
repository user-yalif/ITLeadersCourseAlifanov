using NUnitFramework.Logging;
using OpenQA.Selenium;

namespace NUnitFramework.Pages.Elements.WebTablesElements
{
    public class RegistrationFormPage
    {
        private IWebElement RegistrationForm { get; }

        private IWebElement FirstNameInput => RegistrationForm.FindElement(By.CssSelector("#firstName"));

        private IWebElement LastNameInput => RegistrationForm.FindElement(By.CssSelector("#lastName"));

        private IWebElement EmailInput => RegistrationForm.FindElement(By.CssSelector("#userEmail"));

        private IWebElement AgeInput => RegistrationForm.FindElement(By.CssSelector("#age"));

        private IWebElement SalaryInput => RegistrationForm.FindElement(By.CssSelector("#salary"));

        private IWebElement DepartmentInput => RegistrationForm.FindElement(By.CssSelector("#department"));

        private IWebElement SubmitButton => RegistrationForm.FindElement(By.CssSelector("button#submit"));

        public RegistrationFormPage(IWebDriver driver)
        {
            RegistrationForm = driver.FindElement(By.CssSelector(".modal-content"));
        }

        public RegistrationFormPage InputFirstName(string firstName)
        {
            if (firstName != null)
            {
                Logger.Log.Info("Input First Name {0}", firstName);

                FirstNameInput.Clear();
                FirstNameInput.SendKeys(firstName);
            }

            return this;
        }

        public RegistrationFormPage InputLastName(string lastName)
        {
            if (lastName != null)
            {
                Logger.Log.Info("Input Last Name {0}", lastName);

                LastNameInput.Clear();
                LastNameInput.SendKeys(lastName);
            }

            return this;
        }

        public RegistrationFormPage InputEmail(string email)
        {
            if (email != null)
            {
                Logger.Log.Info("Input Email {0}", email);

                EmailInput.Clear();
                EmailInput.SendKeys(email);
            }

            return this;
        }

        public RegistrationFormPage InputAge(string age)
        {
            if (age != null)
            {
                Logger.Log.Info("Input Age {0}", age);

                AgeInput.Clear();
                AgeInput.SendKeys(age);
            }

            return this;
        }

        public RegistrationFormPage InputSalary(string salary)
        {
            if (salary != null)
            {
                Logger.Log.Info("Input Salary {0}", salary);

                SalaryInput.Clear();
                SalaryInput.SendKeys(salary);
            }

            return this;
        }

        public RegistrationFormPage InputDepartment(string department)
        {
            if (department != null)
            {
                Logger.Log.Info("Input Department {0}", department);

                DepartmentInput.Clear();
                DepartmentInput.SendKeys(department);
            }

            return this;
        }

        public WebTablesPage ClickOnSubmitButton()
        {
            Logger.Log.Info("Click on Submit button");

            SubmitButton.Click();

            return new WebTablesPage();
        }

        public WebTablesPage SubmitRegistrationForm(string firstName = null, string lastName = null, string email = null, string age = null, string salary = null, string department = null)
        {
            Logger.Log.Info("Try to Submit data");

            InputFirstName(firstName)
                    .InputLastName(lastName)
                    .InputEmail(email)
                    .InputAge(age)
                    .InputSalary(salary)
                    .InputDepartment(department)
                    .ClickOnSubmitButton();

            return new WebTablesPage();
        }
    }
}
