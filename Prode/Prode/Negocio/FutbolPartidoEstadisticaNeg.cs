using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prode.Entidades;
using Prode.Dao;

namespace Prode.Negocio
{
    public class FutbolPartidoEstadisticaNeg
    {
        public static bool GuardarPartido(PartidoEstadistica _partido)
        {
            bool exito = false;
            try
            {
                ValidarDatos(_partido);
                exito = FutbolPartidoEstadisticaDao.GuardarPartido(_partido);
            }
            catch (Exception ex)
            {

            }
            return exito;
        }

        private static void ValidarDatos(PartidoEstadistica _partido)
        {
            throw new NotImplementedException();
        }
    }
}
