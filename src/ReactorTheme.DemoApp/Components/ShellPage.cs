namespace ReactorTheme.DemoApp.Components;

class ShellPageState
{
    public bool IsFlyoutPresented { get; set; }
}


partial class ShellPage : Component<ShellPageState>
{
    public override VisualNode Render()
        => Shell(
            FlyoutItem("Color", new ColorsPage()
                .OnOpenSideMenu(OpenFlyout)),
            FlyoutItem("Text", new TextsPage()
                .OnOpenSideMenu(OpenFlyout)),
            FlyoutItem("Button", new ButtonsPage()
                .OnOpenSideMenu(OpenFlyout)),
            FlyoutItem("Content switcher", new ContentSwitchersPage()
                .OnOpenSideMenu(OpenFlyout)),
            FlyoutItem("Tab", new TabsPage()
                .OnOpenSideMenu(OpenFlyout)),
            FlyoutItem("Checkbox", new CheckboxesPage()
                .OnOpenSideMenu(OpenFlyout)),
            FlyoutItem("Radio Button", new RadioButtonsPage()
                .OnOpenSideMenu(OpenFlyout)),
            FlyoutItem("Toggle", new ToggleButtonsPage()
                .OnOpenSideMenu(OpenFlyout))
        )
        .FlyoutIsPresented(State.IsFlyoutPresented)
        ;


    void OpenFlyout()
    {
        SetState(s => s.IsFlyoutPresented = false);
        SetState(s => s.IsFlyoutPresented = true);
    }
}
