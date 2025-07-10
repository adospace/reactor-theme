using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactorTheme.DemoApp.Components;

partial class TabsPage : BaseKitPage
{
    protected override string HowToUse => """
        Tabs are used to organise related content by categories. 

        They allow the user to navigate between groups of content within the same context.
        """;

    protected override string Variants => string.Empty;

    protected override string PropertiesImageSource => "props_tabs.png";

    protected override string Title => "Tabs";

    protected override string Group => "CONTROL";

    protected override VisualNode RenderVariants()
    {
        return VStack(
            HScrollView(
                Render<string?>(selectedItemKey =>
                    new TabKit()
                        .SelectedItemKey(selectedItemKey.Value)
                        .OnSelectedItem(key => selectedItemKey.Set(_ => _ = key))
                        .Items(
                        [
                            new TabItem("Tab1", "Title"),
                            new TabItem("Tab2", "Title"),
                            new TabItem("Tab3", "Title"),
                            new TabItem("Tab4", "Title"),
                            new TabItem("Tab5", "Title")
                        ])
                , defaultValue: "Tab1")
            )
        );
    }
}
