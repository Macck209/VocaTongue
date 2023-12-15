namespace VocaTongue.Views.Mobile;

public partial class MobilePlayPage : ContentPage
{
	public MobilePlayPage()
	{
		InitializeComponent();
    }
    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}