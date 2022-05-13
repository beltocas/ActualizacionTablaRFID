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
    public partial class RFID_ConfigIP : Form
    {
        public RFID_ConfigIP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RFID_CentroAdmin administrador = new RFID_CentroAdmin();
            administrador.Show();
        }
    }
}
