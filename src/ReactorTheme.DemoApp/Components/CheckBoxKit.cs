using MauiReactor;
using MauiReactor.Shapes;
using ReactorTheme.Styles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactorTheme.DemoApp.Components;

enum CheckBoxSize
{
    Small,

    Normal,

    Large
}

partial class CheckBoxKit : Component
{
    [Prop]
    CheckBoxSize _size = CheckBoxSize.Normal;

    [Prop]
    bool _checked;

    [Prop]
    Action<bool>? _onChecked;

    public override VisualNode Render()
    {
        return Border(
            Path()
                .When(_size == CheckBoxSize.Small, _ => _.Data("M0,4 L3,6 L10,0"))
                .When(_size == CheckBoxSize.Normal, _ => _.Data("M0,5 L4,8 L12,0"))
                .When(_size == CheckBoxSize.Large, _ => _.Data("M0,6 L5,10 L14,0"))
                .Stroke(ApplicationTheme.NeutralLightLightest)
                .StrokeThickness(2)
                .StrokeLineCap(Microsoft.Maui.Controls.Shapes.PenLineCap.Round)
                .When(_size == CheckBoxSize.Small, _ => _.Height(10).Width(10))
                .When(_size == CheckBoxSize.Normal, _ => _.Height(12).Width(12))
                .When(_size == CheckBoxSize.Large, _ => _.Height(14).Width(14))
                .Center()
        )
        .OnTapped(() => _onChecked?.Invoke(!_checked))
        .BackgroundColor(_checked ? ApplicationTheme.HighlightDarkest : ApplicationTheme.NeutralLightLightest)
        .Stroke(ApplicationTheme.NeutralLightDarkest)
        .StrokeThickness(_checked ? 0 : 1)
        .When(_size == CheckBoxSize.Small, _ => _.StrokeCornerRadius(4).Height(16).Width(16))
        .When(_size == CheckBoxSize.Normal, _ => _.StrokeCornerRadius(6).Height(24).Width(24))
        .When(_size == CheckBoxSize.Large, _ => _.StrokeCornerRadius(8).Height(32).Width(32));
    }
}
