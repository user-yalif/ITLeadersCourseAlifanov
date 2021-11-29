namespace NUnitFramework.Navigation.LeftPanel
{
    using NUnitFramework.Navigation.LeftPanel.Groups.AlertsFrameAndWindows;
    using NUnitFramework.Navigation.LeftPanel.Groups.Elements;

    public static class LeftPanel
    {
        public static ElementsGroup Elements => new();

        public static AlertsFrameAndWindowsGroup AlertsFrameAndWindows => new();
    }
}
