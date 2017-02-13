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
    public partial class Form2 : Form
    {
        List<int> ListadoNumeros = new List<int>();

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ListadoNumeros.Add(Convert.ToInt32(textBox1.Text));            
            textBox1.Text = string.Empty;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int resultado = ListadoNumeros.Sum();
            MessageBox.Show(Convert.ToString(resultado));
            
            
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double resultado = ListadoNumeros.Average();
            MessageBox.Show(Convert.ToString(resultado));
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var x = ListadoNumeros.Select((y) => y > 2);

            foreach (var item in x)
            {
                MessageBox.Show(item.ToString());
            }

            

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
