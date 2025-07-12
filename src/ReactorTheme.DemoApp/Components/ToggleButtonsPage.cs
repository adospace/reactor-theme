using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactorTheme.DemoApp.Components;

partial class ToggleButtonsPage : BaseKitPage
{
    protected override string HowToUse => """
        A toggle allows the user to select one of two option.

        The toggle must be used when the user can turn something on or off.
        """;

    protected override string Variants => string.Empty;

    protected override string PropertiesImageSource => "props_toggle.png";

    protected override string Title => "Toggle";

    protected override string Group => "INPUT";

    protected override string? Code => """
        new ToggleButtonKit()
            .Checked(state.Value)
            .OnChecked(v => ...))
        """;


    protected override VisualNode RenderVariants()
    {
        return VStack(
            HScrollView(
                
                Render<bool>(state =>
                    new ToggleButtonKit()
                        .Checked(state.Value)
                        .OnChecked(v => state.Set(_=>v)))
            )
        );
    }
}
