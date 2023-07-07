using System;
using System.Collections.Generic;

namespace Sample.Core.Interest
{
    public class InterestForecastHandler : IInterestForecastHandler
    {
        public List<BalanceForecast> Calculate(InterestForecastRequest request)
        {
            var output = new List<BalanceForecast>
            {
                new BalanceForecast()
                {
                    Year = 0,
                    Balance = request.Principal
                }
            };

            for (int i = 1; i <= request.Years; i++)
            {
                double percent = (double)(1 + (request.Rate / 100));
                decimal amount = request.Principal * (decimal)Math.Pow(percent, i);
                output.Add(new BalanceForecast()
                {
                    Year = i,
                    Balance = amount
                });
            }

            return output;
        }
    }
}
