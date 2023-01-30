using Raccioon.Core.Contracts.Persons.Queries;
using Raccioon.Core.Contracts.Persons.Queries.GetPersonOrderCountQuery;
using Zamin.Core.ApplicationServices.Queries;
using Zamin.Core.Contracts.ApplicationServices.Queries;
using Zamin.Utilities;

namespace Raccioon.Core.ApplicationServices.Persons.Queries.GetPersonOrderCountQuery
{
    public class GetPersonOrderCountHandler : QueryHandler<PersonOrderCountQuery, int>
    {
        private readonly IPersonQueryRepository _personQueryRepository;

        public GetPersonOrderCountHandler(IPersonQueryRepository personQueryRepository,ZaminServices zaminServices)
            :base(zaminServices)
        {
            _personQueryRepository = personQueryRepository;
        }

        public override async Task<QueryResult<int>> Handle(PersonOrderCountQuery query)
        {
            var count = await _personQueryRepository.Execute(query.PersonId);
             return Result(count);
        }
    }
}
