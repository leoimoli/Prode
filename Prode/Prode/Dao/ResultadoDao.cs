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
    public class ResultadoDao
    {
        private static MySql.Data.MySqlClient.MySqlConnection connection = new MySqlConnection(Properties.Settings.Default.db);
        public static bool GaurdarResultados(List<Resultados> _listaResultado)
        {
            bool Exito = false;
            _listaResultado = BuscarIdEquipos(_listaResultado);
            foreach (var item in _listaResultado)
            {
                connection.Close();
                connection.Open();
                string proceso = "GaurdarResultados";
                MySqlCommand cmd = new MySqlCommand(proceso, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("idPartido_in", item.idPartido);
                cmd.Parameters.AddWithValue("idTipoResultado_in", item.idTipoResultado);
                cmd.ExecuteNonQuery();
            }
            foreach (var item in _listaResultado)
            {
                connection.Close();
                connection.Open();
                string proceso = "GaurdarDetalleResultados";
                MySqlCommand cmd = new MySqlCommand(proceso, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("IdEquipoLocal_in", item.IdEquipoLocal);
                cmd.Parameters.AddWithValue("MarcadorLocal_in", item.MarcadorLocal);
                cmd.Parameters.AddWithValue("IdEquipoVisitante_in", item.IdEquipoVisitante);
                cmd.Parameters.AddWithValue("MarcadorVisitante_in", item.MarcadorVisitante);
                cmd.Parameters.AddWithValue("idPartido_in", item.idPartido);
                cmd.Parameters.AddWithValue("idUsuario_in", item.idUsuario);
                cmd.ExecuteNonQuery();
            }
            Exito = ActualizarEstadoFecha(_listaResultado);
            connection.Close();
            return Exito;
        }

        public static List<Resultados> BuscarResultados(string torneo, string temporada, string nroFecha)
        {
            List<Resultados> lista = new List<Resultados>();
            int idTorneo = TorneoDao.BuscaIdtorneoPorNombreTemporada(torneo, temporada);
            int idFecha = BuscarIdFecha(idTorneo, nroFecha);
            List<int> ListaIdPartidos = BuscarPartidosPorIdFecha(idFecha);
            if (ListaIdPartidos.Count > 0)
            {
                foreach (var item in ListaIdPartidos)
                {
                    connection.Close();
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    DataTable Tabla = new DataTable();
                    MySqlParameter[] oParam = {
                                      new MySqlParameter("idPartido_in", item)};
                    string proceso = "BuscarResultados";
                    MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
                    dt.SelectCommand.CommandType = CommandType.StoredProcedure;
                    dt.SelectCommand.Parameters.AddRange(oParam);
                    dt.Fill(Tabla);
                    if (Tabla.Rows.Count > 0)
                    {
                        foreach (DataRow item2 in Tabla.Rows)
                        {
                            Resultados listaResultados = new Resultados();
                            listaResultados.IdEquipoLocal = Convert.ToInt32(item2["idEquipoLocal"].ToString());
                            listaResultados.MarcadorLocal = Convert.ToInt32(item2["MarcadorLocal"].ToString());
                            listaResultados.MarcadorVisitante = Convert.ToInt32(item2["MarcadorVisitante"].ToString());
                            listaResultados.IdEquipoVisitante = Convert.ToInt32(item2["idEquipoVisitante"].ToString());
                            lista.Add(listaResultados);
                        }
                    }
                }
            }
            else
            {
                const string message2 = "La fecha ingresada no existe.";
                const string caption2 = "Error";
                var result2 = MessageBox.Show(message2, caption2,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Error);
                throw new Exception();
            }
            if (lista.Count > 0)
            {
                connection.Close();
                connection.Open();
                MySqlCommand cmd3 = new MySqlCommand();
                cmd3.Connection = connection;
                DataTable Tabla2 = new DataTable();
                DataTable Tabla3 = new DataTable();
                foreach (var item in lista)
                {
                    MySqlParameter[] oParam2 = { new MySqlParameter("IdEquipo_in", item.IdEquipoLocal) };
                    string proceso2 = "BuscarNombreEquipo";
                    MySqlDataAdapter dt2 = new MySqlDataAdapter(proceso2, connection);
                    dt2.SelectCommand.CommandType = CommandType.StoredProcedure;
                    dt2.SelectCommand.Parameters.AddRange(oParam2);
                    dt2.Fill(Tabla2);
                    foreach (DataRow itemRow2 in Tabla2.Rows)
                    {
                        item.EquipoLocal = itemRow2["Nombre"].ToString();
                    }


                    MySqlParameter[] oParam3 = { new MySqlParameter("IdEquipo_in", item.IdEquipoVisitante) };
                    string proceso3 = "BuscarNombreEquipo";
                    MySqlDataAdapter dt3 = new MySqlDataAdapter(proceso3, connection);
                    dt3.SelectCommand.CommandType = CommandType.StoredProcedure;
                    dt3.SelectCommand.Parameters.AddRange(oParam3);
                    dt3.Fill(Tabla3);
                    foreach (DataRow itemRow3 in Tabla3.Rows)
                    {
                        item.EquipoVisitante = itemRow3["Nombre"].ToString();
                    }
                }
            }
            connection.Close();
            return lista;
        }

        private static int BuscarIdFecha(int idTorneo, string nroFecha)
        {
            int NroFecha = Convert.ToInt32(nroFecha);
            connection.Close();
            int idFecha = 0;
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("idTorneo_in", idTorneo),
            new MySqlParameter("nroFecha_in", NroFecha)};
            string proceso = "BuscarIdFecha";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            DataSet ds = new DataSet();
            dt.Fill(ds, "Fecha");
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    idFecha = Convert.ToInt32(item["idFecha"].ToString());
                }
            }
            connection.Close();
            return idFecha;
        }

        private static List<int> BuscarPartidosPorIdFecha(int idFecha)
        {
            List<int> ListaIdPartidos = new List<int>();
            connection.Close();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("idFecha_in", idFecha)};
            string proceso = "BuscarPartidosPorIdFecha";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                List<int> Partidos = new List<int>();
                foreach (DataRow item in Tabla.Rows)
                {
                    Partidos.Add(Convert.ToInt32(item["idPartido"].ToString()));
                }
                ListaIdPartidos = Partidos;
            }
            connection.Close();
            return ListaIdPartidos;
        }
        private static int ValidarNroFecha(int idTorneo, string nroFecha)
        {
            int NroFecha = Convert.ToInt32(nroFecha);
            connection.Close();
            int idFecha = 0;
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("idTorneo_in", idTorneo),
            new MySqlParameter("nroFecha_in", NroFecha)};
            string proceso = "ValidarNroFecha";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            DataSet ds = new DataSet();
            dt.Fill(ds, "Fecha");
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    idFecha = Convert.ToInt32(item["idFecha"].ToString());
                }
            }
            connection.Close();
            return idFecha;
        }
        private static bool ActualizarEstadoFecha(List<Resultados> _listaResultado)
        {
            string Estado = "Jugado";
            bool Exito = false;
            var Fecha = _listaResultado.First();
            int idFecha = BuscarIdFechaPorIdPartido(Fecha.idPartido);
            connection.Close();
            connection.Open();
            string proceso = "ActualizarEstadoFecha";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Estado_in", Estado);
            cmd.Parameters.AddWithValue("idFecha_in", idFecha);
            cmd.ExecuteNonQuery();
            Exito = true;
            return Exito;
        }
        private static int BuscarIdFechaPorIdPartido(int idPartido)
        {
            connection.Close();
            connection.Open();
            int idFecha = 0;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("idPartido_in", idPartido)};
            string proceso = "BuscarIdFechaPorIdPartido";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    idFecha = Convert.ToInt32(item["idFecha"].ToString());
                }
            }
            connection.Close();
            return idFecha;
        }
        private static List<Resultados> BuscarIdEquipos(List<Resultados> _listaResultado)
        {
            connection.Close();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            DataTable Tabla2 = new DataTable();
            foreach (var item in _listaResultado)
            {
                MySqlParameter[] oParam = { new MySqlParameter("Nombre_in", item.EquipoLocal) };
                string proceso = "BuscarIdEquipos";
                MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
                dt.SelectCommand.CommandType = CommandType.StoredProcedure;
                dt.SelectCommand.Parameters.AddRange(oParam);
                dt.Fill(Tabla);
                foreach (DataRow itemRow in Tabla.Rows)
                {
                    item.IdEquipoLocal = Convert.ToInt32(itemRow["idEquipo"].ToString());
                }
                MySqlParameter[] oParam2 = { new MySqlParameter("Nombre_in", item.EquipoVisitante) };
                string proceso2 = "BuscarIdEquipos";
                MySqlDataAdapter dt2 = new MySqlDataAdapter(proceso2, connection);
                dt2.SelectCommand.CommandType = CommandType.StoredProcedure;
                dt2.SelectCommand.Parameters.AddRange(oParam2);
                dt2.Fill(Tabla2);
                foreach (DataRow itemRow2 in Tabla2.Rows)
                {
                    item.IdEquipoVisitante = Convert.ToInt32(itemRow2["idEquipo"].ToString());
                }
            }
            connection.Close();
            return _listaResultado;
        }
    }
}
