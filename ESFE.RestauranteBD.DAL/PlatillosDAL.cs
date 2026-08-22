using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using ESFE.RestauranteBD.EN;

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
                    comando.Parameters.AddWithValue("@id_categoria", string.IsNullOrWhiteSpace(platillo.IdCategoria) ? (object)DBNull.Value : platillo.IdCategoria);
                    comando.Parameters.AddWithValue("@id_descuento", string.IsNullOrWhiteSpace(platillo.IdDescuento) ? (object)DBNull.Value : platillo.IdDescuento);

                    conexion.Open();
                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Modificar(Platillo platillo)
        {
            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("ModificarPlatillo", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id_producto", platillo.IdProducto);
                    comando.Parameters.AddWithValue("@nombre", platillo.Nombre);
                    comando.Parameters.AddWithValue("@precio", platillo.Precio);
                    comando.Parameters.AddWithValue("@id_categoria", string.IsNullOrWhiteSpace(platillo.IdCategoria) ? (object)DBNull.Value : platillo.IdCategoria);
                    comando.Parameters.AddWithValue("@id_descuento", string.IsNullOrWhiteSpace(platillo.IdDescuento) ? (object)DBNull.Value : platillo.IdDescuento);

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

        public DataTable ObtenerPlatillos()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("ObtenerPlatillos", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    conexion.Open();
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        tabla.Load(reader);
                    }
                }
            }
            return tabla;
        }

        public bool Actualizar(Platillo platillo) => Modificar(platillo);

        public List<Platillo> Buscar(string idProducto = "")
        {
            List<Platillo> lista = new List<Platillo>();
            DataTable tabla = ObtenerPlatillos();
            foreach (DataRow fila in tabla.Rows)
            {
                lista.Add(new Platillo
                {
                    IdProducto = fila["id_producto"].ToString(),
                    Nombre = fila["nombre"].ToString(),
                    Precio = Convert.ToDecimal(fila["precio"]),
                    IdCategoria = fila["id_categoria"] != DBNull.Value ? fila["id_categoria"].ToString() : null,
                    IdDescuento = fila["id_descuento"] != DBNull.Value ? fila["id_descuento"].ToString() : null
                });
            }
            return lista;
        }

        public List<Platillo> Buscar(Platillo platillo) => Buscar(platillo?.IdProducto ?? "");
    }
}