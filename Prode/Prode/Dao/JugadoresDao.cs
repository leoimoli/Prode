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
    public class JugadoresDao
    {
        private static MySql.Data.MySqlClient.MySqlConnection connection = new MySqlConnection(Properties.Settings.Default.db);
        public static int InsertJugador(Jugadores _jugadores)
        {
            int sexo;
            int Estado = 1;
            if (_jugadores.Sexo == "Masculino")
            {
                sexo = 1;
            }
            else
            {
                sexo = 0;
            }
            int id = 0;
            connection.Close();
            connection.Open();
            string proceso = "GuardarJugador";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Apellido_in", _jugadores.Apellido);
            cmd.Parameters.AddWithValue("Nombre_in", _jugadores.Nombre);
            cmd.Parameters.AddWithValue("Dni_in", _jugadores.Dni);
            cmd.Parameters.AddWithValue("Sexo_in", sexo);
            cmd.Parameters.AddWithValue("Apodo_in", _jugadores.Apodo);
            cmd.Parameters.AddWithValue("FechaNacimiento_in", _jugadores.FechaNacimiento);
            cmd.Parameters.AddWithValue("Altura_in", _jugadores.Altura);
            cmd.Parameters.AddWithValue("Peso_in", _jugadores.Peso);
            cmd.Parameters.AddWithValue("imagen_in", _jugadores.Imagen);
            cmd.Parameters.AddWithValue("idUsuario_in", _jugadores.idUsuario);
            cmd.Parameters.AddWithValue("Estado_in", Estado);
            MySqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                id = Convert.ToInt32(r["ID"].ToString());
            }
            connection.Close();
            return id;
        }
        public static bool EditarJugador(Jugadores _jugadores, int idJugador)
        {
            bool exito = false;
            connection.Close();
            connection.Open();
            string proceso = "EditarJugador";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Dni_in", _jugadores.Dni);
            cmd.Parameters.AddWithValue("Apodo_in", _jugadores.Apodo);
            cmd.Parameters.AddWithValue("FechaNacimiento_in", _jugadores.FechaNacimiento);
            cmd.Parameters.AddWithValue("Altura_in", _jugadores.Altura);
            cmd.Parameters.AddWithValue("Peso_in", _jugadores.Peso);
            cmd.Parameters.AddWithValue("Imagen_in", _jugadores.Imagen);
            cmd.Parameters.AddWithValue("idJugador_in", idJugador);
            cmd.ExecuteNonQuery();
            exito = true;
            connection.Close();
            return exito;
        }

        public static bool AltaFichaTecnica(FichaTecnica _fichaJugadores)
        {
            bool Exito = false;
            connection.Close();
            connection.Open();
            string proceso = "AltaFichaTecnica";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("PosicionDeCampo_in", _fichaJugadores.PosicionDeCampo);
            cmd.Parameters.AddWithValue("PiernaHabil_in", _fichaJugadores.PiernaHabil);
            ///// Cualidades Fisicas
            cmd.Parameters.AddWithValue("Salto_in", _fichaJugadores.Salto);
            cmd.Parameters.AddWithValue("Velocidad_in", _fichaJugadores.Velocidad);
            cmd.Parameters.AddWithValue("Resistencia_in", _fichaJugadores.Resistencia);
            cmd.Parameters.AddWithValue("Fuerza_in", _fichaJugadores.Fuerza);
            ///// Cualidades Tecnicas
            cmd.Parameters.AddWithValue("ControlDeBalon_in", _fichaJugadores.ControlDeBalon);
            cmd.Parameters.AddWithValue("Regates_in", _fichaJugadores.Regates);
            cmd.Parameters.AddWithValue("Definicion_in", _fichaJugadores.Definicion);
            cmd.Parameters.AddWithValue("Marcaje_in", _fichaJugadores.Marcaje);
            cmd.Parameters.AddWithValue("PaseCorto_in", _fichaJugadores.PaseCorto);
            cmd.Parameters.AddWithValue("PaseLargo_in", _fichaJugadores.PaseLargo);
            cmd.Parameters.AddWithValue("Remate_in", _fichaJugadores.Remate);
            cmd.Parameters.AddWithValue("TiroLibre_in", _fichaJugadores.TiroLibre);
            ///// Cualidades tacticas
            cmd.Parameters.AddWithValue("DisciplinaTactica_in", _fichaJugadores.DisciplinaTactica);
            cmd.Parameters.AddWithValue("NivelDefensivo_in", _fichaJugadores.NivelDefensivo);
            cmd.Parameters.AddWithValue("NivelOfensivo_in", _fichaJugadores.NivelOfensivo);

            cmd.Parameters.AddWithValue("IdJugador_in", _fichaJugadores.IdJugador);
            cmd.ExecuteNonQuery();
            connection.Close();
            Exito = true;
            return Exito;
        }
        public static bool EditarFichaTecnicaJugador(FichaTecnica _fichaJugadores)
        {
            bool Exito = false;
            connection.Close();
            connection.Open();
            string proceso = "EditarFichaTecnicaJugador";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("PosicionDeCampo_in", _fichaJugadores.PosicionDeCampo);
            cmd.Parameters.AddWithValue("PiernaHabil_in", _fichaJugadores.PiernaHabil);
            ///// Cualidades Fisicas
            cmd.Parameters.AddWithValue("Salto_in", _fichaJugadores.Salto);
            cmd.Parameters.AddWithValue("Velocidad_in", _fichaJugadores.Velocidad);
            cmd.Parameters.AddWithValue("Resistencia_in", _fichaJugadores.Resistencia);
            cmd.Parameters.AddWithValue("Fuerza_in", _fichaJugadores.Fuerza);
            ///// Cualidades Tecnicas
            cmd.Parameters.AddWithValue("ControlDeBalon_in", _fichaJugadores.ControlDeBalon);
            cmd.Parameters.AddWithValue("Regates_in", _fichaJugadores.Regates);
            cmd.Parameters.AddWithValue("Definicion_in", _fichaJugadores.Definicion);
            cmd.Parameters.AddWithValue("Marcaje_in", _fichaJugadores.Marcaje);
            cmd.Parameters.AddWithValue("PaseCorto_in", _fichaJugadores.PaseCorto);
            cmd.Parameters.AddWithValue("PaseLargo_in", _fichaJugadores.PaseLargo);
            cmd.Parameters.AddWithValue("Remate_in", _fichaJugadores.Remate);
            cmd.Parameters.AddWithValue("TiroLibre_in", _fichaJugadores.TiroLibre);
            ///// Cualidades tacticas
            cmd.Parameters.AddWithValue("DisciplinaTactica_in", _fichaJugadores.DisciplinaTactica);
            cmd.Parameters.AddWithValue("NivelDefensivo_in", _fichaJugadores.NivelDefensivo);
            cmd.Parameters.AddWithValue("NivelOfensivo_in", _fichaJugadores.NivelOfensivo);

            cmd.Parameters.AddWithValue("IdJugador_in", _fichaJugadores.IdJugador);
            cmd.ExecuteNonQuery();
            connection.Close();
            Exito = true;
            return Exito;
        }
        public static List<FichaTecnica> BuscarFichaTecnicaPorIdJugador(int idJugador)
        {
            connection.Close();
            connection.Open();
            List<Entidades.FichaTecnica> lista = new List<Entidades.FichaTecnica>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                       new MySqlParameter("idJugador_in", idJugador)};
            string proceso = "BuscarFichaTecnicaPorIdJugador";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    FichaTecnica FichaTecnica = new FichaTecnica();
                    FichaTecnica.PosicionDeCampo = item["PosicionDeCampo"].ToString();
                    FichaTecnica.PiernaHabil = item["PiernaHabil"].ToString();
                    FichaTecnica.Velocidad = item["Velocidad"].ToString();
                    FichaTecnica.Resistencia = item["Resistencia"].ToString();
                    FichaTecnica.Salto = item["Salto"].ToString();
                    FichaTecnica.Fuerza = item["Fuerza"].ToString();
                    FichaTecnica.ControlDeBalon = item["ControlDeBalon"].ToString();
                    FichaTecnica.Regates = item["Regates"].ToString();
                    FichaTecnica.PaseCorto = item["PaseCorto"].ToString();
                    FichaTecnica.PaseLargo = item["PaseLargo"].ToString();
                    FichaTecnica.Definicion = item["Definicon"].ToString();
                    FichaTecnica.Remate = item["Remate"].ToString();
                    FichaTecnica.TiroLibre = item["TiroLibre"].ToString();
                    FichaTecnica.Marcaje = item["Marcaje"].ToString();
                    FichaTecnica.DisciplinaTactica = item["DisciplinaTactica"].ToString();
                    FichaTecnica.NivelDefensivo = item["NivelDefensivo"].ToString();
                    FichaTecnica.NivelOfensivo = item["NivelOfensivo"].ToString();
                    lista.Add(FichaTecnica);
                }
            }
            connection.Close();
            return lista;
        }
        public static bool EliminarJugador(int idjugador)
        {
            int Estado = 0;
            bool exito = false;
            connection.Close();
            connection.Open();
            string proceso = "EliminarJugador";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Estado_in", Estado);
            cmd.Parameters.AddWithValue("idJugador_in", idjugador);
            cmd.ExecuteNonQuery();
            exito = true;
            connection.Close();
            return exito;
        }
        public static List<string> CargarComboPuestos()
        {
            List<string> _listaPuestos = new List<string>();
            connection.Close();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            string proceso = "CargarComboPuestos";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    _listaPuestos.Add(item["Puesto"].ToString());
                }
            }

            connection.Close();
            return _listaPuestos;
        }
        public static List<string> CargarComboPosiciones(string puesto)
        {
            List<string> _listaPosiciones = new List<string>();
            connection.Close();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { new MySqlParameter("Puesto_in", puesto) };
            string proceso = "CargarComboPosiciones";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    _listaPosiciones.Add(item["Posicion"].ToString());
                }
            }

            connection.Close();
            return _listaPosiciones;
        }
        public static List<Jugadores> BuscarJugadoresPorApellidoYNombre(string apellidoNombre)
        {
            string var = apellidoNombre;
            string Apellido = var.Split(' ')[0];
            string Nombre = var.Split(' ')[1];

            connection.Close();
            connection.Open();
            List<Entidades.Jugadores> lista = new List<Entidades.Jugadores>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("Apellido_in", Apellido),
            new MySqlParameter("Nombre_in", Nombre)};
            string proceso = "BuscarJugadoresPorApellidoYNombre";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Jugadores listaJugadores = new Jugadores();
                    listaJugadores.idJugador = Convert.ToInt32(item["idPersonaFisicaJugador"].ToString());
                    listaJugadores.Apellido = item["Apellido"].ToString();
                    listaJugadores.Nombre = item["Nombre"].ToString();
                    listaJugadores.Dni = item["Dni"].ToString();
                    string Sexo = item["Sexo"].ToString();
                    if (Sexo == "1")
                    { Sexo = "Masculino"; }
                    if (Sexo == "0")
                    { Sexo = "Femenino"; }
                    listaJugadores.Sexo = Sexo;
                    listaJugadores.Apodo = item["Apodo"].ToString();
                    listaJugadores.FechaNacimiento = Convert.ToDateTime(item["FechaNacimiento"].ToString());
                    listaJugadores.Peso = item["Peso"].ToString();
                    listaJugadores.Altura = item["Altura"].ToString();
                    if (item[8].ToString() != string.Empty)
                    {
                        listaJugadores.Imagen = (byte[])item["ImagenJugador"];
                    }
                    lista.Add(listaJugadores);
                }
            }
            else
            {
                const string message2 = "El jugador seleccionado no existe o su estado es 'INACTIVO'.";
                const string caption2 = "Atención";
                var result2 = MessageBox.Show(message2, caption2,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Exclamation);
            }
            connection.Close();
            return lista;
        }
    }
}
