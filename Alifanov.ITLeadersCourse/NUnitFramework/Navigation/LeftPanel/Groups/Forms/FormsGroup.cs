using NUnitFramework.Pages.Forms.PracticeForms;

namespace NUnitFramework.Navigation.LeftPanel.Groups.Forms
{
    public class FormsGroup : BaseGroup
    {
        public PracticeFormPage PracticeForm() => NavigateTo<PracticeFormPage>("automation-practice-form");
    }
}
