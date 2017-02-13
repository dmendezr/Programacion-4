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
    public partial class Prueba2 : Form
    {

        int[] datos = { 10, 20, 8, 9, 15, 17, 2, 3 };
        public Prueba2()
        {
            InitializeComponent();
        }

        private void Prueba2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var resultado = from x in datos   //Origen de datos
                            where x > 10      //Criterios de seleccion
                            orderby x descending //Orden a los elementos mostrados
                            select x;  //Muestra lo que da lo consulta

            foreach (int item in resultado)
            {
                MessageBox.Show(item.ToString());
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int CantidadRegistro = (from x in datos
                                    where x > 10
                                    select x).Count();
            MessageBox.Show(CantidadRegistro.ToString());
              
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int cant = datos.Where(x => x > 10).Count();
            MessageBox.Show(cant.ToString());
        }
    }
}
