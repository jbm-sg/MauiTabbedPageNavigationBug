namespace MauiTabbedPageNavigationBug.Maui.Controls;

public class MyCustomNavigationPage : NavigationPage
{
    public MyCustomNavigationPage(Page root) : base(root) { }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        Navigation.PopToRootAsync();
    }
}