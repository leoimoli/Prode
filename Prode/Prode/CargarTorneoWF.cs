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
    public partial class CargarTorneoWF : Form
    {
        public CargarTorneoWF()
        {
            InitializeComponent();
        }
        private void CargarTorneoWF_Load(object sender, EventArgs e)
        {
            CargarCombo();
        }
        #region Botones
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Entidades.Torneo _torneo = CargarEntidad();
            bool Exito = TorneoNeg.GuardarTorneo(_torneo);
            if (Exito == true)
            {
                ProgressBar();
                const string message2 = "Se registro el torneo exitosamente.";
                const string caption2 = "Éxito";
                var result2 = MessageBox.Show(message2, caption2,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Asterisk);
                LimpiarCampos();
            }
            else
            {

            }
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            InicioWF _inicio = new InicioWF();
            _inicio.Show();
            Hide();
        }
        #endregion
        #region Funciones
        private Entidades.Torneo CargarEntidad()
        {
            Torneo _torneo = new Torneo();
            _torneo.Temporada = cmbTemporada.Text;
            _torneo.NombreTorneo = txtNombreTorneo.Text;
            _torneo.CantidadFechas = Convert.ToInt32(txtFechas.Text);
            _torneo.Liga = txtLiga.Text;
            return _torneo;
        }
        private void ProgressBar()
        {
            progressBar1.Visible = true;
            progressBar1.Maximum = 100000;
            progressBar1.Step = 1;

            for (int j = 0; j < 100000; j++)
            {
                Caluculate(j);
                progressBar1.PerformStep();
            }
        }
        private void Caluculate(int i)
        {
            double pow = Math.Pow(i, i);
        }
        private void LimpiarCampos()
        {
            txtFechas.Clear();
            txtNombreTorneo.Clear();
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
            CargarCombo();
        }
        private void CargarCombo()
        {
            cmbTemporada.Focus();
            string[] Años = Clase_Maestra.ValoresConstantes.Años;
            cmbTemporada.Items.Add("Seleccione");
            cmbTemporada.Items.Clear();
            foreach (string item in Años)
            {
                cmbTemporada.Text = "Seleccione";
                cmbTemporada.Items.Add(item);
            }
        }
        #endregion
    }
}
