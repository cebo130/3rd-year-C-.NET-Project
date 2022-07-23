using System;

namespace Thembelihle
{
    public class Room
    {
        private int _id;
        private String _type;
        private int _numberOfBeds;
        private float _price;
        private String _description;
        private int _quantity;
        private long _from;
        private long _to;
        public Room(int id, string type, int numberOfBeds, float price, string description, int quantity, long from, long to)
        {
            this._id = id;
            this._type = type;
            this._numberOfBeds = numberOfBeds;
            this._price = price;
            this._description = description;
            this._quantity = quantity;
            this._from = from;
            this._to = to;
        }

        public int Id
        {
            get { return _id; }
            set {  _id = value; }
            }

        public string Type
        {
            get {return  _type; }
          set{  _type = value; }
        }

        public int NumberOfBeds
        {
           get { return _numberOfBeds;}
          set { _numberOfBeds = value;}
        }

        public float Price
        {
            get {return  _price; }
          set{  _price = value; }
        }


        public string Description
        {
            get { return _description;}
            set{  _description = value;}
            }

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
            }
        public long From
        {
            get { return this._from; }
            set { this._from = value; }
        }
        public long To
        {
            get { return this._to; }
            set { this._to = value; }
        }
    }

}
