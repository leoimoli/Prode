using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prode.Entidades
{
    public class Equipos
    {
        public int idEquipo { get; set; }
        public string NombreEquipo { get; set; }
        public long Escudo { get; set; }
        public int NombreEstadio { get; set; }
        public string Direccion { get; set; }
        public int idUsuario { get; set; }
    }
}
