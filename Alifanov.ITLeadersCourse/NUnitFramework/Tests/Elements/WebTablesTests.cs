using NUnit.Framework;
using NUnitFramework.Navigation.LeftPanel;

namespace NUnitFramework.Tests.Elements
{
    public class WebTablesTests : BaseTest
    {
        [Test]
        [Description("Test fills all fields, check if row was added, check data and deleted the row from the table")]
        [TestCase("John", "Smith", "john.smith@test.com", "35", "3000", "AQA")]
        public void SubmitRegistrationFormInput(string firstName, string lastName, string email, string age, string salary, string department)
        {
            var webTablesPage = LeftPanel.Elements.WebTables();

            var initialRowsCount = webTablesPage.GetNotEmptyRowsCount();

            webTablesPage.ClickAddButton()
                .SubmitRegistrationForm(firstName, lastName, email, age, salary, department);

            var actualRowsCount = webTablesPage.GetNotEmptyRowsCount();
            var actualFirstName = webTablesPage.GetFirstNameByRowValue(email);
            var actualLastName = webTablesPage.GetLastNameByRowValue(email);
            var actualEmail = webTablesPage.GetEmailByRowValue(email);
            var actualAge = webTablesPage.GetAgeByRowValue(email);
            var actualDepartment = webTablesPage.GetDepartmentByRowValue(email);

            Assert.That(actualRowsCount, Is.EqualTo(initialRowsCount + 1), "Wrong rows count");
            Assert.Multiple(() =>
            {
                Assert.That(actualFirstName, Is.EqualTo(firstName), "Wrong First Name");
                Assert.That(actualLastName, Is.EqualTo(lastName), "Wrong Last Name");
                Assert.That(actualEmail, Is.EqualTo(email), "Wrong Email");
                Assert.That(actualAge, Is.EqualTo(age), "Wrong Age");
                Assert.That(actualDepartment, Is.EqualTo(department), "Wrong Department");
            });

            webTablesPage.ClickOnDeleteButtonByRowValue(email);
            actualRowsCount = webTablesPage.GetNotEmptyRowsCount();

            Assert.That(actualRowsCount, Is.EqualTo(initialRowsCount), "Wrong rows count");
        }

        [Test]
        [Description("Test edits inputs in the row, check if all the data in the row is equal to filled in Registration Form")]
        [TestCase("cierra@example.com", "Smith", "cierra.smith@example.com", "40", "30000")]
        public void SubmitRegistrationFormEdit(string rowToBeChanged, string lastName, string email, string age, string salary)
        {
            var webTablesPage = LeftPanel.Elements.WebTables();

            var initialFirstName = webTablesPage.GetFirstNameByRowValue(rowToBeChanged);
            var initialLastName = webTablesPage.GetLastNameByRowValue(rowToBeChanged);
            var initialEmail = webTablesPage.GetEmailByRowValue(rowToBeChanged);
            var initialAge = webTablesPage.GetAgeByRowValue(rowToBeChanged);
            var initialSalary = webTablesPage.GetSalaryByRowValue(rowToBeChanged);
            var initialDepartment = webTablesPage.GetDepartmentByRowValue(rowToBeChanged);

            webTablesPage.ClickOnEditButtonByRowValue(rowToBeChanged)
                .SubmitRegistrationForm(lastName: lastName, email: email, age: age, salary: salary);

            var actualFirstName = webTablesPage.GetFirstNameByRowValue(email);
            var actualLastName = webTablesPage.GetLastNameByRowValue(email);
            var actualEmail = webTablesPage.GetEmailByRowValue(email);
            var actualAge = webTablesPage.GetAgeByRowValue(email);
            var actualSalary = webTablesPage.GetSalaryByRowValue(email);
            var actualDepartment = webTablesPage.GetDepartmentByRowValue(email);

            Assert.Multiple(() =>
            {
                Assert.That(actualFirstName, Is.EqualTo(initialFirstName), "Wrong Last Name");
                Assert.That(actualLastName, Is.EqualTo(lastName), "Wrong Last Name");
                Assert.That(actualAge, Is.EqualTo(age), "Wrong Age");
                Assert.That(actualSalary, Is.EqualTo(salary), "Wrong salary");
                Assert.That(actualDepartment, Is.EqualTo(initialDepartment), "Wrong Department");
            });
        }
    }
}
