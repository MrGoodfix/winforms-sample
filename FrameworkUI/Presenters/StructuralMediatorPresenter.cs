using FrameworkUI.Views;
using Sample.Core.Mediator;
using Sample.Core.Mediator.Structural;

namespace FrameworkUI.Presenters
{
    public class StructuralMediatorPresenter
    {
        private readonly IMediatorView _view;
        private IMediator _mediator;
        private IColleague _colleague1;
        private IColleague _colleague2;

        public StructuralMediatorPresenter(IMediatorView view)
        {
            _view = view;
            //BasicSetup();
            //ListSetup();
            MediatorCreateSetup();
        }

        private void BasicSetup()
        {
            var mediator = new StructuralMediator();

            var colleague1 = new StructuralColleague(mediator, "Colleague1");
            colleague1.OnNotification += NotifyView;
            _colleague1 = colleague1;

            var colleague2 = new StructuralColleague(mediator, "Colleague2");
            colleague2.OnNotification += NotifyView;
            _colleague2 = colleague2;

            mediator.Colleague1 = colleague1;
            mediator.Colleague2 = colleague2;

            _mediator = mediator;
        }

        private void ListSetup()
        {
            var mediator = new StructuralListMediator();

            var colleague1 = new StructuralColleague(mediator, "Colleague1");
            colleague1.OnNotification += NotifyView;
            _colleague1 = colleague1;

            var colleague2 = new StructuralColleague(mediator, "Colleague2");
            colleague2.OnNotification += NotifyView;
            _colleague2 = colleague2;

            mediator.Register(colleague1);
            mediator.Register(colleague2);

            _mediator = mediator;
        }

        private void MediatorCreateSetup()
        {
            var mediator = new StructuralListMediator();

            var c1 = mediator.CreateColleague<StructuralColleague>();
            c1.Name = "Bilbo Baggins";
            c1.OnNotification += NotifyView;
            _colleague1 = c1;

            var c2 = mediator.CreateColleague<StructuralColleague>();
            c2.Name = "Tom Bombadil";
            c2.OnNotification += NotifyView;
            _colleague2 = c2;

            _mediator = mediator;
        }

        public void StartMediating()
        {
            _colleague1.Send("Hello, World!");
            _colleague2.Send("Hi, there!");
        }

        public void NotifyView(Colleague colleague, string message)
        {
            _view.HandleNotification(message);
        }
    }
}
