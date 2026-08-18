using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using ESFE.RestauranteBD.EN;
using Microsoft.Data.SqlClient;

namespace ESFE.RestauranteBD.DAL
{
  
    
        public class PlatillosDAL
        {
            public bool Insertar(Platillo platillo)
            {
                using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
                {
                    using (SqlCommand comando = new SqlCommand("InsertarPlatillo", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@id_producto", platillo.IdProducto);
                        comando.Parameters.AddWithValue("@nombre", platillo.Nombre);
                        comando.Parameters.AddWithValue("@precio", platillo.Precio);
                        comando.Parameters.AddWithValue("@id_categoria", platillo.IdCategoria ?? (object)DBNull.Value);
                        comando.Parameters.AddWithValue("@id_descuento", platillo.IdDescuento ?? (object)DBNull.Value);

                        conexion.Open();
                        return comando.ExecuteNonQuery() > 0;
                    }
                }
            }

            public bool Actualizar(Platillo platillo)
            {
                using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
                {
                    using (SqlCommand comando = new SqlCommand("ActualizarPlatillo", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@id_producto", platillo.IdProducto);
                        comando.Parameters.AddWithValue("@nombre", platillo.Nombre);
                        comando.Parameters.AddWithValue("@precio", platillo.Precio);
                        comando.Parameters.AddWithValue("@id_categoria", platillo.IdCategoria ?? (object)DBNull.Value);
                        comando.Parameters.AddWithValue("@id_descuento", platillo.IdDescuento ?? (object)DBNull.Value);

                        conexion.Open();
                        return comando.ExecuteNonQuery() > 0;
                    }
                }
            }

            public bool Eliminar(string idProducto)
            {
                using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
                {
                    using (SqlCommand comando = new SqlCommand("EliminarPlatillo", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@id_producto", idProducto);

                        conexion.Open();
                        return comando.ExecuteNonQuery() > 0;
                    }
                }
            }

            public List<Platillo> Buscar(string idProducto)
            {
                List<Platillo> lista = new List<Platillo>();
                using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
                {
                    using (SqlCommand comando = new SqlCommand("BuscarPlatillo", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@id_producto", idProducto);

                        conexion.Open();
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Platillo p = new Platillo();
                                p.IdProducto = reader["id_producto"]?.ToString() ?? string.Empty;
                                p.Nombre = reader["nombre"]?.ToString() ?? string.Empty;
                                p.Precio = reader["precio"] != DBNull.Value ? Convert.ToDecimal(reader["precio"]) : 0m;
                                p.IdCategoria = reader["id_categoria"]?.ToString() ?? string.Empty;
                                p.IdDescuento = reader["id_descuento"]?.ToString() ?? string.Empty;

                                lista.Add(p);
                            }
                        }
                    }
                }
                return lista;
            }
        }
}


      