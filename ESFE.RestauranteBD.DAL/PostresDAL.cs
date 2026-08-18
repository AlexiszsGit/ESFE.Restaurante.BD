using System;
using System.Collections.Generic;
using System.Text;
using ESFE.RestauranteBD.EN;
using Microsoft.Data.SqlClient;
using System.Data;
namespace ESFE.RestauranteBD.DAL
{
   
    
        public class PostreDAL
        {
            public bool Insertar(Postre postre)
            {
                using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
                {
                    using (SqlCommand comando = new SqlCommand("InsertarPostre", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@id_postre", postre.IdPostre);
                        comando.Parameters.AddWithValue("@nombre", postre.Nombre);
                        comando.Parameters.AddWithValue("@precio", postre.Precio);

                        conexion.Open();
                        return comando.ExecuteNonQuery() > 0;
                    }
                }
            }

            public bool Actualizar(Postre postre)
            {
                using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
                {
                    using (SqlCommand comando = new SqlCommand("ActualizarPostre", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@id_postre", postre.IdPostre);
                        comando.Parameters.AddWithValue("@nombre", postre.Nombre);
                        comando.Parameters.AddWithValue("@precio", postre.Precio);

                        conexion.Open();
                        return comando.ExecuteNonQuery() > 0;
                    }
                }
            }

            public bool Eliminar(string idPostre)
            {
                using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
                {
                    using (SqlCommand comando = new SqlCommand("EliminarPostre", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@id_postre", idPostre);

                        conexion.Open();
                        return comando.ExecuteNonQuery() > 0;
                    }
                }
            }

            public List<Postre> Buscar(string idPostre)
            {
                List<Postre> lista = new List<Postre>();
                using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
                {
                    using (SqlCommand comando = new SqlCommand("BuscarPostre", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@id_postre", idPostre);

                        conexion.Open();
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Postre postre = new Postre();
                                postre.IdPostre = reader["id_postre"]?.ToString() ?? string.Empty;
                                postre.Nombre = reader["nombre"]?.ToString() ?? string.Empty;
                                postre.Precio = reader["precio"] != DBNull.Value ? Convert.ToDecimal(reader["precio"]) : 0m;

                                lista.Add(postre);
                            }
                        }
                    }
                }
                return lista;
            }
        }
}