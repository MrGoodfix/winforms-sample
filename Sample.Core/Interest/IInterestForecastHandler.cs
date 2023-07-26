using System.Collections.Generic;

namespace Sample.Core.Interest
{
    public interface IInterestForecastHandler
    {
        Result<List<BalanceForecast>, List<string>> Forecast(InterestForecastRequest request);
    }
}