namespace MenuContextual
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        //private void OnCounterClicked(object sender, EventArgs e)
        //{
        //    count++;

        //    if (count == 1)
        //        CounterBtn.Text = $"Clicked {count} time";
        //    else
        //        CounterBtn.Text = $"Clicked {count} times";

        //    SemanticScreenReader.Announce(CounterBtn.Text);
        //}

        //private void MenuFlyoutItem_Clicked(object sender, EventArgs e)
        //{
        //    MenuFlyoutItem menuItem = sender as MenuFlyoutItem;
        //    string repo = menuItem.CommandParameter as string;
        //    string url = repo == "docs" ? "docs-maui" : "maui";
        //    vistaWeb.Source = new UrlWebViewSource { Url = $"https://github.com/dotnet/{url}" };
        //}

        private void MenuFlyoutItem_Clicked_1(object sender, EventArgs e)
        {

        }

        private void MenuFlyoutItem_Clicked(object sender, EventArgs e)
        {

        }

        private void MenuFlyoutItem_Clicked_2(object sender, EventArgs e)
        {

        }
    }
}