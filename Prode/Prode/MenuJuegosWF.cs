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
    public partial class MenuJuegosWF : MasterWF
    {
        public MenuJuegosWF()
        {
            InitializeComponent();
        }

        private void MenuJuegosWF_Load(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            EquiposWF _equipo = new EquiposWF();
            _equipo.Show();
            Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CargarTorneoWF _torneo = new CargarTorneoWF();
            _torneo.Show();
            Hide();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            FechaWF _fecha = new FechaWF();
            _fecha.Show();
            Hide();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            CargarResultadosWF _resultado = new CargarResultadosWF();
            _resultado.Show();
            Hide();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            CargarJugadasWF _jugadas = new CargarJugadasWF();
            _jugadas.Show();
            Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ResultadoJugadasWF _resultado = new ResultadoJugadasWF();
            _resultado.Show();
            Hide();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            ConsultarFechaWF _consulta = new ConsultarFechaWF();
            _consulta.Show();
            Hide();
        }
    }
}
