using Xunit;
using Xunit.Should;

namespace ImplicitOperatorOverloads.Tests
{
    public class Tests
    {
        [Fact]
        public void TestGoldBooking()
        {
            var silverBooking = new CreateBooking(BookingTypeId.Gold());
            silverBooking.TypeId.ShouldBe(3);
        }

        [Fact]
        public void TestSilverBooking()
        {
            var silverBooking = new CreateBooking(BookingTypeId.Silver());
            silverBooking.TypeId.ShouldBe(2);
        }

        [Fact]
        public void TestBronzeBooking()
        {
            var silverBooking = new CreateBooking(BookingTypeId.Bronze());
            silverBooking.TypeId.ShouldBe(1);
        }

        [Fact]
        public void TestCustomBooking()
        {
            const int custom = 546;
            var silverBooking = new CreateBooking(BookingTypeId.Custom(custom));
            silverBooking.TypeId.ShouldBe(custom);
        }
    }
}