using ReactorTheme.Components;
using ReactorTheme.Styles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactorTheme.DemoApp.Components;

partial class ButtonsPage : BaseKitPage
{
    protected override string Title => "Button";

    protected override string Group => "CONTROL";

    protected override string HowToUse => """
        Buttons communicate actions users can perform by tapping it. 

        They are typically placed where the user can take any action throughout your UI – such as in Dialogs, Forms, Banners, Cards, etc.
        """;

    protected override string Variants => """
        Use different types of buttons to reflect the hierarchy of actions 
        """;

    protected override string PropertiesImageSource => "props_buttons.png";

    protected override VisualNode RenderVariants()
    {
        return Grid("Auto,Auto,Auto,Auto,Auto,Auto", "Auto,*",

            Button("Button"), // same as primary by default

            Label("Primary")
                .ThemeKey(ApplicationTheme.BodyS)
                .VCenter()
                .GridColumn(1)
                .TextColor(ApplicationTheme.NeutralDarkLightest),


            Button("Secondary")
                .ThemeKey(ApplicationTheme.Secondary)
                .GridRow(1),

            Label("Secondary")
                .ThemeKey(ApplicationTheme.BodyS)
                .VCenter()
                .GridRow(1)
                .GridColumn(1)
                .TextColor(ApplicationTheme.NeutralDarkLightest),


            Button("Terciary")
                .ThemeKey(ApplicationTheme.Terciary)
                .GridRow(2),

            Label("Terciary")
                .ThemeKey(ApplicationTheme.BodyS)
                .VCenter()
                .GridRow(2)
                .GridColumn(1)
                .TextColor(ApplicationTheme.NeutralDarkLightest),


            new ButtonKit()
                .ThemeKey(ApplicationTheme.Primary)
                .Text("Button")
                .LeftImageSource("white_placeholder.png")
                .RightImageSource("white_placeholder.png")
                .GridRow(3),

            Label("Primary with images")
                .ThemeKey(ApplicationTheme.BodyS)
                .VCenter()
                .GridRow(3)
                .GridColumn(1)
                .TextColor(ApplicationTheme.NeutralDarkLightest),

            new ButtonKit()
                .ThemeKey(ApplicationTheme.Secondary)
                .Text("Button")
                .LeftImageSource("placeholder.png")
                .RightImageSource("placeholder.png")
                .GridRow(4),

            Label("Secondary with images")
                .ThemeKey(ApplicationTheme.BodyS)
                .VCenter()
                .GridRow(4)
                .GridColumn(1)
                .TextColor(ApplicationTheme.NeutralDarkLightest),

            new ButtonKit()
                .ThemeKey(ApplicationTheme.Terciary)
                .Text("Button")
                .LeftImageSource("placeholder.png")
                .RightImageSource("placeholder.png")
                .GridRow(5),

            Label("Terciary with images")
                .ThemeKey(ApplicationTheme.BodyS)
                .VCenter()
                .GridRow(5)
                .GridColumn(1)
                .TextColor(ApplicationTheme.NeutralDarkLightest)


        )
        .ColumnSpacing(28)
        .RowSpacing(32);
    }
}
