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

namespace SlnPromerica
{
    public partial class FrmClientes : Form
    {
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataAdapter adp;
        string CadenaConexion = "Data Source=RIVERA;Initial Catalog=Promerica;Integrated Security=True";
        DataTable TablaClientes;

        public FrmClientes()
        {
            InitializeComponent();
        }

        private void Conexion()
        {
            conexion = new SqlConnection();
            conexion.ConnectionString = CadenaConexion;
            conexion.Open();

        }

        private void ConsultarClientes(int TipoConsulta = 0, string IdCliente = "")
        {
            Conexion();
            if (conexion.State != ConnectionState.Open)
            {
                return;
            }
            comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.Connection = conexion;
            comando.CommandText = "Select * from Clientes";
            comando.CommandTimeout = 0;
            comando.ExecuteNonQuery();
            adp = new SqlDataAdapter();
            adp.SelectCommand = comando;
            TablaClientes = new DataTable();
            adp.Fill(TablaClientes);
            dgvClientes.DataSource = TablaClientes;

        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultarClientes();
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            var listadoFiltrado = from registro in TablaClientes.AsEnumerable()
                                  where registro.Field<string>("NombreCliente").ToLower().Contains(txtFiltro.Text)
                                  || registro.Field<string>("NombreCliente").ToUpper().Contains(txtFiltro.Text)
                                  select new
                                  {
                                      IdCliente = registro.Field<string>("IdCliente"),
                                      NombreCliente = registro.Field<string>("NombreCliente"),
                                      Apellido1Cliente = registro.Field<string>("Apellido1Cliente"),
                                      Apellido2Cliente = registro.Field<string>("Apellido2Cliente")
                                  };
            int cantidad = listadoFiltrado.Count(n => n.NombreCliente.Length <= 6);
            dgvClientes.DataSource = listadoFiltrado.ToList();
            MessageBox.Show(cantidad.ToString());
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

/*Tarea---incorporar un segundo DVG al seleccionar un cliente muestre las operaciones en el segundo dvg
 * en textbox mostrar saldo total de los creditos de carlos, la ultima fecha en la que formalizo un credito, la operacion que tiene mayor plazo
 * el conteo de la cant de operaciones que tiene carlos, el promedio de los saldos de los creditos y un tercer dvg en un form nuevo
 */