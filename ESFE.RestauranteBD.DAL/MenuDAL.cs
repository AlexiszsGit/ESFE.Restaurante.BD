using ESFE.RestauranteBD.EN;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace ESFE.RestauranteBD.DAL
{
    public class MenuDAL
    {
        public bool Agregar(MenuEN menu)
        {
            using SqlConnection conexion =
                (SqlConnection)DBComun.ObtenerConexion();

            using SqlCommand comando =
                new SqlCommand("InsertarMenu", conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue(
                "@IdPostre",
                (object)menu.IdPostre ?? DBNull.Value);

            comando.Parameters.AddWithValue(
                "@IdBebida",
                (object)menu.IdBebida ?? DBNull.Value);

            comando.Parameters.AddWithValue(
                "@IdProducto",
                (object)menu.IdProducto ?? DBNull.Value);

            comando.Parameters.AddWithValue(
                "@IdCategoria",
                (object)menu.IdCategoria ?? DBNull.Value);

            comando.Parameters.AddWithValue(
                "@IdPedido",
                (object)menu.IdPedido ?? DBNull.Value);

            conexion.Open();

            comando.ExecuteNonQuery();

            return true;
        }

        public bool Actualizar(MenuEN menu)
        {
            using SqlConnection conexion =
                (SqlConnection)DBComun.ObtenerConexion();

            using SqlCommand comando =
                new SqlCommand("ActualizarMenu", conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue(
                "@IdPostre",
                (object)menu.IdPostre ?? DBNull.Value);

            comando.Parameters.AddWithValue(
                "@IdBebida",
                (object)menu.IdBebida ?? DBNull.Value);

            comando.Parameters.AddWithValue(
                "@IdProducto",
                (object)menu.IdProducto ?? DBNull.Value);

            comando.Parameters.AddWithValue(
                "@IdCategoria",
                (object)menu.IdCategoria ?? DBNull.Value);

            comando.Parameters.AddWithValue(
                "@IdPedido",
                (object)menu.IdPedido ?? DBNull.Value);

            conexion.Open();

            comando.ExecuteNonQuery();

            return true;
        }

        public bool Eliminar(MenuEN menu)
        {
            using SqlConnection conexion =
                (SqlConnection)DBComun.ObtenerConexion();

            using SqlCommand comando =
                new SqlCommand("dbo.EliminarMenu", conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue(
                "@IdPostre",
                (object)menu.IdPostre ?? DBNull.Value);

            comando.Parameters.AddWithValue(
                "@IdBebida",
                (object)menu.IdBebida ?? DBNull.Value);

            comando.Parameters.AddWithValue(
                "@IdProducto",
                (object)menu.IdProducto ?? DBNull.Value);

            comando.Parameters.AddWithValue(
                "@IdCategoria",
                (object)menu.IdCategoria ?? DBNull.Value);

            comando.Parameters.AddWithValue(
                "@IdPedido",
                (object)menu.IdPedido ?? DBNull.Value);

            conexion.Open();

            return comando.ExecuteNonQuery() > 0;
        }

        public List<MenuEN> Buscar(MenuEN menu)
        {
            List<MenuEN> lista = new List<MenuEN>();

            using SqlConnection conexion =
                (SqlConnection)DBComun.ObtenerConexion();

            using SqlCommand comando =
                new SqlCommand("dbo.BuscarMenu", conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue(
                "@IdPedido",
                (object)menu.IdPedido ?? DBNull.Value);

            conexion.Open();

            using SqlDataReader reader =
                comando.ExecuteReader();

            while (reader.Read())
            {
                MenuEN item = new MenuEN();

                item.IdPostre =
                    reader["id_postre"] != DBNull.Value
                    ? reader["id_postre"].ToString()
                    : null;

                item.IdBebida =
                    reader["id_bebida"] != DBNull.Value
                    ? reader["id_bebida"].ToString()
                    : null;

                item.IdProducto =
                    reader["id_producto"] != DBNull.Value
                    ? reader["id_producto"].ToString()
                    : null;

                item.IdCategoria =
                    reader["id_categoria"] != DBNull.Value
                    ? reader["id_categoria"].ToString()
                    : null;

                item.IdPedido =
                    reader["id_pedido"] != DBNull.Value
                    ? reader["id_pedido"].ToString()
                    : null;

                lista.Add(item);
            }

            return lista;
        }

        public List<MenuEN> ObtenerTodos()
        {
            List<MenuEN> lista = new List<MenuEN>();

            using SqlConnection conexion =
                (SqlConnection)DBComun.ObtenerConexion();

            using SqlCommand comando =
                new SqlCommand(
                    "SELECT id_postre, id_bebida, id_producto, id_categoria, id_pedido " +
                    "FROM menu ORDER BY id_pedido",
                    conexion);

            comando.CommandType = CommandType.Text;

            conexion.Open();

            using SqlDataReader reader =
                comando.ExecuteReader();

            while (reader.Read())
            {
                MenuEN item = new MenuEN();

                item.IdPostre =
                    reader["id_postre"] != DBNull.Value
                    ? reader["id_postre"].ToString()
                    : null;

                item.IdBebida =
                    reader["id_bebida"] != DBNull.Value
                    ? reader["id_bebida"].ToString()
                    : null;

                item.IdProducto =
                    reader["id_producto"] != DBNull.Value
                    ? reader["id_producto"].ToString()
                    : null;

                item.IdCategoria =
                    reader["id_categoria"] != DBNull.Value
                    ? reader["id_categoria"].ToString()
                    : null;

                item.IdPedido =
                    reader["id_pedido"] != DBNull.Value
                    ? reader["id_pedido"].ToString()
                    : null;

                lista.Add(item);
            }

            return lista;
        }

        public List<Pedido> ObtenerPedidos()
        {
            List<Pedido> lista = new List<Pedido>();

            using SqlConnection conexion =
                (SqlConnection)DBComun.ObtenerConexion();

            using SqlCommand comando =
                new SqlCommand(
                    "SELECT id_pedido, fecha, id_cliente, id_empleado, id_mesa, id_estado " +
                    "FROM pedido ORDER BY id_pedido",
                    conexion);

            comando.CommandType = CommandType.Text;

            conexion.Open();

            using SqlDataReader reader =
                comando.ExecuteReader();

            while (reader.Read())
            {
                Pedido pedido = new Pedido();

                pedido.IdPedido =
                    reader["id_pedido"]?.ToString() ?? string.Empty;

                if (reader["fecha"] != DBNull.Value)
                    pedido.fecha =
                        Convert.ToDateTime(reader["fecha"]);

                pedido.IDCliente =
                    reader["id_cliente"]?.ToString() ?? string.Empty;

                pedido.IdEmpleado =
                    reader["id_empleado"]?.ToString() ?? string.Empty;

                pedido.IdMesa =
                    reader["id_mesa"]?.ToString() ?? string.Empty;

                pedido.IdEstado =
                    reader["id_estado"]?.ToString() ?? string.Empty;

                lista.Add(pedido);
            }

            return lista;
        }

        public List<Categoria> ObtenerCategorias()
        {
            List<Categoria> lista = new List<Categoria>();

            using SqlConnection conexion =
                (SqlConnection)DBComun.ObtenerConexion();

            using SqlCommand comando =
                new SqlCommand(
                    "SELECT id_categoria, nombre " +
                    "FROM categoria ORDER BY nombre",
                    conexion);

            conexion.Open();

            using SqlDataReader reader =
                comando.ExecuteReader();

            while (reader.Read())
            {
                Categoria categoria = new Categoria();

                categoria.IdCategoria =
                    reader["id_categoria"]?.ToString()
                    ?? string.Empty;

                categoria.Nombre =
                    reader["nombre"]?.ToString()
                    ?? string.Empty;

                lista.Add(categoria);
            }

            return lista;
        }

        public List<Postre> ObtenerPostres()
        {
            List<Postre> lista = new List<Postre>();

            using SqlConnection conexion =
                (SqlConnection)DBComun.ObtenerConexion();

            using SqlCommand comando =
                new SqlCommand(
                    "SELECT id_postre, nombre, precio " +
                    "FROM postres ORDER BY nombre",
                    conexion);

            conexion.Open();

            using SqlDataReader reader =
                comando.ExecuteReader();

            while (reader.Read())
            {
                Postre postre = new Postre();

                postre.IdPostre =
                    reader["id_postre"]?.ToString()
                    ?? string.Empty;

                postre.Nombre =
                    reader["nombre"]?.ToString()
                    ?? string.Empty;

                postre.Precio =
                    reader["precio"] != DBNull.Value
                    ? Convert.ToDecimal(reader["precio"])
                    : 0m;

                lista.Add(postre);
            }

            return lista;
        }

        public List<Bebida> ObtenerBebidas()
        {
            List<Bebida> lista = new List<Bebida>();

            using SqlConnection conexion =
                (SqlConnection)DBComun.ObtenerConexion();

            using SqlCommand comando =
                new SqlCommand(
                    "SELECT id_bebida, nombre, precio " +
                    "FROM bebidas ORDER BY nombre",
                    conexion);

            conexion.Open();

            using SqlDataReader reader =
                comando.ExecuteReader();

            while (reader.Read())
            {
                Bebida bebida = new Bebida();

                bebida.IdBebida =
                    reader["id_bebida"]?.ToString()
                    ?? string.Empty;

                bebida.Nombre =
                    reader["nombre"]?.ToString()
                    ?? string.Empty;

                bebida.Precio =
                    reader["precio"] != DBNull.Value
                    ? Convert.ToDecimal(reader["precio"])
                    : 0m;

                lista.Add(bebida);
            }

            return lista;
        }
    }
}