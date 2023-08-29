using System.Collections.Generic;
using System.Linq;

namespace Sample.Core.Mediator.Structural
{
    public class StructuralListMediator : Mediator
    {
        private List<Colleague> _colleagues = new List<Colleague>();

        public void Register(Colleague colleague)
        {
            colleague.SetMediator(this);
            _colleagues.Add(colleague);
        }

        public T CreateColleague<T>() where T : Colleague, new()
        {
            var colleague = new T();
            colleague.SetMediator(this);
            _colleagues.Add(colleague);
            return colleague;
        }

        public override void Send(string message, Colleague colleague)
        {
            _colleagues.Where(c => c != colleague).ToList()
                .ForEach(c => c.HandleNotification(colleague, message));
        }
    }
}
