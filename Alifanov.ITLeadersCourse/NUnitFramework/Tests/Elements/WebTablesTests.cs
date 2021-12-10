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
            var webTablesPage = LeftPanel.Elements.WebTables();

            var registrationFormPage = webTablesPage.ClickAddButton()
                .SubmitInputedData(firstName, lastName, email, age, salary, department);
        }
    }
}
