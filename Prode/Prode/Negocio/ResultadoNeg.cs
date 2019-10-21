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
        public static List<Resultados> BuscarResultados(string torneo, string temporada, string nroFecha, string Liga)
        {
            List<Resultados> _listaReusltados = new List<Resultados>();
            try
            {
                _listaReusltados = ResultadoDao.BuscarResultados(torneo, temporada, nroFecha, Liga);
            }
            catch (Exception ex)
            {
            }
            return _listaReusltados;
        }
        public static List<Resultados> BuscarDetalleApuestaPorPartido(List<Resultados> listaEstatica, string NroJugada)
        {
            List<Resultados> _listaReusltados = new List<Resultados>();
            try
            {
                _listaReusltados = ResultadoDao.BuscarDetalleApuestaPorPartido(listaEstatica, NroJugada);
            }
            catch (Exception ex)
            {
            }
            return _listaReusltados;
        }
    }
}
