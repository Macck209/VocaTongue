namespace VocaTongue.Views.Mobile;

public partial class MobileDatabasePage : ContentPage
{
	public MobileDatabasePage()
	{
		InitializeComponent();
    }
    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MobileMenuPage());
    }
    private async void OnWordlistClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MobileWordlistPage());
    }
}