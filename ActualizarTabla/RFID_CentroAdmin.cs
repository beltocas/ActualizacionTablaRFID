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
    public partial class RFID_CentroAdmin : Form
    {
        public RFID_CentroAdmin()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RFID_NuevoRFID newproduct = new RFID_NuevoRFID();
            newproduct.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RFID_Modificacion modproduct = new RFID_Modificacion();
            modproduct.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            RFID_ConfigIP configuracion = new RFID_ConfigIP();
            configuracion.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

       
    }
}
