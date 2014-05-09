using System;

namespace ImplicitOperatorOverloads
{
    public struct BookingTypeId : IEquatable<int>, IComparable<int>
    {
        private readonly int _value;

        private BookingTypeId(int value)
        {
            //...some simple validation logic...
            _value = value;
        }

        public static BookingTypeId Custom(int value)
        {
            return new BookingTypeId(value);
        }

        public static BookingTypeId Gold()
        {
            return new BookingTypeId(3);
        }

        public static BookingTypeId Silver()
        {
            return new BookingTypeId(2);
        }

        public static BookingTypeId Bronze()
        {
            return new BookingTypeId(1);
        }

        public static implicit operator int(BookingTypeId item)
        {
            return item._value;
        }

        public bool Equals(int other)
        {
            return _value.Equals(other);
        }

        public int CompareTo(int other)
        {
            return _value.CompareTo(other);
        }
    }
}