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
        public static int GuardarPartido(PartidoEstadistica _partido)
        {
            int idPartido = 0;
            try
            {
                ValidarDatos(_partido);
                idPartido = FutbolPartidoEstadisticaDao.GuardarPartido(_partido);
            }
            catch (Exception ex)
            {

            }
            return idPartido;
        }

        private static void ValidarDatos(PartidoEstadistica _partido)
        {
            throw new NotImplementedException();
        }
    }
}
