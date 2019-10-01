using Prode.Entidades;
using Prode.Negocio;
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
    public partial class ResultadoJugadasWF : MasterWF
    {
        public ResultadoJugadasWF()
        {
            InitializeComponent();
        }
        private void ResultadoJugadasWF_Load(object sender, EventArgs e)
        {
            FuncionesBotonHabilitarBuscar();
            CargarCombos();
        }

        #region Funciones
        private void BloquearPantalla()
        {
            grbFiltros.Enabled = false;
        }
        private void CargarCombos()
        {
            List<string> Torneo = new List<string>();
            Torneo = TorneoNeg.CargarComboTorneos();
            cmbTorneo.Items.Clear();
            cmbTorneo.Text = "Seleccione";
            cmbTorneo.Items.Add("Seleccione");
            foreach (string item in Torneo)
            {
                cmbTorneo.Text = "Seleccione";
                cmbTorneo.Items.Add(item);
            }
        }
        private void FuncionesBotonHabilitarBuscar()
        {
            cmbTorneo.Focus();
        }
        private void txtFecha_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                BloquearPantalla();
                List<Resultados> _resultados = new List<Resultados>();
                var torneo = cmbTorneo.Text;
                string var = torneo;
                string Torneo = var.Split('-')[0];
                string Temporada = var.Split('-')[1];
                string NroFecha = txtFecha.Text;
                _resultados = ResultadoNeg.BuscarResultados(Torneo, Temporada, NroFecha);
                if (_resultados.Count > 0)
                {
                    dataGridView1.Visible = true;
                    for (int i = 0; i < _resultados.Count; i++)
                    {
                        dataGridView1.Rows.Add(_resultados[i].EquipoLocal, _resultados[i].MarcadorLocal, _resultados[i].MarcadorVisitante, _resultados[i].EquipoVisitante);
                    }
                }
            }
            catch (Exception ex)
            { }
        }
        #endregion
        #region Botones
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                BloquearPantalla();
                List<Resultados> _resultados = new List<Resultados>();
                var torneo = cmbTorneo.Text;
                string var = torneo;
                string Torneo = var.Split('-')[0];
                string Temporada = var.Split('-')[1];
                string NroFecha = txtFecha.Text;
                _resultados = ResultadoNeg.BuscarResultados(Torneo, Temporada, NroFecha);
                if (_resultados.Count > 0)
                {
                    dataGridView1.Visible = true;
                    for (int i = 0; i < _resultados.Count; i++)
                    {
                        dataGridView1.Rows.Add(_resultados[i].EquipoLocal, _resultados[i].MarcadorLocal, _resultados[i].MarcadorVisitante, _resultados[i].EquipoVisitante);
                    }
                }
            }
            catch (Exception ex)
            { }
        }       
        #endregion
    }
}
