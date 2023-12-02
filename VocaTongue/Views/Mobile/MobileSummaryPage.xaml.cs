namespace VocaTongue.Views.Mobile;

public partial class MobileSummaryPage : ContentPage
{
	public MobileSummaryPage()
	{
		InitializeComponent();
    }
    private async void OnMenuClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MobileMenuPage());
    }
}