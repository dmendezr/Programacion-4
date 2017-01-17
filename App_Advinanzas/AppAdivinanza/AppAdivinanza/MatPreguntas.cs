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
    public partial class MatPreguntas : Form
    {
        List<Pregunta> ListadoPreguntas;
        List<Respusta> ListadoRespuestas;
        int ConsecutivoRespuesta;
        public MatPreguntas()
        {
            InitializeComponent();
            ConsecutivoRespuesta = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        #region Funcionalidad

        private void AgregarRespuesta()
        {
            try
            {
                int lcIdRespuesta = ConsecutivoRespuesta;
                string lcRespuesta = txtRespuesta.Text;
                bool lcCorrecta = chkCorrecta.Checked;

                if (lcIdRespuesta < 0)
                {
                    MessageBox.Show("Identificacion Respuesta Incorrecto");
                    return;
                }
                Respusta objRespuesta = new Respusta();
                objRespuesta.atrIdRespuesta = lcIdRespuesta;
                objRespuesta.atrRespuesta = lcRespuesta;
                objRespuesta.atrCorrecta = lcCorrecta;

                ListadoRespuestas.Add(objRespuesta);
                ConsecutivoRespuesta += 1;
                lBRespuestas.Items.Add(objRespuesta.atrRespuesta);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void AgregarPregunta()
        {
            try
            {
                int lcIdPregunta = Form1.ConsecutivoPreguntas;
                string lcPregunta = txtPregunta.Text;
                Pregunta objPregunta = new Pregunta();
                objPregunta.atrIdPregunta = lcIdPregunta;
                objPregunta.atrPregunta = lcPregunta;
                objPregunta.atrListaRespuesta = ListadoRespuestas;
                Form1.ListadoPregunta.Add(objPregunta);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                
            }
        }
        #endregion

        private void MatPreguntas_Load(object sender, EventArgs e)
        {
            ListadoRespuestas = new List<Respusta>();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarRespuesta();
            txtRespuesta.Text = String.Empty;
            chkCorrecta.Checked = false; 
        }

        private void btnCargaPregunta_Click(object sender, EventArgs e)
        {
            AgregarPregunta();
            ListadoRespuestas = new List<Respusta>();
            ConsecutivoRespuesta = 0;
            txtPregunta.Text = String.Empty;
            lBRespuestas.Items.Clear();
        }
    }
}
