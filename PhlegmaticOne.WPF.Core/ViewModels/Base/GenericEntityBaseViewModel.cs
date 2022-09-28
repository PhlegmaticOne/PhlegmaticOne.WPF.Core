namespace PhlegmaticOne.WPF.Core.ViewModels.Base;

public class GenericEntityBaseViewModel<T> : BaseViewModel where T : struct
{
    public T Id { get; set; }
}
