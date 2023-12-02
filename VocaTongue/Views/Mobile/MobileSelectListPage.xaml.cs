namespace VocaTongue.Views.Mobile;

public partial class MobileSelectListPage : ContentPage
{
	public MobileSelectListPage()
	{
		InitializeComponent();

        for (int i = 0; i < 10; i++)
        {
            var button = new Button
            {
                Text = $"Button {i + 1}",
                Margin = new Thickness(5),
                WidthRequest = 100,
            };

            WordlistContainer.Children.Add(button);
        }
    }
    private async void OnStartClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MobilePlayPage());
    }
    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MobileMenuPage());
    }
    private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
    {
        //TODO
        WordlistContainer.TranslationX = -e.NewValue;
    }
}