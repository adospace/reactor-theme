using MauiReactor.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactorTheme.DemoApp.Components;

public enum CalendarView
{
    Mounth,

    Strip
}

class CalendarKitState
{
    public DateTime DisplayDate { get; set; } = DateTime.Today;
}

partial class CalendarKit : Component<CalendarKitState>
{
    [Prop]
    DateTime _selectedDate = DateTime.Today;

    [Prop]
    Action<DateTime>? _onSelectedDateChanged;

    [Prop]
    CalendarView _view = CalendarView.Mounth;

    protected override void OnMountedOrPropsChanged()
    {
        State.DisplayDate = _selectedDate.Date.AddDays(-_selectedDate.Day + 1);


        base.OnMountedOrPropsChanged();
    }


    public override VisualNode Render()
    {
        if (_view == CalendarView.Mounth)
        {
            return RenderMonthView();
        }
        else
        {
            return RenderStripView();
        }
        
    }

    private VisualNode RenderMonthView()
    {
        var firstDisplayDate = State.DisplayDate.DayOfWeek == DayOfWeek.Monday
            ? State.DisplayDate
            : State.DisplayDate.DayOfWeek == DayOfWeek.Sunday ? State.DisplayDate.AddDays(-6) : State.DisplayDate.AddDays(-(int)State.DisplayDate.DayOfWeek + (int)DayOfWeek.Monday);

        var lastDisplayDate = firstDisplayDate.AddDays(35 - 1);

        return VStack(

            Grid("*","*, Auto, Auto",
                
                Label(State.DisplayDate.ToString("MMM yyyy"))
                    .ThemeKey(ApplicationTheme.H4)
                    .VerticalTextAlignment(TextAlignment.Center)
                    .Margin(8,0),

                Grid(
                    Path()
                        .Data("M6,0 0,6 L6,12")
                        .Stroke(ApplicationTheme.NeutralDarkLightest)
                        .StrokeThickness(1.5)
                        .Width(12)
                        .Height(12)
                        .Margin(20,20)
                )
                .OnTapped(()=>SetState(s => s.DisplayDate = s.DisplayDate.AddMonths(-1)))
                .Height(32)
                .Width(32)
                .GridColumn(1),


                Grid(
                    Path()
                        .Data("M0,0 6,6 L0,12")
                        .Stroke(ApplicationTheme.NeutralDarkLightest)
                        .StrokeThickness(1.5)
                        .Width(12)
                        .Height(12)
                        .Margin(20, 20)
                )
                .OnTapped(() => SetState(s => s.DisplayDate = s.DisplayDate.AddMonths(1)))
                .Height(32)
                .Width(32)
                .GridColumn(2)
            )
            .Padding(0,8),

            Grid("*", "*,*,*,*,*,*,*",

                Enumerable.Range(0, 7)
                    .Select(i => 
                    {
                        var date = firstDisplayDate.AddDays(i);
                        return Label(date.ToString("ddd").Substring(0, 2).ToUpper())
                            .ThemeKey(ApplicationTheme.CaptionM)
                            .TextColor(ApplicationTheme.NeutralDarkLightest)
                            .VerticalTextAlignment(TextAlignment.Center)
                            .HorizontalTextAlignment(TextAlignment.Center)
                            .GridColumn(i);
                    })

            )
            .Height(40),

            Grid("*,*,*,*,*", "*,*,*,*,*,*,*",

                Enumerable.Range(0, 35)
                    .Select(i =>
                    {
                        var date = firstDisplayDate.AddDays(i);
                        var currentMonth = date.Month == State.DisplayDate.Month;
                        return Grid(
                            Ellipse()
                                .Width(40)
                                .Height(40)
                                .Fill(date == _selectedDate.Date ? ApplicationTheme.HighlightDarkest : ApplicationTheme.NeutralLightLightest),
                            Label(date.Day)
                                .ThemeKey(ApplicationTheme.H5)
                                .TextColor(date == _selectedDate.Date ? ApplicationTheme.NeutralLightLightest : (currentMonth ? ApplicationTheme.NeutralDarkMedium : ApplicationTheme.NeutralLightDark))
                                .VerticalTextAlignment(TextAlignment.Center)
                                .HorizontalTextAlignment(TextAlignment.Center)
                        )
                        .GridRow(i / 7)
                        .GridColumn(i % 7)
                        .OnTapped(() => _onSelectedDateChanged?.Invoke(date));
                    })
                )
            );
    }

    private VisualNode RenderStripView()
    {
        throw new NotImplementedException();
    }
}
