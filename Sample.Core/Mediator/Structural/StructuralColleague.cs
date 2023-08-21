using System;

namespace Sample.Core.Mediator.Structural
{
    public delegate void ColleagueNotificationHandler(Colleague colleague, string message);

    public class StructuralColleague : Colleague
    {
        public string Name { get; }

        public event ColleagueNotificationHandler OnNotification;

        public StructuralColleague(Mediator mediator, string name) : base(mediator)
        {
            Name = name;
        }

        public override void HandleNotification(string message)
        {
            RaiseNotification($"Colleague {Name} received notification: {message}");
        }

        public void RaiseNotification(string message)
        {
            if (OnNotification != null)
            {
                OnNotification(this, message);
            }
        }
    }
}
