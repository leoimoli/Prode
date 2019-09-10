using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prode.Entidades
{
    public class Torneo
    {
        public int idTorneo { get; set; }
        public string NombreTorneo { get; set; }
        public int CantidadFechas { get; set; }
        public string Temporada { get; set; }
    }
}
