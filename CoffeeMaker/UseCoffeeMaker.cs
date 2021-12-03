using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    internal class UseCoffeeMaker
    {
        private int numberCoffeeRefills;
        private int numberWaterRefills;
        private int numberClean;

        public UseCoffeeMaker(int numberCoffeeRefills, int numberWaterRefills, int numberClean)
        {
            this.numberCoffeeRefills = numberCoffeeRefills;
            this.numberWaterRefills = numberWaterRefills;
            this.numberClean = numberClean;
        }

        public int NumberCoffeeRefills { get => numberCoffeeRefills; set => numberCoffeeRefills = value; }
        public int NumberWaterRefills { get => numberWaterRefills; set => numberWaterRefills = value; }
        public int NumberClean { get => numberClean; set => numberClean = value; }
    }
}
