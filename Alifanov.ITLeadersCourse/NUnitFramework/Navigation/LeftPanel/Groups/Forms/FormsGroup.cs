namespace NUnitFramework.Navigation.LeftPanel.Groups.Forms
{
    using NUnitFramework.Pages.Forms;

    public class FormsGroup : BaseGroup
    {
        public PracticeFormPage PracticeForm() => NavigateTo<PracticeFormPage>("automation-practice-form");
    }
}
