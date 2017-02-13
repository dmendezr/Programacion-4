using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {

        public delegate void MiDelegado();
        delegate bool Longitud(string palabra);

        int x, y;

        int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }


        public void imprimir(MiDelegado pDele)
        {
            pDele();
            MessageBox.Show(Convert.ToString(x + y));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MiDelegado del1 = () =>
            {
                x = Convert.ToInt32(Txt1.Text);
                y = Convert.ToInt32(Txt2.Text);
               // Tr.Text = Convert.ToString((x + y));
            };


            imprimir(del1);

            //Longitud lg = (s) => (s.Length > 5);
            //MessageBox.Show(lg(Txt1.Text).ToString());



        }
    }
}
