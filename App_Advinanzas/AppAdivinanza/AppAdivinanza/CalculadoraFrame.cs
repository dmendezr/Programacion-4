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

            Button Btn1 = new Button();
            Btn1.Text = "Abrir";
            Btn1.Name = "BtnAbrir";
            Btn1.Image = AppAdivinanza.Properties.Resources.Salvar;
            Btn1.Location = new Point(400, 300);
            Btn1.Click += HolaMundo;
            delSumar = Calculadora.Sumar;


            this.Controls.Add(Btn1);
            


        }

        private void HolaMundo(object sender, EventArgs e)
        {
            MessageBox.Show("Hola Mundo");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            int p1 = Convert.ToInt32(txtNum1.Text);
            int p2 = Convert.ToInt32(txtNum2.Text);
            txtNum3.Text = delSumar(p1, p2).ToString();
        }

        private void CalculadoraFrame_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}
