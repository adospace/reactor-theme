using CommunityToolkit.Maui.Converters;
using MauiReactor.Compatibility;
using ReactorTheme.DemoApp.Resources.Styles;
using ReactorTheme.Styles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactorTheme.DemoApp.Components;

partial class ColorsPage : BasePage
{
    protected override string Title => "Color";

    protected override string Group => "STYLES";

    //public override VisualNode Render()
    //{
    //    return ContentPage(
    //        Grid("127,*", "*",
    //            RenderTitle(),

    //        )
    //    )
    //    .Set(MauiControls.Shell.NavBarIsVisibleProperty, false)
    //    .BackgroundColor(ApplicationTheme.NeutralLightLightest);
    //}

    protected override VisualNode RenderBody()
    {
        return VScrollView(
            HScrollView(
                VStack(spacing: 72,
                    VStack(spacing: 24,
                        Label("Highlight")
                            .ThemeKey(ApplicationTheme.H4),
                        HStack(
                            RenderColorItem(ApplicationTheme.HighlightDarkest, ApplicationTheme.NeutralLightLight, radius: new CornerRadius(16, 0, 16, 0)),
                            RenderColorItem(ApplicationTheme.HighlightDark, ApplicationTheme.NeutralDarkDarkest),
                            RenderColorItem(ApplicationTheme.HighlightMedium, ApplicationTheme.NeutralDarkDarkest),
                            RenderColorItem(ApplicationTheme.HighlightLight, ApplicationTheme.NeutralDarkDarkest),
                            RenderColorItem(ApplicationTheme.HighlightLightest, ApplicationTheme.NeutralDarkDarkest, radius: new CornerRadius(0, 16, 0, 16))
                        )
                    ),

                    VStack(spacing: 24,
                        Label("Neutral")
                            .ThemeKey(ApplicationTheme.H4),
                        Label("Light")
                            .ThemeKey(ApplicationTheme.BodyM)
                            .TextColor(ApplicationTheme.NeutralDarkLight),
                        HStack(
                            RenderColorItem(ApplicationTheme.NeutralLightDarkest, ApplicationTheme.NeutralDarkDarkest, radius: new CornerRadius(16, 0, 16, 0)),
                            RenderColorItem(ApplicationTheme.NeutralLightDark, ApplicationTheme.NeutralDarkDarkest),
                            RenderColorItem(ApplicationTheme.NeutralLightMedium, ApplicationTheme.NeutralDarkDarkest),
                            RenderColorItem(ApplicationTheme.NeutralLightLight, ApplicationTheme.NeutralDarkDarkest),
                            RenderColorItem(ApplicationTheme.NeutralLightLightest, ApplicationTheme.NeutralDarkDarkest, radius: new CornerRadius(0, 16, 0, 16))
                        ),
                        Label("Dark")
                            .ThemeKey(ApplicationTheme.BodyM)
                            .TextColor(ApplicationTheme.NeutralDarkLight),
                        HStack(
                            RenderColorItem(ApplicationTheme.NeutralDarkDarkest, ApplicationTheme.NeutralLightLight, radius: new CornerRadius(16, 0, 16, 0)),
                            RenderColorItem(ApplicationTheme.NeutralDarkDark, ApplicationTheme.NeutralLightLight),
                            RenderColorItem(ApplicationTheme.NeutralDarkMedium, ApplicationTheme.NeutralLightLight),
                            RenderColorItem(ApplicationTheme.NeutralDarkLight, ApplicationTheme.NeutralLightLight),
                            RenderColorItem(ApplicationTheme.NeutralDarkLightest, ApplicationTheme.NeutralDarkDarkest, radius: new CornerRadius(0, 16, 0, 16))
                        )
                    ),

                    VStack(spacing: 24,
                        Label("Support")
                            .ThemeKey(ApplicationTheme.H4),
                        Label("Success")
                            .ThemeKey(ApplicationTheme.BodyM)
                            .TextColor(ApplicationTheme.NeutralDarkLight),
                        HStack(
                            RenderColorItem(ApplicationTheme.SupportSuccessDark, ApplicationTheme.NeutralLightLight, radius: new CornerRadius(16, 0, 16, 0)),
                            RenderColorItem(ApplicationTheme.SupportSuccessMedium, ApplicationTheme.NeutralDarkDarkest),
                            RenderColorItem(ApplicationTheme.SupportSuccessLight, ApplicationTheme.NeutralDarkDarkest, radius: new CornerRadius(0, 16, 0, 16))
                        ),
                        Label("Warning")
                            .ThemeKey(ApplicationTheme.BodyM)
                            .TextColor(ApplicationTheme.NeutralDarkLight),
                        HStack(
                            RenderColorItem(ApplicationTheme.SupportWarningDark, ApplicationTheme.NeutralLightLight, radius: new CornerRadius(16, 0, 16, 0)),
                            RenderColorItem(ApplicationTheme.SupportWarningMedium, ApplicationTheme.NeutralDarkDarkest),
                            RenderColorItem(ApplicationTheme.SupportWarningLight, ApplicationTheme.NeutralDarkDarkest, radius: new CornerRadius(0, 16, 0, 16))
                        ),
                        Label("Error")
                            .ThemeKey(ApplicationTheme.BodyM)
                            .TextColor(ApplicationTheme.NeutralDarkLight),
                        HStack(
                            RenderColorItem(ApplicationTheme.SupportErrorDark, ApplicationTheme.NeutralLightLight, radius: new CornerRadius(16, 0, 16, 0)),
                            RenderColorItem(ApplicationTheme.SupportErrorMedium, ApplicationTheme.NeutralLightLight),
                            RenderColorItem(ApplicationTheme.SupportErrorLight, ApplicationTheme.NeutralDarkDarkest, radius: new CornerRadius(0, 16, 0, 16))
                        )
                    )

                )
            )
        )
        .Padding(45, 70)
        .GridRow(1);
    }

