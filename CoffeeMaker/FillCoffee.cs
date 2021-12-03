using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    internal class FillCoffee
    {
        public List<Coffee> coffees;
        public FillCoffee()
        {
         coffees = new List<Coffee>();
            coffees.Add(NewCoffee("americano ",150,4,50));
            coffees.Add(NewCoffee("espresso",100,3,35));
            coffees.Add(NewCoffee("double espresso",200,6,70));
        }
        public FillCoffee(List<Coffee> coffees)
        {
            this.coffees = new List<Coffee>();
            this.coffees.AddRange(coffees);
        }
        private Coffee NewCoffee(string name, int water, int clean, int coffeeBeans)
        { 
        Coffee coffee = new Coffee();
            coffee.Name = name;
            coffee.Water = water;
            coffee.Clean = clean;   
            coffee.CoffeeBeans = coffeeBeans;   
            return coffee;
        }
    }
}
