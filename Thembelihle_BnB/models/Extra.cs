using System;

namespace ISTN_PROJECT
{
    public class Extra
    {
        private int _id;
        private String _name;
        private float _price;
        private char _availability;
        private int _quantity;
        private String _description;

        public Extra(int id, string name, float price, char availability, int quantity, string description)
        {
            _id = id;
            _name = name;
            _price = price;
            _availability = availability;
            _quantity = quantity;
            _description = description;
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public float Price
        {
            get => _price;
            set => _price = value;
        }

        public char Availability
        {
            get => _availability;
            set => _availability = value;
        }

        public int Quantity
        {
            get => _quantity;
            set => _quantity = value;
        }

        public string Description
        {
            get => _description;
            set => _description = value;
        }
    }
}