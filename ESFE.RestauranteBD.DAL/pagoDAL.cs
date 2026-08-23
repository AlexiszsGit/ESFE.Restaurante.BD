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
        public int Agregar(Pago pPago)
        {
            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("dbo.AgregarPago", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@IdPago", pPago.IdPago.Trim());
                    comando.Parameters.AddWithValue("@Total", pPago.total);
                    comando.Parameters.AddWithValue("@FechaPago", pPago.fechaPago);
                    comando.Parameters.AddWithValue("@IdMetodo", pPago.IdMetodo.Trim());
                    comando.Parameters.AddWithValue("@IdPedido", pPago.IdPedido.Trim());

                    conexion.Open();
                    return comando.ExecuteNonQuery();
                }
            }
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

        public int Eliminar(string pIdPago)
        {
            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("dbo.EliminarPago", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@IdPago", pIdPago.Trim());

                    conexion.Open();
                    return comando.ExecuteNonQuery();
                }
            }
        }

        public List<Pago> Buscar(Pago pPago)
        {
            List<Pago> lista = new List<Pago>();

            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("dbo.BuscarPago", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@IdPago", string.IsNullOrWhiteSpace(pPago.IdPago) ? (object)DBNull.Value : pPago.IdPago.Trim());
                    comando.Parameters.AddWithValue("@IdPedido", string.IsNullOrWhiteSpace(pPago.IdPedido) ? (object)DBNull.Value : pPago.IdPedido.Trim());
                    comando.Parameters.AddWithValue("@IdMetodo", string.IsNullOrWhiteSpace(pPago.IdMetodo) ? (object)DBNull.Value : pPago.IdMetodo.Trim());

                    conexion.Open();
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Pago pago = new Pago
                            {
                                IdPago = reader["IdPago"].ToString(),
                                total = Convert.ToDecimal(reader["Total"]),
                                fechaPago = Convert.ToDateTime(reader["FechaPago"]),
                                IdMetodo = reader["IdMetodo"] != DBNull.Value ? reader["IdMetodo"].ToString() : string.Empty,
                                IdPedido = reader["IdPedido"] != DBNull.Value ? reader["IdPedido"].ToString() : string.Empty
                            };
                            lista.Add(pago);
                        }
                    }
                }
            }
            return lista;
        }
    }
}
