using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prode.Entidades
{
    public class Fecha
    {
        public int idFecha { get; set; }
        public string Torneo { get; set; }
        public string Temporada { get; set; }
        public int idTorneo { get; set; }
        public DateTime Dia { get; set; }
        public string NroFecha { get; set; }
        public string EquipoLocal { get; set; }
        public string EquipoVisitante { get; set; }
        public string Estadio { get; set; }
        public int IdEquipoLocal { get; set; }
        public int IdEquipoVisitante { get; set; }
        public int idUsuario { get; set; }
        public int idPartido { get; set; }
        public string DiaPartido { get; set; }
        public string CondicionLocal { get; set; }
        public string CondicionVisitante { get; set; }
        public string CondicionEmpate { get; set; }
        public string Estado { get; set; }
        public decimal  ValorJugada { get; set; }
        public string Liga { get; set; }
    }
}
