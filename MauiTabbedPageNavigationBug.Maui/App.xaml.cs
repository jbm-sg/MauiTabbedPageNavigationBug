using MauiTabbedPageNavigationBug.Maui.Pages;

namespace MauiTabbedPageNavigationBug.Maui
{
    public partial class App : Application
    {
        public App(IServiceProvider services)
        {
            InitializeComponent();
            if (Current is null)
                return;
            MainPage = services.GetRequiredService<HomePage>();
        }
    }
}