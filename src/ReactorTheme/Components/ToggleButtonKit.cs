using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactorTheme.DemoApp.Components;

public partial class ToggleButtonKit : Component
{
    [Prop]
    bool _checked;

    [Prop]
    Action<bool>? _onChecked;

    public override VisualNode Render()
    {
        return Grid(

            Border()
                .BackgroundColor(_checked ? ApplicationTheme.HighlightDarkest : ApplicationTheme.NeutralLightDark)
                .StrokeCornerRadius(12),


            Ellipse()
                .BackgroundColor(ApplicationTheme.NeutralLightLightest)
                .Margin(4)
                .Height(20)
                .Width(20)
                .HStart()
                .TranslationX(_checked ? 17 : 0)
                .WithAnimation(duration: 100)
        )
        .OnTapped(() => _onChecked?.Invoke(!_checked))
        .Height(28)
        .Width(45);
        
    }

}
