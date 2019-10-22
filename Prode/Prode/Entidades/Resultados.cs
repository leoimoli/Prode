using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prode.Entidades
{
    public class Resultados
    {
        public int idPartido { get; set; }
        public int IdEquipoLocal { get; set; }
        public int IdEquipoVisitante { get; set; }
        public string EquipoLocal { get; set; }
        public int MarcadorLocal { get; set; }
        public int MarcadorVisitante { get; set; }
        public string EquipoVisitante { get; set; }
        public int idTipoResultado { get; set; }
        public int idUsuario { get; set; }

    }
}
