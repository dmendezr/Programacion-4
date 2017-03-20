using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlnPromerica
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SlnPromerica.FrmClientes Form1 = new FrmClientes();
            Form1.MdiParent = this;
            Form1.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            SlnPromerica.Credito FrmCredito = new Credito();
            FrmCredito.MdiParent = this;
            FrmCredito.Show();
        }
    }
}
