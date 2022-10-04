using System.Windows.Input;

namespace PhlegmaticOne.WPF.Core.Commands;

/// <summary>
/// Contract for RelayCommands
/// </summary>
public interface IRelayCommand : ICommand
{
    void RaiseCanExecute();
}