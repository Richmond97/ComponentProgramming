using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Component_A_ClassLibrary
{
    class Address
    {
        private string street;
        private string city;
        private string county;
        private string postcode;

        public Address(string street, string city, string county, string postcode)
        {
            this.Street = street;
            this.City = city;
            this.County = county;
            this.Postcode = postcode;

        }

        public string Split(string address, int index)
        {
            string[] words = address.Split('-');            
            return words[index];
        }

        public string Street { get => street; set => street = value; }
        public string City { get => city; set => city = value; }
        public string County { get => county; set => county = value; }
        public string Postcode { get => postcode; set => postcode = value; }
    }

}
