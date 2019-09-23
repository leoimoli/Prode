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
                cmd.ExecuteNonQuery();
            }
            Exito = true;
            connection.Close();
            return Exito;
        }
    }
}
