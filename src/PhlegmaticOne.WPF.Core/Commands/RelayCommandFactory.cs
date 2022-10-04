namespace PhlegmaticOne.WPF.Core.Commands;

/// <summary>
/// Creates different relay commands
/// </summary>
public static class RelayCommandFactory
{
    /// <summary>
    /// Creates command with no arguments in executing method
    /// </summary>
    /// <param name="action">Executing method delegate</param>
    /// <param name="canExecute">Can execute command predicate</param>
    /// <returns>Relay command</returns>
    public static IRelayCommand CreateEmptyCommand(Action action,
        Predicate<object?>? canExecute = null) => 
        new RelayEmptyCommand(action, canExecute);

    /// <summary>
    /// Creates command with Object argument in executing method
    /// </summary>
    /// <param name="action">Executing method delegate</param>
    /// <param name="canExecute">Can execute command predicate</param>
    /// <returns>Relay command</returns>
    public static IRelayCommand CreateCommand(Action<object?> action,
        Predicate<object?>? canExecute = null) => 
        new RelayGenericCommand<object>(action, canExecute);

    /// <summary>
    /// Creates command with generic T argument that can be null in executing method
    /// </summary>
    /// <typeparam name="T">Argument in executing method type</typeparam>
    /// <param name="action">Executing method delegate</param>
    /// <param name="canExecute">Can execute command predicate</param>
    /// <returns>Relay command</returns>
    public static IRelayCommand CreateCommand<T>(Action<T?> action, 
        Predicate<object?>? canExecute = null) => 
        new RelayGenericCommand<T>(action, canExecute);

    /// <summary>
    /// Creates command with generic T argument in executing method. Method will be called only if passing argument is of type T
    /// </summary>
    /// <typeparam name="T">Argument in executing method type</typeparam>
    /// <param name="action">Executing method delegate</param>
    /// <param name="canExecute">Can execute command predicate</param>
    /// <returns>Relay command</returns>
    public static IRelayCommand CreateRequiredParameterCommand<T>(Action<T> action,
        Predicate<object?>? canExecute = null) =>
        new RelayGenericCommand<T>(action, canExecute, true);

    /// <summary>
    /// Creates command with no arguments in executing method. Method is asynchronous
    /// </summary>
    /// <param name="action">Executing method delegate</param>
    /// <param name="canExecute">Can execute command predicate</param>
    /// <param name="onException">Method that will be called if exception in executing method will be occured</param>
    /// <returns>Relay command</returns>
    public static IRelayCommand CreateEmptyAsyncCommand(Func<Task> action,
        Predicate<object?>? canExecute = null,
        Action<Exception>? onException = null) =>
        new AsyncRelayEmptyCommand(action, canExecute, onException);

    /// <summary>
    /// Creates command with Object argument in executing method. Method is asynchronous
    /// </summary>
    /// <param name="action">Executing method delegate</param>
    /// <param name="canExecute">Can execute command predicate</param>
    /// <param name="onException">Method that will be called if exception in executing method will be occured</param>
    /// <returns>Relay command</returns>
    public static IRelayCommand CreateAsyncCommand(Func<object?, Task> action,
        Predicate<object?>? canExecute = null,
        Action<Exception>? onException = null) => 
        new AsyncRelayGenericCommand<object>(action, canExecute, onException);

    /// <summary>
    /// Creates command with generic T argument in executing method. Method is asynchronous
    /// </summary>
    /// <typeparam name="T">Argument in executing method type</typeparam>
    /// <param name="action">Executing method delegate</param>
    /// <param name="canExecute">Can execute command predicate</param>
    /// <param name="onException">Method that will be called if exception in executing method will be occured</param>
    /// <returns>Relay command</returns>
    public static IRelayCommand CreateAsyncCommand<T>(Func<T?, Task> action, 
        Predicate<object?>? canExecute = null,
        Action<Exception>? onException = null) =>
        new AsyncRelayGenericCommand<T>(action, canExecute, onException);

    /// <summary>
    /// Creates command with generic T argument in executing method. Method is asynchronous. Method will be called only if passing argument is of type T
    /// </summary>
    /// <typeparam name="T">Argument in executing method type</typeparam>
    /// <param name="action">Executing method delegate</param>
    /// <param name="canExecute">Can execute command predicate</param>
    /// <param name="onException">Method that will be called if exception in executing method will be occured</param>
    /// <returns>Relay command</returns>
    public static IRelayCommand CreateRequiredParameterAsyncCommand<T>(Func<T, Task> action,
        Predicate<object?>? canExecute = null,
        Action<Exception>? onException = null) =>
        new AsyncRelayGenericCommand<T>(action, canExecute, onException, true);
}