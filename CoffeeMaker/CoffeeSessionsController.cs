using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeMaker
{
    internal class CoffeeSessionsController
    {
        public static void AddEntryUseCoffeeSessions(CoffeeSessions coffeeSessions) //Метод добавления данных в таблицу CoffeeSession
        {
            var sql = $"INSERT INTO CoffeeSession(date_session, typecoffee, water, coffee, clean) VALUES('{coffeeSessions.DateTime}','{coffeeSessions.TypeCoffee}',{coffeeSessions.Water},{coffeeSessions.Coffee},{coffeeSessions.Clean})";
            var cmds = new NpgsqlCommand(sql, Program.Connection);
            cmds.ExecuteNonQuery();

        }
        public static List<CoffeeSessions> GetListCoffeeSessions()
        {
            List<CoffeeSessions> conditions = new List<CoffeeSessions>();
            var sql = $"SELECT * FROM CoffeeSession ORDER BY id DESC LIMIT 15";
            using (var command = new NpgsqlCommand(sql, Program.Connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CoffeeSessions coffeeSessions = new CoffeeSessions(DateTime.Parse(reader["date_session"].ToString()), reader["typecoffee"].ToString(), Int32.Parse(reader["water"].ToString()), Int32.Parse(reader["coffee"].ToString()), Int32.Parse(reader["clean"].ToString()));
                        conditions.Add(coffeeSessions);

                    }
                }
                if (conditions.Count == 0) return null;
                return conditions;
            }
        }
        public static int GetAllCountCoffeeSessions() // Ментод Получения всех сессий кофе
        {
            int Count=0;
            var sql = $"SELECT COUNT(*) FROM CoffeeSession";
            using (var command = new NpgsqlCommand(sql, Program.Connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Count = Int32.Parse(reader["count"].ToString());

                    }
                }
                return Count;
            }
        }
        public static int GetCountThisMonthCoffeeSessions()// Ментод Получения сессий кофе за текущий месяц
        {
            int Count = 0;
            var sql = $"select COUNT(*) from CoffeeSession where date_part('month', date_session) = date_part('month', now())";
            using (var command = new NpgsqlCommand(sql, Program.Connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Count = Int32.Parse(reader["count"].ToString());

                    }
                }
                return Count;
            }
        }
        public static int GetAllSumCoffeeSessions(string Data) // Ментод Получения потраченной воды и кофе за все время
        {
            try
            {
                int All = 0;
                var sql = $"SELECT SUM({Data})FROM CoffeeSession";
                using (var command = new NpgsqlCommand(sql, Program.Connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            All = Int32.Parse(reader["sum"].ToString());

                        }
                    }
                    return All;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Table not found"); return 0;
            }
        }
        public static int GetAllSumThisMonthCoffeeSessions(string Data) // Ментод Получения потраченной воды и кофе за месяц
        {
            try
            {
                int AllWater = 0;
                var sql = $"select SUM({Data}) from CoffeeSession where date_part('month', date_session) = date_part('month', now())";
                using (var command = new NpgsqlCommand(sql, Program.Connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            AllWater = Int32.Parse(reader["sum"].ToString());

                        }
                    }
                    return AllWater;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Table not found"); return 0;
            }

        }
        public static string GetPopularCoffeeAllTimeCoffeeSessions()
        {
            string PopularCoffee = null;
            var sql = $"SELECT typecoffee FROM Coffeesession GROUP BY typecoffee ORDER BY COUNT(*) DESC LIMIT 1";
            using (var command = new NpgsqlCommand(sql, Program.Connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        PopularCoffee = reader["typecoffee"].ToString();

                    }
                }
                return PopularCoffee;
            }
        }
        public static string GetPopularCoffeeThisMonthCoffeeSessions()
        {
            string PopularCoffee = null;
            var sql = $"select typecoffee from CoffeeSession Where date_part('month', date_session) = date_part('month', now()) GROUP BY typecoffee, date_session ORDER BY COUNT(*) DESC LIMIT 1; ";
            using (var command = new NpgsqlCommand(sql, Program.Connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        PopularCoffee = reader["typecoffee"].ToString();

                    }
                }
                return PopularCoffee;
            }
        }
    }
}
