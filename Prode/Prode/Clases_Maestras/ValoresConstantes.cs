using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prode.Clase_Maestra
{
    public class ValoresConstantes
    {
        public static string[] Estadios
        {
            get
            {
                return new string[] { "Estadio Luzhniki", "Otkrytie Arena", "Estadio de San Petersburgo",
                    "Estadio de Kaliningrado", "Kazán Arena", "Estadio de Nizhni Nóvgorod", "Samara Arena", "Volgogrado Arena",
                "Mordovia Arena", "Rostov Arena","Estadio Fisht","Ekaterimburgo Arena"};
            }
        }
        public static string[] Años
        {
            get
            {
                return new string[] { "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030" };
            }
        }

        public static string[] Sexo
        {
            get
            {
                return new string[] { "Masculino", "Femenino" };
            }
        }
    }
}
