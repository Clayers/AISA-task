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
            var sql = $"INSERT INTO ConditionCoffeeMaker(date_sesion, water, coffee, cleanness) VALUES('{conditionsCoffeeMarket.DateTime}',{conditionsCoffeeMarket.Water},'{conditionsCoffeeMarket.Coffee}','{conditionsCoffeeMarket.Cleanness}')";
            var cmds = new NpgsqlCommand(sql, Program.Connection);
            cmds.ExecuteNonQuery();
        }
    }
}
