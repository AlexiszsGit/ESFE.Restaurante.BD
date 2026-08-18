using ESFE.RestauranteBD.EN;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ESFE.RestauranteBD.DAL
{
    public class PagoDAL
    {
        public bool Insertar(Pago pago)
        {
            using SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion();
            using SqlCommand comando = new SqlCommand("InsertarPago", conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@total", pago.total);
            comando.Parameters.AddWithValue("@fechaPago", pago.fechaPago);
            comando.Parameters.AddWithValue("@IdMetodo", pago.IdMetodo);
            comando.Parameters.AddWithValue("@IdPedido", pago.IdPedido);

            conexion.Open();
            comando.ExecuteNonQuery();

            return true;
        }

        public bool Actualizar(Pago pago)
        {
            using SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion();
            using SqlCommand comando = new SqlCommand("ActualizarPago", conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdPago", pago.IdPago);
            comando.Parameters.AddWithValue("@total", pago.total);
            comando.Parameters.AddWithValue("@fechaPago", pago.fechaPago);
            comando.Parameters.AddWithValue("@IdMetodo", pago.IdMetodo);
            comando.Parameters.AddWithValue("@IdPedido", pago.IdPedido);

            conexion.Open();
            comando.ExecuteNonQuery();

            return true;
        }

        public bool Eliminar(string idPago)
        {
            using SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion();
            using SqlCommand comando = new SqlCommand("EliminarPago", conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdPago", idPago);

            conexion.Open();

            return comando.ExecuteNonQuery() > 0;
        }

        public List<Pago> Buscar(string idPago)
        {
            List<Pago> lista = new List<Pago>();

            using SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion();
            using SqlCommand comando = new SqlCommand("BuscarPago", conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdPago", idPago);

            conexion.Open();

            using SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Pago pago = new Pago();

                pago.IdPago = reader["IdPago"]?.ToString();
                pago.total = Convert.ToDecimal(reader["total"]);
                pago.fechaPago = Convert.ToDateTime(reader["fechaPago"]);
                pago.IdMetodo = reader["IdMetodo"]?.ToString();
                pago.IdPedido = reader["IdPedido"]?.ToString();

                lista.Add(pago);
            }

            return lista;
        }
    }
}
