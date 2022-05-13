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

namespace ActualizarTabla
{
    public partial class RFID_Modificacion : Form
    {
        
        DB db = new DB();
        SqlDataReader resultado;

        public RFID_Modificacion()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RFID_CentroAdmin administrador = new RFID_CentroAdmin();
            administrador.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Por si no guardo
            string readerNombre = Convert.ToString(nomReader);

            an1.Text = "Principal".ToString();
            an2.Text = "Secunadira".ToString();
            an3.Text = "Salida".ToString();
            an4.Text = "Entrada".ToString();
            /* Continuar conexxion*/
            //SqlConnection conn = db.Conectar();
            //SqlCommand consulta = new SqlCommand(string.Format("SELECT * FROM antena INNER JOIN reader ON antena.reader = reader.id WHERE reader.descr like @dsc "),conn);
            //consulta.Parameters.AddWithValue("@dsc", nomReader.Text);

            //SqlDataReader registro = consulta.ExecuteReader();
            //if (registro.Read())
            //{
            //    an1.Text = registro["num_antena"].ToString();
            //    an2.Text = registro["num_antena"].ToString();
            //    an3.Text = registro["num_antena"].ToString();
            //    an4.Text = registro["num_antena"].ToString();
            //}

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Modificacion realizada");
            this.Hide();
        }
    }
}
