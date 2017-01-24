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
    public partial class Form1 : Form
    {
        public static List<Pregunta> ListadoPregunta;
        public static int ConsecutivoPreguntas;
        public Form1()
        {
            InitializeComponent();
            ConsecutivoPreguntas = 0;
            ListadoPregunta = new List<Pregunta>();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AppAdivinanza.MatPreguntas frmMatPreguntas = new MatPreguntas();
            frmMatPreguntas.MdiParent = this;
            frmMatPreguntas.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            AppAdivinanza.frmAdivinanzas objFrmdivinanzas = new frmAdivinanzas();
            objFrmdivinanzas.MdiParent = this;
            objFrmdivinanzas.Show();
        }
    }
}
