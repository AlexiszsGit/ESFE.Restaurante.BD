using ESFE.RestauranteBD.EN;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ESFE.RestauranteBD.DAL
{
    public class MenuDAL
    {
        public bool Insertar(Menu menu)
        {
            using SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion();
            using SqlCommand comando = new SqlCommand("InsertarMenu", conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdPostre", (object)menu.IdPostre ?? DBNull.Value);
            comando.Parameters.AddWithValue("@IdBebida", (object)menu.IdBebida ?? DBNull.Value);
            comando.Parameters.AddWithValue("@IdProducto", (object)menu.IdProducto ?? DBNull.Value);
            comando.Parameters.AddWithValue("@IdCategoria", (object)menu.IdCategoria ?? DBNull.Value);
            comando.Parameters.AddWithValue("@IdPedido", (object)menu.IdPedido ?? DBNull.Value);

            conexion.Open();
            comando.ExecuteNonQuery();

            return true;
        }

        public bool Actualizar(Menu menu)
        {
            using SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion();
            using SqlCommand comando = new SqlCommand("ActualizarMenu", conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdPostre", (object)menu.IdPostre ?? DBNull.Value);
            comando.Parameters.AddWithValue("@IdBebida", (object)menu.IdBebida ?? DBNull.Value);
            comando.Parameters.AddWithValue("@IdProducto", (object)menu.IdProducto ?? DBNull.Value);
            comando.Parameters.AddWithValue("@IdCategoria", (object)menu.IdCategoria ?? DBNull.Value);
            comando.Parameters.AddWithValue("@IdPedido", (object)menu.IdPedido ?? DBNull.Value);

            conexion.Open();
            comando.ExecuteNonQuery();

            return true;
        }

        public bool Eliminar(string idPedido)
        {
            using SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion();
            using SqlCommand comando = new SqlCommand("EliminarMenu", conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdPedido", idPedido);

            conexion.Open();

            return comando.ExecuteNonQuery() > 0;
        }

        public List<Menu> Buscar(string idPedido)
        {
            List<Menu> lista = new List<Menu>();

            using SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion();
            using SqlCommand comando = new SqlCommand("BuscarMenu", conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdPedido", idPedido);

            conexion.Open();

            using SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Menu menu = new Menu();

                menu.IdPostre = reader["IdPostre"].ToString();
                menu.IdBebida = reader["IdBebida"]?.ToString();
                menu.IdProducto = reader["IdProducto"]?.ToString();
                menu.IdCategoria = reader["IdCategoria"]?.ToString();
                menu.IdPedido = reader["IdPedido"]?.ToString();

                lista.Add(menu);
            }

            return lista;
        }
    }
}
