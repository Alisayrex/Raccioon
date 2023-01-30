using FluentValidation;
using Raccioon.Core.Contracts.Orders.Queries.GetOrderByBusinessId;
using Zamin.Extensions.Translations.Abstractions;

namespace Raccioon.Core.ApplicationServices.Orders.Queries.GetOrderByBusinessId
{
    public class GetOrderByBusinessIdValidator : AbstractValidator<GetOrderByBusinessIdQuery>
    {
        public GetOrderByBusinessIdValidator(ITranslator translator)
        {
            RuleFor(query => query.OrderBusinessId)
                .NotEmpty()
                .WithMessage(translator["Required", nameof(GetOrderByBusinessIdQuery.OrderBusinessId)]);
        }
    }
}
