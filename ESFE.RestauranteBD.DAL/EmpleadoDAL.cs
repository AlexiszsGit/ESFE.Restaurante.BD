using System;
using System.Collections.Generic;
using System.Text;
using ESFE.RestauranteBD.EN;
using Microsoft.Data.SqlClient;
using System.Data;

namespace ESFE.RestauranteBD.DAL
{
    
    
        public class EmpleadoDAL
        {
            public bool Insertar(Empleado empleado)
            {
                using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
                {
                    using (SqlCommand comando = new SqlCommand("InsertarEmpleado", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@id_empleado", empleado.IdEmpleado);
                        comando.Parameters.AddWithValue("@nombre", empleado.Nombre);
                        comando.Parameters.AddWithValue("@id_tipo", empleado.IdTipo);

                        conexion.Open();
                        return comando.ExecuteNonQuery() > 0;
                    }
                }
            }

            public bool Actualizar(Empleado empleado)
            {
                using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
                {
                    using (SqlCommand comando = new SqlCommand("ActualizarEmpleado", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@id_empleado", empleado.IdEmpleado);
                        comando.Parameters.AddWithValue("@nombre", empleado.Nombre);
                        comando.Parameters.AddWithValue("@id_tipo", empleado.IdTipo);

                        conexion.Open();
                        return comando.ExecuteNonQuery() > 0;
                    }
                }
            }

            public bool Eliminar(string idEmpleado)
            {
                using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
                {
                    using (SqlCommand comando = new SqlCommand("EliminarEmpleado", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@id_empleado", idEmpleado);

                        conexion.Open();
                        return comando.ExecuteNonQuery() > 0;
                    }
                }
            }

            public List<Empleado> Buscar(string idEmpleado)
            {
                List<Empleado> lista = new List<Empleado>();
                using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
                {
                    using (SqlCommand comando = new SqlCommand("BuscarEmpleado", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@id_empleado", idEmpleado);

                        conexion.Open();
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Empleado emp = new Empleado();
                                emp.IdEmpleado = reader["id_empleado"]?.ToString() ?? string.Empty;
                                emp.Nombre = reader["nombre"]?.ToString() ?? string.Empty;
                                emp.IdTipo = reader["id_tipo"]?.ToString() ?? string.Empty;
                                lista.Add(emp);
                            }
                        }
                    }
                }
                return lista;
            }
        }
}