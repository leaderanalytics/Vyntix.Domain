namespace LeaderAnalytics.Vyntix.Domain.Components;

public interface ICommandAsync<T>
{
    Task ExecuteAsync(T obj);
    bool CanExecute(object obj);
    ICommand Command { get; }
}

public interface ICommandAsync : ICommandAsync<object>
{

}
