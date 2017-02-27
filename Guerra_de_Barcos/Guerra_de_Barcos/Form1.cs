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
        public static List<int> numeroSeteado = new List<int>();
        public static List<int> ataquesEnemigos = new List<int>();
        public int turnoJugador;
        public int turnoEnemigo;
        public int contadorTiempoJugador = 0;
        public int contadorTiempoEnemigo = 0;
        public int puntajeJugador = 0;
        public int puntajeEnemigo = 0;
        public String input;
        public Form1()
        {
            InitializeComponent();
            LlenarArregloEnemigo();
            ColocarBarcosEnemigo();
            LlenarArregloJugador();
            ColocarBarcosJugador();
        }

        public static void LlenarArregloJugador()
        {
            Posicion objPosicion = new Posicion();
            objPosicion.Boton = "btnCampo16";
            objPosicion.contieneBarco = false;
            objPosicion.propio = false;
            listaPosicionJugador.Add(objPosicion);
            objPosicion = new Posicion();
            objPosicion.Boton = "btnCampo17";
            objPosicion.contieneBarco = false;
            objPosicion.propio = false;
            listaPosicionJugador.Add(objPosicion);
            objPosicion = new Posicion();
            objPosicion.Boton = "btnCampo18";
            objPosicion.contieneBarco = false;
            objPosicion.propio = false;
            listaPosicionJugador.Add(objPosicion);
            objPosicion = new Posicion();
            objPosicion.Boton = "btnCampo19";
            objPosicion.contieneBarco = false;
            objPosicion.propio = false;
            listaPosicionJugador.Add(objPosicion);
            objPosicion = new Posicion();
            objPosicion.Boton = "btnCampo20";
            objPosicion.contieneBarco = false;
            objPosicion.propio = false;
            listaPosicionJugador.Add(objPosicion);
            objPosicion = new Posicion();
            objPosicion.Boton = "btnCampo21";
            objPosicion.contieneBarco = false;
            objPosicion.propio = false;
            listaPosicionJugador.Add(objPosicion);
            objPosicion = new Posicion();
            objPosicion.Boton = "btnCampo22";
            objPosicion.contieneBarco = false;
            objPosicion.propio = false;
            listaPosicionJugador.Add(objPosicion);
            objPosicion = new Posicion();
            objPosicion.Boton = "btnCampo23";
            objPosicion.contieneBarco = false;
            objPosicion.propio = false;
            listaPosicionJugador.Add(objPosicion);
            objPosicion = new Posicion();
            objPosicion.Boton = "btnCampo24";
            objPosicion.contieneBarco = false;
            objPosicion.propio = false;
            listaPosicionJugador.Add(objPosicion);
            objPosicion = new Posicion();
            objPosicion.Boton = "btnCampo25";
            objPosicion.contieneBarco = false;
            objPosicion.propio = false;
            listaPosicionJugador.Add(objPosicion);
            objPosicion = new Posicion();
            objPosicion.Boton = "btnCampo26";
            objPosicion.contieneBarco = false;
            objPosicion.propio = false;
            listaPosicionJugador.Add(objPosicion);
            objPosicion = new Posicion();
            objPosicion.Boton = "btnCampo27";
            objPosicion.contieneBarco = false;
            objPosicion.propio = false;
            listaPosicionJugador.Add(objPosicion);
            objPosicion = new Posicion();
            objPosicion.Boton = "btnCampo28";
            objPosicion.contieneBarco = false;
            objPosicion.propio = false;
            listaPosicionJugador.Add(objPosicion);
            objPosicion = new Posicion();
            objPosicion.Boton = "btnCampo29";
            objPosicion.contieneBarco = false;
            objPosicion.propio = false;
            listaPosicionJugador.Add(objPosicion);
            objPosicion = new Posicion();
            objPosicion.Boton = "btnCampo30";
            objPosicion.contieneBarco = false;
            objPosicion.propio = false;
            listaPosicionJugador.Add(objPosicion);
        }

        public static void LlenarArregloEnemigo()
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
            objPosicion = new Posicion();
            objPosicion.Boton = "btnCampo3";
            objPosicion.contieneBarco = false;
            objPosicion.propio = false;
            listaPosicionEnemigo.Add(objPosicion);
            objPosicion = new Posicion();
            objPosicion.Boton = "btnCampo4";
            objPosicion.contieneBarco = false;
            objPosicion.propio = false;
            listaPosicionEnemigo.Add(objPosicion);
            objPosicion = new Posicion();
            objPosicion.Boton = "btnCampo5";
            objPosicion.contieneBarco = false;
            objPosicion.propio = false;
            listaPosicionEnemigo.Add(objPosicion);
            objPosicion = new Posicion();
            objPosicion.Boton = "btnCampo6";
            objPosicion.contieneBarco = false;
            objPosicion.propio = false;
            listaPosicionEnemigo.Add(objPosicion);
            objPosicion = new Posicion();
            objPosicion.Boton = "btnCampo7";
            objPosicion.contieneBarco = false;
            objPosicion.propio = false;
            listaPosicionEnemigo.Add(objPosicion);
            objPosicion = new Posicion();
            objPosicion.Boton = "btnCampo8";
            objPosicion.contieneBarco = false;
            objPosicion.propio = false;
            listaPosicionEnemigo.Add(objPosicion);
            objPosicion = new Posicion();
            objPosicion.Boton = "btnCampo9";
            objPosicion.contieneBarco = false;
            objPosicion.propio = false;
            listaPosicionEnemigo.Add(objPosicion);
            objPosicion = new Posicion();
            objPosicion.Boton = "btnCampo10";
            objPosicion.contieneBarco = false;
            objPosicion.propio = false;
            listaPosicionEnemigo.Add(objPosicion);
            objPosicion = new Posicion();
            objPosicion.Boton = "btnCampo11";
            objPosicion.contieneBarco = false;
            objPosicion.propio = false;
            listaPosicionEnemigo.Add(objPosicion);
            objPosicion = new Posicion();
            objPosicion.Boton = "btnCampo12";
            objPosicion.contieneBarco = false;
            objPosicion.propio = false;
            listaPosicionEnemigo.Add(objPosicion);
            objPosicion = new Posicion();
            objPosicion.Boton = "btnCampo13";
            objPosicion.contieneBarco = false;
            objPosicion.propio = false;
            listaPosicionEnemigo.Add(objPosicion);
            objPosicion = new Posicion();
            objPosicion.Boton = "btnCampo14";
            objPosicion.contieneBarco = false;
            objPosicion.propio = false;
            listaPosicionEnemigo.Add(objPosicion);
            objPosicion = new Posicion();
            objPosicion.Boton = "btnCampo15";
            objPosicion.contieneBarco = false;
            objPosicion.propio = false;
            listaPosicionEnemigo.Add(objPosicion);
        }

       public static void ColocarBarcosJugador()
        {
            int[] aleatorios = CalcularNumeros();
            foreach (int num in aleatorios)
            {
                listaPosicionJugador[Convert.ToInt32(num)].contieneBarco = true; //Setear aleatoriamente segun el numero de indice
            }
        }
        public static void ColocarBarcosEnemigo()
        {
                    int[] aleatorios = CalcularNumeros();
                    foreach (int num in aleatorios)
                    {
                        listaPosicionEnemigo[Convert.ToInt32(num)].contieneBarco = true; //Setear aleatoriamente segun el numero de indice
                    }
        }

        public static int[] CalcularNumeros()
        {
            int[] numeros = new int[4];
            Random r = new Random();

            int auxiliar = 0;
            int contador = 0;

            for (int i = 0; i < 3; i++)
            {
                auxiliar = r.Next(0, 14);
                bool continuar = false;

                while (!continuar)
                {
                    for (int j = 0; j <= contador; j++)
                    {
                        if (auxiliar == numeros[j])
                        {
                            continuar = true;
                            j = contador;
                        }
                    }

                    if (continuar)
                    {
                        auxiliar = r.Next(0, 14);
                        continuar = false;
                    }
                    else
                    {
                        continuar = true;
                        numeros[contador] = auxiliar;
                        contador++;
                    }
                }
            }

            return numeros;
        }


        public void BloquearBotonesEnemigo()
        {
            btnCampo1.Enabled = false;
            btnCampo2.Enabled = false;
            btnCampo3.Enabled = false;
            btnCampo4.Enabled = false;
            btnCampo5.Enabled = false;
            btnCampo6.Enabled = false;
            btnCampo7.Enabled = false;
            btnCampo8.Enabled = false;
            btnCampo9.Enabled = false;
            btnCampo10.Enabled = false;
            btnCampo11.Enabled = false;
            btnCampo12.Enabled = false;
            btnCampo13.Enabled = false;
            btnCampo14.Enabled = false;
            btnCampo15.Enabled = false;

        }

        public void BloquearBotonesJugador()
        {
            btnCampo16.Enabled = false;
            btnCampo17.Enabled = false;
            btnCampo18.Enabled = false;
            btnCampo19.Enabled = false;
            btnCampo20.Enabled = false;
            btnCampo21.Enabled = false;
            btnCampo22.Enabled = false;
            btnCampo23.Enabled = false;
            btnCampo24.Enabled = false;
            btnCampo25.Enabled = false;
            btnCampo26.Enabled = false;
            btnCampo27.Enabled = false;
            btnCampo28.Enabled = false;
            btnCampo29.Enabled = false;
            btnCampo30.Enabled = false;
        }

        public void MostrarBotonesJugador()
        {
            btnCampo16.Enabled = true;
            btnCampo17.Enabled = true;
            btnCampo18.Enabled = true;
            btnCampo19.Enabled = true;
            btnCampo20.Enabled = true;
            btnCampo21.Enabled = true;
            btnCampo22.Enabled = true;
            btnCampo23.Enabled = true;
            btnCampo24.Enabled = true;
            btnCampo25.Enabled = true;
            btnCampo26.Enabled = true;
            btnCampo27.Enabled = true;
            btnCampo28.Enabled = true;
            btnCampo29.Enabled = true;
            btnCampo30.Enabled = true;
        }

        public void MostrarBotonesEnemigo()
        {
            btnCampo1.Enabled = true;
            btnCampo2.Enabled = true;
            btnCampo3.Enabled = true;
            btnCampo4.Enabled = true;
            btnCampo5.Enabled = true;
            btnCampo6.Enabled = true;
            btnCampo7.Enabled = true;
            btnCampo8.Enabled = true;
            btnCampo9.Enabled = true;
            btnCampo10.Enabled = true;
            btnCampo11.Enabled = true;
            btnCampo12.Enabled = true;
            btnCampo13.Enabled = true;
            btnCampo14.Enabled = true;
            btnCampo15.Enabled = true;
        }
        private void button9_Click(object sender, EventArgs e)
        {
        }
            
        public bool buscarBarcoEnemigo (string nombreBoton)
        {
            bool contieneBarco = false;
            foreach (Posicion list in listaPosicionEnemigo)
            {
                if (list.Boton == nombreBoton )
                {
                    contieneBarco = list.contieneBarco;
                }
            }
            return contieneBarco;
        }

        public bool evaluaCampoMostradoEnemigo (string nombreBoton)
        {
            bool evaluaCampo = false;
            foreach (Posicion list in listaPosicionEnemigo)
            {
                if (list.Boton == nombreBoton)
                {
                    evaluaCampo = list.propio;
                }
            }
            return evaluaCampo;
        }

        public void cambiaCampoPropioEnemigo (string nombreBoton)
        {
            foreach (Posicion list in listaPosicionEnemigo)
            {
                if(list.Boton == nombreBoton)
                {
                    list.propio = true;
                }
            }
        }

        public void ataqueEnemigo()
        {
            Random r = new Random();
            int indice = r.Next(0, 14);
            //if (ataquesEnemigos.Count == 0)
            //{
                #region Switch
                switch (indice)
                {
                    case 0:
                        if (listaPosicionJugador[indice].contieneBarco && listaPosicionJugador[indice].propio == false)
                        {
                            btnCampo16.Image = global::Guerra_de_Barcos.Properties.Resources.ConBarco;
                            puntajeEnemigo++;
                            listaPosicionJugador[indice].propio = true;
                        }
                        else if (listaPosicionJugador[indice].propio == false)
                        {
                            btnCampo16.Image = global::Guerra_de_Barcos.Properties.Resources.SinBarco;
                         }
                    break;
                    case 1:
                        if (listaPosicionJugador[indice].contieneBarco && listaPosicionJugador[indice].propio == false)
                        {
                            btnCampo17.Image = global::Guerra_de_Barcos.Properties.Resources.ConBarco;
                            puntajeEnemigo++;
                            listaPosicionJugador[indice].propio = true;
                        }
                        else if (listaPosicionJugador[indice].propio == false)
                    {
                            btnCampo17.Image = global::Guerra_de_Barcos.Properties.Resources.SinBarco;
                        }
                        break;
                    case 2:
                        if (listaPosicionJugador[indice].contieneBarco && listaPosicionJugador[indice].propio == false)
                        {
                            btnCampo18.Image = global::Guerra_de_Barcos.Properties.Resources.ConBarco;
                            puntajeEnemigo++;
                            listaPosicionJugador[indice].propio = true;
                        }
                        else if (listaPosicionJugador[indice].propio == false)
                    {
                            btnCampo18.Image = global::Guerra_de_Barcos.Properties.Resources.SinBarco;
                            
                        }
                        break;
                    case 3:
                        if (listaPosicionJugador[indice].contieneBarco && listaPosicionJugador[indice].propio == false)
                        {
                            btnCampo19.Image = global::Guerra_de_Barcos.Properties.Resources.ConBarco;
                            puntajeEnemigo++;
                            listaPosicionJugador[indice].propio = true;
                        }
                        else if (listaPosicionJugador[indice].propio == false)
                    {
                            btnCampo19.Image = global::Guerra_de_Barcos.Properties.Resources.SinBarco;
                        }
                        break;
                    case 4:
                        if (listaPosicionJugador[indice].contieneBarco && listaPosicionJugador[indice].propio == false)
                        {
                            btnCampo20.Image = global::Guerra_de_Barcos.Properties.Resources.ConBarco;
                            puntajeEnemigo++;
                            listaPosicionJugador[indice].propio = true;
                        }
                        else if (listaPosicionJugador[indice].propio == false)
                        {
                            btnCampo20.Image = global::Guerra_de_Barcos.Properties.Resources.SinBarco;
                        }
                        break;
                    case 5:
                        if (listaPosicionJugador[indice].contieneBarco && listaPosicionJugador[indice].propio == false)
                        {
                            btnCampo21.Image = global::Guerra_de_Barcos.Properties.Resources.ConBarco;
                            puntajeEnemigo++;
                            listaPosicionJugador[indice].propio = true;
                        }
                        else if (listaPosicionJugador[indice].propio == false)
                        {
                            btnCampo21.Image = global::Guerra_de_Barcos.Properties.Resources.SinBarco;
                        }
                        break;
                    case 6:
                        if (listaPosicionJugador[indice].contieneBarco && listaPosicionJugador[indice].propio == false)
                        {
                            btnCampo22.Image = global::Guerra_de_Barcos.Properties.Resources.ConBarco;
                            puntajeEnemigo++;
                            listaPosicionJugador[indice].propio = true;
                        }
                        else if (listaPosicionJugador[indice].propio == false)
                        {
                            btnCampo22.Image = global::Guerra_de_Barcos.Properties.Resources.SinBarco;
                        }
                        break;
                    case 7:
                        if (listaPosicionJugador[indice].contieneBarco && listaPosicionJugador[indice].propio == false)
                        {
                            btnCampo23.Image = global::Guerra_de_Barcos.Properties.Resources.ConBarco;
                            puntajeEnemigo++;
                        listaPosicionJugador[indice].propio = true;
                        }
                        else if (listaPosicionJugador[indice].propio == false)
                        {
                            btnCampo23.Image = global::Guerra_de_Barcos.Properties.Resources.SinBarco;
                        }
                        break;
                    case 8:
                        if (listaPosicionJugador[indice].contieneBarco && listaPosicionJugador[indice].propio == false)
                        {
                            btnCampo24.Image = global::Guerra_de_Barcos.Properties.Resources.ConBarco;
                            puntajeEnemigo++;
                            listaPosicionJugador[indice].propio = true;
                        }
                        else if (listaPosicionJugador[indice].propio == false)
                        {
                            btnCampo24.Image = global::Guerra_de_Barcos.Properties.Resources.SinBarco;
                        }
                        break;
                    case 9:
                        if (listaPosicionJugador[indice].contieneBarco && listaPosicionJugador[indice].propio == false)
                        {
                            btnCampo25.Image = global::Guerra_de_Barcos.Properties.Resources.ConBarco;
                            puntajeEnemigo++;
                            listaPosicionJugador[indice].propio = true;
                        }
                        else if (listaPosicionJugador[indice].propio == false)
                        {
                            btnCampo25.Image = global::Guerra_de_Barcos.Properties.Resources.SinBarco;
                        }
                        break;
                    case 10:
                        if (listaPosicionJugador[indice].contieneBarco && listaPosicionJugador[indice].propio == false)
                        {
                            btnCampo26.Image = global::Guerra_de_Barcos.Properties.Resources.ConBarco;
                            puntajeEnemigo++;
                            listaPosicionJugador[indice].propio = true;
                        }
                        else if (listaPosicionJugador[indice].propio == false)
                        {
                            btnCampo26.Image = global::Guerra_de_Barcos.Properties.Resources.SinBarco;
                        }
                        break;
                    case 11:
                        if (listaPosicionJugador[indice].contieneBarco && listaPosicionJugador[indice].propio == false)
                        {
                            btnCampo27.Image = global::Guerra_de_Barcos.Properties.Resources.ConBarco;
                            puntajeEnemigo++;
                            listaPosicionJugador[indice].propio = true;
                        }
                        else if (listaPosicionJugador[indice].propio == false)
                        {
                            btnCampo27.Image = global::Guerra_de_Barcos.Properties.Resources.SinBarco;
                        }
                        break;
                    case 12:
                        if (listaPosicionJugador[indice].contieneBarco && listaPosicionJugador[indice].propio == false)
                        {
                            btnCampo28.Image = global::Guerra_de_Barcos.Properties.Resources.ConBarco;
                            puntajeEnemigo++;
                            listaPosicionJugador[indice].propio = true;
                        }
                        else if (listaPosicionJugador[indice].propio == false)
                        {
                            btnCampo28.Image = global::Guerra_de_Barcos.Properties.Resources.SinBarco;
                        }
                        break;
                    case 13:
                        if (listaPosicionJugador[indice].contieneBarco && listaPosicionJugador[indice].propio == false)
                        {
                            btnCampo29.Image = global::Guerra_de_Barcos.Properties.Resources.ConBarco;
                            puntajeEnemigo++;
                            listaPosicionJugador[indice].propio = true;
                        }
                        else if (listaPosicionJugador[indice].propio == false)
                        {
                            btnCampo29.Image = global::Guerra_de_Barcos.Properties.Resources.SinBarco;
                        }
                        break;
                    case 14:
                        if (listaPosicionJugador[indice].contieneBarco && listaPosicionJugador[indice].propio == false)
                        {
                            btnCampo30.Image = global::Guerra_de_Barcos.Properties.Resources.ConBarco;
                            puntajeEnemigo++;
                            listaPosicionJugador[indice].propio = true;
                        }
                        else if (listaPosicionJugador[indice].propio == false)
                        {
                            btnCampo30.Image = global::Guerra_de_Barcos.Properties.Resources.SinBarco;
                        }
                        break;
                }
                #endregion
            //}
        }

        public void pintarBarcosJugador()
        {
            if (puntajeJugador == 1)
            {
                lblBarcoEne4.Visible = false;
            }
            if (puntajeJugador == 2)
            {
                lblBarcoEne3.Visible = false;
            }
            if (puntajeJugador == 3)
            {
                lblBarcoEne2.Visible = false;
            }
            if (puntajeJugador == 4)
            {
                lblBarcoEne1.Visible = false;
            }
        }
        public void pintarBarcosEnemigo()
        {
            if (puntajeEnemigo == 1)
            {
                lblBarcoJug4.Visible = false;
            }
            if (puntajeEnemigo == 2)
            {
                lblBarcoJug3.Visible = false;
            }
            if (puntajeEnemigo == 3)
            {
                lblBarcoJug2.Visible = false;
            }
            if (puntajeEnemigo == 4)
            {
                lblBarcoJug1.Visible = false;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            BloquearBotonesJugador();
            turnoJugador = 1;
            input = Microsoft.VisualBasic.Interaction.InputBox("Nombre", "Ingrese su Nombre: ", "Default", 0, 0);
            DialogResult boton = MessageBox.Show("COMENZAR JUEGO", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (boton == DialogResult.OK)
            {
                tmJugador.Start();
            }

        }

        private void btnCampo15_Click(object sender, EventArgs e)
        {
            if (buscarBarcoEnemigo(btnCampo15.Name) == true)
            {
                MessageBox.Show("***BAM***");
                cambiaCampoPropioEnemigo(btnCampo15.Name);
                btnCampo15.Image = global::Guerra_de_Barcos.Properties.Resources.ConBarco;
                puntajeJugador++;
                tmJugador.Stop();
                tmEnemigo.Start();
            }
            else
            {
                MessageBox.Show("Nada por aca :( Suerte para la Proxima");
                cambiaCampoPropioEnemigo(btnCampo15.Name);
                tmJugador.Stop();
                tmEnemigo.Start();
            }
        }


        private void btnCampo1_Click(object sender, EventArgs e)
        {
            //if (evaluaCampoMostradoEnemigo(btnCampo1.Name) == false)
            //{
                if (buscarBarcoEnemigo(btnCampo1.Name) == true)
                {
                    MessageBox.Show("***BAM***");
                    cambiaCampoPropioEnemigo(btnCampo1.Name);
                    btnCampo1.Image = global::Guerra_de_Barcos.Properties.Resources.ConBarco;
                    puntajeJugador++;
                    tmJugador.Stop();
                    tmEnemigo.Start();
                }
                else
                {
                    MessageBox.Show("Nada por aca :( Suerte para la Proxima");
                    cambiaCampoPropioEnemigo(btnCampo1.Name);
                    tmJugador.Stop();
                    tmEnemigo.Start();
                }
            //}
            //else
            //{
               // MessageBox.Show("Ya ataco este cuadrante");
            //}
        }

        private void tmJugador_Tick(object sender, EventArgs e)
        {
            if (puntajeEnemigo == 4)
            {
                tmEnemigo.Stop();
                tmJugador.Stop();
                BloquearBotonesEnemigo();
                BloquearBotonesJugador();
                MessageBox.Show("GANADOR EQUIPO");
            }
            else
            {
                pintarBarcosJugador();
                MostrarBotonesEnemigo();
                tmJugador.Enabled = true;
                contadorTiempoJugador++;
                lblTime.Text = contadorTiempoJugador + "";
                lblNombre.Text = input;
                if (contadorTiempoJugador > 100)
                {
                    tmJugador.Stop();
                    contadorTiempoJugador = 0;
                    BloquearBotonesJugador();
                    tmEnemigo.Start();
                }
            } 
        }

        private void tmEnemigo_Tick(object sender, EventArgs e)
        {
            if (puntajeJugador == 4)
            {
                tmEnemigo.Stop();
                tmJugador.Stop();
                BloquearBotonesEnemigo();
                BloquearBotonesJugador();
                MessageBox.Show("GANADOR JUGADOR 1");
            }else
            {
                pintarBarcosEnemigo();
                BloquearBotonesEnemigo();
                BloquearBotonesJugador();
                tmEnemigo.Enabled = true;
                contadorTiempoEnemigo++;
                lblTime.Text = contadorTiempoEnemigo + "";
                lblNombre.Text = "Equipo";
                if (contadorTiempoEnemigo > 15)
                {
                    ataqueEnemigo();
                    tmEnemigo.Stop();
                    contadorTiempoEnemigo = 0;
                    contadorTiempoJugador = 0;
                    tmJugador.Start();
                }

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCampo2_Click(object sender, EventArgs e)
        {
            if (buscarBarcoEnemigo(btnCampo2.Name) == true)
            {
                MessageBox.Show("***BAM***");
                cambiaCampoPropioEnemigo(btnCampo2.Name);
                btnCampo2.Image = global::Guerra_de_Barcos.Properties.Resources.ConBarco;
                puntajeJugador++;
                tmJugador.Stop();
                tmEnemigo.Start();
            }
            else
            {
                MessageBox.Show("Nada por aca :( Suerte para la Proxima");
                cambiaCampoPropioEnemigo(btnCampo2.Name);
                tmJugador.Stop();
                tmEnemigo.Start();
            }
        }

        private void btnCampo3_Click(object sender, EventArgs e)
        {
            if (buscarBarcoEnemigo(btnCampo3.Name) == true)
            {
                MessageBox.Show("***BAM***");
                cambiaCampoPropioEnemigo(btnCampo3.Name);
                btnCampo3.Image = global::Guerra_de_Barcos.Properties.Resources.ConBarco;
                puntajeJugador++;
                tmJugador.Stop();
                tmEnemigo.Start();
            }
            else
            {
                MessageBox.Show("Nada por aca :( Suerte para la Proxima");
                cambiaCampoPropioEnemigo(btnCampo3.Name);
                tmJugador.Stop();
                tmEnemigo.Start();
            }
        }

        private void btnCampo4_Click(object sender, EventArgs e)
        {
            if (buscarBarcoEnemigo(btnCampo4.Name) == true)
            {
                MessageBox.Show("***BAM***");
                cambiaCampoPropioEnemigo(btnCampo4.Name);
                btnCampo4.Image = global::Guerra_de_Barcos.Properties.Resources.ConBarco;
                puntajeJugador++;
                tmJugador.Stop();
                tmEnemigo.Start();
            }
            else
            {
                MessageBox.Show("Nada por aca :( Suerte para la Proxima");
                cambiaCampoPropioEnemigo(btnCampo4.Name);
                tmJugador.Stop();
                tmEnemigo.Start();
            }
        }

        private void btnCampo5_Click(object sender, EventArgs e)
        {
            if (buscarBarcoEnemigo(btnCampo5.Name) == true)
            {
                MessageBox.Show("***BAM***");
                cambiaCampoPropioEnemigo(btnCampo5.Name);
                btnCampo5.Image = global::Guerra_de_Barcos.Properties.Resources.ConBarco;
                puntajeJugador++;
                tmJugador.Stop();
                tmEnemigo.Start();
            }
            else
            {
                MessageBox.Show("Nada por aca :( Suerte para la Proxima");
                cambiaCampoPropioEnemigo(btnCampo5.Name);
                tmJugador.Stop();
                tmEnemigo.Start();
            }
        }

        private void btnCampo6_Click(object sender, EventArgs e)
        {
            if (buscarBarcoEnemigo(btnCampo6.Name) == true)
            {
                MessageBox.Show("***BAM***");
                cambiaCampoPropioEnemigo(btnCampo6.Name);
                btnCampo6.Image = global::Guerra_de_Barcos.Properties.Resources.ConBarco;
                puntajeJugador++;
                tmJugador.Stop();
                tmEnemigo.Start();
            }
            else
            {
                MessageBox.Show("Nada por aca :( Suerte para la Proxima");
                cambiaCampoPropioEnemigo(btnCampo6.Name);
                tmJugador.Stop();
                tmEnemigo.Start();
            }
        }

        private void btnCampo7_Click(object sender, EventArgs e)
        {
            if (buscarBarcoEnemigo(btnCampo7.Name) == true)
            {
                MessageBox.Show("***BAM***");
                cambiaCampoPropioEnemigo(btnCampo7.Name);
                btnCampo7.Image = global::Guerra_de_Barcos.Properties.Resources.ConBarco;
                puntajeJugador++;
                tmJugador.Stop();
                tmEnemigo.Start();
            }
            else
            {
                MessageBox.Show("Nada por aca :( Suerte para la Proxima");
                cambiaCampoPropioEnemigo(btnCampo7.Name);
                tmJugador.Stop();
                tmEnemigo.Start();
            }
        }

        private void btnCampo8_Click(object sender, EventArgs e)
        {
            if (buscarBarcoEnemigo(btnCampo8.Name) == true)
            {
                MessageBox.Show("***BAM***");
                cambiaCampoPropioEnemigo(btnCampo8.Name);
                btnCampo8.Image = global::Guerra_de_Barcos.Properties.Resources.ConBarco;
                puntajeJugador++;
                tmJugador.Stop();
                tmEnemigo.Start();
            }
            else
            {
                MessageBox.Show("Nada por aca :( Suerte para la Proxima");
                cambiaCampoPropioEnemigo(btnCampo8.Name);
                tmJugador.Stop();
                tmEnemigo.Start();
            }
        }

        private void btnCampo9_Click(object sender, EventArgs e)
        {
            if (buscarBarcoEnemigo(btnCampo9.Name) == true)
            {
                MessageBox.Show("***BAM***");
                cambiaCampoPropioEnemigo(btnCampo9.Name);
                btnCampo9.Image = global::Guerra_de_Barcos.Properties.Resources.ConBarco;
                puntajeJugador++;
                tmJugador.Stop();
                tmEnemigo.Start();
            }
            else
            {
                MessageBox.Show("Nada por aca :( Suerte para la Proxima");
                cambiaCampoPropioEnemigo(btnCampo9.Name);
                tmJugador.Stop();
                tmEnemigo.Start();
            }
        }

        private void btnCampo10_Click(object sender, EventArgs e)
        {
            if (buscarBarcoEnemigo(btnCampo10.Name) == true)
            {
                MessageBox.Show("***BAM***");
                cambiaCampoPropioEnemigo(btnCampo10.Name);
                btnCampo10.Image = global::Guerra_de_Barcos.Properties.Resources.ConBarco;
                puntajeJugador++;
                tmJugador.Stop();
                tmEnemigo.Start();
            }
            else
            {
                MessageBox.Show("Nada por aca :( Suerte para la Proxima");
                cambiaCampoPropioEnemigo(btnCampo10.Name);
                tmJugador.Stop();
                tmEnemigo.Start();
            }
        }

        private void btnCampo11_Click(object sender, EventArgs e)
        {
            if (buscarBarcoEnemigo(btnCampo11.Name) == true)
            {
                MessageBox.Show("***BAM***");
                cambiaCampoPropioEnemigo(btnCampo11.Name);
                btnCampo11.Image = global::Guerra_de_Barcos.Properties.Resources.ConBarco;
                puntajeJugador++;
                tmJugador.Stop();
                tmEnemigo.Start();
            }
            else
            {
                MessageBox.Show("Nada por aca :( Suerte para la Proxima");
                cambiaCampoPropioEnemigo(btnCampo11.Name);
                tmJugador.Stop();
                tmEnemigo.Start();
            }
        }

        private void btnCampo12_Click(object sender, EventArgs e)
        {
            if (buscarBarcoEnemigo(btnCampo12.Name) == true)
            {
                MessageBox.Show("***BAM***");
                cambiaCampoPropioEnemigo(btnCampo12.Name);
                btnCampo12.Image = global::Guerra_de_Barcos.Properties.Resources.ConBarco;
                puntajeJugador++;
                tmJugador.Stop();
                tmEnemigo.Start();
            }
            else
            {
                MessageBox.Show("Nada por aca :( Suerte para la Proxima");
                cambiaCampoPropioEnemigo(btnCampo12.Name);
                tmJugador.Stop();
                tmEnemigo.Start();
            }
        }

        private void btnCampo13_Click(object sender, EventArgs e)
        {
            if (buscarBarcoEnemigo(btnCampo13.Name) == true)
            {
                MessageBox.Show("***BAM***");
                cambiaCampoPropioEnemigo(btnCampo13.Name);
                btnCampo13.Image = global::Guerra_de_Barcos.Properties.Resources.ConBarco;
                puntajeJugador++;
                tmJugador.Stop();
                tmEnemigo.Start();
            }
            else
            {
                MessageBox.Show("Nada por aca :( Suerte para la Proxima");
                cambiaCampoPropioEnemigo(btnCampo13.Name);
                tmJugador.Stop();
                tmEnemigo.Start();
            }
        }

        private void btnCampo14_Click(object sender, EventArgs e)
        {
            if (buscarBarcoEnemigo(btnCampo14.Name) == true)
            {
                MessageBox.Show("***BAM***");
                cambiaCampoPropioEnemigo(btnCampo14.Name);
                btnCampo14.Image = global::Guerra_de_Barcos.Properties.Resources.ConBarco;
                puntajeJugador++;
                tmJugador.Stop();
                tmEnemigo.Start();
            }
            else
            {
                MessageBox.Show("Nada por aca :( Suerte para la Proxima");
                cambiaCampoPropioEnemigo(btnCampo14.Name);
                tmJugador.Stop();
                tmEnemigo.Start();
            }
        }

        private void btnCampo20_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
