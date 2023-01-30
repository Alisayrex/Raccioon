using Zamin.Core.Domain.Exceptions;
using Zamin.Core.Domain.ValueObjects;

namespace Raccioon.Core.Domain.Persons.ValueObjects
{
    public class Name : BaseValueObject<Name>
    {

        #region Properties

        public string Value { get; set; }

        #endregion

        #region Constructors and Factories

        public static Name FromString(string value) => new Name(value);

        const byte minimumLength = 3;

        const byte maximumLength = 50;

        public Name(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new InvalidValueObjectStateException("ValidationErrorIsRequrie", nameof(Name));
            }
            if (value.Length < minimumLength || value.Length > maximumLength)
            {
                throw new InvalidValueObjectStateException("ValidationErrorStringLength", nameof(Address), minimumLength.ToString(), maximumLength.ToString());
            }
            Value = value;

        }

        private Name()
        {

        }
        #endregion

        #region Equality Check

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        #endregion

        #region Operators

        public static explicit operator string(Name name) => name.Value;
        public static implicit operator Name(string value) => new(value);

        #endregion

        #region Methods
        public override string ToString() => Value;
        #endregion


    }
}
