using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESFE.RestauranteBD.EN;
using Microsoft.Data.SqlClient;
using System.Data;

namespace ESFE.RestauranteBD.DAL
{
    public class CategoriaDAL
    {
        public bool Insertar(Categoria categoria)
        {
            using SqlConnection conexion =
                (SqlConnection)DBComun.ObtenerConexion();

            using SqlCommand comando =
                new SqlCommand("InsertarCategoria", conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@id_categoria", categoria.IdCategoria);
            comando.Parameters.AddWithValue("@nombre", categoria.Nombre);

            conexion.Open();

            comando.ExecuteNonQuery();

            return true;
        }

        public bool Actualizar(Categoria categoria)
        {
            using SqlConnection conexion =
                (SqlConnection)DBComun.ObtenerConexion();

            using SqlCommand comando =
                new SqlCommand("ActualizarCategoria", conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@id_categoria", categoria.IdCategoria);
            comando.Parameters.AddWithValue("@nombre", categoria.Nombre);

            conexion.Open();

            comando.ExecuteNonQuery();

            return true;
        }

        public bool Eliminar(string idCategoria)
        {
            using SqlConnection conexion =
                (SqlConnection)DBComun.ObtenerConexion();

            using SqlCommand comando =
                new SqlCommand("EliminarCategoria", conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@id_categoria", idCategoria);

            conexion.Open();

            return comando.ExecuteNonQuery() > 0;
        }

        public List<Categoria> Buscar(string nombre)
        {
            List<Categoria> lista = new List<Categoria>();

            using SqlConnection conexion =
                (SqlConnection)DBComun.ObtenerConexion();

            using SqlCommand comando =
                new SqlCommand("BuscarCategoriaNombre", conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@nombre", nombre);

            conexion.Open();

            using SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Categoria categoria = new Categoria();

                categoria.IdCategoria =
                    Convert.ToString(reader["id_categoria"]) ?? string.Empty;

                categoria.Nombre =
                    Convert.ToString(reader["nombre"]) ?? string.Empty;

                lista.Add(categoria);
            }

            return lista;
        }

        public List<Categoria> BuscarPorNombre(string nombre)
        {
            List<Categoria> lista = new List<Categoria>();

            using SqlConnection conexion =
                (SqlConnection)DBComun.ObtenerConexion();

            using SqlCommand comando =
                new SqlCommand("BuscarCategoriaNombre", conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@nombre", nombre);

            conexion.Open();

            using SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Categoria categoria = new Categoria();

                categoria.IdCategoria =
                    Convert.ToString(reader["id_categoria"]) ?? string.Empty;

                categoria.Nombre =
                    Convert.ToString(reader["nombre"]) ?? string.Empty;

                lista.Add(categoria);
            }

            return lista;
        }
    }
}