using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pizzastore2
{
    public class UserDialog
    {
        //instance fields
        private CustomerRepository _customerRepository;
        private PizzaRepository _pizzaRepository;

        //constructor 
        public UserDialog(CustomerRepository customerRepository,PizzaRepository pizzaRepository) 
        { 
            _customerRepository = customerRepository;
            _pizzaRepository = pizzaRepository;
        }

        //read user choice
        public int ReadUserChoice()
        {
            string choice = Console.ReadLine();
            int input = -1;
            if (int.TryParse(choice, out input))
            {
                return input;
            }
            else
            {
                return -1;
            }
        }


        //user dialog options
        public int ShowOptions()
        {
            Console.Clear();
            Console.WriteLine("-------Pizza information-------");
            Console.WriteLine("\t1. \tPrint menu");
            Console.WriteLine("\t2. \tAdd pizza");
            Console.WriteLine("\t3. \tLook up pizza");
            Console.WriteLine("\t4. \tDelete pizza");
            Console.WriteLine("\t5. \tUpdate pizza");
            Console.WriteLine("-------Customer information-------");
            Console.WriteLine("\t6. \tPrint customers");
            Console.WriteLine("\t7. \tAdd customer");
            Console.WriteLine("\t8. \tLook up customer");
            Console.WriteLine("\t9. \tDelete customer");
            Console.WriteLine("\t10. \tUpdate customer");
            Console.Write("Enter input:");


            return ReadUserChoice();
        }


        //hvor valgene bliver brugt
        public void Run()
        {
            int valg = ShowOptions();
            while (valg != 0)
            {
                switch (valg) 
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Print of menu:");
                        _pizzaRepository.PrintPizza();
                        break;
                    case 2:
                        Console.Clear();
                        AddPizza();
                        break;
                    case 3:
                        Console.Clear();
                        LookUpPizza();
                        break;
                    case 4:
                        Console.Clear();
                        DeletePizza();
                        break;
                    case 5:
                        Console.Clear();
                        UpdatePizza();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Print of customers\n");
                        _customerRepository.PrintCustomer();
                        break;
                    case 7: 
                        Console.Clear();
                        AddCustomer();
                        break;
                    case 8:
                        Console.Clear();
                        LookUpCustomer();
                        break;
                    case 9:
                        Console.Clear();
                        DeleteCustomer();
                        break;
                    case 10:
                        Console.Clear();
                        UpdateCustomer();
                        break;
                    default: 
                        Console.Clear();
                        Console.WriteLine("Invalid input");
                        break;

                
                }
                Console.ReadLine();
                Console.Clear();
                valg = ShowOptions();

            }
        
        }


        //metoder

        //pizza metoder

        //add pizza
        private void AddPizza()
        {
            Console.WriteLine("Create new Pizza:");
            Console.WriteLine("Enter pizza number");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter pizza name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter toppings \nfollow this structure [topping,topping,topping]");
            string topping = Console.ReadLine();
            Console.WriteLine("Enter price");
            int price = int.Parse(Console.ReadLine());
            Pizza p = new Pizza(number, name, price, topping);
            _pizzaRepository.AddPizza(p);
        }
        //look up pizza
        private void LookUpPizza()
        {
            Console.WriteLine("Look up pizza");
            Console.WriteLine("Enter pizza number");
            int number = int.Parse(Console.ReadLine());
            if (_pizzaRepository.LookUpPizza(number) != null)
            {
                Console.WriteLine(_pizzaRepository.LookUpPizza(number));
            }
            else
            {
                Console.WriteLine("Error: there is no pizza with the entered number");
            }
        }

        //delete pizza
        private void DeletePizza()
        {
            Console.WriteLine("Delete pizza:");
            Console.WriteLine("Enter pizza Number");
            int number = int.Parse(Console.ReadLine());
            _pizzaRepository.DeletePizza(number);

        }
        //update pizza
        private void UpdatePizza()
        {
            Console.WriteLine("Update Pizza");
            Console.WriteLine("Enter pizza number");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter toppings \nfollow this structure [topping,topping,topping]");
            string topping = Console.ReadLine();
            Console.WriteLine("Enter price");
            int price = int.Parse(Console.ReadLine());
            Pizza p = new Pizza(number, name, price,topping);
            _pizzaRepository.UpdatePizza(p.Number,p);
        }

        //customer metoder
        //add customer
        private void AddCustomer()
        {
            Console.WriteLine("Add new costumer");
            Console.WriteLine("Enter Full name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter phonenumber");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Email");
            string email = Console.ReadLine();
            Console.WriteLine("Enter adress on following format: 'adress, postcode'");
            String adress= Console.ReadLine();
            Customer c = new Customer(name, phoneNumber, email, adress);
            _customerRepository.AddCustomer(c);

        }
        //look up customer
        private void LookUpCustomer()
        {
            Console.WriteLine("Look up costumer");
            Console.WriteLine("Enter phonenumber");
            string phoneNumber = Console.ReadLine();
            if (_customerRepository.LookUpCustomer(phoneNumber) != null) 
            { 
                Console.WriteLine(_customerRepository.LookUpCustomer(phoneNumber));
            }
            else
            {
                Console.WriteLine("No customer found");
            }
        }
        //delete customer
        private void DeleteCustomer()
        {
            Console.WriteLine("Delete customer");
            Console.WriteLine("Enter phonenumber");
            string phoneNumber = Console.ReadLine();
            _customerRepository.DeleteCustomer(phoneNumber);
            

        }
        //update customer
        private void UpdateCustomer()
        {
            Console.WriteLine("Update Customer");
            Console.WriteLine("Enter Full name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter phonenumber");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Email");
            string email = Console.ReadLine();
            Console.WriteLine("Enter adress on following format: 'adress, postcode'");
            String adress = Console.ReadLine();
            Customer c = new Customer(name, phoneNumber, email, adress);
            _customerRepository.UpdateCustomer(c);

        }

    }
}
