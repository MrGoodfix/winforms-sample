namespace Sample.Core.Interest
{
    public class InterestForecastRequest
    {
        public decimal Principal { get; set; }
        /// <summary>
        /// Percentage, e.g. 6.5% would be stored as 6.5m; not 0.065m
        /// </summary>
        public decimal Rate { get; set; }
        /// <summary>
        /// Number of years compound interest will accrue
        /// </summary>
        public int Years { get; set; }
    }
}
