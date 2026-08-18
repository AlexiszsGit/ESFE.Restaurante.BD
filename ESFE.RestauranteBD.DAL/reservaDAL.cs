using ESFE.RestauranteBD.EN;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ESFE.RestauranteBD.DAL
{
    public class ReservaDAL
    {
        public bool Insertar(Reserva reserva)
        {
            using SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion();
            using SqlCommand comando = new SqlCommand("InsertarReserva", conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@fechaReserva", reserva.fechaReserva);
            comando.Parameters.AddWithValue("@Hora", reserva.Hora);
            comando.Parameters.AddWithValue("@Personas", reserva.Personas);
            comando.Parameters.AddWithValue("@IdCliente", reserva.IdCliente);
            comando.Parameters.AddWithValue("@IdMesa", reserva.IdMesa);

            conexion.Open();
            comando.ExecuteNonQuery();

            return true;
        }

        public bool Actualizar(Reserva reserva)
        {
            using SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion();
            using SqlCommand comando = new SqlCommand("ActualizarReserva", conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdReserva", reserva.IdReserva);
            comando.Parameters.AddWithValue("@fechaReserva", reserva.fechaReserva);
            comando.Parameters.AddWithValue("@Hora", reserva.Hora);
            comando.Parameters.AddWithValue("@Personas", reserva.Personas);
            comando.Parameters.AddWithValue("@IdCliente", reserva.IdCliente);
            comando.Parameters.AddWithValue("@IdMesa", reserva.IdMesa);

            conexion.Open();
            comando.ExecuteNonQuery();

            return true;
        }

        public bool Eliminar(string idReserva)
        {
            using SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion();
            using SqlCommand comando = new SqlCommand("EliminarReserva", conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdReserva", idReserva);

            conexion.Open();

            return comando.ExecuteNonQuery() > 0;
        }

        public List<Reserva> Buscar(string idReserva)
        {
            List<Reserva> lista = new List<Reserva>();

            using SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion();
            using SqlCommand comando = new SqlCommand("BuscarReserva", conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdReserva", idReserva);

            conexion.Open();

            using SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Reserva reserva = new Reserva();

                reserva.IdReserva = reader["IdReserva"]?.ToString();
                reserva.fechaReserva = Convert.ToDateTime(reader["fechaReserva"]);
                reserva.Hora = reader["Hora"]?.ToString();
                reserva.Personas = Convert.ToInt32(reader["Personas"]);
                reserva.IdCliente = reader["IdCliente"]?.ToString();
                reserva.IdMesa = reader["IdMesa"]?.ToString();

                lista.Add(reserva);
            }

            return lista;
        }
    }
}
