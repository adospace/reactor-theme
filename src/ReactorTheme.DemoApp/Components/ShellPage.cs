﻿namespace ReactorTheme.DemoApp.Components;

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
                .OnOpenSideMenu(OpenFlyout)),
            FlyoutItem("Text Field", new TextFieldsPage()
                .OnOpenSideMenu(OpenFlyout)),
            FlyoutItem("Text Area", new TextAreasPage()
                .OnOpenSideMenu(OpenFlyout)),
            FlyoutItem("Number Input", new NumberInputPage()
                .OnOpenSideMenu(OpenFlyout)),
            FlyoutItem("Slider", new SliderPage()
                .OnOpenSideMenu(OpenFlyout)),
            FlyoutItem("Star Rating", new StarRatingPage()
                .OnOpenSideMenu(OpenFlyout)),
            FlyoutItem("Accordition", new AccorditionPage()
                .OnOpenSideMenu(OpenFlyout)),
            FlyoutItem("Calendar", new CalendarPage()
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
