using Astroverse.Services;
using Astroverse.ViewModels;
using Astroverse.Views;
using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Plugin.Maui.DebugRainbows;
using Sharpnado.MaterialFrame;

namespace Astroverse;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>()
        .UseDebugRainbows(new DebugRainbowsOptions
        {
            ShowRainbows = true,
            ShowGrid = false,
            HorizontalItemSize = 10,
            VerticalItemSize = 10,
            MajorGridLineInterval = 0,
            MajorGridLines = new GridLineOptions { Color = Color.FromRgb(255, 0, 0), Opacity = 1, Width = 4 },
            MinorGridLines = new GridLineOptions { Color = Color.FromRgb(255, 0, 0), Opacity = 1, Width = 1 },
            GridOrigin = DebugGridOrigin.Center,
        })
        .UseSharpnadoMaterialFrame(loggerEnable: false)
        .ConfigureFonts(fonts =>
        {
            fonts.AddFont("Kanit-Light.ttf", "Kanit#300");
            fonts.AddFont("Kanit-Regular.ttf", "Kanit#400");
            fonts.AddFont("Kanit-Medium.ttf", "Kanit#500");
        }).UseMauiCommunityToolkit();

        builder.Services.AddSingleton<IPlanetsService, PlanetsService>();

        builder.Services.AddSingleton<WelcomeViewModel>();
        builder.Services.AddSingleton<PlanetariumViewModel>();

        builder.Services.AddSingleton<WelcomePage>();
        builder.Services.AddSingleton<PlanetariumPage>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}