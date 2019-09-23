using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prode.Entidades;
using Prode.Dao;

namespace Prode.Negocio
{
    public class JugadaNeg
    {
        public static bool GuardarJugada(List<Jugada> _listaJugada)
        {
            bool exito = false;
            try
            {
                exito = JugadaDao.GuardarJugada(_listaJugada);
            }
            catch (Exception ex)
            {

            }
            return exito;
        }
    }
}
