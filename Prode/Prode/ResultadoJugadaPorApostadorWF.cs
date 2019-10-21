using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prode
{
    public partial class ResultadoJugadaPorApostadorWF : Form
    {
        private string aciertos;
        private string apellidoNombre;            

        public ResultadoJugadaPorApostadorWF(string aciertos, string apellidoNombre)
        {
            InitializeComponent();
            this.aciertos = aciertos;
            this.apellidoNombre = apellidoNombre;
        }

        private void ResultadoJugadaPorApostadorWF_Load(object sender, EventArgs e)
        {

        }
    }
}
