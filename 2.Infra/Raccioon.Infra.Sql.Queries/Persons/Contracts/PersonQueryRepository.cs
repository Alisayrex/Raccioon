using Microsoft.EntityFrameworkCore;
using Raccioon.Core.Contracts.Persons.Queries;
using Raccioon.Core.Contracts.Persons.Queries.GetPersonOrderCountQuery;
using Raccioon.Infra.Sql.Queries.Common;
using Zamin.Infra.Data.Sql.Queries;

namespace Raccioon.Infra.Sql.Queries.Persons.Contracts
{
    public class PersonQueryRepository : BaseQueryRepository<OrderQueryDbContext>, IPersonQueryRepository
    {
        public PersonQueryRepository(OrderQueryDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<int> Execute(PersonOrderCountQuery query)
        {
            var person = await _dbContext.Persons
                .SingleOrDefaultAsync(p => p.Id == query.PersonId);

          return  person.Orders.Count();
        }

        public Task<int> Execute(long personId)
        {
            //To Do
            throw new NotImplementedException();
        }
    }
}
