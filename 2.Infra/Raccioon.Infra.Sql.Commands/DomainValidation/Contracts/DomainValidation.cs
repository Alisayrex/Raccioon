using Raccioon.Core.Contracts.DomainValidations;

namespace Raccioon.Infra.Sql.Commands.DomainValidation.Contracts
{
    public class DomainValidation : IDomainValidation
    {
        string IDomainValidation.ValidationCaller(string key)
        {
            throw new NotImplementedException();
        }

        Task<string> IDomainValidation.ValidationCallerAsync(string key)
        {
            throw new NotImplementedException();
        }
    }
}
