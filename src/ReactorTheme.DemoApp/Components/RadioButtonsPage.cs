using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactorTheme.DemoApp.Components;

partial class RadioButtonsPage : BaseKitPage
{
    protected override string HowToUse => """
        A radio button allows the user to select a value from a small set of options.

        It should be used when only one option can be selected.
        """;

    protected override string Variants => string.Empty;

    protected override string PropertiesImageSource => "props_radio_buttons.png";

    protected override string Title => "Radio Button";

    protected override string Group => "INPUT";

    protected override string? Code => """
        new RadioButtonKit()
            .Size(RadioButtonSize.Normal)
            .Checked(state.Value)
            .OnChecked(checkedValue => ...)
        """;


    protected override VisualNode RenderVariants()
    {
        return VStack(spacing: 24,

            HStack(spacing: 12,
                new RadioButtonKit()
                    .Size(RadioButtonSize.Small),

                new RadioButtonKit()
                    .Size(RadioButtonSize.Small)
                    .Checked(true)
            )
            .HCenter(),


            HStack(spacing: 12,
                Render<bool>(state =>
                    new RadioButtonKit()
                        .Size(RadioButtonSize.Normal)
                        .Checked(state.Value)
                        .OnChecked(checkedValue => state.Set(_ => checkedValue))
                ),

                new RadioButtonKit()
                    .Size(RadioButtonSize.Normal)
                    .Checked(true)
            )
            .HCenter(),

            HStack(spacing: 12,
                new RadioButtonKit()
                    .Size(RadioButtonSize.Large),

                new RadioButtonKit()
                    .Size(RadioButtonSize.Large)
                    .Checked(true)
            )
            .HCenter()
        );
    }
}
