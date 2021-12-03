using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeMaker
{
    internal class ConectDB
    {
        public void Connect()
        {  
            try
            {
                if (chkDBExists(Program.ConnettionStringDB))
                {  //Проверка наличия Базы Данных
                    Program.Connection.Open(); //Открываем соединение
                }
                else //Создание Базы Данных и таблиц
                {
                    Program.Connection = new NpgsqlConnection(Program.ConnectionString);
                    Program.Connection.Open();

                    var Createdb = new NpgsqlCommand($"CREATE DATABASE \"{Program.NameDB}\" " +
                                       "WITH OWNER = \"postgres\" " +
                                       "ENCODING = 'UTF8' " +
                                       "CONNECTION LIMIT = -1;", Program.Connection).ExecuteNonQuery();

                    Program.Connection.Close();

                    Program.Connection = new NpgsqlConnection(Program.ConnettionStringDB);
                    Program.Connection.Open();

                    //////Создание таблиц по умолчанию
                    var command = new NpgsqlCommand();
                    command.Connection = Program.Connection;
                    //Таблица CoffeeSession
                    command.CommandText = @"CREATE TABLE CoffeeSession(id SERIAL PRIMARY KEY, date_session DATE NOT NULL, typecoffee VARCHAR(50) NOT NULL, water INT NOT NULL, coffee INT NOT NULL, clean INT NOT NULL)";
                    command.ExecuteNonQuery();
                    command.CommandText = @"CREATE TABLE ConditionCoffeeMaker(id SERIAL PRIMARY KEY, date_session DATE NOT NULL, water INT NOT NULL, coffee INT NOT NULL, cleanness INT NOT NULL)";
                    command.ExecuteNonQuery();
                    command.CommandText = @"CREATE TABLE UseCoffeeMaker(id SERIAL PRIMARY KEY, number_coffee_refills INT NOT NULL, number_water_refills INT NOT NULL, number_clean INT NOT NULL)";
                    command.ExecuteNonQuery();

                    FillTestData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось подключиться к PostgresDB. Проверте данные от сервера строку подключения к postgres"); return;
            }

        }
        private bool chkDBExists(string connectionStr) //Проверка наличия Базы Данных
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connectionStr))
                {
                    conn.Open();
                    return true;
                }
            }
            catch (Exception ex) { return false; }
        }
        private void FillTestData()
        {
            UseCoffeeMakerController.AddEntryUseCoffeeMaker( new UseCoffeeMaker(0, 0, 0));
            CoffeeSessionsController.AddEntryUseCoffeeSessions(new CoffeeSessions(new DateTime(2015, 7, 20), "espresso", 100,100,5));
            CoffeeSessionsController.AddEntryUseCoffeeSessions(new CoffeeSessions(new DateTime(2015, 7, 20), "espresso", 100, 100, 5));
            CoffeeSessionsController.AddEntryUseCoffeeSessions(new CoffeeSessions(new DateTime(2015, 7, 20), "espresso", 100, 100, 5));
            CoffeeSessionsController.AddEntryUseCoffeeSessions(new CoffeeSessions(new DateTime(2015, 7, 20), "espresso", 100, 100, 5));
            CoffeeSessionsController.AddEntryUseCoffeeSessions(new CoffeeSessions(new DateTime(2015, 7, 20), "espresso", 100, 100, 5));
            CoffeeSessionsController.AddEntryUseCoffeeSessions(new CoffeeSessions(new DateTime(2015, 7, 20), "espresso", 100, 100, 5));
            CoffeeSessionsController.AddEntryUseCoffeeSessions(new CoffeeSessions(new DateTime(2015, 7, 20), "espresso", 100, 100, 5));
            CoffeeSessionsController.AddEntryUseCoffeeSessions(new CoffeeSessions(new DateTime(2015, 7, 20), "espresso", 100, 100, 5));
            CoffeeSessionsController.AddEntryUseCoffeeSessions(new CoffeeSessions(new DateTime(2015, 7, 20), "espresso", 100, 100, 5));
            CoffeeSessionsController.AddEntryUseCoffeeSessions(new CoffeeSessions(new DateTime(2016, 7, 20), "espresso", 100, 100, 5));
            CoffeeSessionsController.AddEntryUseCoffeeSessions(new CoffeeSessions(new DateTime(2016, 7, 20), "espresso", 100, 100, 5));
            CoffeeSessionsController.AddEntryUseCoffeeSessions(new CoffeeSessions(new DateTime(2019, 7, 20), "espresso", 100, 100, 5));
            ConditionsCoffeeMakerController.AddEntryConditionsCoffeeMaker(new ConditionsCoffeeMarket(new DateTime(2016, 7, 20), 3000, 500, 100));

        }

    }
}
