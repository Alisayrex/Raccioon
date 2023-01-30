using Raccioon.Core.Domain.Orders.Entities;
using Raccioon.Core.Domain.Persons.Entities;

namespace Raccioon.Core.Contracts.DomainServices
{
    public interface IDomainService
    {
        void AssignOrderToPerson(Person person, Order order);

        Dictionary<string, string> OrderValidationCollection();

    }
}
