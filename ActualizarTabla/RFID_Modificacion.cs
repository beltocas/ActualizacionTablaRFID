using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActualizarTabla
{
    public partial class RFID_Modificacion : Form
    {
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
            string readerNombre = Convert.ToString(nomReader);
            
                an1.Text = "A01-202".ToString();
                an2.Text = "A03-203".ToString();
                an3.Text = "A05-102".ToString();
                an4.Text = "A04-002".ToString();
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Modificacion realizada");
            this.Hide();
        }
    }
}
