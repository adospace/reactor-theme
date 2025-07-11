using MauiReactor;
using MauiReactor.Shapes;

namespace ReactorTheme.DemoApp.Components;

class SliderKitState
{
    public double Width { get; set; }
}

partial class SliderKit : Component<SliderKitState>
{
    [Prop]
    string? _label;

    [Prop]
    int? _value;

    [Prop]
    Action<int>? _onValueChanged;

    [Prop]
    int _minValue = 0;

    [Prop]
    int _maxValue = 100;

    [Prop]
    int _step = 1;

    [Prop]
    bool _showValue = true;

    public override VisualNode Render()
    {
        return Grid(

            Border()
                .BackgroundColor(ApplicationTheme.NeutralLightMedium)
                .StrokeCornerRadius(8)
                .Height(8)
                .Margin(4, 0)
                .OnSizeChanged(size => SetState(s => s.Width = size.Width))
                .OnPointerPressed(OnSetThumbPosition),

            //Border()
            //    .BackgroundColor(ApplicationTheme.HighlightDarkest)
            //    .StrokeCornerRadius(8)
            //    .HStart()
            //    .Height(8)
            //    .Margin(4, 0)
            //    .Width((State.Width) * (_value.HasValue ? (_value.Value - _minValue) / (double)(_maxValue - _minValue) : 0)),

            Ellipse()
                .Height(20)
                .Width(20)
                .StrokeThickness(10)
                .Stroke(ApplicationTheme.NeutralLightLightest)
                .Fill(ApplicationTheme.HighlightDarkest)
                .Shadow(Shadow().Brush(new SolidColorBrush(ApplicationTheme.NeutralLightDark)).Radius(4).Offset(0, 2))
                .Margin(10,4)
                .HStart()
                .TranslationX((State.Width - 20) * (_value.HasValue ? (_value.Value - _minValue) / (double)(_maxValue - _minValue) : 0))
        );
    }

    void OnSetThumbPosition(Point? point)
    {
        if (point == null)
        {
            return;
        }

        Console.WriteLine(point);

        //Not working in Android:
        //https://github.com/dotnet/maui/issues/20849
    }
}