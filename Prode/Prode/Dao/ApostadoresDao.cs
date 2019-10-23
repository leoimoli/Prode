using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prode.Entidades;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Prode.Dao
{
    public class ApostadoresDao
    {
        private static MySql.Data.MySqlClient.MySqlConnection connection = new MySqlConnection(Properties.Settings.Default.db);
        public static bool GuardarApostador(Apostadores _apostador)
        {
            int sexo;
            if (_apostador.Sexo == "Masculino")
            {
                sexo = 1;
            }
            else
            {
                sexo = 0;
            }
            bool exito = false;
            connection.Close();
            connection.Open();
            string proceso = "GuardarApostador";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Apellido_in", _apostador.Apellido);
            cmd.Parameters.AddWithValue("Nombre_in", _apostador.Nombre);
            cmd.Parameters.AddWithValue("Dni_in", _apostador.Dni);
            cmd.Parameters.AddWithValue("Sexo_in", sexo);
            cmd.Parameters.AddWithValue("Telefono_in", _apostador.Telefono);
            cmd.Parameters.AddWithValue("Email_in", _apostador.Email);
            cmd.ExecuteNonQuery();
            exito = true;
            connection.Close();
            return exito;
        }
        public static List<Apostadores> BuscarApostadorPorApellidoYNombre(string apellidoNombre)
        {
            string var = apellidoNombre;
            string Apellido = var.Split(' ')[0];
            string Nombre = var.Split(' ')[1];

            connection.Close();
            connection.Open();
            List<Entidades.Apostadores> lista = new List<Entidades.Apostadores>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("Apellido_in", Apellido),
            new MySqlParameter("Nombre_in", Nombre)};
            string proceso = "BuscarApostadorPorApellidoYNombre";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Apostadores listaApostadores = new Apostadores();
                    listaApostadores.idApostador = Convert.ToInt32(item["idJugador"].ToString());
                    listaApostadores.Apellido = item["Apellido"].ToString();
                    listaApostadores.Nombre = item["Nombre"].ToString();
                    listaApostadores.Dni = item["Dni"].ToString();
                    listaApostadores.Sexo = item["Sexo"].ToString();
                    listaApostadores.Telefono = item["Telefono"].ToString();
                    listaApostadores.Email = item["Email"].ToString();
                    lista.Add(listaApostadores);
                }
            }
            connection.Close();
            return lista;
        }
        public static string Variable;
        public static List<ResultadoApuestas> BuscarAciertos(string torneo, string temporada, string nroFecha, string Liga)
        {
            List<ResultadoApuestas> ListaResultadosApuestas = new List<ResultadoApuestas>();
            List<ResultadoApuestas> ListaAciertos = new List<ResultadoApuestas>();
            int idTorneo = TorneoDao.BuscaIdtorneoPorNombreTemporada(torneo, temporada, Liga);
            int idFecha = ResultadoDao.BuscarIdFecha(idTorneo, nroFecha);
            List<int> ListaIdPartidos = ResultadoDao.BuscarPartidosPorIdFecha(idFecha);
            if (ListaIdPartidos.Count > 0)
            {
                int Estado = 1;
                List<ResultadoApuestas> Lista = new List<ResultadoApuestas>();
                List<string> ListaIdPar = new List<string>();
                string ListaPartidos = string.Empty;
                foreach (var item in ListaIdPartidos)
                {
                    ListaPartidos = item.ToString() + "," + Variable;
                    Variable = ListaPartidos;
                }
                Variable = Variable.TrimEnd(',');
                connection.Close();
                connection.Open();
                DataTable Tabla = new DataTable();
                MySqlParameter[] oParam = {
                                           new MySqlParameter("p_idpartidos", Variable)};
                string proceso = "BuscarJugadasXPartido";
                MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
                dt.SelectCommand.CommandType = CommandType.StoredProcedure;
                dt.SelectCommand.Parameters.AddRange(oParam);
                dt.Fill(Tabla);
                if (Tabla.Rows.Count > 0)
                {
                    foreach (DataRow item2 in Tabla.Rows)
                    {
                        ResultadoApuestas _contadorAciertos = new ResultadoApuestas();
                        _contadorAciertos.idApostador = Convert.ToInt32(item2["idApostador"].ToString());
                        _contadorAciertos.NroJugada = Convert.ToInt32(item2["NroJugada"].ToString());
                        _contadorAciertos.Apellido = item2["Apellido"].ToString();
                        _contadorAciertos.Nombre = item2["Nombre"].ToString();
                        _contadorAciertos.Aciertos = Convert.ToInt32(item2["Aciertos"].ToString());
                        Lista.Add(_contadorAciertos);
                    }
                    ListaAciertos = Lista;
                }
            }
            return ListaAciertos;
        }

        public static List<EstadisticasApuestas> BuscarEstadisticaGral(string torneo, string temporada, string nroFecha, string Liga)
        {
            //List<EstadisticasApuestas> ListaResultadosApuestas = new List<EstadisticasApuestas>();
            List<EstadisticasApuestas> Lista = new List<EstadisticasApuestas>();
            //List<EstadisticasApuestas> ListaAciertos = new List<EstadisticasApuestas>();
            int idTorneo = TorneoDao.BuscaIdtorneoPorNombreTemporada(torneo, temporada, Liga);
            int idFecha = ResultadoDao.BuscarIdFecha(idTorneo, nroFecha);
            List<int> ListaIdPartidos = ResultadoDao.BuscarPartidosPorIdFecha(idFecha);
            if (ListaIdPartidos.Count > 0)
            {
                List<EstadisticasApuestas> ListaApuestas = new List<EstadisticasApuestas>();
                List<string> ListaIdPar = new List<string>();
                string ListaPartidos;

                foreach (var item in ListaIdPartidos)
                {
                    ListaPartidos = item.ToString() + "," + Variable;
                    Variable = ListaPartidos;
                }
                Variable = Variable.TrimEnd(',');
                var Variable2 = Variable.Replace('"', ' ');
                connection.Close();
                connection.Open();
                DataTable Tabla = new DataTable();
                string consulta = "select count( distinct NroJugada) as CantJugadas, count(DISTINCT idApostador) as CantApostadores from Jugadas where idPartido IN('" + Variable2 + "')";
                MySqlCommand cmd = new MySqlCommand(consulta, connection);
                cmd.Connection = connection;
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                adap.Fill(Tabla);
                if (Tabla.Rows.Count > 0)
                {
                    decimal ValorFecha = FechaDao.BuscarValorJugada(idFecha);
                    foreach (DataRow item2 in Tabla.Rows)
                    {
                        EstadisticasApuestas _estadisticasApuestas = new EstadisticasApuestas();
                        _estadisticasApuestas.CantidadApuestas = Convert.ToInt32(item2["CantJugadas"].ToString());
                        _estadisticasApuestas.CantidadJugadores = Convert.ToInt32(item2["CantApostadores"].ToString());
                        decimal ValorRecaudado = ValorFecha * _estadisticasApuestas.CantidadApuestas;
                        _estadisticasApuestas.MontoRecaudado = ValorRecaudado;
                        ListaApuestas.Add(_estadisticasApuestas);
                    }
                    Lista = ListaApuestas;
                }
            }
            return Lista;
        }

        //public static List<EstadisticasApuestas> BuscarEstadisticaGral(string torneo, string temporada, string nroFecha)
        //{
        //    List<EstadisticasApuestas> ListaEstadistica = new List<EstadisticasApuestas>();
        //    int idTorneo = TorneoDao.BuscaIdtorneoPorNombreTemporada(torneo, temporada);
        //    int idFecha = ResultadoDao.BuscarIdFecha(idTorneo, nroFecha);
        //    List<int> ListaIdPartidos = ResultadoDao.BuscarPartidosPorIdFecha(idFecha);
        //    if (ListaIdPartidos.Count > 0)
        //    {
        //        connection.Close();
        //        connection.Open();
        //        MySqlCommand cmd = new MySqlCommand();
        //        cmd.Connection = connection;
        //        DataTable Tabla = new DataTable();
        //        MySqlParameter[] oParam = {
        //                              new MySqlParameter("IdFecha_in", idFecha)};
        //        string proceso = "BuscarEstadisticaGral";
        //        MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
        //        dt.SelectCommand.CommandType = CommandType.StoredProcedure;
        //        dt.SelectCommand.Parameters.AddRange(oParam);
        //        dt.Fill(Tabla);
        //        if (Tabla.Rows.Count > 0)
        //        {
        //            foreach (DataRow item in Tabla.Rows)
        //            {
        //                EstadisticasApuestas EstadisticaGral = new EstadisticasApuestas();
        //                EstadisticaGral.CantidadApuestas = Convert.ToInt32(item["CantidadApuestas"].ToString());
        //                EstadisticaGral.CantidadJugadores = Convert.ToInt32(item["CantidadJugadores"].ToString());
        //                ListaEstadistica.Add(EstadisticaGral);
        //            }
        //        }
        //        connection.Close();
        //        return ListaEstadistica;
        //    }
        //}

        private static List<ResultadoApuestas> BuscarTotalAciertosPorApostadores(List<TipoResultadoPorPartido> ListaTipoResultado, List<int> ListaIdPartidos)
        {
            List<ResultadoApuestas> ListaResultadosApuestas = new List<ResultadoApuestas>();


            return ListaResultadosApuestas;
        }
    }
}
