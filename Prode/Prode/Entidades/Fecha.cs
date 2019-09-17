﻿using System;
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
    }
}
