namespace NUnitFramework.Navigation.LeftPanel.Interfaces
{
    using NUnitFramework.Pages;

    public interface ILeftPanelGroup
    {
        T NavigateTo<T>(string path) where T : BasePage, new();
    }
}
