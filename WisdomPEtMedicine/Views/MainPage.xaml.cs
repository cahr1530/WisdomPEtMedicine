using System.Drawing;
using WisdomPetMedicine.DataAccess;

namespace WisdomPEtMedicine.Views
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
            var dbContext = new WpmDbContext();
            categories.Text = dbContext.Categories.Count().ToString();
            products.Text = dbContext.Products.Count().ToString();
            clients.Text = dbContext.Clients.Count().ToString();
        }
  
    }
}