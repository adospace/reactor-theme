using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactorTheme.DemoApp.Components;

partial class ContentSwitchersPage : BaseKitPage
{
    protected override string HowToUse => """
        Content switchers allow users to switch between two or more sections.

        The content switcher must be placed above the content that will be affected by it.
        """;

    protected override string Variants => string.Empty;

    protected override string PropertiesImageSource => "props_content_switchers.png";

    protected override string Title => "Content Switcher";

    protected override string Group => "CONTROL";

    protected override string? Code => """
        new ContentSwitcherKit()
            .SelectedItemKey(selectedItemKey.Value)
            .OnSelectedItem(key => ...)
            .Items(
            [
                new ContentSwitcherItem("Section1", "Section 1"),
                new ContentSwitcherItem("Section2", "Section 2"),
                new ContentSwitcherItem("Section3", "Section 3")
            ])
        """;

    protected override VisualNode RenderVariants()
    {
        return VStack(
                Render<string?>(selectedItemKey =>
                    new ContentSwitcherKit()
                        .SelectedItemKey(selectedItemKey.Value)
                        .OnSelectedItem(key => selectedItemKey.Set(_ => _ = key))
                        .Items(
                        [
                            new ContentSwitcherItem("Section1", "Section 1"),
                            new ContentSwitcherItem("Section2", "Section 2"),
                            new ContentSwitcherItem("Section3", "Section 3")
                        ])
                , defaultValue: "Section1")
        );
    }
}
