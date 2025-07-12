using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactorTheme.DemoApp.Components;

partial class AccorditionPage : BaseKitPage
{
    protected override string HowToUse => """
        An accordion allows the user to show and hide content sections.
        """;

    protected override string Variants => string.Empty;

    protected override string PropertiesImageSource => "props_accordition.png";

    protected override string Title => "Accordition";

    protected override string Group => "CONTENT";

    protected override string? Code => """
        new AccorditionKit()
            .Items([
                new AccorditionItem("item1", "Title 1", _ => 
                    Label($"Content of item 1"),
                new AccorditionItem("item2", "Title 2", _ => 
                    Label($"Content of item 2"),
                new AccorditionItem("item3", "Title 3", _ => 
                    Label($"Content of item 3"),
                ])
            .SelectedKey(state.Value)
            .OnSelected(key => ...)
        """;

    protected override VisualNode RenderVariants()
    {
        return VStack(
            
            Render<string?>(state =>
                new AccorditionKit()
                    .Items([
                        new AccorditionItem("item1", "Title 1", _ => 
                            Label($"Content of item 1")
                                .ThemeKey(ApplicationTheme.BodyS)
                                .TextColor(ApplicationTheme.NeutralDarkLight)),
                        new AccorditionItem("item2", "Title 2", _ => 
                            Label($"Content of item 2")
                                .ThemeKey(ApplicationTheme.BodyS)
                                .TextColor(ApplicationTheme.NeutralDarkLight)),
                        new AccorditionItem("item3", "Title 3", _ => 
                            Label($"Content of item 3")
                                .ThemeKey(ApplicationTheme.BodyS)
                                .TextColor(ApplicationTheme.NeutralDarkLight)),
                        ])
                    .SelectedKey(state.Value)
                    .OnSelected(key => state.Set(s => s == key ? null : key))
                )
            );
    }
}
