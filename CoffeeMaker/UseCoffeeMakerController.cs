using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeMaker
{
    internal class UseCoffeeMakerController
    {
        public static void AddEntryUseCoffeeMaker(UseCoffeeMaker useCoffeeMaker) //Метод добавления данных в таблицу UseCoffeeMaker
        {
            var sql = $"INSERT INTO UseCoffeeMaker(number_coffee_refills, number_water_refills, number_clean) VALUES({useCoffeeMaker.NumberCoffeeRefills},{useCoffeeMaker.NumberWaterRefills},{useCoffeeMaker.NumberClean})";
            var cmds = new NpgsqlCommand(sql, Program.Connection);
            cmds.ExecuteNonQuery();
        }

        public static void Update(UseCoffeeMaker useCoffeeMaker) //Метод  изменения данных в таблице UseCoffeeMaker по id так-как только 1 сесия пока изменяется только 1 поле
        {
            try
            {
                var sql = $"UPDATE UseCoffeeMaker Set number_coffee_refills='{useCoffeeMaker.NumberCoffeeRefills}', number_water_refills='{useCoffeeMaker.NumberWaterRefills}', number_clean='{useCoffeeMaker.NumberClean}'"
                    + $"WHERE id='{1}'";
                var cmd = new NpgsqlCommand(sql, Program.Connection);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show("Ошибка обновления использования кофемашины"); }
        }
        public static UseCoffeeMaker GetDataUseCoffeeMaker()
        {
            var sql = $"SELECT * FROM UseCoffeeMaker WHERE id = '{1}'";
            using (var command = new NpgsqlCommand(sql, Program.Connection))
            {
                int numberCoffeeRefills=0;
                int numberWaterRefills=0;
                int numberClean=0;
                using (var reader = command.ExecuteReader())
                    while (reader.Read())
                    {

                        numberCoffeeRefills = Int32.Parse(reader["number_coffee_refills"].ToString());
                        numberWaterRefills = Int32.Parse(reader["number_water_refills"].ToString());
                        numberClean = Int32.Parse(reader["number_clean"].ToString());

                    }

                UseCoffeeMaker useCoffeeMaker = new UseCoffeeMaker(numberCoffeeRefills, numberWaterRefills, numberClean);
                return useCoffeeMaker;
            }
        }
        

    }
}
