This article is my contribution to the MAUI.NET July event 2025 hosted by Matt Goldman (https://goforgoldman.com/posts/mauiuijuly-25/).

# Introduction
MauiReactor is the library I maintain and use almost daily to build applications for Android and iOS: built on top of .NET MAUI, it allows developers to write code using an MVU approach (if you are new to MauiReactor or the MVU pattern, please take a look at the [MauiReactor site](https://github.com/adospace/reactorui-maui) for samples and documentation).

When you start a new project, especially for new clients, often you're required to create some sort of preliminary work (or an MVP) to experiment UX designs or to help the client to better figure out their requirements.
Most of the time, you do not yet have any UI design to follow. 

Other times, it can happen that you want to test some new approach on existing applications, but are not yet sure which UI/UX pattern to follow.

In this post, I want to introduce a new prototyping kit package for MauiReactor that should ease this process, providing several prebuilt components, like textboxes, number inputs, or tabs, that you can just drop into your project and use right away.

The main idea behind the toolkit is to give you an application theme that defines styles and controls for your prototypes (hence the name Prototyping Kit) that seamlessly integrate with MauiReactor.

The theme follows the excellent Figma design [Mobile Apps – Prototyping Kit](https://www.figma.com/community/file/1129468881607079432) from [Renata Pôrto](https://www.figma.com/@renataporto).

# Getting Started

1) [Set up MauiReactor if you haven't already](https://adospace.gitbook.io/mauireactor/getting-started-1)

2) Install the ReactorTheme package

```
dotnet add package ReactorTheme --version 1.0.0
```

3) Replace the initial ApplicationTheme under Resources/Styles with an empty class deriving from ReactorTheme ApplicationTheme

```csharp
class MyAppApplicationTheme : ApplicationTheme
{
    protected override void OnApply()
    {
      //additional styles
    }
}
```

4) Add ReactorTheme directives to the MauiAppBuilder

```csharp
builder
    .UseMauiReactorApp<ShellPage>(app =>
    {
        app.UseTheme<MyAppApplicationTheme>();//<-- use your application theme class deriving from the ReactorTheme application theme
    },
    unhandledExceptionAction: e =>
    {
        System.Diagnostics.Debug.WriteLine(e.ExceptionObject);
    })
    .UseReactorThemeFonts() //<-- add this line    
```

# Components

The kit includes many components, ranging from the basic Entry to the Tab or Calendar. 


## Color

The theme is based on a simple and elegant palette of a few colors. You can reach any color referencing the ApplicationTheme class.
For example, `ApplicationTheme.HighlightDarkest` returns the first highlight color.

| Property | Hex | Preview |
|---|---|---|
| `ApplicationTheme.HighlightDark` | #2897FF | $$\color{rgb(40,151,255)}{\textsf{■}}$$ |
| `ApplicationTheme.HighlightDarkest` | #006FFD | $$\color{rgb(0,111,253)}{\textsf{■}}$$ |
| `ApplicationTheme.HighlightLight` | #B4DBFF | $$\color{rgb(180,219,255)}{\textsf{■}}$$ |
| `ApplicationTheme.HighlightLightest` | #EAF2FF | $$\color{rgb(234,242,255)}{\textsf{■}}$$ |
| `ApplicationTheme.HighlightMedium` | #6FBAFF | $$\color{rgb(111,186,255)}{\textsf{■}}$$ |
| `ApplicationTheme.NeutralDarkDark` | #2F3036 | $$\color{rgb(47,48,54)}{\textsf{■}}$$ |
| `ApplicationTheme.NeutralDarkDarkest` | #1F2024 | $$\color{rgb(31,32,36)}{\textsf{■}}$$ |
| `ApplicationTheme.NeutralDarkLight` | #71727A | $$\color{rgb(113,114,122)}{\textsf{■}}$$ |
| `ApplicationTheme.NeutralDarkLightest` | #8F9098 | $$\color{rgb(143,144,152)}{\textsf{■}}$$ |
| `ApplicationTheme.NeutralDarkMedium` | #494A50 | $$\color{rgb(73,74,80)}{\textsf{■}}$$ |
| `ApplicationTheme.NeutralLightDark` | #D4D6DD | $$\color{rgb(212,214,221)}{\textsf{■}}$$ |
| `ApplicationTheme.NeutralLightDarkest` | #C5C6CC | $$\color{rgb(197,198,204)}{\textsf{■}}$$ |
| `ApplicationTheme.NeutralLightLight` | #F8F9FE | $$\color{rgb(248,249,254)}{\textsf{■}}$$ |
| `ApplicationTheme.NeutralLightLightest` | #FFFFFF | $$\color{rgb(255,255,255)}{\textsf{■}}$$ |
| `ApplicationTheme.NeutralLightMedium` | #E8E9F1 | $$\color{rgb(232,233,241)}{\textsf{■}}$$ |
| `ApplicationTheme.SupportErrorDark` | #ED3241 | $$\color{rgb(237,50,65)}{\textsf{■}}$$ |
| `ApplicationTheme.SupportErrorLight` | #FFE2E5 | $$\color{rgb(255,226,229)}{\textsf{■}}$$ |
| `ApplicationTheme.SupportErrorMedium` | #FF616D | $$\color{rgb(255,97,109)}{\textsf{■}}$$ |
| `ApplicationTheme.SupportSuccessDark` | #298267 | $$\color{rgb(41,130,103)}{\textsf{■}}$$ |
| `ApplicationTheme.SupportSuccessLight` | #E7F4E8 | $$\color{rgb(231,244,232)}{\textsf{■}}$$ |
| `ApplicationTheme.SupportSuccessMedium` | #3AC0A0 | $$\color{rgb(58,192,160)}{\textsf{■}}$$ |
| `ApplicationTheme.SupportWarningDark` | #E86339 | $$\color{rgb(232,99,57)}{\textsf{■}}$$ |
| `ApplicationTheme.SupportWarningLight` | #FFF4E4 | $$\color{rgb(255,244,228)}{\textsf{■}}$$ |
| `ApplicationTheme.SupportWarningMedium` | #FFB37C | $$\color{rgb(255,179,124)}{\textsf{■}}$$ |

https://github.com/user-attachments/assets/91a69b60-5137-4acd-8e82-9aac6cca42fa

## Text

Typography in ReactorTheme is composed of a total of 14 sizes based on 5 flavors of the Inter font:

```
//font sizes
ApplicationTheme.SizeHeading1
ApplicationTheme.SizeHeading2
ApplicationTheme.SizeHeading3
ApplicationTheme.SizeHeading4
ApplicationTheme.SizeHeading5

ApplicationTheme.SizeBodyXL
ApplicationTheme.SizeBodyL
ApplicationTheme.SizeBodyM
ApplicationTheme.SizeBodyS
ApplicationTheme.SizeBodyXS

ApplicationTheme.SizeActionL
ApplicationTheme.SizeActionM
ApplicationTheme.SizeActionS

ApplicationTheme.SizeCaptionM

//font families
ApplicationTheme.InterRegular
ApplicationTheme.InterBold
ApplicationTheme.InterSemiBold
ApplicationTheme.InterExtraBold
ApplicationTheme.InterMedium
```

Use the `Label.ThemeKey` property to select the size you need:

```csharp
Label("Aa")
    .ThemeKey(ApplicationTheme.H1)
    .TextColor(ApplicationTheme.NeutralDarkLight)
```

or directly reference the font if you want a custom definition:

```csharp
Label("Aa")
    .FontFamily(ApplicationTheme.InterRegular)
    .FontSize(ApplicationTheme.SizeBodyXL)
```

https://github.com/user-attachments/assets/4c5f8b62-bcf7-4010-91b2-5d12baa60b95

## Accordition

*An accordion allows the user to show and hide content sections.*

Sample code:

```csharp
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
```

https://github.com/user-attachments/assets/c4909f43-67a0-4a60-a3a6-b65d5f5d395b

## Button
*Buttons communicate actions users can perform by tapping them. They are typically placed where the user can take any action throughout your UI – such as in Dialogs, Forms, Banners, Cards, etc.*

Sample code:

```csharp
new ButtonKit()
    .ThemeKey(ApplicationTheme.Primary)
    .Text("Button")
    .LeftImageSource("image_left.png")
    .RightImageSource("image_right.png")
```

https://github.com/user-attachments/assets/315b1706-4f75-4686-838c-dff19a812235

## Checkbox
*A checkbox allows the user to select a value from a small set of options. It should be used when multiple options can be selected.*

```csharp
new CheckBoxKit()
    .Size(CheckBoxSize.Normal)
    .Checked(state.Value)
    .OnChecked(checkedValue => ...))
```

https://github.com/user-attachments/assets/90c8a311-9905-4e15-9e15-c6156c1c9cc7

## Content Switcher

*Content switchers allow users to switch between two or more sections. The content switcher must be placed above the content that will be affected by it.*

```csharp
new ContentSwitcherKit()
    .SelectedItemKey(selectedItemKey.Value)
    .OnSelectedItem(key => ...)
    .Items(
    [
        new ContentSwitcherItem("Section1", "Section 1"),
        new ContentSwitcherItem("Section2", "Section 2"),
        new ContentSwitcherItem("Section3", "Section 3")
    ])
```

https://github.com/user-attachments/assets/8b7565e0-ed3d-45b2-9d7c-eebd9a100bbe

## Number Input

*The Number Input is used to enter numerical values and includes controls for increasing or decreasing the value.*

```csharp
new NumberInputKit()
    .Title("Number Input")
    .Value(State.Value)
    .OnValueChanged(value => ...)
    .MinValue(0)
    .MaxValue(10)
```

https://github.com/user-attachments/assets/d16258a9-0a61-4f3c-a409-680adf6d28b7

## Radio Button

*A radio button allows the user to select a value from a small set of options. It should be used when only one option can be selected.*

```csharp
new RadioButtonKit()
    .Size(RadioButtonSize.Normal)
    .Checked(state.Value)
    .OnChecked(checkedValue => ...)
```

https://github.com/user-attachments/assets/87c961f3-955c-4c37-8108-8aad27217381

## Slider

*Sliders allow users to enter values from a range. Avoid sliders when the range is too large.*

```csharp
new SliderKit()
    .Title("Title")
    .Value(state.Value)
    .OnValueChanged(value => ...)
    .MinValue(0)
    .MaxValue(100)
    .Step(1)
```

https://github.com/user-attachments/assets/ef67efb4-0a1c-4250-adab-023621bef1a3

## Star Rating

*Star Rating is a component that allows users to give a rating of 0 to 5 on a certain topic. It is often used to measure the preference level of the user regarding some content.*

```csharp
new StarRatingKit()
    .Title("Star Rating")
    .Value(state.Value)
    .OnValueChanged(value => ...)
    .MaxValue(5)
```

https://github.com/user-attachments/assets/82ea1c11-50db-4c63-b3fd-e0aca7eda02e

## Tab

*Tabs are used to organise related content by categories. They allow the user to navigate between groups of content within the same context.*

```csharp
new TabKit()
    .SelectedItemKey(selectedItemKey.Value)
    .OnSelectedItem(key => ...)
    .Items(
    [
        new TabItem("Tab1", "Title"),
        new TabItem("Tab2", "Title"),
        new TabItem("Tab3", "Title"),
        new TabItem("Tab4", "Title"),
        new TabItem("Tab5", "Title")
    ])
```

https://github.com/user-attachments/assets/183ee7df-dc87-4c8e-be35-6ef231f055ce

## Text Area

*Text Area is a component that allows the user to enter long text. For short inputs, it is recommended to use the Text Field.*

```csharp
new TextAreaKit()
    .Title("Label")
    .Placeholder("Placeholder")
    .Text("Text Field")
    .OnTextChanged(text => ...)
```

https://github.com/user-attachments/assets/15b28996-4594-4e71-a2d8-2041e9b9e020

## Text Field

*Text Field is a component that allows the user to enter text. For long inputs, it is recommended to use the Text Area.*

```csharp
new TextFieldKit()
    .Title("Label")
    .Placeholder("Placeholder")
    .Text("Text Field")
    .OnTextChanged(text => ...)
```

https://github.com/user-attachments/assets/d33dd509-f13a-40df-b547-bed87438d499

## Toggle

*A toggle allows the user to select one of two options. The toggle must be used when the user can turn something on or off.*

```csharp
new ToggleButtonKit()
    .Checked(state.Value)
    .OnChecked(v => ...))
```
https://github.com/user-attachments/assets/2c1351cd-bcc4-41f5-be0d-5e301ff69b24

## Demo application

If you want to experiment with the kit, without creating a new application, clone the repository at https://github.com/adospace/reactor-theme, build, and run the demo application. 


# Conclusion

Even if the package already contains the fundamental components, I'm working to pair all the widgets presented in the Figma design, so stay tuned!

I hope you appreciated my contribution to the .NET MAUI July 2025 event: if you like the project, I encourage you to star it.

Adolfo Marinucci  
Full-stack software developer from sunny Italy  
https://github.com/adospace  




