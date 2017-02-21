using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guerra_de_Barcos
{
    public partial class Form1 : Form
    {
        //Comentario
        public static List<Posicion> listaPosicionEnemigo = new List<Posicion>();
        public static List<Posicion> listaPosicionJugador = new List<Posicion>();
        public Form1()
        {
            InitializeComponent();
            LlenarArreglo();
            ColocarBarcosEnemigo();
        }

        public static void LlenarArreglo()
        {
            Posicion objPosicion = new Posicion();
            objPosicion.Boton = "btnCampo1";
            objPosicion.contieneBarco = false;
            objPosicion.propio = false;
            listaPosicionEnemigo.Add(objPosicion);
            objPosicion = new Posicion();
            objPosicion.Boton = "btnCampo2";
            objPosicion.contieneBarco = false;
            objPosicion.propio = false;
            listaPosicionEnemigo.Add(objPosicion);
        }

        public static void ColocarBarcosEnemigo()
        {
            for (int i = 1; i < 2; i++)
            {
                Random rdn1 = new Random();
                int numeroAleatorio = rdn1.Next(0, 1);//Aleatorio para el indice del arreglo
                listaPosicionEnemigo[Convert.ToInt32(numeroAleatorio)].contieneBarco = true; //Setear aleatoriamente segun el numero de indice
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCampo15_Click(object sender, EventArgs e)
        {

        }
    }
}
