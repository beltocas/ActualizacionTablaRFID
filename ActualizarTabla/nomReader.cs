using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActualizarTabla
{
    public class nomReader
    {
        DB db = new DB();
        public DataTable CargarCombo()
        {
            SqlConnection conn = db.Conectar();
            SqlDataAdapter da = new SqlDataAdapter("SELECT reader.descr from reader", conn);
            //da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dtable = new DataTable();
            da.Fill(dtable);
            return dtable;

        }
    }
}
