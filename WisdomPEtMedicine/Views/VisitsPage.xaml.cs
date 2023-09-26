using WisdomPEtMedicine.ViewModels;

namespace WisdomPEtMedicine.Views;

public partial class VisitsPage : ContentPage
{

    public VisitsPage(VisitsViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }


}
