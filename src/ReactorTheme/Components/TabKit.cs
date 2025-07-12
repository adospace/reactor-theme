using ReactorTheme.Styles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactorTheme.DemoApp.Components;

public record TabItem(string Key, string Title);

public class TabKitState
{
    public Dictionary<string, double> ColumnWidths = [];
}

public partial class TabKit : Component<TabKitState>
{
    [Prop]
    IReadOnlyList<TabItem> _items = [];

    [Prop]
    string? _selectedItemKey;

    [Prop]
    Action<string>? _onSelectedItem;

    public override VisualNode Render()
    {
        var indexOfSelectedItem = _items.ToList().FindIndex(_ => _.Key == _selectedItemKey);
        var sizeBeforeSelectedItem = indexOfSelectedItem == -1 ? 0 : _items.Take(indexOfSelectedItem).Sum(_ => State.ColumnWidths.GetValueOrDefault(_.Key));
        var translationX = _selectedItemKey == null ? 0 :
            sizeBeforeSelectedItem + State.ColumnWidths.GetValueOrDefault(_items.First(_ => _.Key == _selectedItemKey).Key) / 2 - 12;

        return Border(

            Grid("*", string.Join(",", _items.Select(_ => "Auto")),

                new[] {
                    Border()
                        .BackgroundColor(ApplicationTheme.HighlightDarkest)
                        .IsVisible(_selectedItemKey != null)
                        .StrokeThickness(0)
                        .Height(4)
                        .Width(24)
                        .VEnd()
                        .HStart()
                        .StrokeCornerRadius(2)
                        .TranslationX(translationX)
                        .WithAnimation(duration: 200, easing: Easing.CubicOut)
                }
                .Concat(
                    _items.Select((item, index) =>

                        Grid(
                            Label(item.Title)
                                .ThemeKey(item.Key == _selectedItemKey ? ApplicationTheme.H4 : ApplicationTheme.BodyM)
                                .TextColor(item.Key == _selectedItemKey ? ApplicationTheme.NeutralDarkDarkest : ApplicationTheme.NeutralDarkLight)
                                .VerticalTextAlignment(TextAlignment.Center)
                                .HorizontalTextAlignment(TextAlignment.Center)
                        )
                        .Padding(13.5, 0)
                        .GridColumn(index)
                        .OnSizeChanged(size => SetState(s => s.ColumnWidths[item.Key] = size.Width))
                        .OnTapped(() => _onSelectedItem?.Invoke(item.Key))
                    )
                    .Cast<VisualNode>()
                )
            )
        )
        .StrokeThickness(0)
        .Height(75)
        .Padding(16);
    }
}
