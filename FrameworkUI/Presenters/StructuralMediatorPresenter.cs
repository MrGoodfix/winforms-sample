using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrameworkUI.Views;
using Sample.Core.Mediator;
using Sample.Core.Mediator.Structural;

namespace FrameworkUI.Presenters
{
    public class StructuralMediatorPresenter
    {
        private readonly IMediatorView _view;
        private readonly StructuralMediator _mediator;
        private readonly StructuralColleague _colleague1;
        private readonly StructuralColleague _colleague2;

        public StructuralMediatorPresenter(IMediatorView view)
        {
            _view = view;
            _mediator = new StructuralMediator();
            _colleague1 = new StructuralColleague(_mediator, "Colleague1");
            _colleague1.OnNotification += NotifyView;
            _colleague2 = new StructuralColleague(_mediator, "Colleague2");
            _colleague2.OnNotification += NotifyView;
            _mediator.Colleague1 = _colleague1;
            _mediator.Colleague2 = _colleague2;
        }

        public void StartMediating()
        {
            _colleague1.Send("Hello, World! (from Colleague1)");
            _colleague2.Send("Hi, there! (from Colleague2)");
        }

        public void NotifyView(Colleague colleague, string message)
        {
            _view.HandleNotification(message);
        }
    }
}
