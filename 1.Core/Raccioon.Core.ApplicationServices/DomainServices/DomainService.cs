using Raccioon.Core.Contracts.DomainServices;
using Raccioon.Core.Contracts.Persons.Queries;
using Raccioon.Core.Domain.Orders.Entities;
using Raccioon.Core.Domain.Persons.Entities;
using static Raccioon.Core.Domain.Orders.Entities.OrderState;

namespace Raccioon.Core.ApplicationServices.DomainServices
{
    public class DomainService : IDomainService
    {
        private const int MaximumOrderPerPerson = 5;

        private readonly IPersonQueryRepository _personQueryRepository;

        public DomainService(IPersonQueryRepository personQueryRepository)
        {
            _personQueryRepository = personQueryRepository;
        }



        #region Rules methods
        public async void AssignOrderToPerson(Person person, Order order)
        {

            if (person.Id == order.PersonId)
            {
                return;
            }

            if (order.OrderStatus != OrderStatus.Processing)
            {
                throw new ApplicationException("OrderStatusNotValid");
            }

            var maxState = await CheckPersonMaximumAssignedOrders(person);

            if (maxState)
            {
                throw new ApplicationException("PersonMaximumOrderLimitOrders");
            }

            order.AssignPerson(person.Id);
        }

        public Dictionary<string, string> OrderValidationCollection()
        {
            //gets Dictionary From Database then return it
            throw new NotImplementedException();
        }

        private async Task<bool> CheckPersonMaximumAssignedOrders(Person person)
        {
            var orderCounts = await _personQueryRepository.Execute(person.Id);

            if (orderCounts > MaximumOrderPerPerson)
            {
                return false;
            }

            return true;
        }

        #endregion

    }
}
