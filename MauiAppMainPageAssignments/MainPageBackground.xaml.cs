namespace MauiAppMainPageAssignments
{
    public partial class MainPageBackground : ContentPage
    {
        public MainPageBackground()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            if (App.Current is App app)
            {
                app.NavigateFirst();
            }
        }
    }

}
