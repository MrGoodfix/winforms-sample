namespace Sample.Core.Mediator
{
    public interface IMediator
    {
        void Send(string message, Colleague colleague);
    }
}