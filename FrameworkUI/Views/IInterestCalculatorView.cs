using Sample.Core.Interest;
using System.Collections.Generic;

namespace Sample.Core.Views
{
    public interface IInterestCalculatorView
    {
        void DisplayForecasts(List<BalanceForecast> forecasts);
        void HandleNotification(string message);
    }
}
