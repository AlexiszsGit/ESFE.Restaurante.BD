using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using ESFE.RestauranteBD.EN;
using System.Data;
using System.Text;

namespace ESFE.RestauranteBD.DAL
{
    public  class PedidoDAL
    {
        public bool Insertar(Pedido pedido)
        {
            using SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion();
            using SqlCommand comando = new SqlCommand("InsertarPedido", conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@fecha", pedido.fecha);
            comando.Parameters.AddWithValue("@IDCliente", pedido.IDCliente);
            comando.Parameters.AddWithValue("@IdEmpleado", pedido.IdEmpleado);
            comando.Parameters.AddWithValue("@IdMesa", pedido.IdMesa);
            comando.Parameters.AddWithValue("@IdEstado", pedido.IdEstado);

            conexion.Open();
            comando.ExecuteNonQuery();

            return true;
        }

        public bool Actualizar(Pedido pedido)
        {
            using SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion();
            using SqlCommand comando = new SqlCommand("ActualizarPedido", conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdPedido", pedido.IdPedido);
            comando.Parameters.AddWithValue("@fecha", pedido.fecha);
            comando.Parameters.AddWithValue("@IDCliente", pedido.IDCliente);
            comando.Parameters.AddWithValue("@IdEmpleado", pedido.IdEmpleado);
            comando.Parameters.AddWithValue("@IdMesa", pedido.IdMesa);
            comando.Parameters.AddWithValue("@IdEstado", pedido.IdEstado);

            conexion.Open();
            comando.ExecuteNonQuery();

            return true;
        }

        public bool Eliminar(string idPedido)
        {
            using SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion();
            using SqlCommand comando = new SqlCommand("EliminarPedido", conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdPedido", idPedido);

            conexion.Open();

            return comando.ExecuteNonQuery() > 0;
        }

        public List<Pedido> Buscar(string idPedido)
        {
            List<Pedido> lista = new List<Pedido>();

            using SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion();
            using SqlCommand comando = new SqlCommand("BuscarPedido", conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdPedido", idPedido);

            conexion.Open();

            using SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Pedido pedido = new Pedido();

                pedido.IdPedido = reader["IdPedido"]?.ToString();
                pedido.fecha = Convert.ToDateTime(reader["fecha"]);
                pedido.IDCliente = reader["IDCliente"]?.ToString();
                pedido.IdEmpleado = reader["IdEmpleado"]?.ToString();
                pedido.IdMesa = reader["IdMesa"]?.ToString();
                pedido.IdEstado = reader["IdEstado"]?.ToString();

                lista.Add(pedido);
            }

            return lista;
        }
    }
}
