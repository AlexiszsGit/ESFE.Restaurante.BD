using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.Data.SqlClient;

namespace ESFE.RestauranteBD.DAL
{
    public class DBComun
    {

        public const string _stringCnn = @"Server=localhost\SQLEXPRESS2;Database=RestauranteBD;Integrated Security=True;TrustServerCertificate=True;";
       // public const string _stringCnn = @"Server=(localdb)\MSSQLLocalDB;Database=RestauranteBD;Integrated Security=True;TrustServerCertificate=True;";

        /// <summary>
        /// Metodo para obtener base de datos.
        /// </summary>
        /// <returns>Devuelve la  conexion</returns>
        public static IDbConnection ObtenerConexion()
        {
            return new SqlConnection(_stringCnn);
        }

        public static IDataReader ObtenerCommando(IDbConnection pConexion, string pSql)
        {
            SqlCommand _command = new SqlCommand(pSql, pConexion as SqlConnection);
            return _command.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}
