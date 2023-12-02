namespace VocaTongue.Views.Mobile;

public partial class MobileMenuPage : ContentPage
{
	public MobileMenuPage()
	{
		InitializeComponent();
    }

    private async void OnSettingsClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MobileSettingsPage());
    }
    private async void OnDatabaseClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MobileDatabasePage());
    }
    private async void OnTrainClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MobileSelectListPage());
    }

}
