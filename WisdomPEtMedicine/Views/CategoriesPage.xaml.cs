using WisdomPetMedicine.DataAccess;

namespace WisdomPEtMedicine.Views;

public partial class CategoriesPage : ContentPage
{
	public CategoriesPage()
	{
		InitializeComponent();
        var dbContext = new WpmDbContext();
        foreach (var category in dbContext.Categories )
        {
            data.Children.Add(new Label()
            {
                Text = category.Name
            });
        }
    }
}