using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActualizarTabla
{
    public partial class RFID_VisorGeneral : Form
    {
        DB db = new DB();
        SqlCommand consulta = new SqlCommand();
        SqlCommand sentencia = new SqlCommand();
        SqlDataReader resultado;
        int n_filas = 0;

        public RFID_VisorGeneral()
        {
            InitializeComponent();

            DoubleBufferedASD(tabla_1, true);

            consulta.Connection = db.Conectar();
            sentencia.Connection = consulta.Connection;

            ActualizarTabla();
        }

        public void DoubleBufferedASD(DataGridView table, Boolean value)
        {
            Type type = table.GetType();

            PropertyInfo pi = type.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(table, value);
        }

        private void ActualizarTabla()
        {
            try
            {
                consulta.CommandText = "EXEC dbo.sp_obtenerLecturas";
                resultado = consulta.ExecuteReader();

                //Agregar columnas
                tabla_1.Columns.Clear();
                for (int c = 0; c < resultado.FieldCount; c++)
                {
                    tabla_1.Columns.Add("columna" + c.ToString(), "columna" + c.ToString());
                }

                int i = 0;
                tabla_1.Rows.Clear();
                while (resultado.Read())
                {
                    List<String> datos = new List<string>();
                    for (int c = 0; c < resultado.FieldCount; c++)
                    {
                        //Poner nombre de columna
                        if (i == 0)
                        {
                            tabla_1.Columns[c].HeaderText = resultado.GetName(c).Replace("_", " ");
                        }

                        datos.Add(resultado.GetValue(c).ToString());
                    }

                    tabla_1.Rows.Add(datos);

                    i++;
                }

                n_filas = i;
                resultado.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                consulta.CommandText = "EXEC dbo.sp_obtenerLecturas";
                resultado = consulta.ExecuteReader();

                int i = 0;
                while (resultado.Read())
                {
                    if (i < tabla_1.RowCount) {
                        for (int c = 0; c < resultado.FieldCount; c++)
                        {
                            tabla_1.Rows[i].Cells[c].Value = resultado.GetValue(c).ToString();
                        }
                    }

                    i++;
                }
                resultado.Close();

                if (i != n_filas)
                {
                    ActualizarTabla();
                }
            }
            catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }

            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                this.Hide();
                RFID_CentroAdmin administrador = new RFID_CentroAdmin();
                administrador.Show();
            }
            else
            {
                Console.WriteLine("Hola esto no funciona");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RFID_CentroAdmin administrador = new RFID_CentroAdmin();
            administrador.Show();
        }
    }
}
