﻿using PhlegmaticOne.WPF.Core.Commands.Base;

namespace PhlegmaticOne.WPF.Core.Commands;

internal class AsyncRelayEmptyCommand : RelayCommandBase
{
    private readonly Func<Task> _action;
    private readonly Action<Exception>? _onException;

    internal AsyncRelayEmptyCommand(Func<Task> action, 
        Predicate<object?>? canExecute = null,
        Action<Exception>? onException = null) : base(canExecute)
    {
        _action = action ?? throw new ArgumentNullException(nameof(action));
        _onException = onException;
    }

    public override async void Execute(object? parameter)
    {
        SetIsExecuting(true);
        try
        {
            await _action.Invoke();
        }
        catch (Exception exception) when (_onException is not null)
        {
            _onException.Invoke(exception);
        }
        SetIsExecuting(false);
    }
}
