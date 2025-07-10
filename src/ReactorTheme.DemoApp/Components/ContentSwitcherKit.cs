using ReactorTheme.Styles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactorTheme.DemoApp.Components;

record ContentSwitcherItem(string Key, string Title);

class ContentSwitcherKitState
{
    public double? Width { get; set; }
}

partial class ContentSwitcherKit : Component<ContentSwitcherKitState>
{
    [Prop]
    IReadOnlyList<ContentSwitcherItem> _items = [];

    [Prop]
    string? _selectedItemKey;

    [Prop]
    Action<string>? _onSelectedItem;

    public override VisualNode Render()
    {
        var indexOfSelectedItem = _items.ToList().FindIndex(_ => _.Key == _selectedItemKey);
        var translationX = indexOfSelectedItem == -1 || State.Width == null ? 0 : State.Width.Value / _items.Count * indexOfSelectedItem;

        return Border(
            
            Grid("*", string.Join(",", _items.Select(_=>"*")),

                new[] {
                    Border()
                        .BackgroundColor(ApplicationTheme.NeutralLightLightest)
                        .IsVisible(_selectedItemKey != null)
                        .StrokeThickness(0)
                        .StrokeCornerRadius(12)
                        .Padding(13.5, 0)
                        .TranslationX(translationX)
                        .WithAnimation(duration: 200, easing: Easing.CubicOut)
                }
                .Concat(
                    _items.Select((item, index) => 

                        Grid(
                            Label(item.Title)
                                .ThemeKey(ApplicationTheme.H5)
                                .TextColor(item.Key == _selectedItemKey ? ApplicationTheme.NeutralDarkDarkest : ApplicationTheme.NeutralDarkLight)
                                .VerticalTextAlignment(TextAlignment.Center)
                                .HorizontalTextAlignment(TextAlignment.Center)
                        )
                        .Padding(13.5, 0)
                        .GridColumn(index)
                        .OnTapped(() => _onSelectedItem?.Invoke(item.Key))
                    )
                    .Cast<VisualNode>()
                )
            )        
            .OnSizeChanged(size => SetState(s => s.Width = size.Width))
        )
        .Height(40)
        .Padding(4)
        .StrokeCornerRadius(16)
        .BackgroundColor(ApplicationTheme.NeutralLightLight);
    }
}
