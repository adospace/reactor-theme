﻿using ReactorTheme.Styles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactorTheme.DemoApp.Resources.Styles;

[Scaffold(typeof(CommunityToolkit.Maui.Behaviors.StatusBarBehavior))]
public partial class StatusBarBehavior { }

[Scaffold(typeof(CommunityToolkit.Maui.Behaviors.IconTintColorBehavior))]
public partial class IconTintColorBehavior { }

class DemoAppApplicationTheme : ApplicationTheme
{
    public readonly static string Code = nameof(Code);

    protected override void OnApply()
    {
        base.OnApply();

        LabelStyles.Themes[Code] = _ => _
            .FontFamily("CascadiaCodeRegular")
            .TextColor(NeutralDarkDark)
            .BackgroundColor(NeutralLightLight)
            .FontSize(12);

        ContentPageStyles.Default = _ => _
            .Title("MauiReactor Theme Demo App")
            .OnAndroid(_ => _.Set(MauiControls.Shell.BackgroundColorProperty, NeutralLightLightest))
            .AddChildren(
            [
                new StatusBarBehavior()
                    .StatusBarColor(NeutralLightLight)
                    .StatusBarStyle(CommunityToolkit.Maui.Core.StatusBarStyle.DarkContent)
            ])
            ;
    }
}
