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
    public partial class Prueba2 : Form
    {

        int[] datos = { 10, 20, 8, 3, 5, 7 };
        public Prueba2()
        {
            InitializeComponent();
        }

        private void Prueba2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            foreach (var item in datos)
            {
                MessageBox.Show(item.ToString());
            }*/

            var resultado = from x in datos // Origen de selección
                            where x > 10 // Criterio de seleccion
                            orderby x descending // Ordenar Resultado del arreglo
                            select x;

            /* Estructura Basica para hacer la consulta
             * Origen
             * Criterios
             * Orden
             * Select
             */        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int  CantidadRegistro = (from x in datos 
                                    where x > 10 
                                    orderby x descending 
                                    select x).Count();
            MessageBox.Show(CantidadRegistro.ToString());
        }
    }
}
