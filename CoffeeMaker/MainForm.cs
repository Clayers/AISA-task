using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace CoffeeMaker
{
    public partial class MainForm : Form
    {
        private LogicCoffeMaker logicCoffeMaker;
        private FillCoffee fillCoffee;

        public MainForm()
        {
            logicCoffeMaker = new LogicCoffeMaker();
            fillCoffee = new FillCoffee();
            InitializeComponent();
            UpdateAll();
            FillCombobox();
            UpdateListBox();

        }


        private void buttonOnCoffeeMaker_Click(object sender, EventArgs e)
        {
            logicCoffeMaker.OnOffCoffeeMaker();
            UpdateAll();
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {

            logicCoffeMaker.CleanUpCoffeeMaker();

            UpdateAll();
        }

        private void buttonPourWater_Click(object sender, EventArgs e)
        {

            logicCoffeMaker.FillWaterCoffeeMaker();

            UpdateAll();
        }

        private void buttonPourCoffee_Click(object sender, EventArgs e)
        {

            logicCoffeMaker.FillCoffeeCoffeeMaker();

            UpdateAll();
        }
        private void UpdatelabelCoffee() { labelCoffee.Text = Convert.ToString("Coffee: " + logicCoffeMaker.Coffee + "g"); }
        private void UpdatelabelAllCoffee()
        {
            if (CoffeeSessionsController.GetAllCountCoffeeSessions() > 0)
            {
                labelCofeeAllTime.Text = Convert.ToString("Сoffee was poured " + CoffeeSessionsController.GetAllCountCoffeeSessions() + " times");
            }
            else
            {
                labelCofeeAllTime.Text = Convert.ToString("coffee has never been poured");
            }

        }
        private void UpdatelabelCoffeeMonth()
        {
            if (CoffeeSessionsController.GetCountThisMonthCoffeeSessions() > 0)
            {
                labelCoffeeMonth.Text = Convert.ToString("Сoffee was poured " + CoffeeSessionsController.GetCountThisMonthCoffeeSessions() + " times");
            }
            else
            {
                labelCofeeAllTime.Text = Convert.ToString("coffee has never been poured");
            }

        }
        private void UpdatelabelPopularCoffee()
        {
            if (CoffeeSessionsController.GetPopularCoffeeAllTimeCoffeeSessions() != null)
            {
                labelPopularCofeeAllTime.Text = Convert.ToString("Popular coffee All Time: " + CoffeeSessionsController.GetPopularCoffeeAllTimeCoffeeSessions());
            }
            else
            {
                labelPopularCofeeAllTime.Text = Convert.ToString("You haven't had your coffee");
            }
        }
        private void UpdatelabelPopularCoffeeMonth()
        {
            if (CoffeeSessionsController.GetPopularCoffeeThisMonthCoffeeSessions() != null)
            {
                labelPopularMonth.Text = Convert.ToString("Popular coffee Month: " + CoffeeSessionsController.GetPopularCoffeeThisMonthCoffeeSessions());
            }
            else
            {
                labelPopularMonth.Text = Convert.ToString("You haven't had your coffee");
            }
        }
        private void UpdatelabelWaterAll()
        {
            if (CoffeeSessionsController.GetAllWaterCoffeeSessions() != 0)
            {
                labelWaterAllTime.Text = Convert.ToString("Total water spent: " + CoffeeSessionsController.GetAllWaterCoffeeSessions() + "ml");
            }
            else
            {
                labelWaterAllTime.Text = Convert.ToString("Water is not spent");
            }
        }
        private void UpdatelabelWaterMonth()
        {
            if (CoffeeSessionsController.GetWaterThisMonthCoffeeSessions() != 0)
            {
                labelWaterMonth.Text = Convert.ToString("Water spent in a month: " + CoffeeSessionsController.GetWaterThisMonthCoffeeSessions() + "ml");
            }
            else
            {
                labelWaterMonth.Text = Convert.ToString("Water is not spent");
            }
        }
        private void UpdatelabelCoffeeBeansMonth()
        {
            if (CoffeeSessionsController.GetCoffeeBeansThisMonthCoffeeSessions() != 0)
            {
                labelCoffeeBeansMonth.Text = Convert.ToString("Coffee spent in a month: " + CoffeeSessionsController.GetCoffeeBeansThisMonthCoffeeSessions() + "g");
            }
            else
            {
                labelCoffeeBeansMonth.Text = Convert.ToString("Coffee not spent");
            }
        }
        private void UpdatelabelCoffeeBeanseAll()
        {
            if (CoffeeSessionsController.GetAllCoffeeBeansCoffeeSessions() != 0)
            {
                labelCoffeeBeansAllTime.Text = Convert.ToString("Coffee spent all the time: " + CoffeeSessionsController.GetAllCoffeeBeansCoffeeSessions() + "g");
            }
            else
            {
                labelCoffeeBeansAllTime.Text = Convert.ToString("Coffee not spent");
            }
        }
        private void UpdatelabelClean() { labelClean.Text = Convert.ToString("Cleanness: " + logicCoffeMaker.StateCleanliness + "%"); }
        private void UpdatelabelWater() { labelWater.Text = Convert.ToString("Water: " + logicCoffeMaker.Water + "ml"); }
        private void UpdatelabelAllClean(int number) { labelAllClean.Text = Convert.ToString("Cleaned " + number + " times"); }
        private void UpdatelabelAllWater(int number) { labelAllPourWater.Text = Convert.ToString("Water was poured " + number + " times"); }
        private void UpdatelabelAllCoffe(int number) { labelAllPourCoffee.Text = Convert.ToString("Coffee was poured " + number + " times"); }
        private void UpdateListBox()
        {
            this.listBoxCoffee.Items.Clear();
            List<CoffeeSessions> coffeeSesions = CoffeeSessionsController.GetListCoffeeSessions();
            for (int i = 0; i < coffeeSesions.Count; i++)
            {
                this.listBoxCoffee.Items.Add(coffeeSesions.ElementAt(i).DateTime.ToString("d") + " " + coffeeSesions.ElementAt(i).TypeCoffee);
            }
        }
        private void UpdatelabelCoffeeMaker()
        {
            if (logicCoffeMaker.On == true)
            {
                groupBoxCoffeeMaker.Text = Convert.ToString("Coffee Maker: On");
                pictureBoxOnOff.BackColor = Color.Green;
            }
            else
            {
                groupBoxCoffeeMaker.Text = Convert.ToString("Coffee Maker: Off");
                pictureBoxOnOff.BackColor = Color.Red;
            }
        }

        private void UpdateAll()
        {
            UpdatelabelCoffee();
            UpdatelabelWater();
            UpdatelabelClean();
            UpdatelabelCoffeeMaker();
            UseCoffeeMaker useCoffeeMaker = UseCoffeeMakerController.GetDataUseCoffeeMaker();
            UpdatelabelAllClean(useCoffeeMaker.NumberClean);
            UpdatelabelAllWater(useCoffeeMaker.NumberWaterRefills);
            UpdatelabelAllCoffe(useCoffeeMaker.NumberCoffeeRefills);
            UpdatelabelAllCoffee();
            UpdatelabelCoffeeMonth();
            UpdatelabelPopularCoffeeMonth();
            UpdatelabelPopularCoffee();
            UpdatelabelCoffeeBeanseAll();
            UpdatelabelCoffeeBeansMonth();
            UpdatelabelWaterMonth();
            UpdatelabelWaterAll();
            UpdateProgresBarCoffee();
            UpdateProgresBarWater();

        }
        private void UpdateProgresBarCoffee()
        {
            progressBarCofee.Value = logicCoffeMaker.Coffee;
        }
        private void UpdateProgresBarWater()
        {
            progressBarWater.Value = logicCoffeMaker.Water;
        }
        private void FillCombobox()
        {
            this.comboBox1.DataSource = fillCoffee.coffees;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.ValueMember = "Name";
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void buttonСoffee_Click(object sender, EventArgs e)
        {
            logicCoffeMaker.CreateCoffee(fillCoffee.coffees, comboBox1.SelectedValue.ToString());
            UpdateAll();
            UpdateListBox();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            logicCoffeMaker.SaveDataConditionsCoffeeMaker();
            Application.Exit();

        }
    }
}
