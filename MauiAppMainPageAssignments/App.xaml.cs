namespace MauiAppMainPageAssignments
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        public void NavigateFirst()
        {
            MainPage = new NavigationPage(new MainPage());
        }

        public void NavigateSecond()
        {
            MainPage = new NavigationPage(new MainPageSecond());
        }

        public void NavigateBackground()
        {
            MainPage = new NavigationPage(new MainPageBackground());
        }

        protected override void OnResume()
        {
            base.OnResume();
            NavigateBackground();
        }
    }
}
