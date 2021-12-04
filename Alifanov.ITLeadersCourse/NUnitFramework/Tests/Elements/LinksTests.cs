using NUnit.Framework;
using NUnitFramework.Navigation.LeftPanel;

namespace NUnitFramework.Tests.Elements
{
    class LinksTests : BaseTest
    {
        [Test]
        [Description("Test clicks on Created Link and get output and then asserts that output is correct")]
        [TestCase("Link has responded with staus 201 and status text Created")]

        public void ClickOnCreatedLink(string expectedMessage)
        {
            var linksPage = LeftPanel.Elements.Links();

            var actualMessage = linksPage.ClickOnCreatedLink()
                .GetOutput();

            Assert.That(actualMessage, Is.EqualTo(expectedMessage), "Messages are not equal");
        }
    }
}
