using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class Program
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string state { get; set; }
        public int Zipcode { get; set; }
        public Double PhoneNumber { get; set; }
        public string Email { get; set; }
        public void DisplayContact()
        {
            Console.WriteLine("FirstName:" + this.FirstName + "LastName:" + LastName + "Address:" + Address + "city:" + City + "state:" + state
                + "zipcode:" + Zipcode + "phonenumber" + PhoneNumber + "email:" + Email);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the firstname,lastnamea,address,city,state,zipcode,phonenumber,email \n");
            Program objprogram = new Program()
            {
                FirstName = Console.ReadLine(),
                LastName = Console.ReadLine(),
                Address = Console.ReadLine(),
                City = Console.ReadLine(),
                state = Console.ReadLine(),
                Zipcode = int.Parse(Console.ReadLine()),
                PhoneNumber = Double.Parse(Console.ReadLine()),
                Email = Console.ReadLine(),
            };
            objprogram.DisplayContact();
            Console.ReadLine();
        }
    }
}
