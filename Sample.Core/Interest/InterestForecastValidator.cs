using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Core.Interest
{
    public class InterestForecastValidator : AbstractValidator<InterestForecastRequest>
    {
        public InterestForecastValidator()
        {
            RuleFor(r => r.Principal)
                .GreaterThan(0m);
            RuleFor(r => r.Rate)
                .GreaterThan(0m);
            RuleFor(r => r.Years)
                .GreaterThanOrEqualTo(1);
        }
    }
}
