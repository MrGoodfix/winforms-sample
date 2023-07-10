
using Sample.Core.Interest;
using Sample.Core.Views;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

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

            var result = _forecastHandler.Calculate(request);

            if (result.Errors.Count > 0)
            {
                var builder = new StringBuilder();
                builder.AppendLine("Invalid input!");
                foreach (var failure in result.Errors)
                {
                    builder.AppendLine(failure);
                }
                _view.HandleNotification(builder.ToString());
            }

            return result.Forecasts;
        }
    }
}
