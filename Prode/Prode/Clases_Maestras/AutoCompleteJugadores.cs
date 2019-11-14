using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prode.Clases_Maestras
{
    public class AutoCompleteJugadores
    {
        public static DataTable Datos(int idEquipo)
        {
            DataTable dt = new DataTable();
            MySqlConnection conexion = new MySqlConnection(Properties.Settings.Default.db);
            conexion.Open();
            string consulta = "select asig.idJugador, per.Apellido, per.Nombre from FutbolAsignacionJugadorPorEquipo as asig inner join FutbolPersonaFisicaJugador as per on(asig.idJugador = per.idPersonaFisicaJugador)where idEquipo = '" + idEquipo + "'";
            MySqlCommand cmd = new MySqlCommand(consulta, conexion);
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            adap.Fill(dt);
            conexion.Close();
            return dt;
        }

        public static AutoCompleteStringCollection Autocomplete(int idEquipo)
        {
            DataTable DT = Datos(idEquipo);
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in DT.Rows)
            {
                coleccion.Add(Convert.ToString(row["idJugador"] + "," + row["Apellido"] + row["Nombre"]));
            }
            return coleccion;
        }
    }
}
