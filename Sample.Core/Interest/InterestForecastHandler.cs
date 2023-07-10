using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Core.Interest
{
    public class InterestForecastHandler : IInterestForecastHandler
    {
        public InterestForecastResponse Calculate(InterestForecastRequest request)
        {
            var response = new InterestForecastResponse();
            Validate(request, response);
            if (response.Errors.Count == 0)
            {
                response.Forecasts = CalculateNow(request);
            }

            return response;
        }

        private void Validate(InterestForecastRequest request, InterestForecastResponse response) 
        {
            var validator = new InterestForecastValidator();
            var result = validator.Validate(request);
            if (result.IsValid != true) 
            {
                foreach (var failure in result.Errors)
                {
                    response.Errors.Add($"{failure.PropertyName}: {failure.ErrorMessage}");
                }
            }
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
