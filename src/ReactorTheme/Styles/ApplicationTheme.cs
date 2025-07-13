using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiReactor;
using MauiReactor.Shapes;

namespace ReactorTheme.Styles;

public class ApplicationTheme : Theme
{
    public static Color HighlightDarkest { get; } = new Color(0, 111, 253, 255);
    public static Color HighlightDark { get; } = new Color(40, 151, 255, 255);
    public static Color HighlightMedium { get; } = new Color(111, 186, 255, 255);
    public static Color HighlightLight { get; } = new Color(180, 219, 255, 255);
    public static Color HighlightLightest { get; } = new Color(234, 242, 255, 255);
    public static Color NeutralLightDarkest { get; } = new Color(197, 198, 204, 255);
    public static Color NeutralLightDark { get; } = new Color(212, 214, 221, 255);
    public static Color NeutralLightMedium { get; } = new Color(232, 233, 241, 255);
    public static Color NeutralLightLight { get; } = new Color(248, 249, 254, 255);
    public static Color NeutralLightLightest { get; } = new Color(255, 255, 255, 255);
    public static Color NeutralDarkDarkest { get; } = new Color(31, 32, 36, 255);
    public static Color NeutralDarkDark { get; } = new Color(47, 48, 54, 255);
    public static Color NeutralDarkMedium { get; } = new Color(73, 74, 80, 255);
    public static Color NeutralDarkLight { get; } = new Color(113, 114, 122, 255);
    public static Color NeutralDarkLightest { get; } = new Color(143, 144, 152, 255);
    public static Color SupportSuccessDark { get; } = new Color(41, 130, 103, 255);
    public static Color SupportSuccessMedium { get; } = new Color(58, 192, 160, 255);
    public static Color SupportSuccessLight { get; } = new Color(231, 244, 232, 255);
    public static Color SupportWarningDark { get; } = new Color(232, 99, 57, 255);
    public static Color SupportWarningMedium { get; } = new Color(255, 179, 124, 255);
    public static Color SupportWarningLight { get; } = new Color(255, 244, 228, 255);
    public static Color SupportErrorDark { get; } = new Color(237, 50, 65, 255);
    public static Color SupportErrorMedium { get; } = new Color(255, 97, 109, 255);
    public static Color SupportErrorLight { get; } = new Color(255, 226, 229, 255);

    public static double SizeHeading1 { get; } = 24;
    public static double SizeHeading2 { get; } = 18;
    public static double SizeHeading3 { get; } = 16;
    public static double SizeHeading4 { get; } = 14;
    public static double SizeHeading5 { get; } = 12;


    public static double SizeBodyXL { get; } = 18;
    public static double SizeBodyL { get; } = 16;
    public static double SizeBodyM { get; } = 14;
    public static double SizeBodyS { get; } = 12;
    public static double SizeBodyXS { get; } = 10;

    public static double SizeActionL { get; } = 14;
    public static double SizeActionM{ get; } = 12;
    public static double SizeActionS { get; } = 10;

    public static double SizeCaptionM { get; } = 10;


    public readonly static string Primary = nameof(Primary);
    public readonly static string Secondary = nameof(Secondary);
    public readonly static string Terciary = nameof(Terciary);


    public readonly static string H1 = nameof(H1);
    public readonly static string H2 = nameof(H2);
    public readonly static string H3 = nameof(H3);
    public readonly static string H4 = nameof(H4);
    public readonly static string H5 = nameof(H5);

    public readonly static string BodyXL = nameof(BodyXL);
    public readonly static string BodyL = nameof(BodyL);
    public readonly static string BodyM = nameof(BodyM);
    public readonly static string BodyS = nameof(BodyS);
    public readonly static string BodyXS = nameof(BodyXS);

    public readonly static string ActionL = nameof(ActionL);
    public readonly static string ActionM = nameof(ActionM);
    public readonly static string ActionS = nameof(ActionS);

    public readonly static string CaptionM = nameof(CaptionM);


    public readonly static string InterRegular = nameof(InterRegular);
    public readonly static string InterBold = nameof(InterBold);
    public readonly static string InterSemiBold = nameof(InterSemiBold);
    public readonly static string InterExtraBold = nameof(InterExtraBold);
    public readonly static string InterMedium = nameof(InterMedium);



