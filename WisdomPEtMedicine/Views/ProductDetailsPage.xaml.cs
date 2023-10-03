using WisdomPEtMedicine.DataAccess;
using WisdomPEtMedicine.ViewModels;

namespace WisdomPEtMedicine.Views;

public partial class ProductDetailsPage : ContentPage
{

    public ProductDetailsPage(ProductDetailsViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
  
}
