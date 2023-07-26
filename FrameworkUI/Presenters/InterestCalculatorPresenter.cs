
using Sample.Core.Interest;
using Sample.Core.Views;
using System.Collections.Generic;
using System.Text;

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

        public void Calculate(InterestForecastRequest request)
        {
            var response = _forecastHandler.Forecast(request);
            if (response.IsSuccess)
            {
                _view.DisplayForecasts(response.Value);
            }
            else
            {
                _view.DisplayForecasts(new List<BalanceForecast>());
                var builder = new StringBuilder();
                builder.AppendLine("Bad show!");
                foreach (var failure in response.Error)
                {
                    builder.AppendLine(failure);
                }
                _view.HandleNotification(builder.ToString());
            }
        }
    }
}