    protected override void OnApply()
    {
        LabelStyles.Default = _ => _
            .FontFamily(InterRegular)
            .TextColor(NeutralDarkDarkest);

        LabelStyles.Themes[H1] = _ => _
            .FontFamily(InterExtraBold)
            .TextColor(NeutralDarkDarkest)
            .FontSize(SizeHeading1);

        LabelStyles.Themes[H2] = _ => _
            .FontFamily(InterExtraBold)
            .TextColor(NeutralDarkDarkest)
            .FontSize(SizeHeading2);

        LabelStyles.Themes[H3] = _ => _
            .FontFamily(InterExtraBold)
            .TextColor(NeutralDarkDarkest)
            .FontSize(SizeHeading3);

        LabelStyles.Themes[H4] = _ => _
            .FontFamily(InterBold)
            .TextColor(NeutralDarkDarkest)
            .FontSize(SizeHeading4);

        LabelStyles.Themes[H4] = _ => _
            .FontFamily(InterBold)
            .TextColor(NeutralDarkDarkest)
            .FontSize(SizeHeading4);

        LabelStyles.Themes[H5] = _ => _
            .FontFamily(InterBold)
            .TextColor(NeutralDarkDarkest)
            .FontSize(SizeHeading5);

        LabelStyles.Themes[BodyXL] = _ => _
            .FontFamily(InterRegular)
            .TextColor(NeutralDarkDarkest)
            .FontSize(SizeBodyXL);

        LabelStyles.Themes[BodyL] = _ => _
            .FontFamily(InterRegular)
            .FontSize(SizeBodyL);

        LabelStyles.Themes[BodyM] = _ => _
            .FontFamily(InterRegular)
            .TextColor(NeutralDarkDarkest)
            .FontSize(SizeBodyM);

        LabelStyles.Themes[BodyS] = _ => _
            .FontFamily(InterRegular)
            .TextColor(NeutralDarkDarkest)
            .FontSize(SizeBodyS);

        LabelStyles.Themes[BodyXS] = _ => _
            .FontFamily(InterMedium)
            .FontSize(SizeBodyXS);

        LabelStyles.Themes[ActionL] = _ => _
            .FontFamily(InterSemiBold)
            .TextColor(NeutralDarkDarkest)
            .FontSize(SizeActionL);

        LabelStyles.Themes[ActionM] = _ => _
            .FontFamily(InterSemiBold)
            .TextColor(NeutralDarkDarkest)
            .FontSize(SizeActionM);

        LabelStyles.Themes[ActionS] = _ => _
            .FontFamily(InterSemiBold)
            .TextColor(NeutralDarkDarkest)
            .FontSize(SizeActionS);

        LabelStyles.Themes[CaptionM] = _ => _
            .FontFamily(InterSemiBold)
            .TextColor(NeutralDarkDarkest)
            .FontSize(SizeCaptionM);

        ButtonStyles.Default = _ => _
            .FontFamily(InterSemiBold)
            .TextColor(NeutralLightLightest)
            .BackgroundColor(HighlightDarkest)
            .FontSize(SizeCaptionM)
            .CornerRadius(12)
            .Padding(16, 12.5)
            .Height(40);

        ButtonStyles.Themes[Primary] = _ => _
            .FontFamily(InterSemiBold)
            .TextColor(NeutralLightLightest)
            .BackgroundColor(HighlightDarkest)
            .FontSize(SizeCaptionM)
            .CornerRadius(12)
            .Padding(16, 12.5)
            .Height(40);

        ButtonStyles.Themes[Secondary] = _ => _
            .FontFamily(InterSemiBold)
            .TextColor(HighlightDarkest)
            .BackgroundColor(NeutralLightLightest)
            .BorderColor(HighlightDarkest)
            .BorderWidth(1)
            .FontSize(SizeCaptionM)
            .CornerRadius(12)
            .Padding(16, 12.5)
            .Height(40);

        ButtonStyles.Themes[Terciary] = _ => _
            .FontFamily(InterSemiBold)
            .TextColor(HighlightDarkest)
            .BackgroundColor(NeutralLightLightest)
            .BorderWidth(0)
            .FontSize(SizeCaptionM)
            .CornerRadius(12)
            .Padding(16, 12.5)
            .Height(40);


        EntryStyles.Default = _ => _
            .FontFamily(InterRegular)
            .TextColor(NeutralDarkDarkest)
            .BackgroundColor(NeutralLightLightest)
            .FontSize(SizeBodyM)
            ;

        ContentPageStyles.Default = _ => _
            .BackgroundColor(NeutralLightLightest);
    }
}
