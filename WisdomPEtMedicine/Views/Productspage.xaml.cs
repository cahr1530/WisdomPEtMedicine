using WisdomPEtMedicine.DataAccess;

namespace WisdomPEtMedicine.Views;

public partial class Productspage : ContentPage
{
	public Productspage()
	{
		InitializeComponent();
	var dbContext = new WpmDbContext();
		products.ItemsSource = dbContext.Products;

		
        
	}
}