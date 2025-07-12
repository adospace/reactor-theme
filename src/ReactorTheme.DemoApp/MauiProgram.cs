using CommunityToolkit.Maui;
using MauiReactor;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Hosting;
using ReactorTheme.DemoApp.Components;
using ReactorTheme.DemoApp.Resources.Styles;
using ReactorTheme.Styles;

namespace ReactorTheme.DemoApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiReactorApp<ShellPage>(app =>
                {
                    app.UseTheme<DemoAppApplicationTheme>();
                },
                unhandledExceptionAction: e =>
                {
                    System.Diagnostics.Debug.WriteLine(e.ExceptionObject);
                })
                .UseReactorThemeFonts()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("CascadiaCode-Regular.ttf", "CascadiaCodeRegular");
                })
                ;


            return builder.Build();
        }
    }
}
