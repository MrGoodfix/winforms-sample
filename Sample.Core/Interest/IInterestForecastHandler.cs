using System.Collections.Generic;

namespace Sample.Core.Interest
{
    public interface IInterestForecastHandler
    {
        List<BalanceForecast> Calculate(InterestForecastRequest request);
    }
}