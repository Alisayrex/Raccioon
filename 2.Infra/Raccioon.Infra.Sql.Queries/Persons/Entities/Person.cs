using Raccioon.Infra.Sql.Queries.Orders.Entities;

namespace Raccioon.Infra.Sql.Queries.Persons.Entities
{
    public class Person
    {
        public long Id { get; set; }

        public string Name { get; private set; }

        public string LastName { get; private set; }

        public DateTime JoinedDate { get; private set; }

        public string Address { get; private set; }

        public long NationalId { get; private set; }

        public long OrderId { get; private set; }

        public List<Order> Orders { get; set; }
    }
}
