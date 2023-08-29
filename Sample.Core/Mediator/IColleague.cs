namespace Sample.Core.Mediator
{
    public interface IColleague
    {
        string Name { get; }
        void HandleNotification(IColleague colleague, string message);
        void Send(string message);
    }
}