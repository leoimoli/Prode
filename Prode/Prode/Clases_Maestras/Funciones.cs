using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prode.Clases_Maestras
{
   public class Funciones
    {
        public static Bitmap byteToBipmap(byte[] fotoByte)
        {
            MemoryStream ms = new MemoryStream(fotoByte);
            return (Bitmap)Bitmap.FromStream(ms);
        }
        public static Bitmap byteToBipmap2(byte[] fotoByte2)
        {
            MemoryStream ms2 = new MemoryStream(fotoByte2);
            return (Bitmap)Bitmap.FromStream(ms2);
        }
    }
}
