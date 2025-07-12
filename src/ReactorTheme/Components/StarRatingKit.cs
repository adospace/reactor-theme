namespace ReactorTheme.DemoApp.Components;

public partial class StarRatingKit : Component
{
    [Prop]
    string? _title;

    [Prop]
    int? _value;

    [Prop]
    Action<int>? _onValueChanged;

    [Prop]
    int _maxValue = 5;

    public override VisualNode Render()
    {
        return HStack(

            Enumerable.Range(1, _maxValue).Select(i =>
                Image(i <= _value ? $"star_fill.png" : "star_outline.png")
                    .Aspect(Aspect.Center)
                    .Height(20)
                    .Width(20)
                    .OnTapped(() => _onValueChanged?.Invoke(i))
            ).ToArray()

        );
    }
}