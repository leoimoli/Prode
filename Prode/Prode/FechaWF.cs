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
    public partial class FechaWF : MasterWF
    {
        public FechaWF()
        {
            InitializeComponent();
        }
        private void FechaWF_Load(object sender, EventArgs e)
        {
            CargarCombos();
        }
        #region Funciones
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

            List<string> Estadios = new List<string>();
            Estadios = EquiposNeg.CargarComboEstadios();
            cmbEstadio.Items.Clear();
            cmbEstadio.Text = "Seleccione";
            cmbEstadio.Items.Add("Seleccione");
            foreach (string item in Estadios)
            {
                cmbEstadio.Text = "Seleccione";
                cmbEstadio.Items.Add(item);
            }

            List<string> EquipoLocal = new List<string>();
            List<string> EquipoVisitante = new List<string>();
            EquipoLocal = EquiposNeg.CargarComboEquipo();
            EquipoVisitante = EquipoLocal;

            cmbLocal.Items.Clear();
            cmbLocal.Text = "Seleccione";
            cmbLocal.Items.Add("Seleccione");
            foreach (string item in EquipoLocal)
            {
                cmbLocal.Text = "Seleccione";
                cmbLocal.Items.Add(item);
            }

            cmbVisitante.Items.Clear();
            cmbVisitante.Text = "Seleccione";
            cmbVisitante.Items.Add("Seleccione");
            foreach (string item in EquipoVisitante)
            {
                cmbVisitante.Text = "Seleccione";
                cmbVisitante.Items.Add(item);
            }
        }
        private void cmbLocal_SelectedIndexChanged(object sender, EventArgs e)
        {
            string equipoLocal = cmbLocal.Text;
            if (cmbVisitante.Text == equipoLocal)
            {
                const string message2 = "El equipo ya fue seleccionado como equipo Visitante.";
                const string caption2 = "Error";
                var result2 = MessageBox.Show(message2, caption2,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Error);
            }
            else
            {
                byte[] EscudoLocal = EquiposNeg.BuscarImagenEquipoLocal(equipoLocal);
                if (EscudoLocal != null)
                {
                    Bitmap foto1 = Clases_Maestras.Funciones.byteToBipmap(EscudoLocal);
                    pictureBoxLocal.Image = foto1;
                }
            }

        }
        private void cmbVisitante_SelectedIndexChanged(object sender, EventArgs e)
        {
            string equipoVisitante = cmbVisitante.Text;
            if (cmbLocal.Text == equipoVisitante)
            {
                const string message2 = "El equipo ya fue seleccionado como equipo Local.";
                const string caption2 = "Error";
                var result2 = MessageBox.Show(message2, caption2,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Error);
            }
            else
            {
                byte[] EscudoVisitante = EquiposNeg.BuscarImagenEquipoLocal(equipoVisitante);
                if (EscudoVisitante != null)
                {
                    Bitmap foto1 = Clases_Maestras.Funciones.byteToBipmap(EscudoVisitante);
                    pictureBoxVisitante.Image = foto1;
                }
            }
        }
        private void LimpiarCamposDeCarga()
        {
            CargarCombos();
            txtFecha.Clear();
            dtFecha.Value = DateTime.Now;
            pictureBoxLocal.Image = null;
            pictureBoxVisitante.Image = null;
        }
        #endregion

        #region Botones
        private void btnCargar_Click(object sender, EventArgs e)
        {
            var torneo = cmbTorneo.Text;
            string var = torneo;
            string Torneo = var.Split('-')[0];
            string Temporada = var.Split('-')[1];


            bool FechaValida = TorneoNeg.ValidarFecha(txtFecha.Text, Torneo, Temporada);
            string fecha = dtFecha.Value.ToShortDateString();
            dataGridView1.Rows.Add(fecha, cmbEstadio.Text, " ", cmbLocal.Text, " ",  cmbVisitante.Text, " ");
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCamposDeCarga();
        }
        #endregion
    }
}
