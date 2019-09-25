using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prode.Entidades;
using Prode.Dao;

namespace Prode.Negocio
{
    public class ResultadoNeg
    {
        public static bool GaurdarResultados(List<Resultados> _listaResultado)
        {
            bool exito = false;
            try
            {
                exito = ResultadoDao.GaurdarResultados(_listaResultado);
            }
            catch (Exception ex)
            {

            }
            return exito;
        }
    }
}
