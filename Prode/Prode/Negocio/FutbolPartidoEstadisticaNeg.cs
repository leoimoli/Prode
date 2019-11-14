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
                idPartido = FutbolPartidoEstadisticaDao.GuardarPartido(_partido);
            }
            catch (Exception ex)
            {

            }
            return idPartido;
        }       

        public static List<DetallePartido> BuscarPartidoPorNombre(string partido)
        {
            List<DetallePartido> _detallePartido = new List<DetallePartido>();
            try
            {
                _detallePartido = FechaDao.BuscarPartidoPorNombre(partido);
            }
            catch (Exception ex)
            {
            }
            return _detallePartido;
        }
    }
}
