# ReactorTheme

ReactorTheme is a prototyping kit for MauiReactor, providing several prebuilt components ready to use in your prototypes.

[Figma design](https://www.figma.com/community/file/1129468881607079432)

[![Nuget](https://img.shields.io/nuget/v/ReactorTheme)](https://www.nuget.org/packages/ReactorTheme) 

*Getting started*

1) Create a new MauiReactor project

2) Install the ReactorTheme package

```
dotnet add package ReactorTheme --version 1.0.0
```

3) Replace the initial application theme with an empty class deriving from the package application theme

```csharp
class MyAppApplicationTheme : ApplicationTheme
{
    protected override void OnApply()
    {
      //additional styles
    }
}
```

4) Initialize the ReactorTheme package in the MauiAppBuilder

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

## Color

https://github.com/user-attachments/assets/91a69b60-5137-4acd-8e82-9aac6cca42fa


## Text

https://github.com/user-attachments/assets/4c5f8b62-bcf7-4010-91b2-5d12baa60b95

## Accordition

https://github.com/user-attachments/assets/c4909f43-67a0-4a60-a3a6-b65d5f5d395b

## Button

https://github.com/user-attachments/assets/315b1706-4f75-4686-838c-dff19a812235

## Checkbox

https://github.com/user-attachments/assets/90c8a311-9905-4e15-9e15-c6156c1c9cc7

## Content Switcher

https://github.com/user-attachments/assets/8b7565e0-ed3d-45b2-9d7c-eebd9a100bbe

## Number Input

https://github.com/user-attachments/assets/d16258a9-0a61-4f3c-a409-680adf6d28b7

## Radio Button

https://github.com/user-attachments/assets/87c961f3-955c-4c37-8108-8aad27217381

## Slider

https://github.com/user-attachments/assets/ef67efb4-0a1c-4250-adab-023621bef1a3

## Star Rating

https://github.com/user-attachments/assets/82ea1c11-50db-4c63-b3fd-e0aca7eda02e

## Tab

https://github.com/user-attachments/assets/183ee7df-dc87-4c8e-be35-6ef231f055ce

## Text Area

https://github.com/user-attachments/assets/15b28996-4594-4e71-a2d8-2041e9b9e020

## Text Field

https://github.com/user-attachments/assets/d33dd509-f13a-40df-b547-bed87438d499

## Toggle

https://github.com/user-attachments/assets/2c1351cd-bcc4-41f5-be0d-5e301ff69b24

## More info

Please take a look at the introductory article I wrote for the .NET MAUI July 2025 event:

https://github.com/adospace/reactor-theme/blob/main/net_maui_july2025_article.md
