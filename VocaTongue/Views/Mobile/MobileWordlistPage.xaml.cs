using VocaTongue.Resources.Scripts;

namespace VocaTongue.Views.Mobile;

public partial class MobileWordlistPage : ContentPage
{
	public MobileWordlistPage(WordList wlist)
	{
		InitializeComponent();
        WordlistName.Text = wlist.Name;

        foreach (Flashcard fcard in wlist.Flashcards)
        {
            var button = new Button
            {
                Text = $"{fcard.Word} - {fcard.Translation}",
                BackgroundColor = Color.FromArgb("#F28D6A"),
                TextColor = Color.FromArgb("#F0F3EE"),
                FontSize = 24,
                FontFamily = "BalooRegular",
                CornerRadius = 100,
                Margin = new Thickness(8),
                WidthRequest = FlashcardContainer.Width,
            };

            button.Shadow = new Shadow
            {
                Brush = Colors.Black,
                Offset = new Point(0, 4),
                Opacity = 0.25f,
            };

            FlashcardContainer.Children.Add(button);
        }
    }
    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}