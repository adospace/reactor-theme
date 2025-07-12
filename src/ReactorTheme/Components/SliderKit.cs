using MauiReactor;
using MauiReactor.Shapes;

namespace ReactorTheme.DemoApp.Components;

public class SliderKitState
{
    public double Width { get; set; }
}

public partial class SliderKit : Component<SliderKitState>
{
    [Prop]
    string? _title;

    [Prop]
    int _value;

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
        return Grid("Auto,*","*,Auto",

            Label(_title ?? string.Empty)
                .ThemeKey(ApplicationTheme.H5),

            Grid(

                Border()
                    .BackgroundColor(ApplicationTheme.NeutralLightMedium)
                    .StrokeCornerRadius(8)
                    .Height(8)
                    .Margin(6, 0)
                    .OnSizeChanged(size => SetState(s => s.Width = size.Width))
                    .OnPointerPressed(OnSetThumbPosition),

                Border()
                    .BackgroundColor(ApplicationTheme.HighlightDarkest)
                    .StrokeCornerRadius(8)
                    .HStart()
                    .Height(8)
                    .Margin(6, 0)
                    .Width((State.Width) * ((_value - _minValue) / (double)(_maxValue - _minValue))),

                Ellipse()
                    .Height(20)
                    .Width(20)
                    .StrokeThickness(10)
                    .Stroke(ApplicationTheme.NeutralLightLightest)
                    .Fill(ApplicationTheme.HighlightDarkest)
                    .Shadow(Shadow().Brush(new SolidColorBrush(ApplicationTheme.NeutralLightDark)).Radius(4).Offset(0, 2))
                    .Margin(4,4)
                    .HStart()
                    .TranslationX((State.Width - 8) * ((_value - _minValue) / (double)(_maxValue - _minValue)))
            )
            .GridRow(1),


            !_showValue ? null :

            Border(

                Label(((_value - _minValue) / (double)(_maxValue - _minValue)).ToString("p0"))
                    .ThemeKey(ApplicationTheme.BodyS)
                    .VerticalTextAlignment(TextAlignment.Center)
                    .HorizontalTextAlignment(TextAlignment.Center)

            )
            .Width(56)
            .BackgroundColor(ApplicationTheme.NeutralLightLight)
            .StrokeCornerRadius(12)
            .GridColumn(1)
            .GridRowSpan(2)            
        )
        .RowSpacing(4)
        .ColumnSpacing(8);
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