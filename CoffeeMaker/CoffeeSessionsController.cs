using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    internal class CoffeeSessionsController
    {
        public static void AddEntryUseCoffeeSessions(CoffeeSesions coffeeSesions) //Метод добавления данных в таблицу CoffeeSession
        {
            var sql = $"INSERT INTO CoffeeSession(date_sesion, typecoffee, water, coffee, clean) VALUES('{coffeeSesions.DateTime}','{coffeeSesions.TypeCoffee}',{coffeeSesions.Water},{coffeeSesions.Coffee},{coffeeSesions.Clean})";
            var cmds = new NpgsqlCommand(sql, Program.Connection);
            cmds.ExecuteNonQuery();
        }
    }
}
