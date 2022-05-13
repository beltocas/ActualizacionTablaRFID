using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace ActualizarTabla
{
    public partial class RFID_NuevoRFID : Form
    {
        
        SqlCommand consulta = new SqlCommand();
        DB db = new DB();

        SqlDataReader resultado;

        public RFID_NuevoRFID()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            RFID_CentroAdmin administrador = new RFID_CentroAdmin();
            administrador.Show();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            string codigoReader = System.Convert.ToString(codReaderReg);
            string anN1 = System.Convert.ToString(antenaN1);
            string anN2 = System.Convert.ToString(antenaN2);
            string anN3 = System.Convert.ToString(antenaN3);
            string anN4 = System.Convert.ToString(antenaN4);

            consulta.Connection = db.Conectar();
            
            consulta.CommandText = "sp_insertarReader";

            SqlCommand sentencia = new SqlCommand(string.Format("execute sp_insertarReader @nombre_reader,@num_antena1,@descr1,@num_antena2,@descr2,@num_antena3,@descr3"),consulta.Connection);
            sentencia.CommandType = System.Data.CommandType.StoredProcedure;
            sentencia.Parameters.AddWithValue("@nombre_reader", codigoReader);
            sentencia.Parameters.AddWithValue("@num_antena1", 1);
            sentencia.Parameters.AddWithValue("@descr1", anN1);
            sentencia.Parameters.AddWithValue("@num_antena2", 2);
            sentencia.Parameters.AddWithValue("@descr2", anN2);
            sentencia.Parameters.AddWithValue("@num_antena3", 3);
            sentencia.Parameters.AddWithValue("@descr3", anN3);

            try
            {
                sentencia.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            
        }

        
    }
}
