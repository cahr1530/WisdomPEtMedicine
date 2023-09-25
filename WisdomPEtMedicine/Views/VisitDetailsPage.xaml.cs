using WisdomPEtMedicine.ViewModels;

namespace WisdomPEtMedicine.Views;

public partial class VisitDetailsPage : ContentPage, IQueryAttributable
{
	public VisitDetailsPage()
	{
		InitializeComponent();
	}
	public void ApplyQueryAttributes(IDictionary<string, object> query)
	{
		var clientId = int.Parse(query["id"].ToString());
		Title = $"Cliente: {clientId}";
		(BindingContext as VisitDetailsViewModel).ClientId = clientId;
	}
}

