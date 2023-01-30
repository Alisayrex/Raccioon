using Zamin.Core.Domain.Exceptions;
using Zamin.Core.Domain.ValueObjects;

namespace Raccioon.Core.Domain.Orders.ValueObjects
{
    public class Price : BaseValueObject<Price>
    {
        #region Properties

        public long Value { get; private set; }

        #endregion

        #region Constructors and Factories

        private Price()
        {

        }

        public Price(long value)
        {
            long minPrice = 1;
            if (value < 0)
            {
                throw new InvalidValueObjectStateException("InvalidPriceMinRange", minPrice.ToString());
            }
            Value = value;
        }

        public static Price FromString(string value) => new Price(long.Parse(value));
        public static Price FromLong(long value) => new Price(value);
        #endregion

        #region EqualityCheck

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        #endregion

        #region Operator Overloading

        public static Price operator +(Price leftSide, Price rightSide) => leftSide + rightSide;
        public static Price operator -(Price leftSide, Price rightSide) => leftSide - rightSide;
        public static Price operator *(Price leftSide, Price rightSide) => leftSide * rightSide;
        public static Price operator /(Price leftSide, Price rightSide) => leftSide / rightSide;

        public static implicit operator Price(long value) => new(value);
        public static explicit operator long(Price value) => value.Value;
        #endregion

        #region Method
        public override string ToString() => Value.ToString();
        #endregion
    }
}
