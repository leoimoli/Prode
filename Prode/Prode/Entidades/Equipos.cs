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
        public byte[] Escudo { get; set; }
        public string NombreEstadio { get; set; }
        public string Direccion { get; set; }
        public int idUsuario { get; set; }
        public int TiraInfantiles { get; set; }
        public int TiraJuveniles { get; set; }
        public int TiraMayores { get; set; }
    }
}
