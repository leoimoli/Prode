using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prode.Entidades
{
    public class JugadorEstadisticaPartido
    {
        public int idJugador { get; set; }
        public int Minutos { get; set; }
        public int Goles { get; set; }
        public int Amarillas { get; set; }
        public int Rojas { get; set; }
        public int PJ { get; set; }
    }
}
