using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prode.Entidades;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Prode.Dao
{
    public class TorneoDao
    {
        private static MySql.Data.MySqlClient.MySqlConnection connection = new MySqlConnection(Properties.Settings.Default.db);
        public static bool GuardarTorneo(Torneo _torneo)
        {
            bool exito = false;
            bool YaExiste = ValidadTorneoExistente(_torneo);
            if (YaExiste == false)
            {
                connection.Close();
                connection.Open();
                string proceso = "GuardarTorneo";
                MySqlCommand cmd = new MySqlCommand(proceso, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Temporada_in", _torneo.Temporada);
                cmd.Parameters.AddWithValue("NombreTorneo_in", _torneo.NombreTorneo);
                cmd.Parameters.AddWithValue("CantidadFechas_in", _torneo.CantidadFechas);
                cmd.ExecuteNonQuery();
                exito = true;
                connection.Close();
                return exito;
            }
            else
            {
                const string message = "Ya existe un Torneo con el mismo nombre para la temporada seleccionada.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
                exito = false;
                return exito;
            }
        }
        private static bool ValidadTorneoExistente(Torneo _torneo)
        {
            connection.Close();
            bool Existe = false;
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("Temporada_in", _torneo.Temporada),
                                      new MySqlParameter("NombreTorneo_in", _torneo.NombreTorneo)};
            string proceso = "ValidadTorneoExistente";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            DataSet ds = new DataSet();
            dt.Fill(ds, "torneo");
            if (Tabla.Rows.Count > 0)
            {
                Existe = true;
            }
            connection.Close();
            return Existe;
        }

        public static bool ValidarFecha(string fecha, string torneo, string temporada)
        {
            bool FechaValida = false;
            int idTorneo = BuscaIdtorneoPorNombreTemporada(torneo, temporada);
            if (idTorneo > 0)
            {
             // int Fechas
             //   connection.Close();
             //   connection.Open();
             //   MySqlCommand cmd = new MySqlCommand();
             //   cmd.Connection = connection;
             //   DataTable Tabla = new DataTable();
             //   MySqlParameter[] oParam = { new MySqlParameter("NombreTorneo_in", torneo),
             //new MySqlParameter("Temporada_in", temporada)};
             //   string proceso = "BuscaIdtorneoPorNombreTemporada";
             //   MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
             //   dt.SelectCommand.CommandType = CommandType.StoredProcedure;
             //   dt.SelectCommand.Parameters.AddRange(oParam);
             //   dt.Fill(Tabla);
             //   if (Tabla.Rows.Count > 0)
             //   {
             //       foreach (DataRow item in Tabla.Rows)
             //       {
             //           idTorneo = Convert.ToInt32(item["idTorneo"].ToString());
             //       }
             //   }

             //   connection.Close();
             //   return idTorneo;
            }
            return FechaValida;
        }

        private static int BuscaIdtorneoPorNombreTemporada(string torneo, string temporada)
        {
            int idTorneo = 0;
            connection.Close();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { new MySqlParameter("NombreTorneo_in", torneo),
             new MySqlParameter("Temporada_in", temporada)};
            string proceso = "BuscaIdtorneoPorNombreTemporada";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    idTorneo = Convert.ToInt32(item["idTorneo"].ToString());
                }
            }

            connection.Close();
            return idTorneo;
        }

        public static List<string> CargarComboTorneos()
        {
            List<string> _listaTorneo = new List<string>();
            connection.Close();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { };
            string proceso = "CargarComboTorneos";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    _listaTorneo.Add(item["NombreTorneo"].ToString() + "-" + item["Temporada"].ToString());
                }
            }

            connection.Close();
            return _listaTorneo;
        }
    }
}
