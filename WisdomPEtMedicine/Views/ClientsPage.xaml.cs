using WisdomPEtMedicine.DataAccess;
using WisdomPEtMedicine.ViewModels;

namespace WisdomPEtMedicine.Views;

public partial class ClientsPage : ContentPage
{
	public ClientsPage(ClientsViewModel viewModel)
	{
		InitializeComponent();
       BindingContext = viewModel;
       
    }
}