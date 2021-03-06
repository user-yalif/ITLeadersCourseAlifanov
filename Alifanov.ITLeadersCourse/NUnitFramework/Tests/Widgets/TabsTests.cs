using NUnit.Framework;
using NUnitFramework.Navigation.LeftPanel;

namespace NUnitFramework.Tests.Widgets
{
    public class TabsTests : BaseTest
    {
        [Test]
        [Description("Test checks tabs to be clickable")]
        public void AssertThatTabsAreClickableTest()
        {
            var tabsPage = LeftPanel.Widgets.Tabs();

            tabsPage.ClickOnTab("origin");
            tabsPage.ClickOnTab("use");
            tabsPage.ClickOnTab("more");
            tabsPage.ClickOnTab("what");
        }

        [Test]
        [Description("Test clicks ob Tab, gets Tab's text and checks if text content the given one")]
        public void AssertThatTextOfTabsIsCorect()
        {
            var tabsPage = LeftPanel.Widgets.Tabs();

            tabsPage.ClickOnTab("origin");

            string actualOriginTabText = tabsPage.GetOriginTabText();
            string expectedOriginTabText = "de Finibus Bonorum et Malorum";
            Assert.That(actualOriginTabText, Does.Contain(expectedOriginTabText), "Expected text doesn't exist");

            tabsPage.ClickOnTab("use");

            string actualUseTabText = tabsPage.GetUseTabText();
            string expectedUseTabText = "'Content here, content here'";
            Assert.That(actualUseTabText, Does.Contain(expectedUseTabText), "Expected text doesn't exist");

            tabsPage.ClickOnTab("what");

            string actualWhatTabText = tabsPage.GetWhatTabText();
            string expectedWhatTabText = "Lorem Ipsum is simply dummy text";
            Assert.That(actualWhatTabText, Does.Contain(expectedWhatTabText), "Expected text doesn't exist");

            var isMoreTabDisabled = tabsPage.IsTabDisabled("more");
            Assert.That(isMoreTabDisabled, Is.True, "More TAb should be disabled");
        }
    }
}
