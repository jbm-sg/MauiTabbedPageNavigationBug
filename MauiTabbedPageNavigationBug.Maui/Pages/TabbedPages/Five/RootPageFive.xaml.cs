namespace MauiTabbedPageNavigationBug.Maui.Pages.TabbedPages.Five;

public partial class RootPageFive : ContentPage
{
	public RootPageFive()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new SubPageFiveOne());
    }
}