using PhlegmaticOne.WPF.Core.Commands.Constants;

namespace PhlegmaticOne.WPF.Core.Commands.Base;

internal abstract class RelayCommandBase : IRelayCommand
{
    private readonly Predicate<object?> _canExecute;

    protected bool IsExecuting;

    internal RelayCommandBase(Predicate<object?>? canExecute) => _canExecute = canExecute ?? Predicates.True;

    public event EventHandler? CanExecuteChanged;

    public bool CanExecute(object? parameter) => !IsExecuting && _canExecute.Invoke(parameter);

    public abstract void Execute(object? parameter);

    public void RaiseCanExecute() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);

    protected void SetIsExecuting(bool value)
    {
        IsExecuting = value;
        RaiseCanExecute();
    }
}
