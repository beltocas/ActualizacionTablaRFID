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
        SqlDataReader resultado;
        string ipActual=null;
        public RFID_ConfigIP()
        {
            InitializeComponent();
            SqlConnection conn = db.Conectar();
            SqlCommand sentencia = new SqlCommand(string.Format("EXEC sp_getIP"), conn);
            
            //string texto
            resultado = sentencia.ExecuteReader();
            if (resultado.Read())
            {
                traerIP.Text = "IP Actual: ".ToString() + resultado["valor_parametro"].ToString();
                ipActual = resultado["valor_parametro"].ToString();
                nomIP.Text = resultado["valor_parametro"].ToString();
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RFID_CentroAdmin administrador = new RFID_CentroAdmin();
            administrador.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string numeroIp = Convert.ToString(nomIP);
            //string tiempo = Convert.ToString(time);

            //consulta.Connection = db.Conectar();
            //consulta.CommandText = "dbo.sp_insertarIp";
            //SqlCommand sentencia = new SqlCommand(consulta.CommandText, consulta.Connection);
            //sentencia.Parameters.AddWithValue("@numeroIP", numeroIp);

            //try
            //{
            //    sentencia.ExecuteNonQuery();
            //    MessageBox.Show("Actualizacion Completada");
            //    this.Hide();

            //}
            //catch (SqlException ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //    throw;
            //}

            SqlConnection conn = db.Conectar();
            SqlCommand consulta = new SqlCommand(string.Format("EXEC sp_insertarIp @numeroIP"), conn);
            //consulta.Parameters.AddWithValue("@ipActual", ipActual);
            consulta.Parameters.AddWithValue("@numeroIP", nomIP.Text.ToString());
            consulta.ExecuteNonQuery();


            MessageBox.Show("Actualizacion Completa");
            this.Hide();
        }

        

      
    }
}
