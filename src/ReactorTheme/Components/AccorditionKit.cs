using MauiReactor;
using MauiReactor.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactorTheme.DemoApp.Components;

public record AccorditionItem(string Key, string Title, Func<string, VisualNode> ContentRender);

public class AccorditionKitState
{
    public Dictionary<string, double> ContentHeights { get; set; } = [];

    public string? SelectedKey { get; set; }
}



public partial class AccorditionKit : Component<AccorditionKitState>
{
    [Prop]
    IReadOnlyList<AccorditionItem> _items = [];

    [Prop]
    string? _selectedKey;

    [Prop]
    Action<string>? _onSelected;

    protected override void OnPropsChanged()
    {
        if (_selectedKey != State.SelectedKey)
        {
            State.ContentHeights.Clear();
        }

        State.SelectedKey = _selectedKey;

        base.OnPropsChanged();
    }

    public override VisualNode Render()
    {
        return VScrollView(
            VStack(spacing: 0,

                [.. _items.Select(item =>
                    Grid("Auto,Auto", "*,Auto",
                        Label(item.Title)
                            .ThemeKey(ApplicationTheme.BodyM)
                            .OnTapped(()=> _onSelected?.Invoke(item.Key)),


                        Path()
                            .Data("M2,2 L6,6 L10,2")
                            .Width(12)
                            .Height(12)
                            .StrokeThickness(1.5)
                            .Stroke(ApplicationTheme.NeutralDarkLightest)
                            .Rotation(_selectedKey == item.Key ? 180 : 0)
                            .WithAnimation(duration: 200)
                            .Margin(0,4)
                            .GridColumn(1),


                        Grid(
                            item.ContentRender(item.Key)
                        )
                        .Margin(0,12,0,0)
                        .OnSizeChanged(size => SetState(s => s.ContentHeights[item.Key] = size.Height))
                        .GridRow(1)
                        .GridColumnSpan(2)
                        .Height(_selectedKey == item.Key ? State.ContentHeights.GetValueOrDefault(item.Key, double.NaN) : 0)
                    )
                    .Margin(0, 16)
                )]


            )
        );
    }
}
