using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeMaker
{
    public partial class MainForm : Form
    {
        private LogicCoffeMaker logicCoffeMaker = new LogicCoffeMaker();
        public MainForm()
        {
            InitializeComponent();

            UptatelabelCoffee();
            UptatelabelClean();
            UptatelabelCoffeeMaker();
            UptatelabelWater();
        }


        private void buttonOnCoffeeMaker_Click(object sender, EventArgs e)
        {
            logicCoffeMaker.OnOffCoffeeMaker();
            UptatelabelCoffeeMaker();
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {

            logicCoffeMaker.CleanUpCoffeeMaker();

            UptatelabelClean();
        }

        private void buttonPourWater_Click(object sender, EventArgs e)
        {

            logicCoffeMaker.FillWaterCoffeeMaker();

            UptatelabelWater();
        }

        private void buttonPourCoffee_Click(object sender, EventArgs e)
        {

            logicCoffeMaker.FillCoffeeCoffeeMaker();

            MessageBox.Show("On Coffee Maker", "Coffee Maker Off");

            UptatelabelCoffee();
        }
        private void UptatelabelCoffee() { labelCoffee.Text = Convert.ToString("Coffee: " + logicCoffeMaker.Coffee + "g"); }
        private void UptatelabelClean() { labelClean.Text = Convert.ToString("Cleanness: " + logicCoffeMaker.StateCleanliness + "%"); }
        private void UptatelabelCoffeeMaker()
        {
            if (logicCoffeMaker.On == true)
            {
                groupBoxCoffeeMaker.Text = Convert.ToString("Coffee Maker: On");
            }
            else
            {
                groupBoxCoffeeMaker.Text = Convert.ToString("Coffee Maker: Off");
            }
        }
        private void UptatelabelWater() { labelWater.Text = Convert.ToString("Water: " + logicCoffeMaker.Water + "ml"); }

    }
}
