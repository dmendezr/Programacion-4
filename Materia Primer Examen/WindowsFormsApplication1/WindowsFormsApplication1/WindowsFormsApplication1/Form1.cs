using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        public delegate int Sumar(int N1, int N2);

        

        public int SumarNumeros(int N1, int N2)
        {
            return N1 + N2;
        }

        public void IncrementarNVeces(Sumar dSumar,int N)
        {
            int resultadoSuma = dSumar(Convert.ToInt32(TxtN1.Text), Convert.ToInt32(TxtN2.Text));
            int resultadoNVeces = 0;
            for (int i = 1; i <= N; i++)
            {
                resultadoNVeces = resultadoNVeces + resultadoSuma;
            }

            TxtResultado.Text = resultadoNVeces.ToString();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sumar MetedoSumar = SumarNumeros;
            IncrementarNVeces(MetedoSumar, 10);
        }
    }
}
