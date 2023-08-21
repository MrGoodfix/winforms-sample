using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Core.Mediator.Structural
{
    public class StructuralMediator : Mediator
    {
        public StructuralColleague Colleague1 { get; set; }
        public StructuralColleague Colleague2 { get; set; }

        public override void Send(string message, Colleague colleague)
        {
            if (colleague == Colleague1)
            {
                Colleague2.HandleNotification(message);
            }
            else
            {
                Colleague1.HandleNotification(message);
            }
        }
    }
}
