namespace NUnitFramework.Tests.AlertsFrameAndWindows
{
    using NUnit.Framework;
    using NUnitFramework.Navigation.LeftPanel;

    public class AlertsTests : BaseTest
    {
        [Test]
        [Description("Test clicks on Timeout button and waits for alert and then asserts that message is correct")]
        [TestCase("This alert appeared after 5 seconds")]
        public void WaitForAlert(string expectedMessage)
        {
            var alertsPage = LeftPanel.AlertsFrameAndWindows.Alerts();
            var actualMessage = alertsPage.ClickOnAlertWithTimeoutButton()
                .AcceptAlert();

            Assert.That(actualMessage, Is.EqualTo(expectedMessage), "Messages are not equal");
        }
    }
}
