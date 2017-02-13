using System;
using System.Collections;
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
    public partial class Pruebas : Form
    {
        
        Queue<string> Cola = new Queue<string>();
        Stack<string> Pila = new Stack<string>();


        public Pruebas()
        {
            InitializeComponent();
            Cola.Enqueue("Liga");
            Cola.Enqueue("Saprissa");
            Cola.Enqueue("Cartago");

            Pila.Push("Costa Rica");
            Pila.Push("Mexico");
            Pila.Push("Panama");


        }

        private void Pruebas_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Cola.Count <= 0)
            {
                return;
            }



            MessageBox.Show(Cola.Peek());


            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Pila.Peek());
            MessageBox.Show(Pila.Pop());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach  (string item in Cola)
            {
                MessageBox.Show(item);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (string item in Pila)
            {
                MessageBox.Show(item);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }
    }
}
