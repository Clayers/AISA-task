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
        private int stateCleanliness;
        private int water;
        private int coffee;
        public int StateCleanliness { get => stateCleanliness; }
        public bool On { get => on; }
        public int Water { get => water; }
        public int Coffee { get => this.coffee; }

        public LogicCoffeMaker()
        {
            ConditionsCoffeeMarket conditionsCoffeeMarket=GetConditionsCoffeeMarketDB();
            this.stateCleanliness = conditionsCoffeeMarket.Cleanness;
            this.water = conditionsCoffeeMarket.Water;
            this.coffee = conditionsCoffeeMarket.Coffee;
        }
        public void OnOffCoffeeMaker()
        {
            if (on == false)
            {
                this.on = true;
            }
            else
            {
                this.on = false;
                SaveDataConditionsCoffeeMaker();
            }

        }

        public void CleanUpCoffeeMaker()
        {
            if (on == false)
            {
                this.stateCleanliness = 100;
                SaveDataUseCoffeeMaker(false, false, true);
                SaveDataConditionsCoffeeMaker();
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
                SaveDataUseCoffeeMaker(false, true, false);
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
                SaveDataUseCoffeeMaker(true, false, false);
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
        public void CreateCoffee(List<Coffee> coffees, string selectedCoffee)
        {
            FillCoffee fillCoffee = new FillCoffee(coffees);
            if (on == true)
            {
                if (ChekingCoffee() == true & ChekingWater() == true & CheckingClean() == true)
                {
                    for (int i = 0; i < fillCoffee.coffees.Count; i++)
                    {
                        if (fillCoffee.coffees[i].Name==selectedCoffee)
                        {
                            Coffee coffee = new Coffee();
                            coffee = fillCoffee.coffees[i];
                            if (this.stateCleanliness>= coffee.Clean&& this.water>= coffee.Water && this.coffee>= coffee.CoffeeBeans)
                            {
                                this.stateCleanliness = this.stateCleanliness - coffee.Clean;
                                this.water = this.water - coffee.Water;
                                this.coffee = this.coffee - coffee.CoffeeBeans;
                                SaveDataCoffeeSesions(coffee);
                            }
                            else
                            {
                                MessageBox.Show("Add water, coffee or clean the coffee machine.", "Something is missing");
                            }

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("On Coffee Maker", "Coffee Maker Off");
            }

        }
        public void SaveDataUseCoffeeMaker(bool numberCoffeeRefils, bool numberWarerRefils, bool numberClean)
        {

            UseCoffeeMaker useCoffeeMaker = UseCoffeeMakerController.GetDataUseCoffeeMaker();
            if (numberCoffeeRefils==true)
            {
                useCoffeeMaker.NumberCoffeeRefills++;
            }
            if (numberClean == true)
            {
                useCoffeeMaker.NumberClean++;
            }
            if (numberWarerRefils == true)
            {
                useCoffeeMaker.NumberWaterRefills++;
            }
            UseCoffeeMakerController.Update(useCoffeeMaker);
        }
        public void SaveDataConditionsCoffeeMaker()
        {
            ConditionsCoffeeMarket conditionsCoffeeMarket = new ConditionsCoffeeMarket(DateTime.Now,this.water,this.coffee,this.stateCleanliness); 
            ConditionsCoffeeMakerController.AddEntryConditionsCoffeeMaker(conditionsCoffeeMarket);
        }
        public ConditionsCoffeeMarket GetConditionsCoffeeMarketDB()
        {
            ConditionsCoffeeMarket conditionsCoffeeMarket = ConditionsCoffeeMakerController.GetLastDataConditionsCoffeeMaker();
            return conditionsCoffeeMarket;
        }
        public void SaveDataCoffeeSesions(Coffee coffee)
        {
            CoffeeSessionsController.AddEntryUseCoffeeSessions(new CoffeeSessions(DateTime.Now, coffee.Name, coffee.Water, coffee.CoffeeBeans, coffee.Clean));
        }
        
    }
}
