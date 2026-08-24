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
        public bool Agregar(MenuEN menu)
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

        public bool Actualizar(MenuEN menu)
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

        public bool Eliminar(MenuEN pMenu)
        {
            int resultado = 0;
            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("dbo.EliminarMenu", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@IdPostre", (object)pMenu.IdPostre ?? DBNull.Value);
                    comando.Parameters.AddWithValue("@IdBebida", (object)pMenu.IdBebida ?? DBNull.Value);
                    comando.Parameters.AddWithValue("@IdProducto", (object)pMenu.IdProducto ?? DBNull.Value);
                    comando.Parameters.AddWithValue("@IdCategoria", (object)pMenu.IdCategoria ?? DBNull.Value);
                    comando.Parameters.AddWithValue("@IdPedido", pMenu.IdPedido?.Trim() ?? string.Empty);

                    conexion.Open();
                    resultado = comando.ExecuteNonQuery();
                }
            }
            return resultado > 0;
        }


        public List<MenuEN> Buscar(MenuEN pMenu)
        {
            List<MenuEN> lista = new List<MenuEN>();

            using SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion();
            using SqlCommand comando = new SqlCommand("dbo.BuscarMenu", conexion);
            //using SqlCommand comando = new SqlCommand("BuscarMenu", conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdPedido", (object)pMenu.IdPedido ?? DBNull.Value);
            comando.Parameters.AddWithValue("@IdCategoria", (object)pMenu.IdCategoria ?? DBNull.Value);
            comando.Parameters.AddWithValue("@IdPostre", (object)pMenu.IdPostre ?? DBNull.Value);
            comando.Parameters.AddWithValue("@IdProducto", (object)pMenu.IdProducto ?? DBNull.Value);
            comando.Parameters.AddWithValue("@IdBebida", (object)pMenu.IdBebida ?? DBNull.Value);

            conexion.Open();

            using SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                MenuEN menu = new MenuEN();

                // Validamos usando 'id_postre' en AMBOS lados
                menu.IdPostre = reader["id_postre"] != DBNull.Value ? reader["id_postre"].ToString() : null;
                menu.IdBebida = reader["id_bebida"] != DBNull.Value ? reader["id_bebida"].ToString() : null;
                menu.IdProducto = reader["id_producto"] != DBNull.Value ? reader["id_producto"].ToString() : null;
                menu.IdCategoria = reader["id_categoria"] != DBNull.Value ? reader["id_categoria"].ToString() : null;
                menu.IdPedido = reader["id_pedido"] != DBNull.Value ? reader["id_pedido"].ToString() : null;

                lista.Add(menu);
            }

            return lista;
        }
    }
}
