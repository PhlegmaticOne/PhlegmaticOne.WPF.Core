using PhlegmaticOne.WPF.Core.Commands.Base;

namespace PhlegmaticOne.WPF.Core.Commands;

internal class AsyncRelayGenericCommand<T> : RelayCommandBase
{
    private readonly Func<T?, Task> _action;
    private readonly Action<Exception>? _onException;
    private readonly bool _isRequired;

    internal AsyncRelayGenericCommand(Func<T?, Task> action,
        Predicate<object?>? canExecute = null,
        Action<Exception>? onException = null,
        bool isRequired = false) : base(canExecute)
    {
        _action = action ?? throw new ArgumentNullException(nameof(action));
        _onException = onException;
        _isRequired = isRequired;
    }

    public override async void Execute(object? parameter)
    {
        if (parameter is not T generic)
        {
            if (_isRequired == false)
            {
                await Invoke(default);
            }
            return;
        }

        await Invoke(generic);
    }
    private async Task Invoke(T? parameter)
    {
        SetIsExecuting(true);
        try
        {
            await _action.Invoke(parameter);
        }
        catch (Exception exception) when (_onException is not null)
        {
            _onException.Invoke(exception);
        }
        SetIsExecuting(false);
    }
}