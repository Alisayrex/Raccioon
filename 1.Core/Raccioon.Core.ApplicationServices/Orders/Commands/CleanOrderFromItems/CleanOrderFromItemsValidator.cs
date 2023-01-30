using FluentValidation;
using Raccioon.Core.Contracts.Orders.Commands.CleanOrderFromItems;
using Zamin.Core.Domain.Toolkits.ValueObjects;
using Zamin.Extensions.Translations.Abstractions;


namespace Raccioon.Core.ApplicationServices.Orders.Commands.CleanOrderFromItems
{
    public class CleanOrderFromItemsValidator : AbstractValidator<CleanOrderFromItemsCommand>
    {
        public CleanOrderFromItemsValidator(ITranslator translator)
        {
            RuleFor(c => c.OrderId)
             .NotNull().WithMessage(translator["Required", nameof(Title)]);
        }
    }
}
