﻿using ReactorTheme.Styles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactorTheme.DemoApp.Components;

partial class TextFieldsPage : BaseKitPage
{
    protected override string HowToUse => """
        Text Field is a component that allows the user to enter text.

        For long inputs, it is recommended to use the Text Area.
        """;

    protected override string Variants => string.Empty;

    protected override string PropertiesImageSource => "props_text_fields.svg";

    protected override string Title => "Text Field";

    protected override string Group => "INPUT";

    protected override string? Code => """        
        new TextFieldKit()
            .Title("Label")
            .Placeholder("Placeholder")
            .Text("Text Field")
            .OnTextChanged(text => ...)
        """;



    protected override VisualNode RenderVariants()
    {
        return VScrollView(

            VStack(spacing: 24,
                new TextFieldKit()
                    .Title("Title")
                    .Placeholder("Placeholder"),

                new TextFieldKit()
                    .Title("Label")
                    .Placeholder("Placeholder")
                    .Text("Text Field")
                    .OnTextChanged(text => Console.WriteLine($"Text changed: {text}")),

                new TextFieldKit()
                    .InError(true)
                    .Title("Title")
                    .Placeholder("Placeholder"),

                new TextFieldKit()
                    .Title("Disabled")
                    .Placeholder("Placeholder")
                    .Text("Disabled Text Field")
                    .Disabled(true)
            )
        );
    }
}
