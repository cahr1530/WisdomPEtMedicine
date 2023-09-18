namespace WisdomPEtMedicine
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        private async void MenuItem_Clicked(object sender, EventArgs e)
        {
           await Browser.Default.OpenAsync("https://www.wisdompetmed.com/",BrowserLaunchMode.SystemPreferred);
        }
    }
}