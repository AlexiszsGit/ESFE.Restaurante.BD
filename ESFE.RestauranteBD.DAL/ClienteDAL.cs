using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESFE.RestauranteBD.EN;
using Microsoft.Data.SqlClient;
using System.Data;

namespace ESFE.RestauranteBD.DAL
{
    public class ClienteDAL
    {
        public bool Insertar(Cliente cliente)
        {
            using SqlConnection conexion =
                (SqlConnection)DBComun.ObtenerConexion();

            using SqlCommand comando =
                new SqlCommand("InsertarCliente", conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@id_cliente", cliente.IdCliente);
            comando.Parameters.AddWithValue("@nombre", cliente.Nombre);
            comando.Parameters.AddWithValue("@telefono", cliente.Telefono ?? (object)DBNull.Value);

            conexion.Open();

            comando.ExecuteNonQuery();

            return true;
        }

        public bool Actualizar(Cliente cliente)
        {
            using SqlConnection conexion =
                (SqlConnection)DBComun.ObtenerConexion();

            using SqlCommand comando =
                new SqlCommand("ActualizarCliente", conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@id_cliente", cliente.IdCliente);
            comando.Parameters.AddWithValue("@nombre", cliente.Nombre);
            comando.Parameters.AddWithValue("@telefono", cliente.Telefono ?? (object)DBNull.Value);

            conexion.Open();

            comando.ExecuteNonQuery();

            return true;
        }

        public bool Eliminar(string idCliente)
        {
            using SqlConnection conexion =
                (SqlConnection)DBComun.ObtenerConexion();

            using SqlCommand comando =
                new SqlCommand("EliminarCliente", conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@id_cliente", idCliente);

            conexion.Open();

            return comando.ExecuteNonQuery() > 0;
        }

        public List<Cliente> Buscar(string nombre)
        {
            List<Cliente> lista = new List<Cliente>();

            using SqlConnection conexion =
                (SqlConnection)DBComun.ObtenerConexion();

            using SqlCommand comando =
                new SqlCommand("BuscarClienteNombre", conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@nombre", nombre);

            conexion.Open();

            using SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Cliente cliente = new Cliente();

                cliente.IdCliente =
                    Convert.ToString(reader["id_cliente"]) ?? string.Empty;

                cliente.Nombre =
                    Convert.ToString(reader["nombre"]) ?? string.Empty;

                cliente.Telefono =
                    reader["telefono"] == DBNull.Value
                        ? string.Empty
                        : Convert.ToString(reader["telefono"]) ?? string.Empty;

                lista.Add(cliente);
            }

            return lista;
        }

        public List<Cliente> BuscarPorNombre(string nombre)
        {
            List<Cliente> lista = new List<Cliente>();

            using SqlConnection conexion =
                (SqlConnection)DBComun.ObtenerConexion();

            using SqlCommand comando =
                new SqlCommand("BuscarClienteNombre", conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@nombre", nombre);

            conexion.Open();

            using SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Cliente cliente = new Cliente();

                cliente.IdCliente =
                    Convert.ToString(reader["id_cliente"]) ?? string.Empty;

                cliente.Nombre =
                    Convert.ToString(reader["nombre"]) ?? string.Empty;

                cliente.Telefono =
                    reader["telefono"] == DBNull.Value
                        ? string.Empty
                        : Convert.ToString(reader["telefono"]) ?? string.Empty;

                lista.Add(cliente);
            }

            return lista;
        }
    }
}