using System;

namespace ISTN_PROJECT
{
    public class Booking
    {
        private int _id;
        private int _customerId;
        private float _amount;
        private int _numberOfGuest;
        private int _checkIn;
        private int _checkOut;
        private String _status;

        public Booking(int id, int customerId, float amount, int numberOfGuest, int checkIn, int checkOut, string status)
        {
            _id = id;
            _customerId = customerId;
            _amount = amount;
            _numberOfGuest = numberOfGuest;
            _checkIn = checkIn;
            _checkOut = checkOut;
            _status = status;
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public int CustomerId
        {
            get => _customerId;
            set => _customerId = value;
        }

        public float Amount
        {
            get => _amount;
            set => _amount = value;
        }

        public int NumberOfGuest
        {
            get => _numberOfGuest;
            set => _numberOfGuest = value;
        }

        public int CheckIn
        {
            get => _checkIn;
            set => _checkIn = value;
        }

        public int CheckOut
        {
            get => _checkOut;
            set => _checkOut = value;
        }

        public string Status
        {
            get => _status;
            set => _status = value;
        }
    }
}