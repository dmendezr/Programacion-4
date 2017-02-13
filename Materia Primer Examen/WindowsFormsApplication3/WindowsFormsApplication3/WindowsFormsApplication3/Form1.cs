using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        delegate int sumarD(int n1, int n2);
        sumarD delSumar;

        public Form1()
        {
            InitializeComponent();
            delSumar = Calculadora.Sumar;

            Button Btn1 = new Button();
            Btn1.Text = "Abrir";
            Btn1.Name = "BtnAbrir";
            Btn1.Image = WindowsFormsApplication3.Properties.Resources.Salvar;
            Btn1.Location = new Point(15, 30);
            Btn1.Click += HolaMundo;
            this.Controls.Add(Btn1);

        }

        private void HolaMundo(object sender, EventArgs e)
        {
            MessageBox.Show("Hola Mundo");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int p1 = Convert.ToInt32(textBox1.Text);
            int p2 = Convert.ToInt32(textBox2.Text);
            textBox3.Text = delSumar(p1, p2).ToString();
        }
    }
}
