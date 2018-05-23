using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prode.Negocio
{
    public class Insert
    {
        public static bool GuardarPartido(int equipo1, int equipo2, string estadio, DateTime fecha)
        {
            bool exito = false;
            exito = Dao.InsertDao.GuardarPartido(equipo1, equipo2, estadio, fecha);
            return exito;
        }
    }
}
