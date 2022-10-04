using PhlegmaticOne.WPF.Core.Commands.Base;

namespace PhlegmaticOne.WPF.Core.Commands;

internal class RelayGenericCommand<T> : RelayCommandBase
{
    private readonly Action<T?> _action;
    private readonly bool _isRequired;

    internal RelayGenericCommand(Action<T?> action,
        Predicate<object?> canExecute,
        bool isRequired = false) : base(canExecute)
    {
        _action = action;
        _isRequired = isRequired;
    }
    public override void Execute(object? parameter)
    {
        if (parameter is not T && _isRequired )
        {
            return;
        }
        var generic = (T)parameter!;

        SetIsExecuting(true);
        _action.Invoke(generic);
        SetIsExecuting(false);
    }
}