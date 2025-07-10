using ReactorTheme.Styles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactorTheme.DemoApp.Components;

partial class CheckboxesPage : BaseKitPage
{
    protected override string HowToUse => """
        A checkbox allows the user to select a value from a small set of options.

        It should be used when multiple options can be selected.
        """;

    protected override string Variants => string.Empty;

    protected override string PropertiesImageSource => "props_checkboxes.png";

    protected override string Title => "Checkbox";

    protected override string Group => "INPUT";

    protected override VisualNode RenderVariants()
    {
        return VStack(spacing: 24,
            
            HStack(spacing: 12,
                new CheckBoxKit()
                    .Size(CheckBoxSize.Small),

                new CheckBoxKit()
                    .Size(CheckBoxSize.Small)
                    .Checked(true)
            )
            .HCenter(),


            HStack(spacing: 12,
                new CheckBoxKit()
                    .Size(CheckBoxSize.Normal),

                new CheckBoxKit()
                    .Size(CheckBoxSize.Normal)
                    .Checked(true)
            )
            .HCenter(),

            HStack(spacing: 12,
                new CheckBoxKit()
                    .Size(CheckBoxSize.Large),

                new CheckBoxKit()
                    .Size(CheckBoxSize.Large)
                    .Checked(true)
            )
            .HCenter()
        );
    }
}
