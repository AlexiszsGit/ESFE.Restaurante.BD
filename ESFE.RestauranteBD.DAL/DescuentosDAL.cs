using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using ESFE.RestauranteBD.EN;

namespace ESFE.RestauranteBD.DAL
{
    public class DescuentosDAL
    {
        public bool Insertar(Descuentos descuento)
        {
            using (SqlConnection conexion =
                (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando =
                    new SqlCommand("InsertarDescuento", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue(
                        "@IdDescuento",
                        descuento.IdDescuento);

                    comando.Parameters.AddWithValue(
                        "@Descripcion",
                        descuento.Nombre);

                    comando.Parameters.AddWithValue(
                        "@Porcentaje",
                        descuento.Porcentaje);

                    conexion.Open();

                    comando.ExecuteNonQuery();

                    return true;
                }
            }
        }


        public bool Actualizar(
            Descuentos descuento,
            string idAnterior)
        {
            using (SqlConnection conexion =
                (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando =
                    new SqlCommand("ActualizarDescuento", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue(
                        "@IdDescuentoAnterior",
                        idAnterior);

                    comando.Parameters.AddWithValue(
                        "@IdDescuentoNuevo",
                        descuento.IdDescuento);

                    comando.Parameters.AddWithValue(
                        "@Descripcion",
                        descuento.Nombre);

                    comando.Parameters.AddWithValue(
                        "@Porcentaje",
                        descuento.Porcentaje);

                    conexion.Open();

                    comando.ExecuteNonQuery();

                    return true;
                }
            }
        }


        public bool Eliminar(string idDescuento)
        {
            using (SqlConnection conexion =
                (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando =
                    new SqlCommand("EliminarDescuento", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue(
                        "@IdDescuento",
                        idDescuento);

                    conexion.Open();

                    comando.ExecuteNonQuery();

                    return true;
                }
            }
        }


        public List<Descuentos> Buscar(string texto)
        {
            List<Descuentos> lista =
                new List<Descuentos>();

            using (SqlConnection conexion =
                (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando =
                    new SqlCommand(
                        "BuscarDescuentoDescripcion",
                        conexion))
                {
                    comando.CommandType =
                        CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue(
                        "@Descripcion",
                        texto);

                    conexion.Open();

                    using (SqlDataReader reader =
                        comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Descuentos descuento =
                                new Descuentos();

                            descuento.IdDescuento =
                                reader["IdDescuento"]?.ToString() ?? "";

                            descuento.Nombre =
                                reader["Nombre"]?.ToString() ?? "";

                            descuento.Porcentaje =
                                Convert.ToDecimal(
                                    reader["Porcentaje"]);

                            lista.Add(descuento);
                        }
                    }
                }
            }

            return lista;
        }


        public List<Descuentos> BuscarPorNombre(string nombre)
        {
            return Buscar(nombre);
        }
    }
}