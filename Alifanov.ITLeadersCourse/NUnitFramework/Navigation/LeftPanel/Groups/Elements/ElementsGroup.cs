namespace NUnitFramework.Navigation.LeftPanel.Groups.Elements
{
    using NUnitFramework.Pages.Elements;

    public class ElementsGroup : BaseGroup
    {
        public DynamicPropertiesPage DynamicProperties() => NavigateTo<DynamicPropertiesPage>("dynamic-properties");

        public ButtonsPage Buttons() => NavigateTo<ButtonsPage>("buttons");
    }
}
