using ESFE.RestauranteBD.EN;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ESFE.RestauranteBD.DAL
{
    public class MetodoPago
    {
        public bool Insertar(MetodoDePago metodo)
        {
            using SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion();
            using SqlCommand comando = new SqlCommand("InsertarMetodoDePago", conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@Nombre", metodo.Nombre);

            conexion.Open();
            comando.ExecuteNonQuery();

            return true;
        }

        public bool Actualizar(MetodoDePago metodo)
        {
            using SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion();
            using SqlCommand comando = new SqlCommand("ActualizarMetodoDePago", conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdMetodoDePago", metodo.IdMetodoDePago);
            comando.Parameters.AddWithValue("@Nombre", metodo.Nombre);

            conexion.Open();
            comando.ExecuteNonQuery();

            return true;
        }

        public bool Eliminar(string idMetodoDePago)
        {
            using SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion();
            using SqlCommand comando = new SqlCommand("EliminarMetodoDePago", conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdMetodoDePago", idMetodoDePago);

            conexion.Open();

            return comando.ExecuteNonQuery() > 0;
        }

        public List<MetodoDePago> Buscar(string nombre)
        {
            List<MetodoDePago> lista = new List<MetodoDePago>();

            using SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion();
            using SqlCommand comando = new SqlCommand("BuscarMetodoDePagoNombre", conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@Nombre", nombre);

            conexion.Open();

            using SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                MetodoDePago metodo = new MetodoDePago();

                metodo.IdMetodoDePago = reader["IdMetodoDePago"]?.ToString();
                metodo.Nombre = reader["Nombre"]?.ToString();

                lista.Add(metodo);
            }

            return lista;
        }
    }
}
