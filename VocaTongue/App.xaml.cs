using VocaTongue.Views.Mobile;
using VocaTongue.Views.Desktop;
using VocaTongue.Resources.Scripts;

namespace VocaTongue
{
    public partial class App : Application
    {
        public static List<WordList> database; 
        public App()
        {
            InitializeComponent();

            database = new List<WordList>
            {
                new WordList("wordlist 1")
            };

            Page desktopPage = new DesktopMenuPage();
            Page mobilePage = new MobileMenuPage();

            // temp
            MainPage = new NavigationPage(mobilePage);

            /*
#if ANDROID || IOS
            MainPage = new NavigationPage(mobilePage);
#else
                MainPage = new NavigationPage(desktopPage);
#endif
            */
        }
    }
}
