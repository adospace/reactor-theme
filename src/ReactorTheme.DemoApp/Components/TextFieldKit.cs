using ReactorTheme.Styles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactorTheme.DemoApp.Components;

partial class TextFieldKit : Component
{
    [Prop]
    string? _title;

    [Prop]
    string? _placeholder;

    [Prop]
    string? _text;

    [Prop]
    bool _disabled;

    [Prop]
    bool _readOnly;

    [Prop]
    bool _inError;

    [Prop]
    bool _isPassword;

    [Prop]
    Action<string>? _onTextChanged;
    [Prop]
    string? _hintText;

    public override VisualNode Render()
    {
        return VStack(spacing: 8,
            Label()
                .ThemeKey(ApplicationTheme.H5)
                .TextColor(_disabled ? ApplicationTheme.NeutralDarkLightest : ApplicationTheme.NeutralDarkDark)
                .Text(_title ?? string.Empty),
            Border(
                Entry()
                    .ThemeKey(ThemeKey)
                    .Placeholder(_placeholder ?? string.Empty)
                    .IsPassword(_isPassword)
                    .IsReadOnly(_readOnly)
                    .Text(_text ?? string.Empty)
                    .IsEnabled(!_disabled)
                    .OnTextChanged(_onTextChanged)
                    .TextColor(_disabled ? ApplicationTheme.NeutralDarkLightest : ApplicationTheme.NeutralDarkDark)
            )
            .BackgroundColor(_disabled ? ApplicationTheme.NeutralLightLight : ApplicationTheme.NeutralLightLightest)
            .Stroke(_inError ? ApplicationTheme.SupportErrorMedium : ApplicationTheme.NeutralLightDarkest)
            .StrokeCornerRadius(12)
            .StrokeThickness(1.5)
            .Padding(16,2)
            .Height(48),

            _hintText == null ? null :
            Label()
                .ThemeKey(ApplicationTheme.BodyXS)
                .TextColor(ApplicationTheme.NeutralDarkLightest)
                .Text(_hintText ?? string.Empty)
        );
    }

}
