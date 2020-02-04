using Prode.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prode.Negocio
{
    public class FutbolEstadisticaJugadorNeg
    {
        public static bool GuardarEstadisticaJugador(List<string> listaEstadistica, string sistemaTactico, int idEquipos, int idPartidos)
        {
            bool exito = false;
            try
            {
                //ValidarDatos(_equipo);
                exito = FutbolEstadisticaJugadorDao.GuardarEstadisticaJugador(listaEstadistica, sistemaTactico, idEquipos, idPartidos);
            }
            catch (Exception ex)
             {

            }
            return exito;
        }
    }
}
