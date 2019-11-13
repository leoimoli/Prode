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
    public class FutbolPartidoEstadisticaDao
    {
        private static MySql.Data.MySqlClient.MySqlConnection connection = new MySqlConnection(Properties.Settings.Default.db);
        public static bool GuardarPartido(PartidoEstadistica _partido)
        {
            int idTorneo = 0;
            int idPartido = 0;
            bool Exito = false;
            idTorneo = TorneoDao.BuscaIdtorneoPorNombreTemporada(_partido.Torneo, _partido.Temporada, _partido.Liga);
            connection.Close();
            connection.Open();
            string proceso = "FutbolGuardarPartido";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Fecha_in", _partido.Fecha);
            cmd.Parameters.AddWithValue("idEquipoLocal_in", _partido.idEquipoLocal);
            cmd.Parameters.AddWithValue("Marcador_in", _partido.Marcador);
            cmd.Parameters.AddWithValue("Resultado_in", _partido.Resultado);
            cmd.Parameters.AddWithValue("idTorneo_in", idTorneo);
            cmd.Parameters.AddWithValue("idEquipoVisitante_in", _partido.idEquipoVisitante);
            cmd.Parameters.AddWithValue("Estadio_in", _partido.Estadio);
            cmd.Parameters.AddWithValue("NroFecha_in", _partido.NroFecha);
            cmd.Parameters.AddWithValue("NombrePartido_in", _partido.NombrePartido);
            MySqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                idPartido = Convert.ToInt32(r["ID"].ToString());
            }
            if (idPartido > 0)
            {
                Exito = RegistrarDatellePartido(_partido, idPartido);
            }
            connection.Close();
            return Exito;
        }

        private static bool RegistrarDatellePartido(PartidoEstadistica _partido, int idPartido)
        {
            bool Exito = false;
            connection.Close();
            connection.Open();
            string proceso = "FutbolGuardarPartido";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("CornersLocal_in", _partido.CornersLocal);
            cmd.Parameters.AddWithValue("CornersVisitante_in", _partido.CornersVisitante);
            cmd.Parameters.AddWithValue("FaltasLocal_in", _partido.FaltasLocal);
            cmd.Parameters.AddWithValue("FaltasVisitante_in", _partido.FaltasVisitante);
            cmd.Parameters.AddWithValue("PenalesLocal_in", _partido.PenalesLocal);
            cmd.Parameters.AddWithValue("PenalesVisitante_in", _partido.PenalesVisitante);
            cmd.Parameters.AddWithValue("OffsideLocal_in", _partido.OffsideLocal);
            cmd.Parameters.AddWithValue("OffsideVisitante_in", _partido.OffsideVisitante);
            cmd.Parameters.AddWithValue("RematesLocal_in", _partido.RematesLocal);
            cmd.Parameters.AddWithValue("RematesVisitante_in", _partido.RematesVisitante);
            cmd.Parameters.AddWithValue("TirosAlArcoLocal_in", _partido.TirosAlArcoLocal);
            cmd.Parameters.AddWithValue("TirosAlArcoVisitante_in", _partido.TirosAlArcoVisitante);
            cmd.Parameters.AddWithValue("PasesCorrectosLocal_in", _partido.PasesCorrectosLocal);
            cmd.Parameters.AddWithValue("PasesCorrectosVisitante_in", _partido.PasesCorrectosVisitante);
            cmd.Parameters.AddWithValue("PosesionLocal_in", _partido.PosesionLocal);
            cmd.Parameters.AddWithValue("PosesionVisitante_in", _partido.PosesionVisitante);
            Exito = true;
            connection.Close();
            return Exito;
        }
    }
}
