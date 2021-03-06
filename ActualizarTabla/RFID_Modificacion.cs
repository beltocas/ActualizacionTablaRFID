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
        
        SqlDataAdapter adaptador;
        SqlCommandBuilder scb;
        DataTable dt;

        nomReader nombreReaderBox = new nomReader();

        private void RFID_Modificacion_Load(object sender, EventArgs e)
        {

            cboNomReader.DataSource = nombreReaderBox.CargarCombo();
            cboNomReader.DisplayMember = "descr";

            //cboNomReader.ValueMember = "id";
        }

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
            SqlConnection conn = db.Conectar();
            SqlCommand consulta = new SqlCommand(string.Format("SELECT antena.num_antena as NumeroAntena, antena.descr as Nombre, reader.descr as NombreReader FROM antena INNER JOIN reader ON antena.reader = reader.id WHERE reader.descr like @dsc "), conn);
            consulta.Parameters.AddWithValue("@dsc", cboNomReader.Text.ToString());
            adaptador = new SqlDataAdapter(consulta);
            dt = new DataTable();
            dt.Clear();
            adaptador.Fill(dt);
            antenasView.DataSource = dt;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = db.Conectar();
            for (int item = 0; item < antenasView.Rows.Count - 1; item++)
            {
                //SqlCommand cmd2 = new SqlCommand("Update antena  set antena.num_antena = @numAntena, antena.descr = @nombre from antena INNER JOIN reader as rd ON antena.reader = rd.id WHERE rd.descr like @idReader and antena.num_antena like @numero", conn);
                //SqlCommand cmd3 = new SqlCommand("Update reader set reader.descr = @actuReader from reader INNER JOIN antena ON  reader.id = antena.reader WHERE reader.descr like @idReader1", conn);
                //cmd2.Parameters.AddWithValue("@idReader", cboNomReader.Text.ToString());
                //cmd3.Parameters.AddWithValue("@idReader1", cboNomReader.Text.ToString());
                //cmd2.Parameters.AddWithValue("@numero", antenasView.Rows[item].Cells[0].Value);
                //cmd3.Parameters.AddWithValue("@actuReader", antenasView.Rows[0].Cells[2].Value);
                //cmd2.Parameters.AddWithValue("@nombre", antenasView.Rows[item].Cells[1].Value);
                //cmd2.Parameters.AddWithValue("@numAntena", antenasView.Rows[item].Cells[0].Value);



                //cmd2.ExecuteNonQuery();
                //cmd3.ExecuteNonQuery();

                SqlCommand consul = new SqlCommand("EXEC modificarReader @numAntena, @nombAntena, @idReader, @numero, @actuReader, @idReader1", conn);
                consul.Parameters.AddWithValue("@numAntena", antenasView.Rows[item].Cells[0].Value);
                consul.Parameters.AddWithValue("@nombAntena", antenasView.Rows[item].Cells[1].Value);

                consul.Parameters.AddWithValue("@idReader", cboNomReader.Text.ToString());
                consul.Parameters.AddWithValue("@numero", antenasView.Rows[item].Cells[0].Value);
                consul.Parameters.AddWithValue("@actuReader", antenasView.Rows[0].Cells[2].Value);
                consul.Parameters.AddWithValue("@idReader1", cboNomReader.Text.ToString());
                
                
                
                
                consul.ExecuteNonQuery();

                //SqlCommand consulta = new SqlCommand(string.Format("EXEC sp_update @numAntena, @descripAntena,@nombreReader, @actNombrReader"), conn);

                //consulta.Parameters.AddWithValue("@nombreReader", nomReader.Text.ToString());
                //consulta.Parameters.AddWithValue("@descripAntena", antenasView.Rows[item].Cells[1].Value);
                //consulta.Parameters.AddWithValue("@actNombrReader", antenasView.Rows[0].Cells[2].Value);
                //consulta.Parameters.AddWithValue("@numAntena", antenasView.Rows[item].Cells[0].Value);
            }
            MessageBox.Show("Modificacion realizada");
            this.Hide();
        }

        
    }
}
