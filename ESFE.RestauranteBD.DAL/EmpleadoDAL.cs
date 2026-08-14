using System;
using System.Collections.Generic;
using System.Text;
using ESFE.RestauranteBD.EN;
using Microsoft.Data.SqlClient;

namespace ESFE.RestauranteBD.DAL
{
    internal class EmpleadoDAL
    {
            public static int Guardar(Empleado pEmpleado)
            {
                using (SqlConnection conn = (SqlConnection)DBComun.ObtenerConexion())
                {
                    conn.Open();
                    string query = "INSERT INTO Empleado (Nombre, Apellido, IdTipoEmpleado) VALUES (@Nombre, @Apellido, @IdTipoEmpleado)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Nombre", pEmpleado.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", pEmpleado.Apellido);
                    cmd.Parameters.AddWithValue("@IdTipoEmpleado", pEmpleado.IdTipoEmpleado);
                    return cmd.ExecuteNonQuery();
                }
            }

            public static List<Empleado> ObtenerTodos()
            {
                List<Empleado> lista = new List<Empleado>();
                using (SqlConnection conn = (SqlConnection)DBComun.ObtenerConexion())
                {
                    conn.Open();
                    string query = "SELECT Id, Nombre, Apellido, IdTipoEmpleado FROM Empleado";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        lista.Add(new Empleado
                        {
                            IdEmpleado = reader.GetInt32(0), // Verifica si en EN es IdEmpleado o Id
                            Nombre = reader.GetString(1),
                            Apellido = reader.GetString(2),
                            IdTipoEmpleado = reader.GetInt32(3)
                        });
                    }
                }
                return lista;
            }
    }
}

