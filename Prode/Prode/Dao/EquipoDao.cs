using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prode.Entidades;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;

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

            if (_equipo.TiraInfantiles == 1)
            {
                List<int> TiraInfantiles = new List<int>();
                for (int i = 2007; i < 2015; i++)
                {
                    TiraInfantiles.Add(i);
                }
                foreach (var item in TiraInfantiles)
                {
                    connection.Close();
                    connection.Open();
                    string proceso = "AltaEquipo";
                    MySqlCommand cmd = new MySqlCommand(proceso, connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("NombreEquipo_in", _equipo.NombreEquipo + " " +  item);
                    cmd.Parameters.AddWithValue("Escudo_in", _equipo.Escudo);
                    cmd.Parameters.AddWithValue("NombreEstadio_in", _equipo.NombreEstadio);
                    cmd.Parameters.AddWithValue("Direccion_in", _equipo.Direccion);
                    cmd.Parameters.AddWithValue("idUsuario_in", _equipo.idUsuario);
                    cmd.ExecuteNonQuery();
                    exito = true;
                }
            }
            if (_equipo.TiraJuveniles == 1)
            {
                List<string> TiraJuveniles = new List<string>();
                string Cuarta = "4ta";
                TiraJuveniles.Add(Cuarta);
                string Quinta = "5ta";
                TiraJuveniles.Add(Quinta);
                string Sexta = "6ta";
                TiraJuveniles.Add(Sexta);
                string Septima = "7ma";
                TiraJuveniles.Add(Septima);
                string Octava = "8va";
                TiraJuveniles.Add(Octava);
                string Novena = "9na";
                TiraJuveniles.Add(Novena);
                string PreNovena = "Pre-9na";
                TiraJuveniles.Add(PreNovena);
                foreach (var item in TiraJuveniles)
                {
                    connection.Close();
                    connection.Open();
                    string proceso = "AltaEquipo";
                    MySqlCommand cmd = new MySqlCommand(proceso, connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("NombreEquipo_in", _equipo.NombreEquipo + " " + item);
                    cmd.Parameters.AddWithValue("Escudo_in", _equipo.Escudo);
                    cmd.Parameters.AddWithValue("NombreEstadio_in", _equipo.NombreEstadio);
                    cmd.Parameters.AddWithValue("Direccion_in", _equipo.Direccion);
                    cmd.Parameters.AddWithValue("idUsuario_in", _equipo.idUsuario);
                    cmd.ExecuteNonQuery();
                    exito = true;
                }
            }
            if (_equipo.TiraMayores == 1)
            {
                List<string> TiraMayores = new List<string>();
                string Reserva = "Reserva";
                TiraMayores.Add(Reserva);
                string Primera = "1ra";
                TiraMayores.Add(Primera);
                foreach (var item in TiraMayores)
                {
                    connection.Close();
                    connection.Open();
                    string proceso = "AltaEquipo";
                    MySqlCommand cmd = new MySqlCommand(proceso, connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("NombreEquipo_in", _equipo.NombreEquipo + " " + item);
                    cmd.Parameters.AddWithValue("Escudo_in", _equipo.Escudo);
                    cmd.Parameters.AddWithValue("NombreEstadio_in", _equipo.NombreEstadio);
                    cmd.Parameters.AddWithValue("Direccion_in", _equipo.Direccion);
                    cmd.Parameters.AddWithValue("idUsuario_in", _equipo.idUsuario);
                    cmd.ExecuteNonQuery();
                    exito = true;
                }
            }
            if (_equipo.TiraInfantiles == 0 && _equipo.TiraJuveniles == 0 && _equipo.TiraMayores == 0)
            {
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
            }

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
        public static string urla;
        public static List<PlantelActual> BuscarPlantelActual(int idEquipo)
        {
            connection.Close();
            connection.Open();
            List<PlantelActual> lista = new List<PlantelActual>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("idEquipo_in", idEquipo)};
            string proceso = "BuscarPlantelActual";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    PlantelActual plantel = new PlantelActual();
                    plantel.idJugador = Convert.ToInt32(item["idJugador"].ToString());
                    plantel.Apellido = item["Apellido"].ToString();
                    plantel.Nombre = item["Nombre"].ToString();
                    plantel.PosicionDeCampo = item["PosicionDeCampo"].ToString();
                    lista.Add(plantel);
                }
            }
            connection.Close();
            return lista;
        }
        public static bool ValidarJugadorYaAsignadoAlEquipo(int idJugador, int idEquipoSeleccionado)
        {
            connection.Close();
            bool Existe = false;
            connection.Open();
            List<Equipos> lista = new List<Equipos>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("idJugador_in", idJugador),
            new MySqlParameter("idEquipoSeleccionado_in", idEquipoSeleccionado)};
            string proceso = "ValidarJugadorYaAsignadoAlEquipo";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            DataSet ds = new DataSet();
            dt.Fill(ds, "FutbolAsignacionJugadorPorEquipo");
            if (Tabla.Rows.Count > 0)
            {
                Existe = true;
            }
            connection.Close();
            return Existe;
        }
        public static bool CargaMasivaDeAsignaciones(List<int> listaId, int idEquipoSeleccionado)
        {
            bool exito = false;
            connection.Close();
            connection.Open();
            foreach (var item in listaId)
            {
                DateTime FechaAsignacion = DateTime.Now;
                string proceso = "AsignarJugadorEquipo";
                MySqlCommand cmd = new MySqlCommand(proceso, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("idJugador_in", item);
                cmd.Parameters.AddWithValue("idEquipoSeleccionado_in", idEquipoSeleccionado);
                cmd.Parameters.AddWithValue("FechaAsignacion_in", FechaAsignacion);
                cmd.ExecuteNonQuery();
                exito = true;
            }
            connection.Close();
            return exito;
        }
        public static bool AsignarJugadorEquipo(int idJugador, int idEquipoSeleccionado)
        {
            bool exito = false;
            connection.Close();
            connection.Open();
            DateTime FechaAsignacion = DateTime.Now;
            string proceso = "AsignarJugadorEquipo";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("idJugador_in", idJugador);
            cmd.Parameters.AddWithValue("idEquipoSeleccionado_in", idEquipoSeleccionado);
            cmd.Parameters.AddWithValue("FechaAsignacion_in", FechaAsignacion);
            cmd.ExecuteNonQuery();
            exito = true;
            connection.Close();
            return exito;
        }
        public static string BuscarEstadioPorEquipoLocalSeleccionado(string equipoLocal)
        {
            string _EstadioLocal = null;
            connection.Close();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { new MySqlParameter("Nombre_in", equipoLocal) };
            string proceso = "BuscarEstadioPorEquipoLocalSeleccionado";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    _EstadioLocal = item["Estadio"].ToString();
                }
            }

            connection.Close();
            return _EstadioLocal;
        }
        public static bool EliminarEquipo(int idEquipo)
        {
            bool exito = false;
            connection.Close();
            connection.Open();
            string proceso = "EliminarEquipo";
            int Estado = 0;
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("idEquipo_in", idEquipo);
            cmd.Parameters.AddWithValue("Estado_in", Estado);
            cmd.ExecuteNonQuery();
            exito = true;
            connection.Close();
            return exito;
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
                    equipos.idEquipo = Convert.ToInt32(item["idEquipo"].ToString());
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
