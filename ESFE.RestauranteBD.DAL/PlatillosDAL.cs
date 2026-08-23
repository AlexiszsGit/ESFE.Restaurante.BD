using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using ESFE.RestauranteBD.EN;

namespace ESFE.RestauranteBD.DAL
{
    public class PlatillosDAL
    {
        // =========================
        // INSERTAR
        // =========================
        public bool Insertar(Platillo platillo)
        {
            using (SqlConnection conexion =
                (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando =
                    new SqlCommand("InsertarPlatillo", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue(
                        "@id_producto",
                        platillo.IdProducto);

                    comando.Parameters.AddWithValue(
                        "@nombre",
                        platillo.Nombre);

                    comando.Parameters.AddWithValue(
                        "@precio",
                        platillo.Precio);

                    comando.Parameters.AddWithValue(
                        "@id_categoria",
                        string.IsNullOrWhiteSpace(platillo.IdCategoria)
                            ? (object)DBNull.Value
                            : platillo.IdCategoria);

                    comando.Parameters.AddWithValue(
                        "@id_descuento",
                        string.IsNullOrWhiteSpace(platillo.IdDescuento)
                            ? (object)DBNull.Value
                            : platillo.IdDescuento);

                    conexion.Open();

                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }

        // =========================
        // MODIFICAR
        // =========================
        public bool Modificar(Platillo platillo)
        {
            using (SqlConnection conexion =
                (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando =
                    new SqlCommand("ModificarPlatillo", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue(
                        "@id_producto",
                        platillo.IdProducto);

                    comando.Parameters.AddWithValue(
                        "@nombre",
                        platillo.Nombre);

                    comando.Parameters.AddWithValue(
                        "@precio",
                        platillo.Precio);

                    comando.Parameters.AddWithValue(
                        "@id_categoria",
                        string.IsNullOrWhiteSpace(platillo.IdCategoria)
                            ? (object)DBNull.Value
                            : platillo.IdCategoria);

                    comando.Parameters.AddWithValue(
                        "@id_descuento",
                        string.IsNullOrWhiteSpace(platillo.IdDescuento)
                            ? (object)DBNull.Value
                            : platillo.IdDescuento);

                    conexion.Open();

                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }

        // =========================
        // ACTUALIZAR
        // =========================
        public bool Actualizar(Platillo platillo)
        {
            return Modificar(platillo);
        }

        // =========================
        // ELIMINAR
        // =========================
        public bool Eliminar(string idProducto)
        {
            using (SqlConnection conexion =
                (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando =
                    new SqlCommand("EliminarPlatillo", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue(
                        "@id_producto",
                        idProducto);

                    conexion.Open();

                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }

        // =========================
        // OBTENER TODOS LOS PLATILLOS
        // =========================
        public DataTable ObtenerPlatillos()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conexion =
                (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando =
                    new SqlCommand("ObtenerPlatillos", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    conexion.Open();

                    using (SqlDataReader reader =
                        comando.ExecuteReader())
                    {
                        tabla.Load(reader);
                    }
                }
            }

            return tabla;
        }

        // =========================
        // BUSCAR PLATILLOS
        // =========================
        public DataTable BuscarTabla(string busqueda)
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conexion =
                (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando =
                    new SqlCommand("BuscarPlatillo", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue(
                        "@busqueda",
                        string.IsNullOrWhiteSpace(busqueda)
                            ? ""
                            : busqueda.Trim());

                    conexion.Open();

                    using (SqlDataReader reader =
                        comando.ExecuteReader())
                    {
                        tabla.Load(reader);
                    }
                }
            }

            return tabla;
        }

        // =========================
        // BUSCAR COMO LISTA
        // =========================
        public List<Platillo> Buscar(string busqueda = "")
        {
            List<Platillo> lista = new List<Platillo>();

            DataTable tabla;

            if (string.IsNullOrWhiteSpace(busqueda))
            {
                tabla = ObtenerPlatillos();
            }
            else
            {
                tabla = BuscarTabla(busqueda);
            }

            foreach (DataRow fila in tabla.Rows)
            {
                Platillo platillo = new Platillo
                {
                    IdProducto =
                        fila["id_producto"]?.ToString() ?? "",

                    Nombre =
                        fila["nombre"]?.ToString() ?? "",

                    Precio =
                        fila["precio"] != DBNull.Value
                            ? Convert.ToDecimal(fila["precio"])
                            : 0m,

                    IdCategoria =
                        fila["id_categoria"] != DBNull.Value
                            ? fila["id_categoria"]?.ToString()
                            : null,

                    IdDescuento =
                        fila["id_descuento"] != DBNull.Value
                            ? fila["id_descuento"]?.ToString()
                            : null
                };

                lista.Add(platillo);
            }

            return lista;
        }

        // =========================
        // OBTENER CATEGORÍAS
        // =========================
        public DataTable ObtenerCategorias()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conexion =
                (SqlConnection)DBComun.ObtenerConexion())
            {
                string sql = @"
                    SELECT
                        id_categoria,
                        nombre
                    FROM categoria
                    ORDER BY nombre";

                using (SqlCommand comando =
                    new SqlCommand(sql, conexion))
                {
                    comando.CommandType = CommandType.Text;

                    conexion.Open();

                    using (SqlDataReader reader =
                        comando.ExecuteReader())
                    {
                        tabla.Load(reader);
                    }
                }
            }

            return tabla;
        }

        // =========================
        // OBTENER DESCUENTOS
        // =========================
        public DataTable ObtenerDescuentos()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conexion =
                (SqlConnection)DBComun.ObtenerConexion())
            {
                string sql = @"
                    SELECT
                        id_descuento,
                        descripcion
                    FROM descuento
                    ORDER BY id_descuento";

                using (SqlCommand comando =
                    new SqlCommand(sql, conexion))
                {
                    comando.CommandType = CommandType.Text;

                    conexion.Open();

                    using (SqlDataReader reader =
                        comando.ExecuteReader())
                    {
                        tabla.Load(reader);
                    }
                }
            }

            return tabla;
        }
    }
}