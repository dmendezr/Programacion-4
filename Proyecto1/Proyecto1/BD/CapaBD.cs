using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BD
{
    public class CapaBD
    {
        string cadenaConexion = "";
        SqlConnection objConexion;
        SqlCommand objComando;

        public List<Clientes> ObtenerClientes()
        {
            SqlDataReader dr;
            List<Clientes> ListadoClientes = new List<Clientes>();
            objConexion = new SqlConnection(cadenaConexion);
            objComando = new SqlCommand ();
            objComando.CommandType = System.Data.CommandType.Text;
            objComando.Connection = objConexion;
            objComando.CommandText = "SELECT * FROM Clientes";
            objComando.CommandTimeout = 0;
            objConexion.Open();
            dr = objComando.ExecuteReader();

            while (dr.Read())
            {
                Clientes objCliente = new Clientes();
                objCliente.IdCliente = dr.GetString(0);
                objCliente.NombreCLiente = dr.GetString(1);
                objCliente.Apellido1Cliente = dr.GetString(2);
                objCliente.Apellido2Cliente = dr.GetString(3);
                ListadoClientes.Add(objCliente);
            }

            objConexion.Close();
            objComando.Dispose();
            dr.Dispose();

            return ListadoClientes;
        }

    }
}
