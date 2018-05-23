using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Prode.Dao
{
    public class Consultar
    {
        private static SqlConnection connection = new SqlConnection(Properties.Settings.Default.db);
        //private static MySql.Data.MySqlClient.MySqlConnection connection = new MySqlConnection(Properties.Settings.Default.db);
        public static List<string> CargarComboSelecciones()
        {
            connection.Close();
            connection.Open();
            List<string> _listaSelecciones = new List<string>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            SqlParameter[] oParam = { };
            string proceso = "EquipoBuscarTodos";
            SqlDataAdapter dt = new SqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    _listaSelecciones.Add(item["IdEquipo"].ToString() +";"+ item["Nombre"].ToString());
                    //_listaSelecciones.Add(item["Nombre"].ToString());
                }
            }
            connection.Close();
            return _listaSelecciones;
        }
    }
}
