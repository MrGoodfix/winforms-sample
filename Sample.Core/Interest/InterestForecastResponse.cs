using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Core.Interest
{
    public class InterestForecastResponse
    {
        public List<BalanceForecast> Forecasts { get; set; } = new List<BalanceForecast>();
        public List<string> Errors { get; set; } = new List<string>();
    }
}
