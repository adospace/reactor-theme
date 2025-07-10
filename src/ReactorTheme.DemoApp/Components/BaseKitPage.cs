using MauiReactor.Compatibility;
using ReactorTheme.Styles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactorTheme.DemoApp.Components;

abstract partial class BaseKitPage : BasePage
{
    protected abstract string HowToUse { get; }

    protected abstract string Variants { get; }

    protected abstract string PropertiesImageSource { get; }

    protected override VisualNode RenderBody()
    {
        return VScrollView(
            VStack(spacing: 20,
                RenderSectionTitle(1, "HOW TO USE"),

                Label(HowToUse)
                    .ThemeKey(ApplicationTheme.BodyS)
                    .TextColor(ApplicationTheme.NeutralDarkLight),

                RenderSectionTitle(2, "VARIANTS"),

                string.IsNullOrWhiteSpace(Variants) ? null : 
                Label(Variants)
                    .ThemeKey(ApplicationTheme.BodyS)
                    .TextColor(ApplicationTheme.NeutralDarkLight),

                RenderVariants(),

                RenderSectionTitle(3, "PROPERTIES"),

                Image(PropertiesImageSource)
            )
        )
        .Padding(45, 70)
        .GridRow(1);
    }   

    VisualNode RenderSectionTitle(int sectionNumber, string title)
    {
        return Border(
            Grid("32", "32,*",

                Border(
                    Label(sectionNumber)
                        .ThemeKey(ApplicationTheme.H5)
                        .TextColor(ApplicationTheme.NeutralDarkDarkest)
                        .VerticalTextAlignment(TextAlignment.Center)
                        .HorizontalTextAlignment(TextAlignment.Center)
                )
                .StrokeThickness(0)
                .BackgroundColor(ApplicationTheme.NeutralLightMedium)
                .StrokeCornerRadius(12),

                Label(title)
                    .ThemeKey(ApplicationTheme.ActionM)
                    .TextColor(ApplicationTheme.NeutralDarkDarkest)
                    .VerticalTextAlignment(TextAlignment.Center)
                    .GridColumn(1)
            )
            .VCenter()
            .Margin(6, 0)
            .ColumnSpacing(15)
        )
        .StrokeCornerRadius(16)
        .BackgroundColor(ApplicationTheme.NeutralLightLight)
        .Height(44);
    }

    protected abstract VisualNode RenderVariants();
}
