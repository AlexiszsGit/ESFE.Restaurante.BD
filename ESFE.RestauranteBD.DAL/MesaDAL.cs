using System;
using System.Collections.Generic;
using System.Data;
using ESFE.RestauranteBD.EN;
using Microsoft.Data.SqlClient;

namespace ESFE.RestauranteBD.DAL
{
    public class MesaDAL
    {
        // =========================================================
        // INSERTAR
        // =========================================================

        public bool Insertar(Mesa mesa)
        {
            using (SqlConnection conexion =
                   (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando =
                       new SqlCommand("InsertarMesa", conexion))
                {
                    comando.CommandType =
                        CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue(
                        "@id_mesa",
                        mesa.IdMesa.Trim());

                    comando.Parameters.AddWithValue(
                        "@capacidad",
                        mesa.Capacidad);

                    comando.Parameters.AddWithValue(
                        "@disponible",
                        ConvertirDisponible(mesa.Disponible));

                    conexion.Open();

                    comando.ExecuteNonQuery();

                    return true;
                }
            }
        }

        // =========================================================
        // MODIFICAR
        // =========================================================

        public bool Modificar(Mesa mesa)
        {
            using (SqlConnection conexion =
                   (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando =
                       new SqlCommand("ModificarMesa", conexion))
                {
                    comando.CommandType =
                        CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue(
                        "@id_mesa",
                        mesa.IdMesa.Trim());

                    comando.Parameters.AddWithValue(
                        "@capacidad",
                        mesa.Capacidad);

                    comando.Parameters.AddWithValue(
                        "@disponible",
                        ConvertirDisponible(mesa.Disponible));

                    conexion.Open();

                    // Ejecutamos el procedimiento.
                    // No usamos el valor de ExecuteNonQuery()
                    // porque puede devolver -1 cuando el procedimiento
                    // tiene SET NOCOUNT ON.
                    comando.ExecuteNonQuery();

                    return true;
                }
            }
        }

        // =========================================================
        // ACTUALIZAR
        // =========================================================

        public bool Actualizar(Mesa mesa)
        {
            using (SqlConnection conexion =
                   (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando =
                       new SqlCommand("ActualizarMesa", conexion))
                {
                    comando.CommandType =
                        CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue(
                        "@id_mesa",
                        mesa.IdMesa.Trim());

                    comando.Parameters.AddWithValue(
                        "@capacidad",
                        mesa.Capacidad);

                    comando.Parameters.AddWithValue(
                        "@disponible",
                        ConvertirDisponible(mesa.Disponible));

                    conexion.Open();

                    comando.ExecuteNonQuery();

                    return true;
                }
            }
        }

        // =========================================================
        // ELIMINAR
        // =========================================================

        public bool Eliminar(string idMesa)
        {
            using (SqlConnection conexion =
                   (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando =
                       new SqlCommand("EliminarMesa", conexion))
                {
                    comando.CommandType =
                        CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue(
                        "@id_mesa",
                        idMesa.Trim());

                    conexion.Open();

                    int filas =
                        comando.ExecuteNonQuery();

                    return filas > 0;
                }
            }
        }

        // =========================================================
        // BUSCAR
        // =========================================================

        public List<Mesa> Buscar(string idMesa)
        {
            List<Mesa> lista =
                new List<Mesa>();

            using (SqlConnection conexion =
                   (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando =
                       new SqlCommand("BuscarMesa", conexion))
                {
                    comando.CommandType =
                        CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue(
                        "@Id_Mesa",
                        idMesa.Trim());

                    conexion.Open();

                    using (SqlDataReader reader =
                           comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Mesa mesa =
                                new Mesa();

                            mesa.IdMesa =
                                reader["Id_Mesa"] != DBNull.Value
                                    ? reader["Id_Mesa"].ToString()
                                    : string.Empty;

                            mesa.Capacidad =
                                reader["Capacidad"] != DBNull.Value
                                    ? Convert.ToInt32(
                                        reader["Capacidad"])
                                    : 0;

                            mesa.Disponible =
                                reader["Disponible"] != DBNull.Value
                                    ? reader["Disponible"].ToString()
                                    : string.Empty;

                            lista.Add(mesa);
                        }
                    }
                }
            }

            return lista;
        }

        // =========================================================
        // OBTENER TODAS LAS MESAS
        // =========================================================

        public List<Mesa> ObtenerMesas()
        {
            List<Mesa> lista =
                new List<Mesa>();

            using (SqlConnection conexion =
                   (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando =
                       new SqlCommand("ObtenerMesas", conexion))
                {
                    comando.CommandType =
                        CommandType.StoredProcedure;

                    conexion.Open();

                    using (SqlDataReader reader =
                           comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Mesa mesa =
                                new Mesa();

                            mesa.IdMesa =
                                reader["id_mesa"] != DBNull.Value
                                    ? reader["id_mesa"].ToString()
                                    : string.Empty;

                            mesa.Capacidad =
                                reader["capacidad"] != DBNull.Value
                                    ? Convert.ToInt32(
                                        reader["capacidad"])
                                    : 0;

                            mesa.Disponible =
                                reader["disponible"] != DBNull.Value
                                    ? reader["disponible"].ToString()
                                    : string.Empty;

                            lista.Add(mesa);
                        }
                    }
                }
            }

            return lista;
        }

        // =========================================================
        // CONVERTIR ESTADO
        // =========================================================

        private string ConvertirDisponible(
            string disponible)
        {
            if (string.IsNullOrWhiteSpace(disponible))
                return "NO";

            string estado =
                disponible.Trim().ToUpper();

            if (estado == "SI" ||
                estado == "LIBRE" ||
                estado == "DISPONIBLE")
            {
                return "SI";
            }

            return "NO";
        }
    }
}