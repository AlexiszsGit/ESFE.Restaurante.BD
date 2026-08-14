using System;
using System.Collections.Generic;
using System.Text;
using ESFE.RestauranteBD.EN;
using Microsoft.Data.SqlClient;

namespace ESFE.RestauranteBD.DAL
{
    public class MesaDAL
    {
            public static int Guardar(Mesa pMesa)
            {
                using (SqlConnection conn = (SqlConnection)DBComun.ObtenerConexion())
                {
                    conn.Open();
                    string query = "INSERT INTO Mesa (NumeroMesa, Capacidad, Estado) VALUES (@NumeroMesa, @Capacidad, @Estado)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@NumeroMesa", pMesa.NumeroMesa);
                    cmd.Parameters.AddWithValue("@Capacidad", pMesa.Capacidad);
                    cmd.Parameters.AddWithValue("@Estado", pMesa.Estado);
                    return cmd.ExecuteNonQuery();
                }
            }

            public static List<Mesa> ObtenerTodos()
            {
                List<Mesa> lista = new List<Mesa>();
                using (SqlConnection conn = (SqlConnection)DBComun.ObtenerConexion())
                {
                    conn.Open();
                    string query = "SELECT Id, NumeroMesa, Capacidad, Estado FROM Mesa";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        lista.Add(new Mesa
                        {
                            IdMesa = reader.GetInt32(0),
                            NumeroMesa = reader.GetInt32(1),
                            Capacidad = reader.GetInt32(2),
                            Estado = reader.GetString(3) // Si Estado en Mesa.cs es byte/int, cámbialo a GetByte(3) o GetInt32(3)
                        });
                    }
                }
                return lista;
            }
    }
}


