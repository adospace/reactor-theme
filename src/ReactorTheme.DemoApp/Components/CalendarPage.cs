using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactorTheme.DemoApp.Components;

partial class CalendarPage : BaseKitPage
{
    protected override string HowToUse => """
        A calendar can be used to provide information based on dates, or as a date input.

        A weekly calendar is recommended when more detailed content needs to be displayed.
        """;

    protected override string Variants => string.Empty;

    protected override string PropertiesImageSource => "props_calendar.png";

    protected override string Title => "Calendar";

    protected override string Group => "CONTENT";

    protected override string? Code => """
        new CalendarKit()
            .SelectedDate(State.MyDate)
            .OnSelectedDateChanged(date => ...)
        """;

    protected override VisualNode RenderVariants()
    {
        return VScrollView(
            VStack(
                
                Render<DateTime>(state =>
                    new CalendarKit()
                        .SelectedDate(state.Value)
                        .OnSelectedDateChanged(date => state.Set(_ => date))
                , defaultValue: DateTime.Today)
            
            )
        );
    }
}
