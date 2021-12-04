using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeMaker
{
    internal static class Program
    {
        public static string PasswordDB = "admin";//pasword
        public static string NameDB = "CoffeeMarket"; // name Create DateBase
        public static string ConnectionString = "Server=localhost;Port=5432;User Id=postgres;Password=" + PasswordDB;
        public static string ConnettionStringDB = "Server=localhost;Port=5432;User Id=postgres;Password=" + PasswordDB + ";Database=" + NameDB;
        public static NpgsqlConnection Connection = new NpgsqlConnection(ConnettionStringDB); //Conect DB
        [STAThread]
        static void Main()
        {
            ConectDB conectDB = new ConectDB();
            conectDB.Connect();
           // Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
