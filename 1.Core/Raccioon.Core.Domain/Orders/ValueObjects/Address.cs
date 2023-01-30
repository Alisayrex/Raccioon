using Zamin.Core.Domain.Exceptions;
using Zamin.Core.Domain.ValueObjects;

namespace Raccioon.Core.Domain.Orders.BaseValueObjects
{
    public class Address : BaseValueObject<Address>
    {

        #region properties
        public string Value { get; private set; }
        #endregion

        #region constructors and factories

        public static Address FromString(string value) => new Address(value);

        public Address(string value)
        {

            const byte MinAddressLength = 10;
            const byte MaxAddressLength = 150;

            if(string.IsNullOrWhiteSpace(value))
            {
                throw new InvalidValueObjectStateException("ValidationErrorIsRequired",nameof(Address));
            }
            if(value.Length <MinAddressLength || value.Length > MaxAddressLength)
            {
                throw new InvalidValueObjectStateException("ValidationErrorStringLength", nameof(Address));
            }
            Value = value;

        }
        private Address()
        {

        }


        #endregion

        #region Equality Check
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
        #endregion

        #region Operator Overloading
        public static implicit operator Address(string value) => new(value);
        public static explicit operator string (Address address)=> address.Value;

        #endregion

        #region method
        public override string ToString() => Value;
        #endregion
    }
}
