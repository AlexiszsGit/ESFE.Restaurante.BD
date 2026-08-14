using System;
using System.Collections.Generic;
using System.Text;
using ESFE.RestauranteBD.EN;
using Microsoft.Data.SqlClient;

namespace ESFE.RestauranteBD.DAL
{
    public class TipoEmpleadoDAL
    {
            public static int Guardar(TipoEmpleado pTipoEmpleado)
            {
                using (SqlConnection conn = (SqlConnection)DBComun.ObtenerConexion())
                {
                    conn.Open();
                    string query = "INSERT INTO TipoEmpleado (Nombre) VALUES (@Nombre)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Nombre", pTipoEmpleado.Nombre);
                    return cmd.ExecuteNonQuery();
                }
            }

            public static List<TipoEmpleado> ObtenerTodos()
            {
                List<TipoEmpleado> lista = new List<TipoEmpleado>();
                using (SqlConnection conn = (SqlConnection)DBComun.ObtenerConexion())
                {
                    conn.Open();
                    string query = "SELECT Id, Nombre FROM TipoEmpleado";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        lista.Add(new TipoEmpleado
                        {
                            IdTipoEmpleado = reader.GetInt32(0), // Verifica si en EN es IdTipoEmpleado o Id
                            Nombre = reader.GetString(1)
                        });
                    }
                }
                return lista;
            }
    }
}
