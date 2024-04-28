using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Address
    {
        private string country; // країна
        private string city; // місто
        private string street; // вулиця
        private int number; // номер будинку

        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }

        public string Street
        {
            get
            {
                return street;
            }
            set
            {
                street = value;
            }
        }

        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }

        public Address()
        {
            country = string.Empty;
            city = string.Empty;
            street = string.Empty;
            number = 0;
        }
        public Address(string country, string city, string street, int number)
        {
            this.country = country;
            this.city = city;
            this.street = street;
            this.number = number;
        }

        public override string ToString()
        {
            return "Country -> " + country + "\n" + "City -> " + city + "\n" + "Street -> " + street + "\n" + "Number -> " + number;
        }
    }
}
