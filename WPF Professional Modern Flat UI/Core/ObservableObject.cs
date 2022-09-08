using System.ComponentModel;
using System.Runtime.CompilerServices;
using WPF_Professional_Modern_Flat_UI.Annotations;

namespace WPF_Professional_Modern_Flat_UI.Core;

public class ObservableObject: INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    [NotifyPropertyChangedInvocator]
    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}