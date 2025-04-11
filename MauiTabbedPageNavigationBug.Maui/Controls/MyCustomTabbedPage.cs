using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;
using MauiTabbedPage = Microsoft.Maui.Controls.TabbedPage;

namespace MauiTabbedPageNavigationBug.Maui.Controls
{
    public class MyCustomTabbedPage : MauiTabbedPage
    {
        public Func<string?, Task> TriggerItemSelected { get; set; } = _ => Task.CompletedTask;

        protected MyCustomTabbedPage()
        {
            On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
            On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().SetIsSmoothScrollEnabled(false);
        }
    }
}
