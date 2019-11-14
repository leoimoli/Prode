using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prode.Entidades
{
    public class DetallePartido
    {
        public int idPartido { get; set; }
        public int idEquipoLocal { get; set; }
        public int idEquipoVisitante { get; set; }
        public byte[] EscudoLocal { get; set; }
        public byte[] EscudoVisitante { get; set; }
        public string Marcador { get; set; }
        public int Resultado { get; set; }
        public string Estadio { get; set; }

    }
}
