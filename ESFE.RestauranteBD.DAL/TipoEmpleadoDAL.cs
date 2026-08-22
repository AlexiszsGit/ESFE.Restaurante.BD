using System;
using System.Collections.Generic;
using System.Text;
using ESFE.RestauranteBD.EN;
using Microsoft.Data.SqlClient;
using System.Data;

namespace ESFE.RestauranteBD.DAL;

    public class TipoEmpleadoDAL
    {
        public bool Insertar(TipoEmpleado tipo)
        {
            
            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("InsertarTipoEmpleado", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id_tipo", tipo.IdTipo); // Si en tu EN se llama IdTipoEmpleado, cámbialo aquí
                    comando.Parameters.AddWithValue("@nombre", tipo.Nombre);

                    conexion.Open();
                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }

    public int Actualizar(TipoEmpleado tipo, string idViejo)
    {
        using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
        {
            SqlCommand comando = new SqlCommand("ActualizarTipoEmpleado", conexion);
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@id_viejo", idViejo);
            comando.Parameters.AddWithValue("@id_nuevo", tipo.IdTipo);
            comando.Parameters.AddWithValue("@nombre", tipo.Nombre);

            conexion.Open();
            return comando.ExecuteNonQuery();
        }
    }

    public bool Eliminar(string idTipo)
        {
            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("EliminarTipoEmpleado", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id_tipo", idTipo);

                    conexion.Open();
                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }

        public List<TipoEmpleado> Buscar(string idTipo)
        {
            List<TipoEmpleado> lista = new List<TipoEmpleado>();
            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("BuscarTipoEmpleado", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id_tipo", idTipo);

                    conexion.Open();
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TipoEmpleado tipo = new TipoEmpleado();
                            tipo.IdTipo = reader["id_tipo"].ToString() ?? string.Empty;
                        tipo.Nombre = reader["nombre"].ToString() ?? string.Empty;

                        lista.Add(tipo);
                        }
                    }
                }
            }
            return lista;
        }
    }