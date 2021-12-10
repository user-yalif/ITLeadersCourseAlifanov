using NUnit.Framework;
using NUnitFramework.Navigation.LeftPanel;

namespace NUnitFramework.Tests.Elements
{
    public class WebTablesTests : BaseTest
    {
        [Test]
        [Description("Test fills all fields and add a string to the table")]
        [TestCase("John", "Smith", "john.smith@test.com", "35", "3000", "AQA")]
        public void SubmitRegistrationFormInput(string firstName, string lastName, string email, string age, string salary, string department)
        {
            var webTablesPage = LeftPanel.Elements.WebTables()
                .ClickAddButton()
                .SubmitInputedData(firstName, lastName, email, age, salary, department);

            var actualFirstName = webTablesPage.GetFirstNameByRowValue(email);
            var actualLastName = webTablesPage.GetLastNameByRowValue(email);

            Assert.Multiple(() =>
            {
                Assert.That(actualFirstName, Is.EqualTo(firstName), "Wrong First Name");
                Assert.That(actualLastName, Is.EqualTo(lastName), "Wrong Last Name");
            });
        }
    }
}
