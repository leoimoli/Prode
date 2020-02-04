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
    public partial class MenuFutbolWF : MasterWF
    {
        public MenuFutbolWF()
        {
            InitializeComponent();
        }
        private void MenuFutbolWF_Load(object sender, EventArgs e)
        {

        }
        private void btnTorneo_Click(object sender, EventArgs e)
        {
            CargarTorneoWF _torneo = new CargarTorneoWF();
            _torneo.Show();
            Hide();
        }
        private void btnJugadores_Click(object sender, EventArgs e)
        {
            JugadoresWF _jugadores = new JugadoresWF();
            _jugadores.Show();
            Hide();
        }
        private void btnPartido_Click(object sender, EventArgs e)
        {
            PartidosWF _partido = new PartidosWF();
            _partido.Show();
            Hide();
        }
        private void btnEquipos_Click(object sender, EventArgs e)
        {
            EquiposWF _equipo = new EquiposWF();
            _equipo.Show();
            Hide();
        }
    }
}
