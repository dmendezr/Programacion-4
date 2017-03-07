using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AppPromerica
{
    public partial class frmClientes : Form
    {
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataAdapter adp;
        String CadenaDeConexion = @"Data Source=1217-30\SQLSERVER2016;Initial Catalog=Promerica;Integrated Security=True";
        DataTable tablaClientes; 
        public frmClientes()
        {
            InitializeComponent();
        }

        private void conectar()
        {
            conexion = new SqlConnection();
            conexion.ConnectionString = CadenaDeConexion;
            conexion.Open();
        }

        private void consultarClientes(int tipoConsulta = 0 , string idCliente = "")
        {
            conectar();
            if (conexion.State != ConnectionState.Open)
            {
                return;
            }
            comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.Connection = conexion;
            comando.CommandText = "Select * From Clientes";
            comando.CommandTimeout = 0;
            comando.ExecuteNonQuery();
            adp = new SqlDataAdapter();
            adp.SelectCommand = comando;
            tablaClientes = new DataTable();
            adp.Fill(tablaClientes);
            dgClientes.DataSource = tablaClientes;
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            consultarClientes();
        }

        private void lblFiltro_Click(object sender, EventArgs e)
        {

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            var listadoFiltrado = from registro in tablaClientes.AsEnumerable ()
                                  where registro.Field<string>("NombreCliente").ToLower().Contains(txtFiltro.Text)
                                  select new
                                  {
                                      IdCliente = registro.Field<string>("IdCliente"),
                                      nombreCliente = registro.Field<string>("NombreCliente"),
                                      Apellido1Cliente = registro.Field<string>("Apellido1Cliente"),
                                      Apellido2Cliente = registro.Field<string>("Apellido2Cliente")
                                  };
            int cantidad = listadoFiltrado.Count(n => n.nombreCliente.Length <= 9);
            dgClientes.DataSource = listadoFiltrado.ToList();
            MessageBox.Show(cantidad.ToString());
        }
    }
}
