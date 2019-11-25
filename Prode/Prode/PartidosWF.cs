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
    public partial class PartidosWF : MasterWF
    {
        public PartidosWF()
        {
            InitializeComponent();
        }

        private void PartidosWF_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevoPartido_Click(object sender, EventArgs e)
        {
            NuevoPartidoWF _NuevoPartido = new NuevoPartidoWF();
            _NuevoPartido.Show();
            Hide();
        }

        private void btnEditarAlineacion_Click(object sender, EventArgs e)
        {
            AlineacionEquipoWF _alineacion = new AlineacionEquipoWF();
            _alineacion.Show();
            Hide();
        }
    }
}
