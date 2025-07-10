using MauiReactor;
using MauiReactor.Compatibility;
using ReactorTheme.DemoApp.Resources.Styles;
using ReactorTheme.Styles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactorTheme.DemoApp.Components;

abstract partial class BasePage : Component
{
    protected abstract string Title { get; }

    protected abstract string Group { get; }

    //protected abstract string HowToUse { get; }

    //protected abstract string Variants { get; }

    //protected abstract string PropertiesImageSource { get; }


    [Prop]
    Action? _onOpenSideMenu;

    public override VisualNode Render()
    {
        return ContentPage(
            Grid("127,*","*",
                RenderTitle(),


                RenderBody()

                //VScrollView(
                //    VStack(spacing: 20,
                //        RenderSectionTitle(1, "HOW TO USE"),

                //        Label(HowToUse)
                //            .ThemeKey(ApplicationTheme.BodyS)
                //            .TextColor(ApplicationTheme.NeutralDarkLight),
                        
                //        RenderSectionTitle(2, "VARIANTS"),
                                                
                //        Label(Variants)
                //            .ThemeKey(ApplicationTheme.BodyS)
                //            .TextColor(ApplicationTheme.NeutralDarkLight),

                //        RenderBody(),

                //        RenderSectionTitle(3, "PROPERTIES"),

                //        Image(PropertiesImageSource)
                //    )
                //)
                //.Padding(45,70)
                //.GridRow(1)
            )
        )
        .Set(MauiControls.Shell.NavBarIsVisibleProperty, false)
        .BackgroundColor(ApplicationTheme.NeutralLightLightest);
    }

    protected abstract VisualNode RenderBody();        

    VisualNode RenderTitle()
    {
        return Grid(

            Grid("48","48, *",

                Border(
                    Image(
                        new IconTintColorBehavior()
                            .TintColor(ApplicationTheme.NeutralDarkDarkest)
                    )
                    .Source("hamburger_menu.png")
                    .Aspect(Aspect.Center)
                    .Width(24)
                    .Height(24)
                )
                .GridColumn(0)
                .BackgroundColor(ApplicationTheme.NeutralLightMedium)
                .Height(48)
                .StrokeThickness(0)
                .StrokeCornerRadius(16)
                .OnTapped(_onOpenSideMenu),

                VStack(
                    Label(Group)
                        .ThemeKey(ApplicationTheme.CaptionM)
                        .TextColor(ApplicationTheme.NeutralDarkLightest),
                    Label(Title)
                        .ThemeKey(ApplicationTheme.H1)
                        .TextColor(ApplicationTheme.NeutralDarkDarkest)
                )
                .GridColumn(1)

            )
            .ColumnSpacing(18)
        )
        .Padding(32, 32+7.5)
        .BackgroundColor(ApplicationTheme.NeutralLightLight);
    }

    //VisualNode RenderSectionTitle(int sectionNumber, string title)
    //{
    //    return Border(
    //        Grid("32","32,*",
            
    //            Border(
    //                Label(sectionNumber)
    //                    .ThemeKey(ApplicationTheme.H5)
    //                    .TextColor(ApplicationTheme.NeutralDarkDarkest)
    //                    .VerticalTextAlignment(TextAlignment.Center)
    //                    .HorizontalTextAlignment(TextAlignment.Center)
    //            )
    //            .StrokeThickness(0)
    //            .BackgroundColor(ApplicationTheme.NeutralLightMedium)
    //            .StrokeCornerRadius(12),

    //            Label(title)
    //                .ThemeKey(ApplicationTheme.ActionM)
    //                .TextColor(ApplicationTheme.NeutralDarkDarkest)
    //                .VerticalTextAlignment(TextAlignment.Center)
    //                .GridColumn(1)                    
    //        )
    //        .VCenter()
    //        .Margin(6,0)
    //        .ColumnSpacing(15)
    //    )
    //    .StrokeCornerRadius(16)
    //    .BackgroundColor(ApplicationTheme.NeutralLightLight)
    //    .Height(44);
    //}

    //protected abstract VisualNode RenderVariants();


}
