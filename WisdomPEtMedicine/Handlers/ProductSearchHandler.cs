using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WisdomPEtMedicine.DataAccess;
using WisdomPEtMedicine.Views;

namespace WisdomPEtMedicine.Handlers
{
    public class ProductSearchHandler: SearchHandler
    {
        WpmDbContext db;
        public ProductSearchHandler()
        {
             db=new WpmDbContext();
        }
        protected override void OnQueryChanged(string oldValue, string newValue)
        {
           if(string.IsNullOrWhiteSpace (newValue))
            {
                ItemsSource = null;
                return;
            }
            else
            {
                ItemsSource = db.Products.Where(p => p.Name.ToLowerInvariant().Contains(newValue.ToLower())).ToList();
            }
            
        }

        protected async override void OnItemSelected(object item)
        {
           await Shell.Current.GoToAsync($"{nameof(ProductDetailsPage)}?id={((Product)item).Id}");
        }
    }
}
