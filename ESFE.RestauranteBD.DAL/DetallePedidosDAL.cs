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
    public class DetallePedidosDAL
    {
        public bool Insertar(DetallePedidos detalle)
        {
            using SqlConnection conexion =
                (SqlConnection)DBComun.ObtenerConexion();

            using SqlCommand comando =
                new SqlCommand("InsertarDetallePedido", conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@id_detalle", detalle.IdDetalle);

            comando.Parameters.AddWithValue(
                "@id_pedido",
                detalle.IdPedido ?? (object)DBNull.Value);

            comando.Parameters.AddWithValue(
                "@cantidad",
                detalle.Cantidad);

            conexion.Open();

            comando.ExecuteNonQuery();

            return true;
        }

        public bool Actualizar(DetallePedidos detalle)
        {
            using SqlConnection conexion =
                (SqlConnection)DBComun.ObtenerConexion();

            using SqlCommand comando =
                new SqlCommand("ActualizarDetallePedido", conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue(
                "@id_detalle",
                detalle.IdDetalle);

            comando.Parameters.AddWithValue(
                "@id_pedido",
                detalle.IdPedido ?? (object)DBNull.Value);

            comando.Parameters.AddWithValue(
                "@cantidad",
                detalle.Cantidad);

            conexion.Open();

            comando.ExecuteNonQuery();

            return true;
        }

        public bool Eliminar(string idDetalle)
        {
            using SqlConnection conexion =
                (SqlConnection)DBComun.ObtenerConexion();

            using SqlCommand comando =
                new SqlCommand("EliminarDetallePedido", conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue(
                "@id_detalle",
                idDetalle);

            conexion.Open();

            return comando.ExecuteNonQuery() > 0;
        }

        public List<DetallePedidos> Buscar(string idPedido)
        {
            List<DetallePedidos> lista =
                new List<DetallePedidos>();

            using SqlConnection conexion =
                (SqlConnection)DBComun.ObtenerConexion();

            using SqlCommand comando =
                new SqlCommand("BuscarDetallePedido", conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue(
                "@id_pedido",
                idPedido);

            conexion.Open();

            using SqlDataReader reader =
                comando.ExecuteReader();

            while (reader.Read())
            {
                DetallePedidos detalle =
                    new DetallePedidos();

                detalle.IdDetalle =
                    Convert.ToString(reader["id_detalle"])
                    ?? string.Empty;

                detalle.IdPedido =
                    reader["id_pedido"] == DBNull.Value
                    ? string.Empty
                    : Convert.ToString(reader["id_pedido"])
                    ?? string.Empty;

                detalle.Cantidad =
                    Convert.ToInt32(reader["cantidad"]);

                lista.Add(detalle);
            }

            return lista;
        }

        public List<DetallePedidos> BuscarPorPedido(string idPedido)
        {
            List<DetallePedidos> lista =
                new List<DetallePedidos>();

            using SqlConnection conexion =
                (SqlConnection)DBComun.ObtenerConexion();

            using SqlCommand comando =
                new SqlCommand("BuscarDetallePedido", conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue(
                "@id_pedido",
                idPedido);

            conexion.Open();

            using SqlDataReader reader =
                comando.ExecuteReader();

            while (reader.Read())
            {
                DetallePedidos detalle =
                    new DetallePedidos();

                detalle.IdDetalle =
                    Convert.ToString(reader["id_detalle"])
                    ?? string.Empty;

                detalle.IdPedido =
                    reader["id_pedido"] == DBNull.Value
                    ? string.Empty
                    : Convert.ToString(reader["id_pedido"])
                    ?? string.Empty;

                detalle.Cantidad =
                    Convert.ToInt32(reader["cantidad"]);

                lista.Add(detalle);
            }

            return lista;
        }
    }
}