using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactorTheme.DemoApp.Components;

partial class NumberInputPage : BaseKitPage
{
    protected override string HowToUse => """
        The Number Input is used to enter numerical values and includes controls for increasing or decreasing the value.
        """;

    protected override string Variants => string.Empty;

    protected override string PropertiesImageSource => "props_number_input.png";

    protected override string Title => "Number Input";

    protected override string Group => "INPUT";

    protected override VisualNode RenderVariants()
    {
        return VScrollView(
            VStack(spacing: 24,
                Render<int>(state =>
                    new NumberInputKit()
                        .Title("Number Input")
                        .Value(state.Value)
                        .OnValueChanged(value => state.Set(_ => value))
                        ),

                Render<int>(state =>
                    new NumberInputKit()
                        .Title("Number Input")
                        .Value(state.Value)
                        .OnValueChanged(value => state.Set(_ => value))
                        .MinValue(0)
                        .MaxValue(10)
                        )

            )
        );
    }
}
