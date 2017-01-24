using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAdivinanza
{
    public partial class frmAdivinanzas : Form
    {

        static Random rdn = new Random();

        public frmAdivinanzas()
        {
            InitializeComponent();
        }

        private void frmAdivinanzas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int indice = rdn.Next(Form1.ListadoPregunta.Count);
            txtPreguntas.Text = Form1.ListadoPregunta[indice].atrPregunta;
            dgRespuestas.DataSource = Form1.ListadoPregunta[indice].atrListaRespuesta;
        }
    }
}
