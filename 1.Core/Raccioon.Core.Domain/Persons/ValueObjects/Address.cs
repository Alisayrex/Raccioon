using Zamin.Core.Domain.Exceptions;
using Zamin.Core.Domain.ValueObjects;

namespace Raccioon.Core.Domain.Persons.ValueObjects
{
    public class Address : BaseValueObject<Address>
    {
        #region Properties
        public string Value { get; private set; }
        #endregion

        #region Constructors And Factories

        public static Address FromString(string value) => new Address(value);

        const byte minimumLength = 10;
        const byte maximumLength = 150;
        public Address(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new InvalidValueObjectStateException("ValidationErrorIsRequrie", nameof(Address));
            }
            if (value.Length < minimumLength || value.Length > maximumLength)
            {
                throw new InvalidValueObjectStateException("ValidationErrorStringLength", nameof(Address), minimumLength.ToString(), maximumLength.ToString());
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

        public static explicit operator string(Address address) => address.Value;
        public static implicit operator Address(string value) => new(value);
        #endregion

        #region Method
        public override string ToString() => Value;

        #endregion
    }
}
