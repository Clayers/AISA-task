using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    internal class CoffeeSesions
    {
        private DateTime dateTime = new DateTime();
        private string typeCoffee;
        private int water;
        private int coffee;
        private int clean;

        public CoffeeSesions(DateTime dateTime, string typeCoffee, int water, int coffee, int clean)
        {
            this.dateTime = dateTime;
            this.typeCoffee = typeCoffee;
            this.water = water;
            this.coffee = coffee;
            this.clean = clean;
        }

        public DateTime DateTime { get => dateTime; set => dateTime = value; }
        public string TypeCoffee { get => typeCoffee; set => typeCoffee = value; }
        public int Water { get => water; set => water = value; }
        public int Coffee { get => coffee; set => coffee = value; }
        public int Clean { get => clean; set => clean = value; }
    }
}
