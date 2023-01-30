using Zamin.Core.Contracts.Data.Queries;

namespace Raccioon.Core.Contracts.Persons.Queries
{
    public interface IPersonQueryRepository:IQueryRepository
    {
        Task<int> Execute(long personId);


    }
}
