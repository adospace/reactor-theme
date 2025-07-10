using MauiReactor;
using Microsoft.Maui.Graphics.Text;
using ReactorTheme.DemoApp.Resources.Styles;
using ReactorTheme.Styles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ReactorTheme.Components;

partial class ButtonKit : Component
{
    [Prop]
    string? _text;

    [Prop]
    Action? _onClicked;

    [Prop]
    string? _leftImageSource;

    [Prop]
    Func<VisualNode>? _leftImage;

    [Prop]
    string? _rightImageSource;

    [Prop]
    Func<VisualNode>? _rightImage;


    public override VisualNode Render()
    {
        bool isPrimary = ThemeKey == ApplicationTheme.Primary;

        return Grid(
            Button()
                .ThemeKey(ThemeKey)
                .OnClicked(_onClicked),

            HStack(spacing: 8,

                _leftImage?.Invoke(),

                _leftImageSource == null ? null :
                Image(_leftImageSource)
                    .VCenter(),

                Label(_text)
                    .TextColor(isPrimary ? ApplicationTheme.NeutralLightLightest : ApplicationTheme.HighlightDarkest)
                    .FontSize(ApplicationTheme.SizeCaptionM)
                    .HorizontalTextAlignment(TextAlignment.Center)
                    .VerticalTextAlignment(TextAlignment.Center),

                _rightImage?.Invoke(),

                _rightImageSource == null ? null :
                Image(_rightImageSource)
                    .VCenter()
            )
            .Padding(16,0)
            .OnTapped(_onClicked)
            .HCenter()
        );
    }
}
