namespace MauiAppMainPageAssignments
{
    public partial class MainPageSecond : ContentPage
    {
        public MainPageSecond()
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
