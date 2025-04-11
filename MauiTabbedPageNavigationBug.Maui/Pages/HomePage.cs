using MauiTabbedPageNavigationBug.Maui.Controls;

namespace MauiTabbedPageNavigationBug.Maui.Pages;

public enum MyCustomMenuItem { RootPageOne, RootPageTwo, RootPageThree, RootPageFour, RootPageFive }

public sealed class HomePage : MyCustomTabbedPage
{
    public MyCustomMenuItem[] Items = Enum.GetValues<MyCustomMenuItem>();

    public HomePage(PageResolver PageResolver)
    {
        foreach (MyCustomMenuItem item in Items)
        {
            Children.Add(new MyCustomNavigationPage(PageResolver.ResolveByBottomMenuItemName(item))
            {
                Title = item.ToString()
            });
        }
    }
}