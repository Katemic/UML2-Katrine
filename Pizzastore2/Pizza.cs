using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzastore2
{
    public class Pizza
    {
        //instance fields 
        private int _number;
        private string _name;
        private int _price;
        private string _toppings;


        //properties
        public int Number
        {
            get { return _number; }
        }

        public string Name
        {
            get { return _name; }
        }

        public int Price
        {
            get { return _price; }
        }

        public string Toppings
        {
            get { return _toppings; }
        }

        //constructor 
        public Pizza (int number, string name, int price, string toppings)
        {
            _name = name;
            _price = price;
            _toppings = toppings;
            _number = number;
        }

        //methods 



        //ToString
        public override string ToString()
        {
            return $"{Number}.\t|{Name}|\t\t|{Price}kr|\n\t-{Toppings}\n";
        }



    }
}
