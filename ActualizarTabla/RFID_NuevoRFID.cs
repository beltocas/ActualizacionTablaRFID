using System.Windows.Forms;

namespace ActualizarTabla
{
    public partial class RFID_NuevoRFID : Form
    {
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
    }
}
