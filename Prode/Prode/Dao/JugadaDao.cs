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
    public class JugadaDao
    {
        private static MySql.Data.MySqlClient.MySqlConnection connection = new MySqlConnection(Properties.Settings.Default.db);
        public static bool GuardarJugada(List<Jugada> _listaJugada)
        {
            bool Exito = false;
            int UltimoNroJugada = BuscarUltimoNroJugada();
            if (UltimoNroJugada > 0)
            {
                int NuevoNumeroDeJugada = UltimoNroJugada + 1;
                foreach (var item in _listaJugada)
                {
                    connection.Close();
                    connection.Open();
                    string proceso = "GuardarJugada";
                    MySqlCommand cmd = new MySqlCommand(proceso, connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("idPartido_in", item.idPartido);
                    cmd.Parameters.AddWithValue("idApostador_in", item.idApostador);
                    cmd.Parameters.AddWithValue("idResultado_in", item.idResultado);
                    cmd.Parameters.AddWithValue("NroJugada_in", NuevoNumeroDeJugada);
                    cmd.ExecuteNonQuery();
                }
                Exito = true;
                connection.Close();
                return Exito;
            }
            else
            {
                int NuevoNumeroDeJugada = 1;
                foreach (var item in _listaJugada)
                {
                    connection.Close();
                    connection.Open();
                    string proceso = "GuardarJugada";
                    MySqlCommand cmd = new MySqlCommand(proceso, connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("idPartido_in", item.idPartido);
                    cmd.Parameters.AddWithValue("idApostador_in", item.idApostador);
                    cmd.Parameters.AddWithValue("idResultado_in", item.idResultado);
                    cmd.Parameters.AddWithValue("NroJugada_in", NuevoNumeroDeJugada);
                    cmd.ExecuteNonQuery();
                }
                Exito = true;
                connection.Close();
                return Exito;
            }
        }

        private static int BuscarUltimoNroJugada()
        {
            int NroJugada = 0;
            connection.Close();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { };
            string proceso = "BuscarUltimoNroJugada";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    if (item.ItemArray[0].ToString() != "")
                    {
                        NroJugada = Convert.ToInt32(item["MAX(NroJugada)"].ToString());
                    }
                    else
                    {
                        NroJugada = 0;
                    }
                }
            }
            connection.Close();
            return NroJugada;
        }      
    }
}
