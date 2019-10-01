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
        public static List<ResultadoApuestas> BuscarAciertos(string torneo, string temporada, string nroFecha)
        {
            List<ResultadoApuestas> ListaResultadosApuestas = new List<ResultadoApuestas>();
            List<TipoResultadoPorPartido> ListaTipoResultado = new List<TipoResultadoPorPartido>();
            int idTorneo = TorneoDao.BuscaIdtorneoPorNombreTemporada(torneo, temporada);
            int idFecha = ResultadoDao.BuscarIdFecha(idTorneo, nroFecha);
            List<int> ListaIdPartidos = ResultadoDao.BuscarPartidosPorIdFecha(idFecha);
            if (ListaIdPartidos.Count > 0)
            {
                List<TipoResultadoPorPartido> Lista = new List<TipoResultadoPorPartido>();
                foreach (var item in ListaIdPartidos)
                {
                    connection.Close();
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    DataTable Tabla = new DataTable();
                    MySqlParameter[] oParam = {
                                      new MySqlParameter("idPartido_in", item)};
                    string proceso = "BuscarTipoResultados";
                    MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
                    dt.SelectCommand.CommandType = CommandType.StoredProcedure;
                    dt.SelectCommand.Parameters.AddRange(oParam);
                    dt.Fill(Tabla);
                    if (Tabla.Rows.Count > 0)
                    {
                        foreach (DataRow item2 in Tabla.Rows)
                        {
                            TipoResultadoPorPartido tipo = new TipoResultadoPorPartido();
                            tipo.idPartido = item;
                            tipo.idTipoResultado = Convert.ToInt32(item2["idTipoResultado"].ToString());
                            Lista.Add(tipo);
                        }
                        ListaTipoResultado = Lista;
                    }
                }
            }
            ListaResultadosApuestas = BuscarTotalAciertosPorApostadores(ListaTipoResultado);
            return ListaResultadosApuestas;
        }
        private static List<ResultadoApuestas> BuscarTotalAciertosPorApostadores(List<TipoResultadoPorPartido> ListaTipoResultado)
        {
            List<ResultadoApuestas> ListaResultadosApuestas = new List<ResultadoApuestas>();

            return ListaResultadosApuestas;
        }
    }
}
