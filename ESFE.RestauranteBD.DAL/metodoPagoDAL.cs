using ESFE.RestauranteBD.EN;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ESFE.RestauranteBD.DAL
{
    public class MetodoPago
    {
        public List<MetodoDePago> Buscar(MetodoDePago pMetodo)
        {
            List<MetodoDePago> lista = new List<MetodoDePago>();
            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("dbo.BuscarMetodoPago", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@IdMetodo", string.IsNullOrWhiteSpace(pMetodo.IdMetodoDePago) ? (object)DBNull.Value : pMetodo.IdMetodoDePago.Trim());
                    comando.Parameters.AddWithValue("@Nombre", string.IsNullOrWhiteSpace(pMetodo.Nombre) ? (object)DBNull.Value : pMetodo.Nombre.Trim());

                    conexion.Open();
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new MetodoDePago
                            {
                                IdMetodoDePago = reader["IdMetodo"].ToString(),
                                Nombre = reader["Nombre"].ToString()
                            });
                        }
                    }
                }
            }
            return lista;
        }

        public int Agregar(MetodoDePago pMetodo)
        {
            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("dbo.AgregarMetodoPago", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@IdMetodo", pMetodo.IdMetodoDePago.Trim());
                    comando.Parameters.AddWithValue("@Nombre", pMetodo.Nombre.Trim());

                    conexion.Open();
                    return comando.ExecuteNonQuery();
                }
            }
        }

        public int Eliminar(string pIdMetodo)
        {
            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("dbo.EliminarMetodoPago", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@IdMetodo", pIdMetodo.Trim());

                    conexion.Open();
                    return comando.ExecuteNonQuery();
                }
            }
        }
    }
}
