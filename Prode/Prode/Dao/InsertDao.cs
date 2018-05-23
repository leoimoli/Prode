using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Prode.Dao
{
   public class InsertDao
    {
        private static SqlConnection connection = new SqlConnection(Properties.Settings.Default.db);

        public static bool GuardarPartido(int equipo1, int equipo2, string estadio, DateTime fecha)
        {
            bool exito = false;
            connection.Close();
            connection.Open();
            string proceso = "PartidoGrabar";
            SqlCommand cmd = new SqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("IdPartido", 0);
            cmd.Parameters.AddWithValue("IdEquipo1", equipo1);
            cmd.Parameters.AddWithValue("IdEquipo2", equipo2);
            cmd.Parameters.AddWithValue("FechaPartido", fecha);
            cmd.Parameters.AddWithValue("Estadio", estadio);
            cmd.ExecuteNonQuery();
            exito = true;
            connection.Close();
            return exito;
        }
    }
}
