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
            bool exito = false;
            connection.Close();
            connection.Open();
            string proceso = "GuardarApostador";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Apellido_in", _apostador.Apellido);
            cmd.Parameters.AddWithValue("Nombre_in", _apostador.Nombre);
            cmd.Parameters.AddWithValue("Dni_in", _apostador.Dni);
            cmd.Parameters.AddWithValue("Sexo_in", _apostador.Sexo);
            cmd.Parameters.AddWithValue("Telefono_in", _apostador.Telefono);
            cmd.Parameters.AddWithValue("Email_in", _apostador.Email);
            cmd.ExecuteNonQuery();
            exito = true;
            connection.Close();
            return exito;
        }
    }
}
