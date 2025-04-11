using MauiTabbedPageNavigationBug.Maui.Pages;
using MauiTabbedPageNavigationBug.Maui.Pages.TabbedPages;
using MauiTabbedPageNavigationBug.Maui.Pages.TabbedPages.Five;

namespace MauiTabbedPageNavigationBug.Maui.DependencyInjection;

public static class PageServiceBinder
{
    public static IServiceCollection UsePages(this IServiceCollection services)
    {
        services.AddTransient<HomePage>();
        services.AddTransient<RootPageOne>();
        services.AddTransient<RootPageTwo>();
        services.AddTransient<RootPageThree>();
        services.AddTransient<RootPageFour>();
        services.AddTransient<RootPageFive>();
        services.AddTransient<SubPageFiveOne>();
        services.AddTransient<PageResolver>();
        return services;
    }
}