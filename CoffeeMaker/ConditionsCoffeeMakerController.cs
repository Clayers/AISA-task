using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    internal class ConditionsCoffeeMakerController
    {
        public static void AddEntryConditionsCoffeeMaker(ConditionsCoffeeMarket conditionsCoffeeMarket) //Метод добавления данных в таблицу CoffeeSession
        {
            var sql = $"INSERT INTO ConditionCoffeeMaker(date_session, water, coffee, cleanness) VALUES('{conditionsCoffeeMarket.DateTime}',{conditionsCoffeeMarket.Water},'{conditionsCoffeeMarket.Coffee}','{conditionsCoffeeMarket.Cleanness}')";
            var cmds = new NpgsqlCommand(sql, Program.Connection);
            cmds.ExecuteNonQuery();
        }
        public static ConditionsCoffeeMarket GetLastDataConditionsCoffeeMaker()
        {
            var sql = $"SELECT * FROM ConditionCoffeeMaker ORDER BY id DESC LIMIT 1";
            using (var command = new NpgsqlCommand(sql, Program.Connection))
            {
                DateTime dateTime = new DateTime();
                int water = 0;
                int coffee = 0;
                int cleanness = 0;
                using (var reader = command.ExecuteReader())
                    while (reader.Read())
                    {

                        dateTime = DateTime.Parse(reader["date_session"].ToString());
                        water = Int32.Parse(reader["water"].ToString());
                        coffee = Int32.Parse(reader["coffee"].ToString());
                        cleanness = Int32.Parse(reader["cleanness"].ToString());
                    }

                ConditionsCoffeeMarket conditionsCoffeeMarket = new ConditionsCoffeeMarket(dateTime, water, coffee, cleanness);
                return conditionsCoffeeMarket;
            }
        }
    }
}
