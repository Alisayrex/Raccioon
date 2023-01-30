using FluentValidation;
using Raccioon.Core.Contracts.Orders.Commands.DefineOrder;
using Zamin.Core.Domain.Toolkits.ValueObjects;
using Zamin.Extensions.Translations.Abstractions;

namespace Raccioon.Core.ApplicationServices.Orders.Commands.DefineOrder
{
    public class DefineOrderValidator : AbstractValidator<DefineOrderCommand>
    {
        public DefineOrderValidator(ITranslator translator)
        {
            RuleFor(c => c.title)
              .NotNull().WithMessage(translator["Required", nameof(Title)])
              .MinimumLength(10).WithMessage(translator["MinimumLength", nameof(Title), "2"])
              .MaximumLength(100).WithMessage(translator["MaximumLength", nameof(Title), "100"]);

            RuleFor(c => c.description)
                .NotNull().WithMessage(translator["Required", nameof(Description)]).WithErrorCode("1")
                .MinimumLength(50).WithMessage(translator["MinimumLength", nameof(Description), "10"]).WithErrorCode("2")
                .MaximumLength(500).WithMessage(translator["MaximumLength", nameof(Description), "500"]).WithErrorCode("3");
        }
    }
}
