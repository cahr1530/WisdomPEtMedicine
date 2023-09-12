using WisdomPetMedicine.DataAccess;

namespace WisdomPEtMedicine
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();

        }
        private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
           await DisplayAlert("mensaje","Tap","Ok","Cancelar");
        }
    }
}