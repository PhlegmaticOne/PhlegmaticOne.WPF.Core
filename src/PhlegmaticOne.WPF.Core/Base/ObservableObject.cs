using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PhlegmaticOne.WPF.Core.Base;

/// <summary>
/// Base object for Models and ViewModels that implements INotifyPropertyChanged
/// </summary>
public class ObservableObject : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    [NotifyPropertyChangedInvocator]
    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}