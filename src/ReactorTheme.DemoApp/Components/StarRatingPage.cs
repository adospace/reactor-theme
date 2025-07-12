using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactorTheme.DemoApp.Components;

partial class StarRatingPage : BaseKitPage
{
    protected override string HowToUse => """
        Star Rating is a component which allows users to give a rating of 0 to 5 on a certain topic.

        It is often used to measure the preference level of the user regarding some content.
        """;

    protected override string Variants => string.Empty;

    protected override string PropertiesImageSource => "props_star_rating.png";

    protected override string Title => "Star Rating";

    protected override string Group => "INPUT";

    protected override VisualNode RenderVariants()
    {
        return VScrollView(
            VStack(spacing: 24,
                Render(state =>
                    new StarRatingKit()
                        .Title("Star Rating")
                        .Value(state.Value)
                        .OnValueChanged(value => state.Set(_ => value))
                        .MaxValue(5)
                , defaultValue: 2)
            )
        );
    }
}
