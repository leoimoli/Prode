using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prode.Entidades
{
    public class ResultadoApuestas
    {
        public int idApostador { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public int Aciertos { get; set; }
    }
}
