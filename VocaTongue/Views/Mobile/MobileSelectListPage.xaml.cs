using VocaTongue.Resources.Scripts;

namespace VocaTongue.Views.Mobile;

public partial class MobileSelectListPage : ContentPage
{
    public MobileSelectListPage()
	{
		InitializeComponent();

        foreach (WordList wlist in App.database)
        {
            var button = new Button
            {
                Text = $"{wlist.Name}",
                BackgroundColor = Color.FromArgb("#F28D6A"),
                TextColor = Color.FromArgb("#F0F3EE"),
                FontSize = 24,
                FontFamily = "BalooRegular",
                CornerRadius = 100,
                Margin = new Thickness(8),
                WidthRequest = WordlistContainer.Width,
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
        await Navigation.PopAsync();
    }
}