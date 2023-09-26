using WisdomPEtMedicine.ViewModels;

namespace WisdomPEtMedicine.Views;

public partial class VisitDetailsPage : ContentPage
{
	public VisitDetailsPage(VisitDetailsViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}

