using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WisdomPEtMedicine.Services
{
    public interface INavigationService
    {
        Task GotoAsync (string route);
        Task GotoAsync(string route, IDictionary<string, object> parameters);
    }
}
