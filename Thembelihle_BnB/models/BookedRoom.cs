namespace ISTN_PROJECT
{
    public class BookedRoom
    {
        private int _id;
        private int _bookingId;
        private int _roomId;

        public BookedRoom(int id, int bookingId, int roomId)
        {
            _id = id;
            _bookingId = bookingId;
            _roomId = roomId;
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

        public int RoomId
        {
            get => _roomId;
            set => _roomId = value;
        }
    }
}