using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace ActualizarTabla
{
    public partial class RFID_ConfigIP : Form
    {
        SqlCommand consulta = new SqlCommand();
        DB db = new DB();
        public RFID_ConfigIP()
        {
            InitializeComponent();
            traerIP.Text = "Esto es una prueba".ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RFID_CentroAdmin administrador = new RFID_CentroAdmin();
            administrador.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string numeroIp = Convert.ToString(nomIP);
            string tiempo = Convert.ToString(time);

            consulta.Connection = db.Conectar();
            consulta.CommandText = "dbo.sp_insertarIp";
            SqlCommand sentencia = new SqlCommand(consulta.CommandText, consulta.Connection);
            sentencia.Parameters.AddWithValue("@numeroIP", numeroIp);

            try
            {
                sentencia.ExecuteNonQuery();
                MessageBox.Show("Actualizacion Completada");
                this.Hide();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }

            MessageBox.Show("Actualizacion Completa");
            this.Hide();
        }

       
    }
}
