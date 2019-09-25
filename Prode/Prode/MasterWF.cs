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
    public partial class MasterWF : Form
    {
        public MasterWF()
        {
            InitializeComponent();
        }
        private void cargarTorneoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarTorneoWF _torneo = new CargarTorneoWF();
            _torneo.Show();
            Hide();
        }
        private void cargarEquiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EquiposWF _equipo = new EquiposWF();
            _equipo.Show();
            Hide();
        }
        private void cargarFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FechaWF _fecha = new FechaWF();
            _fecha.Show();
            Hide();
        }

        private void cargarPartidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarJugadasWF _jugadas = new CargarJugadasWF();
            _jugadas.Show();
            Hide();
        }
        private void imprimirCuponesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarFechaWF _consulta = new ConsultarFechaWF();
            _consulta.Show();
            Hide();
        }

        private void resultadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cargarResultadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarResultadosWF _resultado = new CargarResultadosWF();
            _resultado.Show();
            Hide();
        }
    }
}
