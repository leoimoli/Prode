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
