namespace ReactorTheme.DemoApp.Components;

partial class HomePage : Component
{
    public override VisualNode Render()
    {
        return ContentPage("Home",
            VStack(
                Label("MauiReatcor")
                    .FontSize(24)
                    .TextColor(Colors.Black)
                ),
                Label("Mobile Apps Prototyping Kit")
                    .FontSize(18)
                    .TextColor(Colors.Gray)
            );
    }
}