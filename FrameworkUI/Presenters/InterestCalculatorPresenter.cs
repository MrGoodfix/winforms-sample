using Sample.Core.Interest;
using Sample.Core.Views;
using System.Collections.Generic;

namespace FrameworkUI.Presenters
{
    public class InterestCalculatorPresenter
    {
        private readonly IInterestCalculatorView _view;
        private readonly IInterestForecastHandler _forecastHandler;

        public InterestCalculatorPresenter(IInterestCalculatorView view)
        {
            _view = view;
            _forecastHandler = Program.GetService<IInterestForecastHandler>();
        }

        public List<BalanceForecast> Calculate(InterestForecastRequest request)
        {
            return _forecastHandler.Calculate(request);
        }
    }
}
