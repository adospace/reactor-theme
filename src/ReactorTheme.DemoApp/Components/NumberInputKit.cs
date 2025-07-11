using MauiReactor.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactorTheme.DemoApp.Components;

partial class NumberInputKit : Component
{
    [Prop]
    string? _label;

    [Prop]
    int _value;

    [Prop]
    Action<int>? _onValueChanged;

    [Prop]
    int? _minValue;

    [Prop]
    int? _maxValue;

    public override VisualNode Render()
    {
        return Grid("*","*,24,Auto,24", 
            
            Label()
                .ThemeKey(ApplicationTheme.H5)
                .TextColor(ApplicationTheme.NeutralDarkDark)
                .Text(_label ?? string.Empty),

            Ellipse()
                .Width(24)
                .Height(24)
                .BackgroundColor(_minValue != null && _value <= _minValue.Value ? ApplicationTheme.NeutralLightLight : ApplicationTheme.HighlightLightest)
                .GridColumn(1)
                .When(_minValue == null || _value > _minValue.Value, _ => _.OnTapped(() => _onValueChanged?.Invoke(_value - 1))),

            Path()
                .Data("M7,12 L17,12")
                .Stroke(_minValue != null && _value <= _minValue.Value ? ApplicationTheme.NeutralLightDarkest : ApplicationTheme.HighlightDarkest)
                .StrokeThickness(1.5)
                .Width(24)
                .Height(24)
                .GridColumn(1),

            Label(_value)
                .ThemeKey(ApplicationTheme.BodyM)
                .TextColor(ApplicationTheme.NeutralDarkDarkest)
                .VerticalTextAlignment(TextAlignment.Center)
                .GridColumn(2)
                .Margin(6,0),

            Ellipse()
                .Width(24)
                .Height(24)
                .BackgroundColor(_maxValue != null && _value >= _maxValue.Value ? ApplicationTheme.NeutralLightLight : ApplicationTheme.HighlightLightest)
                .GridColumn(3)
                .When(_maxValue == null || _value < _maxValue.Value, _ => _.OnTapped(() => _onValueChanged?.Invoke(_value + 1))),

            Path()
                .Data("M12,7 L12,17")
                .Stroke(_maxValue != null && _value >= _maxValue.Value ? ApplicationTheme.NeutralLightDarkest : ApplicationTheme.HighlightDarkest)
                .StrokeThickness(1.5)
                .Width(24)
                .Height(24)
                .GridColumn(3),

            Path()
                .Data("M7,12 L17,12")
                .Stroke(_maxValue != null && _value >= _maxValue.Value ? ApplicationTheme.NeutralLightDarkest : ApplicationTheme.HighlightDarkest)
                .StrokeThickness(1.5)
                .Width(24)
                .Height(24)
                .GridColumn(3)
        );
    }
}
