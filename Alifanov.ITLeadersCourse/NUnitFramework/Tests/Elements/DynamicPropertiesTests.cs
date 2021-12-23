namespace NUnitFramework.Tests.Elements
{
    using NUnit.Framework;
    using NUnitFramework.Navigation.LeftPanel;

    public class DynamicPropertiesTests : BaseTest
    {
        [Test]
        [TestCase(true)]
        public void WaitButtonToBeEnabled(bool expectedResult)
        {
            var isButtonEnabled = LeftPanel.Elements.DynamicProperties()
                .IsEnableAfterButtonEnabled();

            Assert.That(isButtonEnabled, Is.EqualTo(expectedResult), "Button should be enabled");
        }

        [Test]
        [Description("Test waits until Color Button's color change")]
        [TestCase(true)]
        public void WaitColorButtonChangesColor(bool expectedResult)
        {
            var isColorChanged = LeftPanel.Elements.DynamicProperties()
                .IsColorButtonColorChanged();

            Assert.That(isColorChanged, Is.EqualTo(expectedResult), "Button should change its color");
        }

        [Test]
        [Description("Test waits until Visible After 5 Seconds Button is enabled and clickable")]
        [TestCase(true, true)]
        public void WaitUntilVisibleAfter5SecondsButtonEnabledAndClickable(bool isEnabled, bool isClickable)
        {
            var dynamicPropertiesPage = LeftPanel.Elements.DynamicProperties();

            bool actualEnabled = dynamicPropertiesPage.IsVisibleAfterButtonEnabled();
            var actualClickable = dynamicPropertiesPage.IsVisibleAfterButtonClickable();

            Assert.Multiple(() =>
            {
                Assert.That(actualEnabled, Is.EqualTo(isEnabled), "Button should be enabled");
                Assert.That(actualClickable, Is.EqualTo(isClickable), "Button should be clickable");
            });
        }
    }
}
