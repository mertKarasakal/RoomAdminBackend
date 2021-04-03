using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Constants;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class StatusValidator : AbstractValidator<Status>
    {
        public StatusValidator()
        {
            RuleFor(s => s.Id).NotEmpty()
                .WithMessage(ValidationMessages.StatusTitleCannotBeNull);
            RuleFor(s => s.Title).Must(StartsWithA);
            ///farklı kurallar eklenebilir
        }

        private bool StartsWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
