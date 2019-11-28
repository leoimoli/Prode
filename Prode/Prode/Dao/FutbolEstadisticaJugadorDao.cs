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
    public class FutbolEstadisticaJugadorDao
    {
        private static MySql.Data.MySqlClient.MySqlConnection connection = new MySqlConnection(Properties.Settings.Default.db);
        public static List<JugadorEstadisticaPartido> listaStatic;
        public static bool GuardarEstadisticaJugador(List<string> listaEstadistica, string sistemaTactico, int idPartidos, int idEquipos)
        {
            bool exito = false;
            connection.Close();
            connection.Open();

            exito = ActualizarSistemaTactico(sistemaTactico, idPartidos);
            if (exito == true)
            {
                List<JugadorEstadisticaPartido> ListaMomentanea = new List<JugadorEstadisticaPartido>();
                foreach (var item in listaEstadistica)
                {
                    JugadorEstadisticaPartido listaJugador = new JugadorEstadisticaPartido();
                    string Cadena = item;

                    string id = Cadena.Split(',')[0];
                    string Cadena2 = Cadena.Split(',')[1];

                    string Min = Cadena2.Split('-')[0];
                    string Cadena3 = Cadena2.Split('-')[1];

                    string Gol = Cadena3.Split('.')[0];
                    string Cadena4 = Cadena3.Split('.')[1];

                    string Ama = Cadena4.Split('+')[0];
                    string Cadena5 = Cadena4.Split('+')[1];

                    string Ro = Cadena5;

                    int idJugador = Convert.ToInt32(id);
                    int Minutos = Convert.ToInt32(Min);
                    int Goles = Convert.ToInt32(Gol);
                    int Amarillas = Convert.ToInt32(Ama);
                    int Rojas = Convert.ToInt32(Ro);

                    listaJugador.idJugador = idJugador;
                    listaJugador.Minutos = Minutos;
                    listaJugador.Goles = Goles;
                    listaJugador.Amarillas = Amarillas;
                    listaJugador.Rojas = Rojas;

                    string proceso = "GuardarEstadisticaJugadorPartido";
                    MySqlCommand cmd = new MySqlCommand(proceso, connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("idJugador_in", idJugador);
                    cmd.Parameters.AddWithValue("Minutos_in", Minutos);
                    cmd.Parameters.AddWithValue("Goles_in", Goles);
                    cmd.Parameters.AddWithValue("Amarillas_in", Amarillas);
                    cmd.Parameters.AddWithValue("Rojas_in", Amarillas);
                    cmd.Parameters.AddWithValue("idEquipo_in", idEquipos);
                    cmd.Parameters.AddWithValue("idPartido_in", idPartidos);
                    cmd.ExecuteNonQuery();
                    ListaMomentanea.Add(listaJugador);
                }
                listaStatic = ListaMomentanea;
                exito = true;

                if (exito == true)
                {
                    exito = ActualizarEstadisticaGeneral(idPartidos, idEquipos);
                }
            }
            connection.Close();
            return exito;

        }

        private static bool ActualizarSistemaTactico(string sistemaTactico, int idPartidos)
        {
            bool exito = false;
            connection.Close();
            connection.Open();
            string procesoUpdate = "ActualizarSistemaTactico";
            MySqlCommand cmd3 = new MySqlCommand(procesoUpdate, connection);
            cmd3.CommandType = CommandType.StoredProcedure;
            cmd3.Parameters.AddWithValue("sistemaTactico_in", sistemaTactico);
            cmd3.Parameters.AddWithValue("idPartido_in", idPartidos);
            cmd3.ExecuteNonQuery();
            exito = true;
            return exito;
        }
        private static bool ActualizarEstadisticaGeneral(int idPartidos, int idEquipos)
        {
            bool exito = false;
            connection.Close();
            connection.Open();
            int MinutosNew;
            int GolesNew;
            int AmarillasNew;
            int RojasNew;
            int PJNew;
            foreach (var item in listaStatic)
            {
                int idJugador = item.idJugador;
                MinutosNew = item.Minutos;
                GolesNew = item.Goles;
                AmarillasNew = item.Amarillas;
                RojasNew = item.Rojas;
               
                List<Entidades.JugadorEstadisticaPartido> lista = new List<Entidades.JugadorEstadisticaPartido>();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                DataTable Tabla = new DataTable();
                MySqlParameter[] oParam = {
                                      new MySqlParameter("idJugador_in", idJugador)};
                string proceso = "BuscarEstadisticaJugador";
                MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
                dt.SelectCommand.CommandType = CommandType.StoredProcedure;
                dt.SelectCommand.Parameters.AddRange(oParam);
                dt.Fill(Tabla);
                if (Tabla.Rows.Count > 0)
                {
                    foreach (DataRow item2 in Tabla.Rows)
                    {
                        JugadorEstadisticaPartido listaJugador = new JugadorEstadisticaPartido();
                        listaJugador.idJugador = Convert.ToInt32(item2["idJugador"].ToString());
                        listaJugador.Minutos = Convert.ToInt32(item2["MinutosJugados"].ToString());
                        listaJugador.Goles = Convert.ToInt32(item2["Goles"].ToString());
                        listaJugador.Rojas = Convert.ToInt32(item2["Rojas"].ToString());
                        listaJugador.Amarillas = Convert.ToInt32(item2["Amarillas"].ToString());
                        listaJugador.PJ = Convert.ToInt32(item2["PJ"].ToString());
                        lista.Add(listaJugador);
                    }
                }
                if (lista.Count > 0)
                {
                    
                    var Jugador = lista.First();
                    ///// Calculo Estadistica
                    int MinutosFinales = Jugador.Minutos + MinutosNew;
                    int GolesFinales = Jugador.Goles + GolesNew;
                    int AmarillasFinales = Jugador.Amarillas + AmarillasNew;
                    int RojasFinales = Jugador.Rojas + RojasNew;
                    int PJFinales = Jugador.PJ + 1;
                    exito = false;
                    connection.Close();
                    connection.Open();
                    string procesoUpdate = "EditarEstadisticaTotalJugador";
                    MySqlCommand cmd3 = new MySqlCommand(procesoUpdate, connection);
                    cmd3.CommandType = CommandType.StoredProcedure;
                    cmd3.Parameters.AddWithValue("Minutos_in", MinutosFinales);
                    cmd3.Parameters.AddWithValue("Goles_in", GolesFinales);
                    cmd3.Parameters.AddWithValue("Amarillas_in", AmarillasFinales);
                    cmd3.Parameters.AddWithValue("Rojas_in", RojasFinales);
                    cmd3.Parameters.AddWithValue("idJugador_in", idJugador);
                    cmd3.Parameters.AddWithValue("PJ_in", PJFinales);
                    cmd3.ExecuteNonQuery();
                }
                else
                {
                    PJNew = 1;
                    string procesoInsert = "GuardarEstadisticaTotalJugador";
                    MySqlCommand cmd2 = new MySqlCommand(procesoInsert, connection);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("idJugador_in", idJugador);
                    cmd2.Parameters.AddWithValue("Minutos_in", MinutosNew);
                    cmd2.Parameters.AddWithValue("Goles_in", GolesNew);
                    cmd2.Parameters.AddWithValue("Amarillas_in", AmarillasNew);
                    cmd2.Parameters.AddWithValue("Rojas_in", RojasNew);
                    cmd2.Parameters.AddWithValue("PJ_in", PJNew);
                    cmd2.ExecuteNonQuery();
                }
            }
            exito = true;
            connection.Close();
            return exito;
        }
    }
}
