using System;

namespace ISTN_PROJECT
{
    public class Room
    {
        private int _id;
        private String _type;
        private int _numberOfBeds;
        private float _price;
        private char _availability;
        private String _description;
        private String _name;

        public Room(int id, string type, int numberOfBeds, float price, char availability, string description, string name)
        {
            this._id = id;
            this._type = type;
            this._numberOfBeds = numberOfBeds;
            this._price = price;
            this._availability = availability;
            this._description = description;
            this._name = name;
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Type
        {
            get => _type;
            set => _type = value;
        }

        public int NumberOfBeds
        {
            get => _numberOfBeds;
            set => _numberOfBeds = value;
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

        public string Description
        {
            get => _description;
            set => _description = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }
    }
}