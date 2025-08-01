﻿using MauiReactor;
using MauiReactor.Shapes;
using ReactorTheme.Styles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactorTheme.DemoApp.Components;
public enum RadioButtonSize
{
    Small,

    Normal,

    Large
}

public partial class RadioButtonKit : Component
{
    [Prop]
    RadioButtonSize _size = RadioButtonSize.Normal;

    [Prop]
    bool _checked;

    [Prop]
    Action<bool>? _onChecked;

    public override VisualNode Render()
    {
        return Ellipse()
            .Fill(ApplicationTheme.NeutralLightLightest)
            .Stroke(_checked ? ApplicationTheme.HighlightDarkest : ApplicationTheme.NeutralLightDarkest)
            .When(_size == RadioButtonSize.Small, _ => _.Height(16).Width(16).StrokeThickness(_checked ? 10 : 2))
            .When(_size == RadioButtonSize.Normal, _ => _.Height(24).Width(24).StrokeThickness(_checked ? 15 : 2))
            .When(_size == RadioButtonSize.Large, _ => _.Height(32).Width(32).StrokeThickness(_checked ? 22 : 2))
            .OnTapped(() => _onChecked?.Invoke(!_checked))
            ;
    }
}
