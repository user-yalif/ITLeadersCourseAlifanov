using NUnitFramework.Pages.Widgets;

namespace NUnitFramework.Navigation.LeftPanel.Groups.Widgets
{
    public class WidgetsGroup : BaseGroup
    {
        public TabsPage Tabs() => NavigateTo<TabsPage>("tabs");

        public ToolTipsPage ToolTips() => NavigateTo<ToolTipsPage>("tool-tips");
    }
}