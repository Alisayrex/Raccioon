using FluentValidation;
using Raccioon.Core.Contracts.Persons.Queries.GetPersonOrderCountQuery;
using Zamin.Extensions.Translations.Abstractions;

namespace Raccioon.Core.ApplicationServices.Persons.Queries.GetPersonOrderCountQuery
{
    public class GetPersonOrderCountValidator: AbstractValidator<PersonOrderCountQuery>
    {
        public GetPersonOrderCountValidator(ITranslator translator)
        {
            RuleFor(query => query.PersonId)
                .NotEmpty()
                .WithMessage(translator["Required", nameof(PersonOrderCountQuery.PersonId)]);
        }
    }
}
