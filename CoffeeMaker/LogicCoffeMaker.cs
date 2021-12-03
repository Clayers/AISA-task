using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeMaker
{
    internal class LogicCoffeMaker
    {
        private bool on = false;
        private int stateCleanliness = 100;
        private int water = 200;
        private int coffee = 333;

        public int StateCleanliness { get => stateCleanliness; }
        public bool On { get => on; }
        public int Water { get => water; }
        public int Coffee { get => this.coffee; }

        public void OnOffCoffeeMaker()
        {
            if (on == false)
            {
                this.on = true;
            }
            else
            {
                this.on = false;
            }

        }

        public void CleanUpCoffeeMaker()
        {
            if (on == false)
            {
                this.stateCleanliness = 100;
            }
            else
            {
                MessageBox.Show("Off Coffee Maker", "Coffee Maker On");
            }
        }



        public bool CheckingClean()
        {

            if (this.stateCleanliness < 15)
            {
                MessageBox.Show("Dirty", "Clean");
                return false;
            }
            else
            {
                return true;
            }
        }

        public void FillWaterCoffeeMaker()
        {
            if (on == true)
            {
                this.water = 3000;
            }
            else
            {
                MessageBox.Show("On Coffee Maker", "Coffee Maker Off");
            }
        }
        public bool ChekingWater()
        {

            if (this.water < 250)
            {
                MessageBox.Show("No Water", "Fill");
                return false;
            }
            else
            {
                return true;
            }

        }
        public void FillCoffeeCoffeeMaker()
        {
            if (on == true)
            {
                this.coffee = 500;
            }
            else
            {
                MessageBox.Show("On Coffee Maker", "Coffee Maker Off");
            }
        }
        public bool ChekingCoffee()
        {
            if (this.coffee < 50)
            {
                MessageBox.Show("No Coffee Beans", "Fill");
                return false;
            }
            else
            {
                return true;
            }
        }
        public void SaveData()
        {

        }
    }
}
