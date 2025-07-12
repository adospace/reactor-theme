using ReactorTheme.Styles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactorTheme.DemoApp.Components;

partial class TextAreasPage : BaseKitPage
{
    protected override string HowToUse => """
        Text Area is a component that allows the user to enter long text.

        For short inputs, it is recommended to use the Text Field.
        """;

    protected override string Variants => string.Empty;

    protected override string PropertiesImageSource => "props_text_areas.svg";

    protected override string Title => "Text Area";

    protected override string Group => "INPUT";

    protected override string? Code => """
        new TextAreaKit()
            .Title("Label")
            .Placeholder("Placeholder")
            .Text("Text Field")
            .OnTextChanged(text => ...)
        """;


    protected override VisualNode RenderVariants()
    {
        return VScrollView(

            VStack(spacing: 24,
                new TextAreaKit()
                    .Title("Title")
                    .Placeholder("Placeholder"),

                new TextAreaKit()
                    .Title("Label")
                    .Placeholder("Placeholder")
                    .Text("Text Field")
                    .OnTextChanged(text => Console.WriteLine($"Text changed: {text}")),

                new TextAreaKit()
                    .InError(true)
                    .Title("Title")
                    .Placeholder("Placeholder"),

                new TextAreaKit()
                    .Title("Disabled")
                    .Placeholder("Placeholder")
                    .Text("Disabled Text Field")
                    .Disabled(true)
            )
        );
    }
}
