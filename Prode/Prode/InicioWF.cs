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
    public partial class InicioWF : MasterWF
    {
        public InicioWF()
        {
            InitializeComponent();
        }
        private void InicioWF_Load(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            MenuJuegosWF _juegos = new MenuJuegosWF();
            _juegos.Show();
            Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MenuFutbolWF _futbol = new MenuFutbolWF();
            _futbol.Show();
            Hide();
        }
    }
}
