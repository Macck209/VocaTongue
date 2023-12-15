using VocaTongue.Resources.Scripts;

namespace VocaTongue.Views.Mobile;

public partial class MobileDatabasePage : ContentPage
{
	public MobileDatabasePage()
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

            button.Clicked += (sender, e) => OnWordlistSelected(wlist);

            WordlistContainer.Children.Add(button);
        }
    }

    private async void OnWordlistSelected(WordList wlist)
    {
        await Navigation.PushAsync(new MobileWordlistPage(wlist));
    }
    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
    /*
    private async void OnWordlistClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MobileWordlistPage());
    }*/
}