    //VisualNode RenderTitle()
    //{
    //    return Grid(

    //        Grid("48", "48, *",

    //            Border(
    //                Image(
    //                    new IconTintColorBehavior()
    //                        .TintColor(ApplicationTheme.NeutralDarkDarkest)
    //                )
    //                .Source("hamburger_menu.png")
    //                .Aspect(Aspect.Center)
    //                .Width(24)
    //                .Height(24)
    //            )
    //            .GridColumn(0)
    //            .BackgroundColor(ApplicationTheme.NeutralLightMedium)
    //            .Height(48)
    //            .StrokeThickness(0)
    //            .StrokeCornerRadius(16)
    //            .OnTapped(_onOpenSideMenu),

    //            VStack(
    //                Label("STYLES")
    //                    .ThemeKey(ApplicationTheme.CaptionM)
    //                    .TextColor(ApplicationTheme.NeutralDarkLightest),
    //                Label("Color")
    //                    .ThemeKey(ApplicationTheme.H1)
    //                    .TextColor(ApplicationTheme.NeutralDarkDarkest)
    //            )
    //            .GridColumn(1)

    //        )
    //        .ColumnSpacing(18)
    //    )
    //    .Padding(32, 32 + 7.5)
    //    .BackgroundColor(ApplicationTheme.NeutralLightLight);
    //}

    VisualNode RenderColorItem(Color backgrond, Color foreground, CornerRadius? radius = null)
        => Border(
            Label(backgrond.ToRgbaHex(includeAlpha: false).ToUpperInvariant())
                .ThemeKey(ApplicationTheme.CaptionM)
                .TextColor(foreground)
                .VerticalTextAlignment(TextAlignment.Center)
                .Margin(16, 0)
        )
        .StrokeThickness(0)
        .When(radius != null, _ => _.StrokeCornerRadius(radius!.Value))
        .Height(60)
        .Width(160)
        .BackgroundColor(backgrond);
}
