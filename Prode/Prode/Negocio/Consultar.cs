using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prode.Negocio
{
    public class Consultar
    {
        public static List<string> CargarComboSelecciones()
        {
            List<string> lista = new List<string>();
            lista = Dao.Consultar.CargarComboSelecciones();
            return lista;
        }
    }
}
