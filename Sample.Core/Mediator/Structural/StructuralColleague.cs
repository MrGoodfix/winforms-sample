namespace Sample.Core.Mediator.Structural
{
    public delegate void ColleagueNotificationHandler(Colleague colleague, string message);

    public class StructuralColleague : Colleague
    {
        public event ColleagueNotificationHandler OnNotification;

        public StructuralColleague(IMediator mediator, string name) : base(mediator) 
        { 
            Name = name;
        }

        public StructuralColleague()
        {
            
        }

        public override void HandleNotification(IColleague colleague, string message)
        {
            RaiseNotification($"Colleague {Name} received notification from {colleague.Name}: {message}");
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
