using VocaTongue.Views.Mobile;
using VocaTongue.Views.Desktop;

namespace VocaTongue
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Page desktopPage = new DesktopMenuPage();
            Page mobilePage = new MobileMenuPage();

#if ANDROID || IOS
            MainPage = new NavigationPage(mobilePage);
#else
                MainPage = new NavigationPage(desktopPage);
#endif
        }
    }
}
