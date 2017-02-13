using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AppAdivinanzas
{
    public partial class Form1 : Form
    {

        public static List<Pregunta> ListadoPreguntas;
        public static int ConsecutivoPreguntas;

        public Form1()
        {
            InitializeComponent();
            ConsecutivoPreguntas = 0;
            ListadoPreguntas = new List<Pregunta>();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AppAdivinanzas.MatPreguntas FrmMantPreguntas = new MatPreguntas();
            FrmMantPreguntas.MdiParent = this;
            FrmMantPreguntas.Show();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            AppAdivinanzas.FrmAdivinanzas ObjFrmAdivinanzas = new FrmAdivinanzas();
            ObjFrmAdivinanzas.MdiParent = this;
            ObjFrmAdivinanzas.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
