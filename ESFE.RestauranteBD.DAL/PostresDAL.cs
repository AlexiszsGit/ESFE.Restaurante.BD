using System;
using System.Collections.Generic;
using System.Text;
using ESFE.RestauranteBD.EN;
using Microsoft.Data.SqlClient;

namespace ESFE.RestauranteBD.DAL
{
    public class PostresDAL
    {
        
            public static int Guardar(Postres pPostre)
            {
                using (SqlConnection conn = (SqlConnection)DBComun.ObtenerConexion())
                {
                    conn.Open();
                    string query = "INSERT INTO Postres (Nombre, Precio, Descripcion) VALUES (@Nombre, @Precio, @Descripcion)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Nombre", pPostre.Nombre);
                    cmd.Parameters.AddWithValue("@Precio", pPostre.Precio);
                    cmd.Parameters.AddWithValue("@Descripcion", pPostre.Descripcion);
                    return cmd.ExecuteNonQuery();
                }
            }

            public static List<Postres> ObtenerTodos()
            {
                List<Postres> lista = new List<Postres>();
                using (SqlConnection conn = (SqlConnection)DBComun.ObtenerConexion())
                {
                    conn.Open();
                    string query = "SELECT Id, Nombre, Precio, Descripcion FROM Postres";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        lista.Add(new Postres
                        {
                            IdPostre = reader.GetInt32(0), // Verifica si en EN es IdPostre o Id
                            Nombre = reader.GetString(1),
                            Precio = reader.GetDecimal(2),
                            Descripcion = reader.GetString(3)
                        });
                    }
                }
                return lista;
            }
    }
}
