using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WisdomPEtMedicine;
public class BindableObject : INotifyPropertyChanged
{
    public void RaisePropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public event PropertyChangedEventHandler PropertyChanged;
}
