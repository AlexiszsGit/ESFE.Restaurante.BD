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
    public class BebidaDAL
    {
        public bool Insertar(Bebida bebida)
        {
            using SqlConnection conexion =
                (SqlConnection)DBComun.ObtenerConexion();

            using SqlCommand comando =
                new SqlCommand("InsertarBebida", conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@id_bebida", bebida.IdBebida);
            comando.Parameters.AddWithValue("@nombre", bebida.Nombre);
            comando.Parameters.AddWithValue("@precio", bebida.Precio);

            conexion.Open();

            comando.ExecuteNonQuery();

            return true;
        }

        public bool Actualizar(Bebida bebida)
        {
            using SqlConnection conexion =
                (SqlConnection)DBComun.ObtenerConexion();

            using SqlCommand comando =
                new SqlCommand("ActualizarBebida", conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@id_bebida", bebida.IdBebida);
            comando.Parameters.AddWithValue("@nombre", bebida.Nombre);
            comando.Parameters.AddWithValue("@precio", bebida.Precio);

            conexion.Open();

            comando.ExecuteNonQuery();

            return true;
        }

        public bool Eliminar(string idBebida)
        {
            using SqlConnection conexion =
                (SqlConnection)DBComun.ObtenerConexion();

            using SqlCommand comando =
                new SqlCommand("EliminarBebida", conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@id_bebida", idBebida);

            conexion.Open();

            return comando.ExecuteNonQuery() > 0;
        }

        public List<Bebida> Buscar(string nombre)
        {
            List<Bebida> lista = new List<Bebida>();

            using SqlConnection conexion =
                (SqlConnection)DBComun.ObtenerConexion();

            using SqlCommand comando =
                new SqlCommand("BuscarBebidaNombre", conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@nombre", nombre);

            conexion.Open();

            using SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Bebida bebida = new Bebida();

                bebida.IdBebida =
                    Convert.ToString(reader["id_bebida"]) ?? string.Empty;

                bebida.Nombre =
                    Convert.ToString(reader["nombre"]) ?? string.Empty;

                bebida.Precio =
                    Convert.ToDecimal(reader["precio"]);

                lista.Add(bebida);
            }

            return lista;
        }

        public List<Bebida> BuscarPorNombre(string nombre)
        {
            List<Bebida> lista = new List<Bebida>();

            using SqlConnection conexion =
                (SqlConnection)DBComun.ObtenerConexion();

            using SqlCommand comando =
                new SqlCommand("BuscarBebidaNombre", conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@nombre", nombre);

            conexion.Open();

            using SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Bebida bebida = new Bebida();

                bebida.IdBebida =
                    Convert.ToString(reader["id_bebida"]) ?? string.Empty;

                bebida.Nombre =
                    Convert.ToString(reader["nombre"]) ?? string.Empty;

                bebida.Precio =
                    Convert.ToDecimal(reader["precio"]);

                lista.Add(bebida);
            }

            return lista;
        }
    }
}