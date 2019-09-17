using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prode.Entidades;
using MySql.Data.MySqlClient;
using System.Data;

namespace Prode.Dao
{
    public class FechaDao
    {
        private static MySql.Data.MySqlClient.MySqlConnection connection = new MySqlConnection(Properties.Settings.Default.db);
        public static bool GuardarFecha(List<Fecha> _Fecha)
        {
            var fecha = _Fecha.First();
            int idTorneo = 0;
            int idFechaCreada = 0;
            bool Exito = false;
            idTorneo = TorneoDao.BuscaIdtorneoPorNombreTemporada(fecha.Torneo, fecha.Temporada);
            connection.Close();
            connection.Open();
            string proceso = "GuardarFecha";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Dia_in", fecha.Dia);
            cmd.Parameters.AddWithValue("NroFecha_in", fecha.NroFecha);
            cmd.Parameters.AddWithValue("IdTorneo_in", idTorneo);
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
