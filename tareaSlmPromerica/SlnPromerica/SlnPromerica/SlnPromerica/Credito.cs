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
    public partial class Credito : Form
    {
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataAdapter adp;
        string CadenaConexion = "Data Source=RIVERA;Initial Catalog=Promerica;Integrated Security=True";
        DataTable TablaClientes;

        public Credito()
        {
            InitializeComponent();
        }

        private void Conexion()
        {
            conexion = new SqlConnection();
            conexion.ConnectionString = CadenaConexion;
            conexion.Open();

        }

        private void ConsultarCredito(int TipoConsulta = 0, string IdCliente = "")
        {
            Conexion();
            if (conexion.State != ConnectionState.Open)
            {
                return;
            }
            comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.Connection = conexion;
            comando.CommandText = "Select * from Creditos";
            comando.CommandTimeout = 0;
            comando.ExecuteNonQuery();
            adp = new SqlDataAdapter();
            adp.SelectCommand = comando;
            TablaClientes = new DataTable();
            adp.Fill(TablaClientes);
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnFechForma_Click(object sender, EventArgs e)
        {
            ConsultarCredito();

            var listadoFiltrado = from registro in TablaClientes.AsEnumerable()
                                  where registro.Field<string>("IdCliente").Contains(txtFiltro.Text)

                                  select new
                                  {
                                      IdCliente = registro.Field<string>("IdCliente"),
                                      FechaFormalizacion = registro.Field<DateTime>("FechaFormalizacion")
                                  };

            var result = listadoFiltrado.GroupBy(x => x.IdCliente)
                                     .Select(g => new { Id = g.Key, Max = g.Max(x => x.FechaFormalizacion) });

            dgvCredito.DataSource = result.ToList();


        }

        private void Credito_Load(object sender, EventArgs e)
        {

        }

        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTotalCreditos_Click(object sender, EventArgs e)
        {
            ConsultarCredito();

            var listadoFiltrado = from registro in TablaClientes.AsEnumerable()
                                  where registro.Field<string>("IdCliente").Contains(txtFiltro.Text)
                                  
                                  select new
                                  {
                                      IdCliente = registro.Field<string>("IdCliente"),
                                      Saldo = registro.Field<double>("Saldo")
                                   };

            var result = listadoFiltrado.GroupBy(x => x.IdCliente)
                                     .Select(g => new { Id = g.Key, Sum = g.Sum(x => x.Saldo) } );

            dgvCredito.DataSource = result.ToList();
         
        }

        private void btnMayorPlazo_Click(object sender, EventArgs e)
        {
            ConsultarCredito();


            var listadoFiltrado = from registro in TablaClientes.AsEnumerable()
                                  where registro.Field<string>("IdCliente").Contains(txtFiltro.Text)

                                  select new
                                  {
                                      IdCliente = registro.Field<string>("IdCliente"),
                                      Plazo = registro.Field<int>("Plazo")
                                  };

            var result = listadoFiltrado.GroupBy(x => x.IdCliente)
                                     .Select(g => new { Id = g.Key, Max = g.Max(x => x.Plazo) });

            dgvCredito.DataSource = result.ToList();
        }

        private void btnPromSaldCred_Click(object sender, EventArgs e)
        {
            ConsultarCredito();
            var listadoFiltrado = from registro in TablaClientes.AsEnumerable()
                                  where registro.Field<string>("IdCliente").Contains(txtFiltro.Text)

                                  select new
                                  {
                                      IdCliente = registro.Field<string>("IdCliente"),
                                      Saldo = registro.Field<double>("Saldo")
                                  };

            var result = listadoFiltrado.GroupBy(x => x.IdCliente)
                                     .Select(g => new { Id = g.Key, AVG = g.Average(x => x.Saldo) });

            dgvCredito.DataSource = result.ToList();

        }

        private void btnMayorOpera_Click(object sender, EventArgs e)
        {
            ConsultarCredito();
            var listadoFiltrado = from registro in TablaClientes.AsEnumerable()
                                  where registro.Field<string>("IdCliente").Contains(txtFiltro.Text)

                                  select new
                                  {
                                      IdCliente = registro.Field<string>("IdCliente"),
                                      IdOperacion = registro.Field<string>("IdOperacion")
                                  };

            var result = listadoFiltrado.GroupBy(x => x.IdCliente)
                                     .Select(g => new { Id = g.Key, Cont = g.Count() });

            dgvCredito.DataSource = result.ToList();            

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ConsultarCredito();
            var listadoFiltrado = from registro in TablaClientes.AsEnumerable()
                                  where registro.Field<DateTime>("FechaFormalizacion").Date == dtpFechaForma.Value.Date
                                  && registro.Field<DateTime>("FechaVencimiento").Date == dtpFechVenci.Value.Date

                                  select new
                                  {
                                      IdCliente = registro.Field<string>("IdCliente"),
                                      IdOperacion = registro.Field<string>("IdOperacion"),
                                      FechaFormalizacion = registro.Field<DateTime>("FechaFormalizacion"),
                                      FechaVencimiento = registro.Field<DateTime>("FechaVencimiento")
                                  };
            
            dgvFechas.DataSource = listadoFiltrado.ToList();

        }
    }
}
