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
    public class FechaDao
    {
        private static MySql.Data.MySqlClient.MySqlConnection connection = new MySqlConnection(Properties.Settings.Default.db);
        public static bool GuardarFecha(List<Fecha> _Fecha)
        {
            string Estado = "Pendiente";
            var fecha = _Fecha.First();
            int idTorneo = 0;
            int idFechaCreada = 0;
            bool Exito = false;
            idTorneo = TorneoDao.BuscaIdtorneoPorNombreTemporada(fecha.Torneo, fecha.Temporada, fecha.Liga);
            connection.Close();
            connection.Open();
            string proceso = "GuardarFecha";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Dia_in", fecha.Dia);
            cmd.Parameters.AddWithValue("NroFecha_in", fecha.NroFecha);
            cmd.Parameters.AddWithValue("IdTorneo_in", idTorneo);
            cmd.Parameters.AddWithValue("Estado_in", Estado);
            cmd.Parameters.AddWithValue("ValorJugada_in", fecha.ValorJugada);
            MySqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                idFechaCreada = Convert.ToInt32(r["ID"].ToString());
            }
            if (idFechaCreada > 0)
            {
                Exito = RegistrarPartidos(_Fecha, idFechaCreada);
            }
            connection.Close();
            return Exito;
        }
        public static List<Fecha> BuscarFechaExistente(string torneo, string temporada, string nroFecha, string Liga)
        {
            List<Fecha> lista = new List<Fecha>();
            int idTorneo = TorneoDao.BuscaIdtorneoPorNombreTemporada(torneo, temporada, Liga);
            int idFecha = ValidarNroFecha(idTorneo, nroFecha);
            if (idFecha > 0)
            {
                decimal ValorDeJugada = BuscarValorJugada(idFecha);
                connection.Close();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                DataTable Tabla = new DataTable();
                MySqlParameter[] oParam = {
                                      new MySqlParameter("idFecha_in", idFecha)};
                string proceso = "BuscarFecha";
                MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
                dt.SelectCommand.CommandType = CommandType.StoredProcedure;
                dt.SelectCommand.Parameters.AddRange(oParam);
                dt.Fill(Tabla);
                if (Tabla.Rows.Count > 0)
                {
                    foreach (DataRow item in Tabla.Rows)
                    {
                        Fecha listaFecha = new Fecha();
                        listaFecha.idPartido = Convert.ToInt32(item["idPartido"].ToString());
                        listaFecha.EquipoLocal = item["NombreLocal"].ToString();
                        listaFecha.EquipoVisitante = item["NombreVisitante"].ToString();
                        DateTime dia = Convert.ToDateTime(item["FechaPartido"].ToString());
                        listaFecha.DiaPartido = dia.ToShortDateString();
                        listaFecha.Estadio = item["Estadio"].ToString();
                        listaFecha.ValorJugada = ValorDeJugada;
                        lista.Add(listaFecha);
                    }
                }
            }
            else
            {
                const string message2 = "La fecha ingresada no existe o ya figura como jugada para el torneo seleccionado.";
                const string caption2 = "Error";
                var result2 = MessageBox.Show(message2, caption2,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Error);
                throw new Exception();
            }
            connection.Close();
            return lista;
        }

        private static decimal BuscarValorJugada(int idFecha)
        {
            connection.Close();
            decimal Valor = 0;
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                        new MySqlParameter("idFecha_in", idFecha)};
            string proceso = "BuscarValorJugada";
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
                    Valor = Convert.ToDecimal(item["ValorJugada"].ToString());
                }
            }
            connection.Close();
            return Valor;
        }

        private static int ValidarNroFecha(int idTorneo, string nroFecha)
        {
            connection.Close();
            int idFecha = 0;
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("idTorneo_in", idTorneo),
            new MySqlParameter("nroFecha_in", nroFecha)};
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
        private static bool RegistrarPartidos(List<Fecha> _Fecha, int idFechaCreada)
        {
            bool Exito = false;
            _Fecha = BuscarIdEquipos(_Fecha);
            foreach (var item in _Fecha)
            {
                connection.Close();
                connection.Open();
                string proceso = "GuardarPartidos";
                MySqlCommand cmd = new MySqlCommand(proceso, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("EquipoLocal_in", item.IdEquipoLocal);
                cmd.Parameters.AddWithValue("EquipoVisitante_in", item.IdEquipoVisitante);
                cmd.Parameters.AddWithValue("Dia_in", item.Dia);
                cmd.Parameters.AddWithValue("Estadio_in", item.Estadio);
                cmd.Parameters.AddWithValue("idFechaCreada_in", idFechaCreada);
                cmd.ExecuteNonQuery();
            }
            Exito = true;
            connection.Close();
            return Exito;
        }
        private static List<Fecha> BuscarIdEquipos(List<Fecha> _Fecha)
        {
            connection.Close();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            DataTable Tabla2 = new DataTable();
            foreach (var item in _Fecha)
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
            return _Fecha;
        }
    }
}
