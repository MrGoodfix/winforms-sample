namespace Sample.Core.Mediator
{
    public abstract class Mediator : IMediator
    {
        public abstract void Send(string message, Colleague colleague);
    }
}
