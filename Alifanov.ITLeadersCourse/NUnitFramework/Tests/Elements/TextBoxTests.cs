using NUnit.Framework;
using NUnitFramework.Navigation.LeftPanel;

namespace NUnitFramework.Tests.Elements
{
    public class TextBoxTests : BaseTest
    {

        [Test]
        [Description("Test of Text Box (User Form) with clicks on Submit button and get messages and then asserts that messages are correct")]
        [TestCase("John Smith")]
        public void CompareFullNameAfterClickOnSubmitButton(string expectedFullNameMessage)
        {
            var textBoxPage = LeftPanel.Elements.TextBox();          

            var actualMessage = textBoxPage.ClickOnSubmitButton()
                .GetNameInUserForm();

            Assert.That(actualMessage, Is.EqualTo(expectedFullNameMessage), "Message are not equal");
        }

        [Test]
        [Description("Test of Text Box (User Form) with clicks on Submit button and get messages and then asserts that messages are correct")]
        [TestCase("john@smith.com")]
        public void CompareEmailAfterClickOnSubmitButton(string expectedUserEmailMessage)
        {
            var textBoxPage = LeftPanel.Elements.TextBox();

            var actualMessage = textBoxPage.ClickOnSubmitButton()
                .GetEmailInUserForm();

            Assert.That(actualMessage, Is.EqualTo(expectedUserEmailMessage), "Message are not equal");
        }

        [Test]
        [Description("Test of Text Box (User Form) with clicks on Submit button and get messages and then asserts that messages are correct")]
        [TestCase("Downing street")]
        public void CompareCurrentAddressAfterClickOnSubmitButton(string expectedCurrentAddressMessage)
        {
            var textBoxPage = LeftPanel.Elements.TextBox();

            var actualMessage = textBoxPage.ClickOnSubmitButton()
                .GetCurrentAddressInUserForm();

            Assert.That(actualMessage, Is.EqualTo(expectedCurrentAddressMessage), "Message are not equal");
        }

        [Test]
        [Description("Test of Text Box (User Form) with clicks on Submit button and get messages and then asserts that messages are correct")]
        [TestCase("Buckingham Palace")]
        public void ComparePermanentAddressAfterClickOnSubmitButton(string expectedPermanentAddressMessage)
        {
            var textBoxPage = LeftPanel.Elements.TextBox();

            var actualMessage = textBoxPage.ClickOnSubmitButton()
                .GetPermanentAddressInUserForm();

            Assert.That(actualMessage, Is.EqualTo(expectedPermanentAddressMessage), "Message are not equal");
        }
    }
}
