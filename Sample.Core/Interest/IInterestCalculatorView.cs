using System.Collections.Generic;

namespace Sample.Core.Interest
{
    public interface IInterestCalculatorView
    {
        void DisplayForecasts(List<BalanceForecast> forecasts);
        void HandleNotification(string message);
    }
}
