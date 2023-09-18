using WisdomPetMedicine.DataAccess;

namespace WisdomPEtMedicine.Views;

public partial class ClientsPage : ContentPage
{
	public ClientsPage()
	{
		InitializeComponent();
        var dbContext = new WpmDbContext();
        foreach (var client in dbContext.Clients)
        {
            data.Children.Add(new Label()
            {
                Text = client.Name
            });
        }
    }
}