using System.Collections.Generic;

namespace Sample.Core.Interest
{
    public interface IInterestForecastHandler
    {
        InterestForecastResponse Calculate(InterestForecastRequest request);
    }
}