using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactorTheme.DemoApp.Components;

partial class SliderPage : BaseKitPage
{
    protected override string HowToUse => """
        Sliders allow users to enter values from a range.

        Avoid sliders when the range is too large.
        """;

    protected override string Variants => string.Empty;

    protected override string PropertiesImageSource => "props_slider.png";

    protected override string Title => "Slider";

    protected override string Group => "INPUT";

    protected override string? Code => """
        new SliderKit()
            .Title("Title")
            .Value(state.Value)
            .OnValueChanged(value => ...)
            .MinValue(0)
            .MaxValue(100)
            .Step(1)
        """;

    protected override VisualNode RenderVariants()
    {
        return VScrollView(
            VStack(spacing: 24,
                Render<int>(state =>
                    new SliderKit()
                        .Title("Title")
                        .Value(state.Value)
                        .OnValueChanged(value => state.Set(_ => value))
                        .MinValue(0)
                        .MaxValue(100)
                        .Step(1)
                ),

                new SliderKit()
                    .Title("Title")
                    .Value(0)
                    .MinValue(0)
                    .MaxValue(100)
                    .Step(1),

                new SliderKit()
                    .Title("Title")
                    .Value(25)
                    .MinValue(0)
                    .MaxValue(100)
                    .Step(1),

                new SliderKit()
                    .Title("Title")
                    .Value(50)
                    .MinValue(0)
                    .MaxValue(100)
                    .Step(1),

                new SliderKit()
                    .Title("Title")
                    .Value(75)
                    .MinValue(0)
                    .MaxValue(100)
                    .Step(1),

                new SliderKit()
                    .Title("Title")
                    .Value(100)
                    .MinValue(0)
                    .MaxValue(100)
                    .Step(1)
            )
        );
    }
}
