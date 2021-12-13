namespace NUnitFramework.Navigation.LeftPanel.Groups.Elements
{
    using NUnitFramework.Pages.Elements;

    public class ElementsGroup : BaseGroup
    {
        public DynamicPropertiesPage DynamicProperties() => NavigateTo<DynamicPropertiesPage>("dynamic-properties");

        public ButtonsPage Buttons() => NavigateTo<ButtonsPage>("buttons");

        public LinksPage Links() => NavigateTo<LinksPage>("links");

        public TextBoxPage TextBox() => NavigateTo<TextBoxPage>("text-box");
    }
}
