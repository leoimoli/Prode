﻿using System;
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
                cmd.Parameters.AddWithValue("Liga_in", _torneo.Liga);
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
        public static bool ValidarNroFechaExistente(string nroFecha, string torneo, string temporada, string Liga)
        {
            bool FechaValida = false;
            int idTorneo = BuscaIdtorneoPorNombreTemporada(torneo, temporada, Liga);
            if (idTorneo > 0)
            {

                int FechaExistente = 0;
                connection.Close();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                DataTable Tabla = new DataTable();
                MySqlParameter[] oParam = { new MySqlParameter("idTorneo_in", idTorneo),
                new MySqlParameter("NroFecha_in", nroFecha)};
                string proceso = "ValidarNroFechaExistente";
                MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
                dt.SelectCommand.CommandType = CommandType.StoredProcedure;
                dt.SelectCommand.Parameters.AddRange(oParam);
                dt.Fill(Tabla);
                if (Tabla.Rows.Count > 0)
                {
                    foreach (DataRow item in Tabla.Rows)
                    {
                        FechaExistente = Convert.ToInt32(item["NroFecha"].ToString());
                    }
                }
                if (FechaExistente > 0)
                {
                    FechaValida = false;
                }
                else { FechaValida = true; }
            }
            connection.Close();
            return FechaValida;
        }
        public static List<string> CargarComboLiga()
        {
            List<string> _listaTorneo = new List<string>();
            connection.Close();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { };
            string proceso = "CargarComboLiga";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    _listaTorneo.Add(item["Liga"].ToString());
                }
            }

            connection.Close();
            return _listaTorneo;
        }

        public static bool ValidarFecha(string fecha, string torneo, string temporada, string Liga)
        {
            bool FechaValida = false;
            int idTorneo = BuscaIdtorneoPorNombreTemporada(torneo, temporada, Liga);
            if (idTorneo > 0)
            {
                int CantidadFechas = 0;
                int FechasCargadas = 0;
                connection.Close();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                DataTable Tabla = new DataTable();
                MySqlParameter[] oParam = { new MySqlParameter("idTorneo_in", idTorneo) };
                string proceso = "ContadorDeFechasPorIdTorneo";
                MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
                dt.SelectCommand.CommandType = CommandType.StoredProcedure;
                dt.SelectCommand.Parameters.AddRange(oParam);
                dt.Fill(Tabla);
                if (Tabla.Rows.Count > 0)
                {
                    foreach (DataRow item in Tabla.Rows)
                    {
                        FechasCargadas = Convert.ToInt32(item["totalFechas"].ToString());
                        CantidadFechas = Convert.ToInt32(item["CantidadFechas"].ToString());
                    }
                }
                if (FechasCargadas <= CantidadFechas)
                {
                    FechaValida = true;
                }
                else { FechaValida = false; }
            }
            connection.Close();
            return FechaValida;
        }
        public static int BuscaIdtorneoPorNombreTemporada(string torneo, string Liga, string temporada)
        {
            int idTorneo = 0;
            connection.Close();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { new MySqlParameter("Nombre_in", torneo),
             new MySqlParameter("Temporada_in", temporada),
            new MySqlParameter("Liga_in", Liga)};
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
        public static List<string> CargarComboTorneos(string Liga)
        {
            List<string> _listaTorneo = new List<string>();
            connection.Close();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { new MySqlParameter("Liga_in", Liga) };
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
