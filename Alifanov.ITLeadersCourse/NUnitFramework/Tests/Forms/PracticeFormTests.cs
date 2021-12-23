namespace NUnitFramework.Tests.Forms
{
    using NUnit.Framework;
    using NUnitFramework.Navigation.LeftPanel;

    public class PracticeFormTests : BaseTest
    {
        [Test]
        [TestCase("John", "Smith", "js@gmail.com", "Male", "1234567890", "20 Dec 2005", "English", "Sports", "Bukenghame Palace, 17", "Rajasthan", "Jaiselmer")]
        public void SubmitPracticeFormTest(string name,
                                           string lastName,
                                           string email,
                                           string gender,
                                           string mobile,
                                           string dateOfBirth,
                                           string subject,
                                           string hobby,
                                           string address,
                                           string state,
                                           string city)
        {
            var thanksForSubmitingFormPage = LeftPanel.Forms.PracticeForm()
                .SubmitForm(name, lastName, email, gender, mobile, dateOfBirth, subject, hobby, address, state, city);

            var actualFullName = thanksForSubmitingFormPage.GetRowValueByLable("Student Name");
            var actualEmail = thanksForSubmitingFormPage.GetRowValueByLable("Student Email");
            var actualGender = thanksForSubmitingFormPage.GetRowValueByLable("Gender");
            var actualMobile = thanksForSubmitingFormPage.GetRowValueByLable("Mobile");
            var actualDateOfBirth = thanksForSubmitingFormPage.GetRowValueByLable("Date of Birth");
            var actualSubject = thanksForSubmitingFormPage.GetRowValueByLable("Subjects");
            var actualHobby = thanksForSubmitingFormPage.GetRowValueByLable("Hobbies");
            var actualAddress = thanksForSubmitingFormPage.GetRowValueByLable("Address");
            var actualState = thanksForSubmitingFormPage.GetRowValueByLable("State and City");

            Assert.Multiple(() =>
            {
                Assert.That(actualFullName, Is.EqualTo($"{name} {lastName}"), "Wrong name");
                Assert.That(actualEmail, Is.EqualTo(email), "Wrong email");
                Assert.That(actualGender, Is.EqualTo(gender), "Wrong gender");
                Assert.That(actualMobile, Is.EqualTo(mobile), "Wrong mobile number");

                Assert.Multiple(() =>
                {
                    Assert.That(actualDateOfBirth, Does.Contain("20").IgnoreCase, "Wrong date");
                    Assert.That(actualDateOfBirth, Does.Contain("Dec").IgnoreCase, "Wrong month");
                    Assert.That(actualDateOfBirth, Does.Contain("2005").IgnoreCase, "Wrong year");
                });

                Assert.That(actualSubject, Is.EqualTo(subject), "Wrong subject");
                Assert.That(actualHobby, Is.EqualTo(hobby), "Wrong hobby");
                Assert.That(actualAddress, Is.EqualTo(address), "Wrong address");
                Assert.That(actualState, Is.EqualTo($"{state} {city}"), "Wrong state or city");
            });
        }
    }
}
