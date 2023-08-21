using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Core.Mediator
{
    public abstract class Colleague
    {
        protected Mediator _mediator;

        protected Colleague(Mediator mediator)
        {
            _mediator = mediator;
        }

        public virtual void Send(string message)
        {
            _mediator.Send(message, this);
        }

        public abstract void HandleNotification(string message);


    }
}
