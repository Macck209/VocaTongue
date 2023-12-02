namespace VocaTongue.Views.Mobile;

public partial class MobileWordlistPage : ContentPage
{
	public MobileWordlistPage()
	{
		InitializeComponent();
    }
    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MobileMenuPage());
    }
}