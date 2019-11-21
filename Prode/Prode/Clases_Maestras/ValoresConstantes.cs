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
        public static string[] PiernaHabil
        {
            get
            {
                return new string[] { "Derecha", "Izquierda" };
            }
        }
        public static string[] Habilidades
        {
            get
            {
                return new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9","10" };
            }
        }
        public static string[] DisposicionTactica
        {
            get
            {
                return new string[] { "1-4-4-2", "1-4-3-1-2", "1-4-2-3,1", "1-4-1-3-2","1-4-3-3", "1-5-3-2", "1-5-2-1-2", "1-3-4-3", "1-3-4-1-2","1-3-3-1-3" };
            }
        }
    }
}
