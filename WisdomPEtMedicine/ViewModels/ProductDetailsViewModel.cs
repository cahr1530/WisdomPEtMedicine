using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WisdomPEtMedicine.DataAccess;

namespace WisdomPEtMedicine.ViewModels;

public partial class ProductDetailsViewModel : ViewModelBase, IQueryAttributable
{
    [ObservableProperty]
    string name;

    [ObservableProperty]
    string description;

    [ObservableProperty]
    decimal price;
    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        var dbContext = new WpmDbContext();
        var product = dbContext.Products.First(p => p.Id == int.Parse(query["id"].ToString()));
        Name = product.Name;
        Description = product.Description;
        Price = product.Price;
    }
}
