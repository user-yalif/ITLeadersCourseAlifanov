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
                .SubmitInputedData(name, email, currentAddress, permanentAddress);

            var actualName = textBoxPage.GetNameOutputMessage().Split(":")[1];
            var actualEmail = textBoxPage.GetEmailOutputMessage().Split(":")[1];
            var actualCurrentAddress = textBoxPage.GetCurrentAddressMessage().Split(":")[1];
            var actualPermanentAddress = textBoxPage.GetPermanentAddressMessage().Split(":")[1];

            Assert.Multiple(() =>
            {
                Assert.That(actualName, Is.EqualTo(name), "Wrong Full Name");
                Assert.That(actualEmail, Does.Contain(email), "Wrong Email");
                Assert.That(actualCurrentAddress, Does.Contain(currentAddress), "Wrong Current Address");
                Assert.That(actualPermanentAddress, Does.Contain(permanentAddress), "Wrong Permanent Address");
            });
        }
    }
}
