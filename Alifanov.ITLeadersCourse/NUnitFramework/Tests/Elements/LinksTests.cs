using NUnit.Framework;
using NUnitFramework.Helpers;
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
                .GetCreatedLinkOutput();

            Assert.That(actualMessage, Is.EqualTo(expectedMessage), "Messages are not equal");
        }

        [Test]
        [Description("Test clicks on Home Link and get window's url and then check out that link is equal to BaseUrl")]
        [TestCase("https://demoqa.com/")]
        public void ClickOnHomeLink(string BaseUrl)
        {
            var linksPage = LeftPanel.Elements.Links();
            var linksPagelWindowHandle = WindowHelper.AddWindow();

            var newHomePage = linksPage.ClickOnHomeLink();
            var newHomePagelWindowHandle = WindowHelper.AddWindow();
            WindowHelper.SwitchTo(newHomePagelWindowHandle);
            var actualUrl = newHomePage.GetUrl();


            Assert.That(actualUrl, Is.EqualTo(BaseUrl), "Urls are not equal");
            WindowHelper.SwitchTo(linksPagelWindowHandle);
            WindowHelper.CloseAllBut(linksPagelWindowHandle);
        }
    }
}
