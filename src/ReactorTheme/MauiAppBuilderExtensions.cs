using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactorTheme;

public static class MauiAppBuilderExtensions
{
    public static MauiAppBuilder UseReactorThemeFonts(this MauiAppBuilder mauiAppBuilder)
    {
        return mauiAppBuilder
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("Inter-Regular.ttf", "InterRegular");
                    fonts.AddFont("Inter-Bold.ttf", "InterBold");
                    fonts.AddFont("Inter-SemiBold.ttf", "InterSemiBold");
                    fonts.AddFont("Inter-ExtraBold.ttf", "InterExtraBold");
                    fonts.AddFont("Inter-Medium.ttf", "InterMedium");
                });
    }

}
