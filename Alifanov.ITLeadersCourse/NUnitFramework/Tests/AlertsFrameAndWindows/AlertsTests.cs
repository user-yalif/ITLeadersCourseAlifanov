namespace NUnitFramework.Tests.AlertsFrameAndWindows
{
    using NUnit.Framework;
    using NUnitFramework.Navigation.LeftPanel;

    public class AlertsTests : BaseTest
    {
        [Test]
        [TestCase("You clicked a button")]
        public void AcceptAlert(string expectedMessage)
        {
            var actualMessage = LeftPanel.AlertsFrameAndWindows.Alerts()
                .ClickOnAlertButton()
                .AcceptAlert();

            Assert.That(actualMessage, Is.EqualTo(expectedMessage), "Messages are not equal");
        }

        [Test]
        [Description("Test clicks on Timeout button and waits for alert and then asserts that message is correct")]
        [TestCase("This alert appeared after 5 seconds")]
        public void WaitForAlert(string expectedMessage)
        {
            var actualMessage = LeftPanel.AlertsFrameAndWindows.Alerts()
                .ClickOnAlertWithTimeoutButton()
                .AcceptAlert();

            Assert.That(actualMessage, Is.EqualTo(expectedMessage), "Messages are not equal");
        }
    }
}
