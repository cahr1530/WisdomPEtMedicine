using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WisdomPEtMedicine.DataAccess;

namespace WisdomPEtMedicine.ViewModels;

public partial class ClientsViewModel: ViewModelBase
{
    [ObservableProperty]
    ObservableCollection<Client> clients;

    [ObservableProperty]
    Client selectedClient;  
    public ClientsViewModel()
    {
        var db = new WpmDbContext();
        Clients = new ObservableCollection<Client>(db.Clients);
    }
}
