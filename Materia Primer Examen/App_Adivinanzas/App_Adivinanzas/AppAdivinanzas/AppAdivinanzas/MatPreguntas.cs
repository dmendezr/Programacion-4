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
    public partial class MatPreguntas : Form
    {

        List<Pregunta> ListadoPreguntas;
        List<Respuesta> ListaRespuestas;

        

        int ConsecutivoRespuesta;


        public MatPreguntas()
        {
            InitializeComponent();
            ConsecutivoRespuesta = 0;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        #region Funcionalida


        private void AgregarPregunta()
        {
            try
            {
                int lcIdPregunta = Form1.ConsecutivoPreguntas;
                string lcPregunta = TxtPregunta.Text;
                Pregunta objPregunta = new Pregunta();
                objPregunta.atrIdPregunta = lcIdPregunta;
                objPregunta.atrPregunta = lcPregunta;
                objPregunta.atrListaRespuesta = ListaRespuestas;
                Form1.ListadoPreguntas.Add(objPregunta);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

         private void AgregarRespuesta()
        {
            try
            {
                int lcIdRespuesta = ConsecutivoRespuesta;
                string lcRespuesta = TxtRespuesta.Text;
                bool lcCorrecta = ChkCorrecta.Checked;

                if (lcIdRespuesta < 0)
                {
                    MessageBox.Show("Idetificacion de respuesta");
                    return;
                }

                Respuesta objRespuesta = new Respuesta();
                objRespuesta.atrIdRespuesta = lcIdRespuesta;
                objRespuesta.atrRespuesta = lcRespuesta;
                objRespuesta.atrCorrecta = lcCorrecta;

                ListaRespuestas.Add(objRespuesta);
                                
                ConsecutivoRespuesta += 1;
                LstListaRespuestas.Items.Add(objRespuesta.atrRespuesta);




            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }


        #endregion

        private void MatPreguntas_Load(object sender, EventArgs e)
        {
            ListaRespuestas = new List<Respuesta>();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            AgregarRespuesta();
            TxtRespuesta.Text = string.Empty;
            ChkCorrecta.Checked = false;
        }

        private void BtnGuardaPregunta_Click(object sender, EventArgs e)
        {
            AgregarPregunta();
            ListaRespuestas = new List<Respuesta>();
            ConsecutivoRespuesta = 0;
            TxtPregunta.Text = string.Empty;
            LstListaRespuestas.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
        }
    }
}
