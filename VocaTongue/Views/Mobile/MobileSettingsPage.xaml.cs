namespace VocaTongue.Views.Mobile;

public partial class MobileSettingsPage : ContentPage
{
    int count = 60;
    bool soundsOn = true;
    public MobileSettingsPage()
	{
		InitializeComponent();

        count = Preferences.Get("TrainingTime", 60);
        soundsOn = Preferences.Get("SoundsOn", true);

        TrainingTimeBtn.Text = count.ToString();
        SoundsToggle.IsToggled = soundsOn;
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
        Preferences.Set("TrainingTime", count);
        Preferences.Set("SoundsOn", soundsOn);
        await Navigation.PopAsync();
    }
    private void OnTrainingTimeClicked(object sender, EventArgs e)
    {
        count+=15;

        if (count > 151) {count = 15;}
        TrainingTimeBtn.Text = count.ToString();

        SemanticScreenReader.Announce(TrainingTimeBtn.Text);
    }
    private void OnSoundsToggled(object sender, EventArgs e)
    {
        soundsOn = !soundsOn;
    }
}