using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzastore2
{
    public class Customer
    {
        //intance fields
        private string _name;
        private string _phoneNumber;
        private string _email;
        private string _address;

        //properties
        public string Name 
        { 
            get { return _name; } 
        }

        public string PhoneNumber
        { 
            get { return _phoneNumber; } 
        }

        public string Email
        { 
            get { return _email; } 
        }

        public string Address
        {
            get { return _address; }
        }

        //constructor
        public Customer(string name, string phoneNumber, string email, string adress) 
        { 
            _name = name; 
            _phoneNumber = phoneNumber;
            _email = email;
            _address = adress;
        }

        //methods 


        //Tostring
        public override string ToString()
        {
            return $"Customer info:\n" +
                $"Name: {Name}\n" +
                $"Phonenumber:  {PhoneNumber}\n" +
                $"email:    {Email}\n" +
                $"Adress:   {Address}\n\n";
        }

    }
}
