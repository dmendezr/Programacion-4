using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Ejercisio ejemplo de delegados*/

namespace AppAdivinanza
{
    public partial class CalculadoraFrame : Form
    {

        delegate int sumar(int n1, int n2);
        sumar delSumar;

        public CalculadoraFrame()
        {
            InitializeComponent();
           delSumar = Calculadora.Sumar;

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            int p1 = Convert.ToInt32(txtNum1.Text);
            int p2 = Convert.ToInt32(txtNum2.Text);
            txtNum3.Text = delSumar(p1, p2).ToString();
        }
    }
}
