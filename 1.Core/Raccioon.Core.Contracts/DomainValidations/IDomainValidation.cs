namespace Raccioon.Core.Contracts.DomainValidations
{
    public interface IDomainValidation
    {
        string ValidationCaller(string key);

        Task<string> ValidationCallerAsync(string key);
    }
}
