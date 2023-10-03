using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Collections.ObjectModel;
using System.ComponentModel;
using WisdomPEtMedicine.DataAccess;
using WisdomPEtMedicine.Services;
using WisdomPEtMedicine.Views;

namespace WisdomPEtMedicine.ViewModels;

public partial class VisitsViewModel : ViewModelBase
{
    [ObservableProperty]
    private int remainingVisits;

 
     [ObservableProperty]
    private ObservableCollection<Client> clients;


    [ObservableProperty]
    private Client selectedClient;
    private readonly INavigationService navigationService;

   

    public VisitsViewModel(INavigationService navigationService)
    {
        var db = new WpmDbContext();
        Clients = new ObservableCollection<Client>(db.Clients);
        PropertyChanged += VisitsData_PropertyChanged;
        this.navigationService = navigationService;
    }

    private async void VisitsData_PropertyChanged(object sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(SelectedClient))
        {
            var uri = $"{nameof(VisitDetailsPage)}?id={SelectedClient.Id}";
      await navigationService.GoToAsync(uri);
        }
    }

}