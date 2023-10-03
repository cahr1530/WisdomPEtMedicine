using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WisdomPEtMedicine.Services
{
    public class NavigationService : INavigationService
    {
        public Task GoToAsync(string route)
        {
          return   Shell.Current.GoToAsync(route);
        }

        public Task GoToAsync(string route, IDictionary<string, object> parameters)
        {

            return Shell.Current.GoToAsync(route,parameters);
        }
    }
}
