using System;

namespace ISTN_PROJECT
{
    public class Payment
    {
        private int _id;
        private int _customerId;
        private String _cardHolder;
        private String _cardNumber;
        private String _expiryDate;

        public Payment(int id, int customerId, string cardHolder, string cardNumber, string expiryDate)
        {
            _id = id;
            _customerId = customerId;
            _cardHolder = cardHolder;
            _cardNumber = cardNumber;
            _expiryDate = expiryDate;
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

        public string CardHolder
        {
            get => _cardHolder;
            set => _cardHolder = value;
        }

        public string CardNumber
        {
            get => _cardNumber;
            set => _cardNumber = value;
        }

        public string ExpiriyDate
        {
            get => _expiryDate;
            set => _expiryDate = value;
        }
    }
}