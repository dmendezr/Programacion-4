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


// Ejemplo de Colas y pilas

namespace AppAdivinanza
{
    public partial class Pruebas : Form
    {
        Queue<String> Cola = new Queue<String>(); // System Collections Generic
        Queue Cola2 = new Queue();// System Collections
        Stack<String> Pila = new Stack<String>();

        public Pruebas()
        {
            InitializeComponent();
            Cola.Enqueue("Liga");
            Cola.Enqueue("Saprissa");
            Cola.Enqueue("Cartago");
            Cola.Enqueue("Herediano");

            Pila.Push("Costa Rica");
            Pila.Push("Colombia");
            Pila.Push("Panama");
        }

        private void Pruebas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*if (Cola.Count <= 0)
            {
                MessageBox.Show(Cola.Dequeue()); //Quita valores de la cola
            }*/
            //Cola.Clear();   //-->Limpia todos los elementos de la cola
            //MessageBox.Show(Cola.peek()) // --> Muestra el dato pero no lo quita 

            foreach (var item in Cola)
            {
                MessageBox.Show(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Pila.Pop()); //Quita Valores de la pila
            //MessageBox.Show (Pila.peek()) // --> Muestra el dato pero no lo quita

            foreach (var item in Pila)
            {
                MessageBox.Show(item);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(Cola.Contains(txtBuscar.Text))
            {
                MessageBox.Show("Encontrado");
            }else
            {
                MessageBox.Show("No encontrado");
            }
        }
    }
}
