using System;
using System.Collections.Generic;

namespace Sample.Core.Interest
{
    public class InterestForecastHandler : IInterestForecastHandler
    {
        public Result<List<BalanceForecast>, List<string>> Forecast(InterestForecastRequest request)
        {
            var validator = new InterestForecastValidator();
            var validationResults = validator.Validate(request);
            if (validationResults.IsValid != true)
            {
                var errorList = new List<string>();
                foreach (var failure in validationResults.Errors)
                {
                    errorList.Add($"{failure.PropertyName}: {failure.ErrorMessage}");
                }
                return errorList;
            }

            return CalculateNow(request);
        }

        private List<BalanceForecast> CalculateNow(InterestForecastRequest request)
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
