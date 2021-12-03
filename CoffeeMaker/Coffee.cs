using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    internal class Coffee
    {
        private string name;
        private int water;
        private int coffeeBeans;
        private int clean;

        public string Name { get => name; set => name = value; }
        public int Water { get => water; set => water = value; }
        public int CoffeeBeans { get => coffeeBeans; set => coffeeBeans = value; }
        public int Clean { get => clean; set => clean = value; }
    }
}
