namespace ReactorTheme.DemoApp.Components;

partial class StarRatingKit : Component
{
    [Prop]
    string? _label;

    [Prop]
    int? _value;

    [Prop]
    Action<int>? _onValueChanged;

    [Prop]
    int _maxValue = 5;

    public override VisualNode Render()
    {
        return Grid();
    }
}