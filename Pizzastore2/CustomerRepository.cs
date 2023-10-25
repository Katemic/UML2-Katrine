using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzastore2
{
    public class CustomerRepository
    {
        //instance fields
        private List<Customer> _customerList;

        public CustomerRepository()
        {
             _customerList = new List<Customer>();
        }

        //properties 
        public int Count
        { 
            get { return _customerList.Count; } 
        }

        //methods 

        //add
        public void AddCustomer(Customer aCustomer)
        {
            if (LookUpCustomer(aCustomer.PhoneNumber)==null)
            {
                _customerList.Add(aCustomer);
            }
            else
            {
                Console.WriteLine("Error: a customer with the entered phone number already exists");
            }
            
        }

        //look up
        public Customer LookUpCustomer(string phoneNumber)
        {
            foreach (var customer in _customerList) 
            { 
                if (customer.PhoneNumber==phoneNumber)
                {
                    return customer;
                }
            }
            return null;
        }

        //delete 
        public void DeleteCustomer(string phoneNumber) 
        {
            if (LookUpCustomer(phoneNumber)==null) 
            {
                Console.WriteLine("Error: Phonenumber does not exist in the system");
            }
            else
            {
                _customerList.Remove(LookUpCustomer(phoneNumber));
                Console.WriteLine("Customer has been deleted");
            }


        }

        //update
        public void UpdateCustomer(Customer newCustomer) 
        {
            //int count = 0;
            //foreach(var customer in _customerList) 
            //{
            //    if (customer.PhoneNumber==newCustomer.PhoneNumber)
            //    {
            //        _customerList[count] = newCustomer;
            //        break;
            //    }
            //   count++;   
            //}

            for (int count=0; count < _customerList.Count; count++) 
            { 
                if (_customerList[count].PhoneNumber==newCustomer.PhoneNumber)
                {
                    _customerList[count] = newCustomer;
                    break;
                }
            }
                
            
        }


        //print all
        public void PrintCustomer()
        {
            foreach (var customer in _customerList)
            {
                Console.WriteLine(customer);
            }
        }

    }
}
