using NUnit.Framework;
using NUnitFramework.Navigation.LeftPanel;

namespace NUnitFramework.Tests.Elements
{
    public class ButtonsTests : BaseTest
    {
        [Test]
        [Description("Test clicks on Double Click Me button and get message and then asserts that message is correct")]
        [TestCase("You have done a double click")]
        public void ClickOnDoubleClickMeButton(string expectedMessage)
        {
            var buttonsPage = LeftPanel.Elements.Buttons();

            var actualMessage = buttonsPage.ClickOnDoubleClickMeButton()
                .GetMessageAfterDoubleClick();

            Assert.That(actualMessage, Is.EqualTo(expectedMessage), "Messages are not equal");

        }
    }
}
