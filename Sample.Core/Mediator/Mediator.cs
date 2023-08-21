using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Core.Mediator
{
    public abstract class Mediator
    {
        public abstract void Send(string message, Colleague colleague);
    }
}
