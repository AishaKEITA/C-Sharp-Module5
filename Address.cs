using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Address
    {
        private string city;
        private string street;
        private string zipCode;
        private Countries country;
        private Address address;

        /// <summary>
        /// constructor address
        /// </summary>
        public Address(string street, string zipCode, string city, Countries country)

        {
            this.city = this.City;
            this.street = this.Street;
            this.zipCode = this.ZipCode;
            this.country = country;
        }

        /// <summary>
        /// address constructor
        /// </summary>
        public Address()
        {
        }

        /// <summary>
        /// address constructor with parameter
        /// </summary>
        /// <param name="address"></param>
        public Address(Address address)
        {
            this.address = address;
        }

        /// <summary>
        /// get and set access for city
        /// </summary>
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        /// <summary>
        /// get and set access for street
        /// </summary>
        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        /// <summary>
        /// get and set access for zip code
        /// </summary>
        public string ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }

        /// <summary>
        /// method to get and set country
        /// </summary>
        public Countries Country
        {
            get { return country; }
            set { country = value; }
        }

        /// <summary>
        /// method to get country to string
        /// </summary>
        /// <returns>return to sting</returns>
        public string GetCountryString()
        {
            string  strCountry = country.ToString();
            strCountry = strCountry.Replace("_", " ");
            return strCountry;        }

        /// <summary>
        /// method to get the full address label
        /// </summary>
        /// <returns></returns>
        public string GetAdressLabel()
        {
            string strOut = street + Environment.NewLine;
            strOut += zipCode + " " + city;
            return strOut;
        }

        /// <summary>
        /// method to to return stree, zipcode, and city
        /// need to see where to add name
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string strOut = string.Format("{0, 25} {1, -8} {2, -10} {3}", street, zipCode, city, GetCountryString());
            return strOut;
        }
        /// <summary>
        /// method to check so city is not empty or null string
        /// </summary>
        /// <param name="city"></param>
        /// <returns></returns>
        public bool Validate()
        {
            if (string.IsNullOrEmpty(city))
            {
                return false;
            }

            return true;
        }
    }
}