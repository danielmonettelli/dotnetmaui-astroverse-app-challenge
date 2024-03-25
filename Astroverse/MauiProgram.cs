﻿using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Sharpnado.MaterialFrame;

namespace Astroverse;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>()
        .UseSharpnadoMaterialFrame(loggerEnable: false)
        .ConfigureFonts(fonts =>
        {
            fonts.AddFont("Kanit-Light.ttf", "Kanit#300");
            fonts.AddFont("Kanit-Regular.ttf", "Kanit#400");
            fonts.AddFont("Kanit-Medium.ttf", "Kanit#500");
        }).UseMauiCommunityToolkit();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}