using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prode.Entidades;
using Prode.Dao;

namespace Prode.Negocio
{
    public class FechaNeg
    {
        public static bool GuardarFecha(List<Fecha> _Fecha)
        {
            bool exito = false;
            try
            {
                //ValidarDatos(_Fecha);
                exito = FechaDao.GuardarFecha(_Fecha);
            }
            catch (Exception ex)
            {

            }
            return exito;
        }
        private static void ValidarDatos(List<Fecha> _Fecha)
        {
            throw new NotImplementedException();
        }
    }
}
