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
    public class DescuentosDAL
    {
        public bool Insertar(Descuentos descuento)
        {
            using SqlConnection conexion =
                (SqlConnection)DBComun.ObtenerConexion();

            using SqlCommand comando =
                new SqlCommand("InsertarDescuento", conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@id_descuento", descuento.IdDescuento);
            comando.Parameters.AddWithValue("@descripcion", descuento.Nombre);
            comando.Parameters.AddWithValue("@porcentaje", descuento.Porcentaje);

            conexion.Open();

            comando.ExecuteNonQuery();

            return true;
        }

        public bool Actualizar(Descuentos descuento)
        {
            using SqlConnection conexion =
                (SqlConnection)DBComun.ObtenerConexion();

            using SqlCommand comando =
                new SqlCommand("ActualizarDescuento", conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@id_descuento", descuento.IdDescuento);
            comando.Parameters.AddWithValue("@descripcion", descuento.Nombre);
            comando.Parameters.AddWithValue("@porcentaje", descuento.Porcentaje);

            conexion.Open();

            comando.ExecuteNonQuery();

            return true;
        }

        public bool Eliminar(string idDescuento)
        {
            using SqlConnection conexion =
                (SqlConnection)DBComun.ObtenerConexion();

            using SqlCommand comando =
                new SqlCommand("EliminarDescuento", conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@id_descuento", idDescuento);

            conexion.Open();

            return comando.ExecuteNonQuery() > 0;
        }

        public List<Descuentos> Buscar(string nombre)
        {
            List<Descuentos> lista = new List<Descuentos>();

            using SqlConnection conexion =
                (SqlConnection)DBComun.ObtenerConexion();

            using SqlCommand comando =
                new SqlCommand("BuscarDescuentoDescripcion", conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@descripcion", nombre);

            conexion.Open();

            using SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Descuentos descuento = new Descuentos();

                descuento.IdDescuento =
                    Convert.ToString(reader["id_descuento"]) ?? string.Empty;

                descuento.Nombre =
                    Convert.ToString(reader["descripcion"]) ?? string.Empty;

                descuento.Porcentaje =
                    Convert.ToDecimal(reader["porcentaje"]);

                lista.Add(descuento);
            }

            return lista;
        }

        public List<Descuentos> BuscarPorNombre(string nombre)
        {
            List<Descuentos> lista = new List<Descuentos>();

            using SqlConnection conexion =
                (SqlConnection)DBComun.ObtenerConexion();

            using SqlCommand comando =
                new SqlCommand("BuscarDescuentoDescripcion", conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@descripcion", nombre);

            conexion.Open();

            using SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Descuentos descuento = new Descuentos();

                descuento.IdDescuento =
                    Convert.ToString(reader["id_descuento"]) ?? string.Empty;

                descuento.Nombre =
                    Convert.ToString(reader["descripcion"]) ?? string.Empty;

                descuento.Porcentaje =
                    Convert.ToDecimal(reader["porcentaje"]);

                lista.Add(descuento);
            }

            return lista;
        }
    }
}