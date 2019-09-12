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
    public class EquipoDao
    {
        private static MySql.Data.MySqlClient.MySqlConnection connection = new MySqlConnection(Properties.Settings.Default.db);
        public static bool EditarEquipo(Equipos _equipo)
        {
            bool exito = false;
            connection.Close();
            connection.Open();
            string proceso = "EditarEquipo";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("NombreEquipo_in", _equipo.NombreEquipo);
            cmd.Parameters.AddWithValue("Escudo_in", _equipo.Escudo);
            cmd.Parameters.AddWithValue("NombreEstadio_in", _equipo.NombreEstadio);
            cmd.Parameters.AddWithValue("Direccion_in", _equipo.Direccion);
            cmd.Parameters.AddWithValue("idUsuario_in", _equipo.idUsuario);
            cmd.ExecuteNonQuery();
            exito = true;
            connection.Close();
            return exito;
        }
        public static bool InsertEquipo(Equipos _equipo)
        {
            bool exito = false;
            connection.Close();
            connection.Open();
            string proceso = "AltaEquipo";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("NombreEquipo_in", _equipo.NombreEquipo);
            cmd.Parameters.AddWithValue("Escudo_in", _equipo.Escudo);
            cmd.Parameters.AddWithValue("NombreEstadio_in", _equipo.NombreEstadio);
            cmd.Parameters.AddWithValue("Direccion_in", _equipo.Direccion);
            cmd.Parameters.AddWithValue("idUsuario_in", _equipo.idUsuario);
            cmd.ExecuteNonQuery();
            exito = true;
            connection.Close();
            return exito;
        }

        public static List<string> CargarComboEquipo()
        {
            List<string> _listaEquipos = new List<string>();
            connection.Close();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { };
            string proceso = "CargarComboEquipo";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    _listaEquipos.Add(item["Nombre"].ToString());
                }
            }

            connection.Close();
            return _listaEquipos;
        }

        public static List<string> CargarComboEstadios()
        {
            List<string> _listaEstadios = new List<string>();
            connection.Close();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { };
            string proceso = "CargarComboEstadios";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    _listaEstadios.Add(item["Estadio"].ToString());
                }
            }

            connection.Close();
            return _listaEstadios;
        }

        public static byte[] BuscarImagenEquipoLocal(string nombreEquipoLocal)
        {
            byte[] _escudoLocal = null;
            connection.Close();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { new MySqlParameter("NombreEquipoLocal_in", nombreEquipoLocal) };
            string proceso = "BuscarImagenEquipoLocal";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    if (item[0].ToString() != string.Empty)
                    {
                        _escudoLocal = (byte[])item["Escudo"];
                    }
                }
            }

            connection.Close();
            return _escudoLocal;
        }

        public static bool ValidarEquipoExistente(string nombreEquipo)
        {
            connection.Close();
            bool Existe = false;
            connection.Open();
            List<Equipos> lista = new List<Equipos>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("NombreEquipo_in", nombreEquipo)};
            string proceso = "ValidarEquipoExistente";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            DataSet ds = new DataSet();
            dt.Fill(ds, "Equipo");
            if (Tabla.Rows.Count > 0)
            {
                Existe = true;
            }
            connection.Close();
            return Existe;
        }

        public static List<Equipos> BuscarEquipoPorNombre(string nombre)
        {
            connection.Close();
            connection.Open();
            List<Entidades.Equipos> lista = new List<Entidades.Equipos>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("Nombre_in", nombre)};
            string proceso = "BuscarEquipoPorNombre";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Equipos equipos = new Equipos();
                    equipos.NombreEquipo = item["Nombre"].ToString();
                    if (item[2].ToString() != string.Empty)
                    {
                        equipos.Escudo = (byte[])item["Escudo"];
                    }
                    equipos.NombreEstadio = item["Estadio"].ToString();
                    equipos.Direccion = item["DomicilioEstadio"].ToString();
                    lista.Add(equipos);
                }
            }
            connection.Close();
            return lista;
        }
    }
}
