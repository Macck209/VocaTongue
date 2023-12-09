using VocaTongue.Resources.Scripts;

namespace VocaTongue.Views.Mobile;

public partial class MobileSelectListPage : ContentPage
{
    public MobileSelectListPage()
	{
		InitializeComponent();

        for (int i = 1; i <= 5; i++) // (WordList wlist in App.database)
        {
            var button = new Button
            {
                Text = $"button {i}",
                BackgroundColor = Color.FromArgb("#F28D6A"),
                TextColor = Color.FromArgb("#F0F3EE"),
                FontSize = 24,
                FontFamily = "BalooRegular",
                CornerRadius = 100,
                Margin = new Thickness(8),
                WidthRequest = 100, // WordlistContainer.Width * 0.9f
            };

            button.Shadow = new Shadow
            {
                Brush = Colors.Black,
                Offset = new Point(0, 4),
                Opacity = 0.25f,
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
}