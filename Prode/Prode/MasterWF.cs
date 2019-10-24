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
        
        }
        private void cargarEquiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void cargarFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void cargarPartidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        private void imprimirCuponesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        private void resultadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }
        private void cargarResultadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InicioWF _inicio = new InicioWF();
            _inicio.Show();
            Hide();
        }
    }
}
