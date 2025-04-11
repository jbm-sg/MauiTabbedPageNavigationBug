using MauiTabbedPageNavigationBug.Maui.Pages.TabbedPages;
using MauiTabbedPageNavigationBug.Maui.Pages.TabbedPages.Five;

namespace MauiTabbedPageNavigationBug.Maui.Pages;

public class PageResolver(RootPageOne RootPageOne, RootPageTwo RootPageTwo, RootPageThree RootPageThree, RootPageFour RootPageFour, RootPageFive RootPageFive)
{
    public Page ResolveByBottomMenuItemName(MyCustomMenuItem menuItem)
    {
        return menuItem switch
        {
            MyCustomMenuItem.RootPageOne => RootPageOne,
            MyCustomMenuItem.RootPageTwo => RootPageTwo,
            MyCustomMenuItem.RootPageThree => RootPageThree,
            MyCustomMenuItem.RootPageFour => RootPageFour,
            MyCustomMenuItem.RootPageFive => RootPageFive,
            _ => throw new ArgumentException("This item mismatch", nameof(menuItem))
        };
    }
}