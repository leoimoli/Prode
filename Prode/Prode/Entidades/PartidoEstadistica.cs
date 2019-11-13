using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prode.Entidades
{
    public class PartidoEstadistica
    {
        public int idPartido { get; set; }
        public DateTime Fecha { get; set; }
        public int idEquipoLocal { get; set; }
        public int idEquipoVisitante { get; set; }
        public string Marcador { get; set; }
        public int Resultado { get; set; }
        public int idTorneo { get; set; }
        public string Torneo { get; set; }
        public string Estadio { get; set; }
        public int NroFecha { get; set; }
        public string NombrePartido { get; set; }
        public string Temporada { get; set; }
        public string Liga { get; set; }

        //////////////Estadisticas del partido
        public int CornersLocal { get; set; }
        public int CornersVisitante { get; set; }
        public int FaltasLocal { get; set; }
        public int FaltasVisitante { get; set; }
        public int PenalesLocal { get; set; }
        public int PenalesVisitante { get; set; }
        public int OffsideLocal { get; set; }
        public int OffsideVisitante { get; set; }
        public int RematesLocal { get; set; }
        public int RematesVisitante { get; set; }
        public int TirosAlArcoLocal { get; set; }
        public int TirosAlArcoVisitante { get; set; }
        public int PasesCorrectosLocal { get; set; }
        public int PasesCorrectosVisitante { get; set; }
        public int PosesionLocal { get; set; }
        public int PosesionVisitante { get; set; }
    }
}
