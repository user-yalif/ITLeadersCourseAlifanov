using NUnit.Framework;
using NUnitFramework.Navigation.LeftPanel;

namespace NUnitFramework.Tests.Elements
{
    public class TextBoxTests : BaseTest
    {
        [Test]
        [Description("Test checks that inputed data is correct")]
        [TestCase("John Smith", "john@smith.com", "Buckingham Palace", "12, Downing St.")]
        public void SubmitTextBoxInput(string name, string email, string currentAddress, string permanentAddress)
        {
            var textBoxPage = LeftPanel.Elements.TextBox()
                .SubmitData(name, email, currentAddress, permanentAddress);

            var actualName = textBoxPage.GetOutputName();
            var actualEmail = textBoxPage.GetOutputEmail();
            var actualCurrentAddress = textBoxPage.GetOutputCurrentAddress();
            var actualPermanentAddress = textBoxPage.GetOutputPermanentAddress();

            Assert.Multiple(() =>
            {
                Assert.That(actualName, Is.EqualTo(name), "Wrong Full Name");
                Assert.That(actualEmail, Is.EqualTo(email), "Wrong Email");
                Assert.That(actualCurrentAddress, Is.EqualTo(currentAddress), "Wrong Current Address");
                Assert.That(actualPermanentAddress, Is.EqualTo(permanentAddress), "Wrong Permanent Address");
            });
        }
    }
}
