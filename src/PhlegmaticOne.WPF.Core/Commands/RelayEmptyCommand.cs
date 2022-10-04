using PhlegmaticOne.WPF.Core.Commands.Base;

namespace PhlegmaticOne.WPF.Core.Commands;

internal class RelayEmptyCommand : RelayCommandBase
{
    private readonly Action _action;
    public RelayEmptyCommand(Action action, Predicate<object?> canExecute) : base(canExecute)
    {
        _action = action;
    }

    public override void Execute(object? parameter)
    {
        SetIsExecuting(true);
        _action?.Invoke();
        SetIsExecuting(false);
    }
}
