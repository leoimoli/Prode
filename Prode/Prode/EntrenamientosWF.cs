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
    public partial class EntrenamientosWF : MasterWF
    {
        public EntrenamientosWF()
        {
            InitializeComponent();
        }

        private void EntrenamientosWF_Load(object sender, EventArgs e)
        {

        }

        private void btnFutbol_Click(object sender, EventArgs e)
        {
            MenuFutbolWF _futbol = new MenuFutbolWF();
            _futbol.Show();
            Hide();
        }

        private void btnNuevoPartido_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }
    }
}
