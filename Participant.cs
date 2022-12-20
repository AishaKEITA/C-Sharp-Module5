using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment5
{
    internal class Participant
    {
        //instance variable
        private string firstName;
        private string lastName;

        private Address address;

        /// <summary>
        /// constructor partcipant which uses the address class
        /// </summary>
        public Participant()
        {
          address = new Address();
        }

        /// <summary>
        /// constructor with parameters
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="address"></param>
        public Participant(string firstName, string lastName, Address address)
        {
            this.firstName = firstName;
            this.lastName = lastName;

            if (address != null)
                this.address = address;

            else
                address = new Address();
        }

        /// <summary>
        /// method to create a copy of participant
        /// the other is another constructor
        /// </summary>
        /// <param name="theOther"></param>
        public Participant(Participant theOther)
        {
            this.firstName = theOther.firstName;
            this.lastName = theOther.lastName;
            this.address = new Address(theOther.address);
        }

        /// <summary>
        /// method to get and set address
        /// </summary>
        public Address Address
        {
            get { return address; }
            set { address = value; }
        }

        /// <summary>
        /// method to get and set first name
        /// </summary>
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        /// <summary>
        /// method to get and set last name
        /// </summary>
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        /// <summary>
        /// method to return first name, last name, and address to string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string strOut = String.Format("{0, 20} {1, 10} {2, -10}", firstName, lastName, address.ToString());
            return strOut;
        }

        /// <summary>
        /// method to validate so that first name and last name are not empty
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            bool addrOk = address.Validate();
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || addrOk)
            {
                return false;
            }

            return true;
        }
    }
}
