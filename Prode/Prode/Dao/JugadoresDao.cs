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
    public class JugadoresDao
    {
        private static MySql.Data.MySqlClient.MySqlConnection connection = new MySqlConnection(Properties.Settings.Default.db);
        public static int InsertJugador(Jugadores _jugadores)
        {
            int sexo;
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
            MySqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                id = Convert.ToInt32(r["ID"].ToString());
            }
            connection.Close();
            return id;
        }
    }
}
