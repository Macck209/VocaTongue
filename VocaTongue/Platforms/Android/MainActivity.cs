using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;
using AndroidX.Core.View;

namespace VocaTongue
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Window.AddFlags(WindowManagerFlags.Fullscreen);

#pragma warning disable CA1422 // Walidacja zgodności z platformą
            Window.DecorView.SystemUiVisibility = (StatusBarVisibility)
    (SystemUiFlags.ImmersiveSticky | SystemUiFlags.HideNavigation |
     SystemUiFlags.Fullscreen | SystemUiFlags.Immersive);
#pragma warning restore CA1422 // Walidacja zgodności z platformą

            Window.SetStatusBarColor(Android.Graphics.Color.Transparent);
        }

    }
}