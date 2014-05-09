namespace ImplicitOperatorOverloads
{
    public class CreateBooking
    {
        public CreateBooking(BookingTypeId typeId)
        {
            TypeId = typeId;
        }

        public int TypeId { get; private set; }
    }
}