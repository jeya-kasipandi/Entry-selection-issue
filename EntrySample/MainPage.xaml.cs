using Microsoft.Maui.Controls;

namespace EntrySample;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
#if MACCATALYST || IOS
        if (entry.Handler.PlatformView is Microsoft.Maui.Platform.MauiTextField macEntry)
        {
            macEntry.TintColor = UIKit.UIColor.Green;
        }
#endif
    }
}

