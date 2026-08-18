using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using ESFE.RestauranteBD.EN;
using Microsoft.Data.SqlClient;


namespace ESFE.RestauranteBD.DAL
{
   
        public class MesaDAL
        {
            public bool Insertar(Mesa mesa)
            {
                using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
                {
                    using (SqlCommand comando = new SqlCommand("InsertarMesa", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@id_mesa", mesa.IdMesa);
                        comando.Parameters.AddWithValue("@capacidad", mesa.Capacidad);
                        comando.Parameters.AddWithValue("@disponible", mesa.Disponible ?? (object)DBNull.Value);

                        conexion.Open();
                        return comando.ExecuteNonQuery() > 0;
                    }
                }
            }

            public bool Actualizar(Mesa mesa)
            {
                using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
                {
                    using (SqlCommand comando = new SqlCommand("ActualizarMesa", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@id_mesa", mesa.IdMesa);
                        comando.Parameters.AddWithValue("@capacidad", mesa.Capacidad);
                        comando.Parameters.AddWithValue("@disponible", mesa.Disponible ?? (object)DBNull.Value);

                        conexion.Open();
                        return comando.ExecuteNonQuery() > 0;
                    }
                }
            }

            public bool Eliminar(string idMesa)
            {
                using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
                {
                    using (SqlCommand comando = new SqlCommand("EliminarMesa", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@id_mesa", idMesa);

                        conexion.Open();
                        return comando.ExecuteNonQuery() > 0;
                    }
                }
            }

            public List<Mesa> Buscar(string idMesa)
            {
                List<Mesa> lista = new List<Mesa>();
                using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
                {
                    using (SqlCommand comando = new SqlCommand("BuscarMesa", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@id_mesa", idMesa);

                        conexion.Open();
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Mesa mesa = new Mesa();
                                mesa.IdMesa = reader["id_mesa"]?.ToString() ?? string.Empty;
                                mesa.Capacidad = reader["capacidad"] != DBNull.Value ? Convert.ToInt32(reader["capacidad"]) : 0;
                                mesa.Disponible = reader["disponible"]?.ToString() ?? string.Empty;

                                lista.Add(mesa);
                            }
                        }
                    }
                }
                return lista;
            }
        }
}