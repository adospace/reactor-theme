using MauiReactor.Compatibility;
using ReactorTheme.Styles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactorTheme.DemoApp.Components;

partial class TextsPage : BasePage
{
    protected override string Title => "Text";

    protected override string Group => "STYLE";

    protected override VisualNode RenderBody()
    {
        return VScrollView(
            HScrollView(                
                VStack(spacing: 70,
                    VStack(
                        Label("Aa")
                            .ThemeKey(ApplicationTheme.H1),
                        Label("Inter")
                            .ThemeKey(ApplicationTheme.BodyL)
                            .TextColor(ApplicationTheme.NeutralDarkLight)
                        ),

                    Grid("Auto, Auto, Auto, Auto, Auto, Auto", "Auto,Auto,Auto",
                        Label("Heading")
                            .ThemeKey(ApplicationTheme.H4),

                        RenderFontItem(ApplicationTheme.H1, "H1", "Extra bold / 24", 1, 0),
                        RenderFontItem(ApplicationTheme.H2, "H2", "Extra bold / 18", 2, 0),
                        RenderFontItem(ApplicationTheme.H3, "H3", "Extra bold / 16", 3, 0),
                        RenderFontItem(ApplicationTheme.H4, "H4", "Bold / 14", 4, 0),
                        RenderFontItem(ApplicationTheme.H5, "H5", "Bold / 12", 5, 0),

                        Label("Body")
                            .ThemeKey(ApplicationTheme.H4)
                            .GridColumn(1),

                        RenderFontItem(ApplicationTheme.BodyXL, "XL", "Regular / 18", 1, 1),
                        RenderFontItem(ApplicationTheme.BodyL, "L", "Regular / 16", 2, 1),
                        RenderFontItem(ApplicationTheme.BodyM, "M", "Regular / 14", 3, 1),
                        RenderFontItem(ApplicationTheme.BodyS, "S", "Regular / 12", 4, 1),
                        RenderFontItem(ApplicationTheme.BodyXS, "xs", "Medium / 10", 5, 1),

                        Label("Action")
                            .ThemeKey(ApplicationTheme.H4)
                            .GridColumn(2),

                        RenderFontItem(ApplicationTheme.ActionL, "L", "Semi Bold / 14", 1, 2),
                        RenderFontItem(ApplicationTheme.ActionM, "M", "Semi Bold / 12", 2, 2),
                        RenderFontItem(ApplicationTheme.ActionS, "s", "Semi Bold / 10", 3, 2),


                        Label("Caption")
                            .ThemeKey(ApplicationTheme.H4)
                            .GridColumn(2)
                            .GridRow(4)
                            .VCenter(),

                        RenderFontItem(ApplicationTheme.CaptionM, "M", "Semi Bold / 10", 5, 2)
                    )
                    .ColumnSpacing(100)
                    .RowSpacing(24)
                
                )
            )
        )
        .Padding(45, 70)
        .GridRow(1);
    }

    VStack RenderFontItem(string selector, string label, string fontDescription, int row, int column)
        => VStack(
            Label(label)
                .ThemeKey(selector),
            Label(fontDescription)
                .ThemeKey(ApplicationTheme.BodyS)
                .TextColor(ApplicationTheme.NeutralDarkLightest)
            )
        .VEnd()
        .GridRow(row)
        .GridColumn(column);
}
