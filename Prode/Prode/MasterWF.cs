﻿using System;
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
    }
}