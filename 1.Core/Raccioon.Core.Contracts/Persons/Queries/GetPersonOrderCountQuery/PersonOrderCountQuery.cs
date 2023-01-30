using Zamin.Core.Contracts.ApplicationServices.Queries;

namespace Raccioon.Core.Contracts.Persons.Queries.GetPersonOrderCountQuery
{
    public class PersonOrderCountQuery:IQuery<int>
    {
        public long PersonId { get; set; }
    }
}
