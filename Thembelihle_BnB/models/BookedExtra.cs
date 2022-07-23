namespace ISTN_PROJECT
{
    public class BookedExtra
    {
        private int _id;
        private int _bookingId;
        private int _extraId;

        public BookedExtra(int id, int bookingId, int extraId)
        {
            _id = id;
            _bookingId = bookingId;
            _extraId = extraId;
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public int BookingId
        {
            get => _bookingId;
            set => _bookingId = value;
        }

        public int ExtraId
        {
            get => _extraId;
            set => _extraId = value;
        }
    }
}