using System;

namespace Sample.Core.Mediator
{
    public abstract class Colleague : IColleague
    {
        protected IMediator _mediator;

        public string Name { get; set; }

        public Colleague()
        {
            Name = Guid.NewGuid().ToString().Substring(0, 8);
        }

        protected Colleague(IMediator mediator)
        {
            _mediator = mediator;
        }

        internal void SetMediator(IMediator mediator)
        {
            _mediator = mediator;
        }

        public virtual void Send(string message)
        {
            _mediator?.Send(message, this);
        }

        public abstract void HandleNotification(IColleague colleague, string message);
    }
}
