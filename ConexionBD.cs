using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Matricula
{
    class ConexionBD
    {
        string cadena = "Data source= DESKTOP-B6EFBEB\\SQLEXPRESS; Initial Catalog= Matricula; Integrated Security = True";
        public SqlConnection conectarbd = new SqlConnection();

        public ConexionBD()
        {
            conectarbd.ConnectionString = cadena;
        }

        public void abrir()
        {
            try
            {
                conectarbd.Open();
                Console.WriteLine("Conexion abierta");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar con la BD" + ex.Message);
            }

        }
        public void cerrar()
        {
            conectarbd.Close();
        }
    }
}
