using WisdomPEtMedicine.DataAccess;

namespace WisdomPEtMedicine.Views;

public partial class Productspage : ContentPage
{
	public Productspage()
	{
		InitializeComponent();
		var dbContext = new WpmDbContext();
		foreach (var product in dbContext.Products)
		{
			var btn=new Button() { Text = product.Name };
			btn.Clicked += async (s, a) =>
			{
				var uri = $"{nameof(ProductDetailsPage)}?id={product.Id}";
				await Shell.Current.GoToAsync(uri);
			};
            data.Children.Add(btn);
        }
	}
}