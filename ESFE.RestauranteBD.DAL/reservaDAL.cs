using ESFE.RestauranteBD.EN;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace ESFE.RestauranteBD.DAL
{
    public class ReservaDAL
    {
        // =========================================================
        // AGREGAR
        // =========================================================

        public bool Insertar(Reserva reserva)
        {
            using SqlConnection conexion =
                (SqlConnection)DBComun.ObtenerConexion();

            using SqlCommand comando =
                new SqlCommand(
                    "sp_AgregarReserva",
                    conexion);

            comando.CommandType =
                CommandType.StoredProcedure;

            comando.Parameters.AddWithValue(
                "@id_reserva",
                reserva.IdReserva);

            comando.Parameters.AddWithValue(
                "@fecha",
                reserva.fechaReserva);

            comando.Parameters.AddWithValue(
                "@hora",
                reserva.Hora);

            comando.Parameters.AddWithValue(
                "@personas",
                reserva.Personas);

            comando.Parameters.AddWithValue(
                "@id_cliente",
                reserva.IdCliente);

            comando.Parameters.AddWithValue(
                "@id_mesa",
                reserva.IdMesa);

            conexion.Open();

            return comando.ExecuteNonQuery() > 0;
        }


        // =========================================================
        // ACTUALIZAR
        // =========================================================

        public bool Actualizar(Reserva reserva)
        {
            using SqlConnection conexion =
                (SqlConnection)DBComun.ObtenerConexion();

            using SqlCommand comando =
                new SqlCommand(
                    "sp_ActualizarReserva",
                    conexion);

            comando.CommandType =
                CommandType.StoredProcedure;

            comando.Parameters.AddWithValue(
                "@id_reserva",
                reserva.IdReserva);

            comando.Parameters.AddWithValue(
                "@fecha",
                reserva.fechaReserva);

            comando.Parameters.AddWithValue(
                "@hora",
                reserva.Hora);

            comando.Parameters.AddWithValue(
                "@personas",
                reserva.Personas);

            comando.Parameters.AddWithValue(
                "@id_cliente",
                reserva.IdCliente);

            comando.Parameters.AddWithValue(
                "@id_mesa",
                reserva.IdMesa);

            conexion.Open();

            return comando.ExecuteNonQuery() > 0;
        }


        // =========================================================
        // ELIMINAR
        // =========================================================

        public bool Eliminar(string idReserva)
        {
            using SqlConnection conexion =
                (SqlConnection)DBComun.ObtenerConexion();

            using SqlCommand comando =
                new SqlCommand(
                    "sp_EliminarReserva",
                    conexion);

            comando.CommandType =
                CommandType.StoredProcedure;

            comando.Parameters.AddWithValue(
                "@id_reserva",
                idReserva);

            conexion.Open();

            return comando.ExecuteNonQuery() > 0;
        }


        // =========================================================
        // MOSTRAR TODAS
        // =========================================================

        public List<Reserva> Buscar(string idReserva)
        {
            List<Reserva> lista =
                new List<Reserva>();

            using SqlConnection conexion =
                (SqlConnection)DBComun.ObtenerConexion();

            SqlCommand comando;

            // Si no se proporciona ID,
            // mostramos todas las reservas.
            if (string.IsNullOrWhiteSpace(idReserva))
            {
                comando = new SqlCommand(
                    "sp_MostrarReservas",
                    conexion);
            }
            else
            {
                comando = new SqlCommand(
                    "sp_BuscarReserva",
                    conexion);

                comando.Parameters.AddWithValue(
                    "@id_reserva",
                    idReserva);
            }

            using (comando)
            {
                comando.CommandType =
                    CommandType.StoredProcedure;

                conexion.Open();

                using SqlDataReader reader =
                    comando.ExecuteReader();

                while (reader.Read())
                {
                    Reserva reserva =
                        new Reserva();

                    reserva.IdReserva =
                        reader["id_reserva"]?
                        .ToString() ?? "";

                    reserva.fechaReserva =
                        Convert.ToDateTime(
                            reader["fecha"]);

                    reserva.Hora =
                        reader["hora"]?
                        .ToString() ?? "";

                    reserva.Personas =
                        Convert.ToInt32(
                            reader["personas"]);

                    reserva.IdCliente =
                        reader["id_cliente"]?
                        .ToString() ?? "";

                    reserva.IdMesa =
                        reader["id_mesa"]?
                        .ToString() ?? "";

                    lista.Add(reserva);
                }
            }

            return lista;
        }
    }
}