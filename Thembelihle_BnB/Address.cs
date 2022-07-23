using System;

namespace Thembelihle
{
    public class Address
    {
        private int zipCode;
        private String state;
        private String city;
        private String country;
        public Address(String country, String state, String city, int zipCode)
        {
            this.country = country;
            this.state = state;
            this.city = city;
            this.zipCode = zipCode;
        }
        public Address() { }
        public String Country
        {
            get { return country; }
            set { country = value; }
        }
        public String State
        {
            get { return state; }
            set { state = value; }
        }
        public String City
        {
            get { return city; }
            set { city = value; }
        }
        public int ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }
    }
}
