using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.Common;

namespace Matricula
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           /* string provider = ConfigurationManager.AppSettings["provider"];
            string connectionString = ConfigurationManager.AppSettings["connectionString"];
            DbProviderFactory factory = DbProviderFactories.GetFactory(provider);
            using (DbConnection connection = factory.CreateConnection())
            {
                if (connection==null)
                {
                    Console.WriteLine("Conection error");
                    Console.ReadLine();
                    return;

                }
                connection.ConnectionString = connectionString;
                DbCommand command = factory.CreateCommand();
                if(command == null)
                {
                    Console.WriteLine("Conection error");
                    Console.ReadLine();
                    return;
                }
                command.Connection = connection;
                command.CommandText = "Select * from Login";
                using (DbDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Console.WriteLine($"{dataReader["Username"]}"
                            + $"{dataReader["Login"]}");
                    }
                }
                Console.ReadLine();
            }*/

                Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FLogIn());
        }
    }
}
