using NUnit.Framework;
using NUnitFramework.Navigation.LeftPanel;

namespace NUnitFramework.Tests.Widgets
{
    public class ToolTipsTests : BaseTest
    {
        [Test]
        [Description("Test navigates to 'Hover me to see' button, gets and checks tool tip's message")]
        [TestCase("You hovered over the Button")]
        public void NavigateToHoverMeToSeeButtonAndGetTextFromToolTip(string expectedToolTipText)
        {
            var toolTipsPage = LeftPanel.Widgets.ToolTips();

            toolTipsPage.MoveToHoverMeToSeeButton();

            string actualToolTipText = toolTipsPage.GetTextOfToolTipHoverMeToSeeButton();

            Assert.That(actualToolTipText, Is.EqualTo(expectedToolTipText), "Wrong text of Tool tip");
        }
    }
}