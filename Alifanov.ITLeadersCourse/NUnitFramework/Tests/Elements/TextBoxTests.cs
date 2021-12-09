using NUnit.Framework;
using NUnitFramework.Navigation.LeftPanel;

namespace NUnitFramework.Tests.Elements
{
    public class TextBoxTests : BaseTest
    {

        [Test]
        [Description("Test of Text Box (User Form) with clicks on Submit button and get messages and then asserts that messages are correct")]
        [TestCase("John Smith")]
        public void CompareFullNameAfterCliclOnSubmitButton(string expectedMessage)
        {
            var textBoxPage = LeftPanel.Elements.TextBox();

            var actualMessage = textBoxPage.ClickOnSubmitButton()
                .GetNameInUserForm();

            Assert.That(actualMessage, Is.EqualTo(expectedMessage), "Message are not equal");
        }

        [Test]
        [Description("Test of Text Box (User Form) with clicks on Submit button and get messages and then asserts that messages are correct")]
        [TestCase("john@smith.com")]
        public void CompareEmailAfterCliclOnSubmitButton(string expectedMessage)
        {
            var textBoxPage = LeftPanel.Elements.TextBox();

            var actualMessage = textBoxPage.ClickOnSubmitButton()
                .GetEmailInUserForm();

            Assert.That(actualMessage, Is.EqualTo(expectedMessage), "Message are not equal");
        }

        [Test]
        [Description("Test of Text Box (User Form) with clicks on Submit button and get messages and then asserts that messages are correct")]
        [TestCase("Downing street")]
        public void CompareCurrentAddressAfterCliclOnSubmitButton(string expectedMessage)
        {
            var textBoxPage = LeftPanel.Elements.TextBox();

            var actualMessage = textBoxPage.ClickOnSubmitButton()
                .GetCurrentAddressInUserForm();

            Assert.That(actualMessage, Is.EqualTo(expectedMessage), "Message are not equal");
        }

        [Test]
        [Description("Test of Text Box (User Form) with clicks on Submit button and get messages and then asserts that messages are correct")]
        [TestCase("Buckingham Palace")]
        public void ComparePermanentAddressAfterCliclOnSubmitButton(string expectedMessage)
        {
            var textBoxPage = LeftPanel.Elements.TextBox();

            var actualMessage = textBoxPage.ClickOnSubmitButton()
                .GetPermanentAddressInUserForm();

            Assert.That(actualMessage, Is.EqualTo(expectedMessage), "Message are not equal");
        }
    }
}
