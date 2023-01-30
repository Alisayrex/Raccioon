using Raccioon.Core.Domain.Persons.ValueObjects;
using Zamin.Core.Domain.Entities;
using Zamin.Core.Domain.Toolkits.ValueObjects;

namespace Raccioon.Core.Domain.Persons.Entities
{
    public class Person : AggregateRoot
    {
        #region properties
        public Name Name { get; private set; }

        public Name LastName { get; private set; }

        public DateTime JoinedDate { get; private set; }

        public Address Address { get; private set; }

        public LegalNationalId NationalId { get; private set; }

        public long OrderId { get; private set; }
        #endregion

        #region constructors
        private Person()
        {

        }

        public Person(Name name, Name lastName, DateTime joinedDate, Address address, LegalNationalId nationalId)
        {
            Name = name;
            LastName = lastName;
            JoinedDate = joinedDate;
            Address = address;
            NationalId = nationalId;
        }

        #endregion

        #region Behaviours
        public static Person AddPerson(Name name, Name lastName, DateTime joinedDate, Address address, LegalNationalId nationalId)
            => new(name, lastName, joinedDate, address, nationalId);

        public void AddPerson(Name name, Name lastName, Address address, LegalNationalId nationalId)
        {
            Name = name;
            LastName = lastName;
            JoinedDate = DateTime.Now;
            Address = address;
            NationalId = nationalId;
            
        }




        #endregion

    }
}
