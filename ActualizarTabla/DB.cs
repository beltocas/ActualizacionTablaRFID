using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActualizarTabla
{
    class DB
    {
        public SqlConnection Conectar()
        {
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = "Data Source=LAPTOP-2KIC1MVB\\SERVER;Initial Catalog=PruebasRFID;User ID=sa;Password=perpedj/";

                conexion.Open();
            }
            catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }

            return conexion;
        }

    }
}
