using System;
using System.Collections.Generic;
using System.Data;
using ESFE.RestauranteBD.EN;
using Microsoft.Data.SqlClient;

namespace ESFE.RestauranteBD.DAL
{
    public class DetallePedidosDAL
    {
        // =========================
        // INSERTAR
        // =========================
        public bool Insertar(DetallePedidos detalle)
        {
            using SqlConnection conexion =
                (SqlConnection)DBComun.ObtenerConexion();

            using SqlCommand comando =
                new SqlCommand("InsertarDetallePedido", conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue(
                "@id_detalle",
                detalle.IdDetalle);

            comando.Parameters.AddWithValue(
                "@id_pedido",
                string.IsNullOrWhiteSpace(detalle.IdPedido)
                    ? (object)DBNull.Value
                    : detalle.IdPedido);

            comando.Parameters.AddWithValue(
                "@id_producto",
                string.IsNullOrWhiteSpace(detalle.IdProducto)
                    ? (object)DBNull.Value
                    : detalle.IdProducto);

            comando.Parameters.AddWithValue(
                "@cantidad",
                detalle.Cantidad);

            conexion.Open();

            comando.ExecuteNonQuery();

            return true;
        }


        // =========================
        // ACTUALIZAR
        // =========================
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
                string.IsNullOrWhiteSpace(detalle.IdPedido)
                    ? (object)DBNull.Value
                    : detalle.IdPedido);

            comando.Parameters.AddWithValue(
                "@id_producto",
                string.IsNullOrWhiteSpace(detalle.IdProducto)
                    ? (object)DBNull.Value
                    : detalle.IdProducto);

            comando.Parameters.AddWithValue(
                "@cantidad",
                detalle.Cantidad);

            conexion.Open();

            comando.ExecuteNonQuery();

            return true;
        }


        // =========================
        // ELIMINAR
        // =========================
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

            comando.ExecuteNonQuery();

            return true;
        }


        // =========================
        // BUSCAR
        // =========================
        public List<DetallePedidos> Buscar(string busqueda)
        {
            List<DetallePedidos> lista =
                new List<DetallePedidos>();

            using SqlConnection conexion =
                (SqlConnection)DBComun.ObtenerConexion();

            using SqlCommand comando =
                new SqlCommand("BuscarDetallePedido", conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue(
                "@Busqueda",
                busqueda ?? string.Empty);

            conexion.Open();

            using SqlDataReader reader =
                comando.ExecuteReader();

            while (reader.Read())
            {
                DetallePedidos detalle =
                    new DetallePedidos();

                detalle.IdDetalle =
                    reader["id_detalle"] == DBNull.Value
                        ? string.Empty
                        : Convert.ToString(
                            reader["id_detalle"]) ?? string.Empty;

                detalle.IdPedido =
                    reader["id_pedido"] == DBNull.Value
                        ? string.Empty
                        : Convert.ToString(
                            reader["id_pedido"]) ?? string.Empty;

                detalle.IdProducto =
                    reader["id_producto"] == DBNull.Value
                        ? string.Empty
                        : Convert.ToString(
                            reader["id_producto"]) ?? string.Empty;

                detalle.NombreProducto =
                    reader["nombre_producto"] == DBNull.Value
                        ? string.Empty
                        : Convert.ToString(
                            reader["nombre_producto"]) ?? string.Empty;

                detalle.Cantidad =
                    reader["cantidad"] == DBNull.Value
                        ? 0
                        : Convert.ToInt32(
                            reader["cantidad"]);

                lista.Add(detalle);
            }

            return lista;
        }
    }
}