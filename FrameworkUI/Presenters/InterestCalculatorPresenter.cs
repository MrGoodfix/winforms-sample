using System.Collections.Generic;
using System.Text;
using Sample.Core.Interest;

namespace FrameworkUI.Presenters
{
    public class InterestCalculatorPresenter : IInterestCalculatorPresenter
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
                _view.HandleNotification(FormatErrors(response.Error));
            }
        }

        private string FormatErrors(List<string> errors)
        {
            var builder = new StringBuilder();
            builder.AppendLine("Bad show!");
            foreach (var failure in errors)
            {
                builder.AppendLine(failure);
            }

            return builder.ToString();
        }
    }
}
