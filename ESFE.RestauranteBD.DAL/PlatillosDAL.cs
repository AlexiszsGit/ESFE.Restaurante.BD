using System;
using System.Collections.Generic;
using System.Text;
using ESFE.RestauranteBD.EN;
using Microsoft.Data.SqlClient;

namespace ESFE.RestauranteBD.DAL
{
    public class PlatillosDAL
    {
        
            public static int Guardar(Platillos pPlatillo)
            {
                using (SqlConnection conn = (SqlConnection)DBComun.ObtenerConexion())
                {
                    conn.Open();
                    string query = "INSERT INTO Platillos (Nombre, Precio, IdCategoria) VALUES (@Nombre, @Precio, @IdCategoria)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Nombre", pPlatillo.Nombre);
                    cmd.Parameters.AddWithValue("@Precio", pPlatillo.Precio);
                    cmd.Parameters.AddWithValue("@IdCategoria", pPlatillo.IdCategoria);
                    return cmd.ExecuteNonQuery();
                }
            }

            public static List<Platillos> ObtenerTodos()
            {
                List<Platillos> lista = new List<Platillos>();
                using (SqlConnection conn = (SqlConnection)DBComun.ObtenerConexion())
                {
                    conn.Open();
                    string query = "SELECT Id, Nombre, Precio, IdCategoria FROM Platillos";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        lista.Add(new Platillos
                        {
                            IdPlatillo = reader.GetInt32(0), // Verifica si en EN es IdPlatillo o Id
                            Nombre = reader.GetString(1),
                            Precio = reader.GetDecimal(2),
                            IdCategoria = reader.GetInt32(3)
                        });
                    }
                }
                return lista;
            }
    }
}
