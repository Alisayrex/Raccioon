using Raccioon.Core.Domain.Persons.Entities;
using Zamin.Core.Contracts.Data.Commands;

namespace Raccioon.Core.Contracts.Persons.Commands
{
    public interface IPersonCommandRepository:ICommandRepository<Person>
    {

    }
}
