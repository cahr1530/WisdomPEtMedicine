using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WisdomPEtMedicine.Services
{
    public interface INavigationService
    {
        Task GotoAsync (string uri);
        Task GotoAsync(string uri, IDictionary<string, object> parameters);
    }
}
