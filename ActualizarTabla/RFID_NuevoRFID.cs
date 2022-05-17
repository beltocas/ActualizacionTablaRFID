using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;
using System;

namespace ActualizarTabla
{
    public partial class RFID_NuevoRFID : Form
    {

       
        
        DB db = new DB();



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
            string codigoReader = System.Convert.ToString(codReaderReg.Text);
            string anN1 = System.Convert.ToString(antenaN1.Text);
            string anN2 = System.Convert.ToString(antenaN2.Text);
            string anN3 = System.Convert.ToString(antenaN3.Text);
            string anN4 = System.Convert.ToString(antenaN4.Text);

            SqlConnection conn = db.Conectar();


            SqlCommand sentencia = new SqlCommand(string.Format("execute insertarReader @nombre_reader,@num_antena1,@descr1,@num_antena2,@descr2,@num_antena3,@descr3"), conn);
            //sentencia.CommandType = System.Data.CommandType.StoredProcedure;
            sentencia.Parameters.AddWithValue("@nombre_reader", codigoReader);
            sentencia.Parameters.AddWithValue("@num_antena1", 1);
            sentencia.Parameters.AddWithValue("@descr1", anN1);
            sentencia.Parameters.AddWithValue("@num_antena2", 2);
            sentencia.Parameters.AddWithValue("@descr2", anN2);
            sentencia.Parameters.AddWithValue("@num_antena3", 3);
            sentencia.Parameters.AddWithValue("@descr3", anN3);

            /*Con intento de grilla*/

            //for (int item = 0; item < agregarAntena.Rows.Count - 1; item++)
            //{
            //    SqlCommand consul = new SqlCommand("EXEC sp_ingresarReaderAntena @numAntena,@descrNombreAntena,@codigoReader,@descrNombreReader", conn);
            //    consul.Parameters.AddWithValue("@numAntena",Convert.ToInt32(agregarAntena.Rows[item].Cells[0].Value));
            //    consul.Parameters.AddWithValue("@descrNombreAntena", agregarAntena.Rows[item].Cells[1].Value);
            //    consul.Parameters.AddWithValue("@codigoReader", agregarAntena.Rows[0].Cells[2].Value);
            //    consul.Parameters.AddWithValue("@descrNombreReader", agregarAntena.Rows[0].Cells[3].Value);
            //    consul.ExecuteNonQuery();
            //    if(agregarAntena.Rows.Count == 8)
            //    {
            //        break;
            //    }
            //}
            //MessageBox.Show("Su registro fue exitoso");
            //this.Hide();    

            try
            {
                sentencia.ExecuteNonQuery();

                codReaderReg.Text = "".ToString();
                antenaN1.Text = "".ToString();
                antenaN2.Text = "".ToString();
                antenaN3.Text = "".ToString();
                antenaN4.Text = "".ToString();
                MessageBox.Show("Su registro fue exitoso");

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }


            //Simulacion

        }

        private void RFID_NuevoRFID_Load(object sender, System.EventArgs e)
        {
            //SqlConnection conn = db.Conectar();
            //SqlCommand consulta = new SqlCommand(string.Format("SELECT antena.num_antena as NumeroAntena, antena.descr as Nombre, reader.descr as NombreReader FROM antena INNER JOIN reader ON antena.reader = reader.id WHERE reader.descr like @dsc "), conn);
            //consulta.Parameters.AddWithValue("@dsc", cboNomReader.Text.ToString());
            //adaptador = new SqlDataAdapter(consulta);
            //dt = new DataTable();
            //dt.Clear();
            //adaptador.Fill(dt);
            //antenasView.DataSource = dt;
        }
    }
}
