namespace NUnitFramework.Navigation.LeftPanel.Groups.Elements
{
    using NUnitFramework.Pages.Elements;

    public class ElementsGroup : BaseGroup
    {
        public TextBoxPage TextBox() => NavigateTo<TextBoxPage>("text-box");

        public WebTablesPage WebTables() => NavigateTo<WebTablesPage>("webtables");

        public ButtonsPage Buttons() => NavigateTo<ButtonsPage>("buttons");

        public LinksPage Links() => NavigateTo<LinksPage>("links");

        public DynamicPropertiesPage DynamicProperties() => NavigateTo<DynamicPropertiesPage>("dynamic-properties");
    }
}
