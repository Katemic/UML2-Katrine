using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzastore2
{
    public class PizzaRepository
    {
        //instance fields 
        private SortedDictionary<int, Pizza> _pizzas;

        //constructor 
        public PizzaRepository()
        {
            _pizzas = new SortedDictionary<int, Pizza>();
        }

        //properties 
        public int Count
        {
            get { return _pizzas.Count; }
        }

        //methods 

        //add 
        public void AddPizza(Pizza aPizza)
        {
            if (!_pizzas.ContainsKey(aPizza.Number))
            {
                _pizzas.Add(aPizza.Number, aPizza);
            }
            else
            {
                Console.WriteLine("error: Pizza number already exists");
            }
        }

        //look up
        public Pizza LookUpPizza(int pizzanumber)
        {
            if (_pizzas.ContainsKey(pizzanumber))
            {
                return _pizzas[pizzanumber];
            }

            return null;
            
        }

        //delete 
        public void DeletePizza(int pizzaNumber)
        {
            if (_pizzas.ContainsKey(pizzaNumber))
            {
                _pizzas.Remove(pizzaNumber);
                Console.WriteLine($"Pizza number:{pizzaNumber} has been deleted");
            }
            else
            {
                Console.WriteLine("Error: the entered pizzanumber does not exist");
            }
        }

        //update
        public void UpdatePizza(int pizzaNumber, Pizza pizzaUpdate)
        {
            if (_pizzas.ContainsKey(pizzaNumber))
            {
                _pizzas[pizzaNumber] = pizzaUpdate;
                Console.WriteLine("Pizza has been updated");
            }
            else
            {
                Console.WriteLine("Error: the entered pizza number does not exist");
            }
            
        }

        //print all
        public void PrintPizza()
        {
            
            foreach(var pizza in _pizzas.Values)
            { 
                Console.WriteLine(pizza); 
            }
        }



    }
}
