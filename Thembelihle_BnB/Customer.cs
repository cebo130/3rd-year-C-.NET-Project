using System;

namespace Thembelihle
{
    public class Customer
    {
        private int _id;
        private String _name;
        private String _surname;
        private String _phoneNumber;
        private String _email;
        private String _password;
        private Address _address;
        private string phone;

        public Customer(int id, string name, string surname, string phoneNumber, string email, string password, Address address)
        {
            _id = id;
            _name = name;
            _surname = surname;
            _phoneNumber = phoneNumber;
            _email = email;
            _password = password;
            this._address = address;

        }
        public Customer(){}

        public Customer(int id, string name, string surname, string phone, string _email, string _password)
        {
            Id = id;
            Name = name;
            Surname = surname;
            this.phone = phone;
            this._email = _email;
            this._password = _password;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
            }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
            }

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
            }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set {  _phoneNumber = value; }
            }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
            }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
            }
        public Address Address
        {
            get { return _address; }
            set { _address = value; }
        }
    }

}