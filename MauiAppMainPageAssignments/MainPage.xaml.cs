namespace MauiAppMainPageAssignments
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            if (App.Current is App app)
            {
                app.NavigateSecond();
            }
        }
    }

}
