using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    internal class ConditionsCoffeeMarket
    {
        private DateTime dateTime = new DateTime();
        private int water;
        private int coffee;
        private int cleanness;

        public ConditionsCoffeeMarket(DateTime dateTime, int water, int coffee, int cleanness)
        {
            this.dateTime = dateTime;
            this.water = water;
            this.coffee = coffee;
            this.cleanness = cleanness;
        }

        public DateTime DateTime { get => dateTime; set => dateTime = value; }
        public int Water { get => water; set => water = value; }
        public int Coffee { get => coffee; set => coffee = value; }
        public int Cleanness { get => cleanness; set => cleanness = value; }
    }
}

