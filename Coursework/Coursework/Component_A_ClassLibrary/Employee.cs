using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Component_A_ClassLibrary
{
    class Employee
    {
        private string name;
        private string surname;
        private string email;
        private int number;
        private int iD;
        private DateTime joinDate;
        private Address address;

        public Employee(string name, string surname, string email, int number, int ID, Address address)
        {
            this.Name = name;
            this.Surname = surname;
            this.Email = email;
            this.Number = number;
            this.ID = IDcreation();
            this.JoinDate = DateTime.Today;
            this.Address = address;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Email { get => email; set => email = value; }
        public int Number { get => number; set => number = value; }
        public int ID { get => iD; set => iD = value; }
        public DateTime JoinDate { get => joinDate; set => joinDate = value; }
        internal Address Address { get => address; set => address = value; }

        private int IDcreation()
        {
            int verifiedID;
            Random random = new Random();
            verifiedID = random.Next(10000000, 99999999);

            if (true)
            {
                

            }

            return verifiedID;
        }


    }
}
