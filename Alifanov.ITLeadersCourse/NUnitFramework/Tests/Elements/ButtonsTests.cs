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
                .GetDoubleClickMeButtonMessage();

            Assert.That(actualMessage, Is.EqualTo(expectedMessage), "Messages are not equal");
        }

        [Test]
        [Description("Test clicks on Click Me button and get message and then asserts that message is correct")]
        [TestCase("You have done a dynamic click")]
        public void ClickOnClickMeButton(string expectedMessage)
        {
            var buttonsPage = LeftPanel.Elements.Buttons();

            var actualMessage = buttonsPage.ClickOnClickMeButton()
                .GetMessageAfterClickOnClickMeButton();

            Assert.That(actualMessage, Is.EqualTo(expectedMessage), "Message are not equal");
        }

        [Test]
        [Description("Test clicks on Right Click Me button and get message and then asserts that message is correct")]
        [TestCase("You have done a right click")]
        public void RightClickOnRightClickMeButton(string expectedMessage)
        {
            var buttonsPage = LeftPanel.Elements.Buttons();

            var actualMessage = buttonsPage.RightClickOnRightClickMeButton()
                .GetMessageAfterRightClickMe();

            Assert.That(actualMessage, Is.EqualTo(expectedMessage), "Messages are not equal");
        }
    }
}
