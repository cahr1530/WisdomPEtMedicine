using WisdomPEtMedicine.DataAccess;
using WisdomPEtMedicine.ViewModels;

namespace WisdomPEtMedicine.Views;

public partial class Productspage : ContentPage
{
	public Productspage(ProductsViewModel viewModel)
	{
		InitializeComponent();
BindingContext = viewModel;
	}
}