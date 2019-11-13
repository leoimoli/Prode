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
    public partial class NuevoPartidoWF : Form
    {
        public NuevoPartidoWF()
        {
            InitializeComponent();
        }
        private void NuevoPartidoWF_Load(object sender, EventArgs e)
        {
            try
            {
                CargarCombos();
                txtEquipoLocal.AutoCompleteCustomSource = Clases_Maestras.AutoCompletePorEquipo.Autocomplete();
                txtEquipoLocal.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtEquipoLocal.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtEquipoVisitante.AutoCompleteCustomSource = Clases_Maestras.AutoCompletePorEquipo.Autocomplete();
                txtEquipoVisitante.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtEquipoVisitante.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch (Exception ex)
            { }
        }
        #region Botones
        private void txtEquipoLocal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string equipoLocal = txtEquipoLocal.Text;
                if (equipoLocal != "")
                {
                    if (txtEquipoVisitante.Text == equipoLocal)
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
                            pictureBox1.Image = foto1;
                            pictureBox1.Visible = true;
                        }
                        else
                        {
                            pictureBox1.Image = Image.FromFile("C:\\ProFuSo\\Silueta Equipo.jpg");
                            pictureBox1.Visible = true;
                        }                        
                        string EstadioLocal = EquiposNeg.BuscarEstadioPorEquipoLocalSeleccionado(equipoLocal);
                        if (EstadioLocal != null)
                        {
                            lblEstadioEdit.Text = EstadioLocal;
                        }
                        List<Equipos> _equipo = new List<Equipos>();
                        var NombreEquipo = txtEquipoLocal.Text;
                        _equipo = EquiposNeg.BuscarEquipoPorNombre(NombreEquipo);
                        var equipo = _equipo.First();
                        lblIdLocal.Text =Convert.ToString(equipo.idEquipo);
                        lblVS.Visible = true;
                        lblEstadio.Visible = true;
                        lblEstadioEdit.Visible = true;
                    }
                }
            }
        }
        private void txtEquipoVisitante_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string equipoVisitante = txtEquipoVisitante.Text;
                if (equipoVisitante != "")
                {
                    if (txtEquipoLocal.Text == equipoVisitante)
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
                            pictureBox2.Image = foto1;
                            pictureBox2.Visible = true;
                        }
                        else
                        {
                            pictureBox2.Image = Image.FromFile("C:\\ProFuSo\\Silueta Equipo.jpg");
                            pictureBox2.Visible = true;
                        }
                        List<Equipos> _equipo = new List<Equipos>();
                        var NombreEquipo = txtEquipoVisitante.Text;
                        _equipo = EquiposNeg.BuscarEquipoPorNombre(NombreEquipo);
                        var equipo = _equipo.First();
                        lblIdVistante.Text = Convert.ToString(equipo.idEquipo);
                        lblMarcador.Visible = true;
                        txtMarcadorLocal.Visible = true;
                        txtMarcadorVisitante.Visible = true;
                        txtMarcadorLocal.Focus();
                        groupBox1.Visible = true;
                        btnCancelar.Visible = true;
                        btnGuardar.Visible = true;
                    }
                }
            }
        }
        private void cmbLiga_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Liga = cmbLiga.Text;
            if (Liga != "Seleccione")
            {
                CargarComboTorneo(Liga);
            }
            else
            {
                cmbTorneo.Enabled = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                List<Fecha> _fecha = new List<Fecha>();
                var torneo = cmbTorneo.Text;
                string var = torneo;
                string Torneo = var.Split('-')[0];
                string Temporada = var.Split('-')[1];
                string NroFecha = txtFecha.Text;
                string Liga = cmbLiga.Text;
                _fecha = FechaNeg.BuscarFechaExistente(Torneo, Temporada, NroFecha, Liga);
                if (_fecha.Count > 0)
                {
                }
            }
            catch (Exception ex)
            { }
        }
        private void txtFecha_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                List<Fecha> _fecha = new List<Fecha>();
                var torneo = cmbTorneo.Text;
                string var = torneo;
                string Torneo = var.Split('-')[0];
                string Temporada = var.Split('-')[1];
                string NroFecha = txtFecha.Text;
                string Liga = cmbLiga.Text;
                _fecha = FechaNeg.BuscarFechaExistente(Torneo, Temporada, NroFecha, Liga);
                if (_fecha.Count > 0)
                {
                }
            }
            catch (Exception ex)
            { }
        }
        #endregion
        #region Funciones
        private void CargarCombos()
        {
            List<string> Liga = new List<string>();
            Liga = TorneoNeg.CargarComboLiga();
            cmbLiga.Items.Clear();
            cmbLiga.Text = "Seleccione";
            cmbLiga.Items.Add("Seleccione");
            foreach (string item in Liga)
            {
                cmbLiga.Text = "Seleccione";
                cmbLiga.Items.Add(item);
            }
        }
        private void CargarComboTorneo(string Liga)
        {
            List<string> Torneo = new List<string>();
            Torneo = TorneoNeg.CargarComboTorneos(Liga);
            cmbTorneo.Items.Clear();
            cmbTorneo.Text = "Seleccione";
            cmbTorneo.Items.Add("Seleccione");
            foreach (string item in Torneo)
            {
                cmbTorneo.Text = "Seleccione";
                cmbTorneo.Items.Add(item);
            }
            cmbTorneo.Enabled = true;
        }
        private PartidoEstadistica CargarEntidad()
        {
            PartidoEstadistica _partido = new PartidoEstadistica();
            _partido.Fecha = dtFecha.Value;
            _partido.idEquipoLocal = Convert.ToInt32(lblIdLocal.Text);
            string Marcador1 = txtMarcadorLocal.Text;
            string Marcador2 = txtMarcadorVisitante.Text;
            _partido.Marcador = Marcador1 + " - " + Marcador2;
            int Mar1 = Convert.ToInt32(Marcador1);
            int Mar2 = Convert.ToInt32(Marcador2);
            if (Mar1 > Mar2)
            {
                _partido.Resultado = 1;
            }
            if (Mar1 < Mar2)
            {
                _partido.Resultado = 2;
            }
            if (Mar1 == Mar2)
            {
                _partido.Resultado = 3;
            }
            var torneo = cmbTorneo.Text;
            string var = torneo;
            string Torneo = var.Split('-')[0];
            string Temporada = var.Split('-')[1];
            _partido.Torneo = Torneo;
            _partido.Liga = cmbLiga.Text;
            _partido.Temporada = Temporada;
            _partido.idEquipoVisitante = Convert.ToInt32(lblIdVistante.Text);
            _partido.Estadio = lblEstadioEdit.Text;
            _partido.NroFecha = Convert.ToInt32(txtFecha.Text);
            _partido.NombrePartido = txtEquipoLocal.Text + " - " + txtEquipoVisitante.Text;

            ////////Info Partido
            _partido.CornersLocal = Convert.ToInt32(txtCornersLocal.Text);
            _partido.CornersVisitante = Convert.ToInt32(txtCornersVisitante.Text);
            _partido.FaltasLocal = Convert.ToInt32(txtFaltasLocal.Text);
            _partido.FaltasVisitante = Convert.ToInt32(txtFaltasVisitante.Text);
            _partido.PenalesLocal = Convert.ToInt32(txtPenalesLocal.Text);
            _partido.PenalesVisitante = Convert.ToInt32(txtPenalesVisitante.Text);
            _partido.OffsideLocal = Convert.ToInt32(txtOffsideLocal.Text);
            _partido.OffsideVisitante = Convert.ToInt32(txtOffsideVisitante.Text);
            _partido.RematesLocal = Convert.ToInt32(txtRematesLocal.Text);
            _partido.RematesVisitante = Convert.ToInt32(txtRematesVisitante.Text);
            _partido.TirosAlArcoLocal = Convert.ToInt32(txtTirosAlArcoLocal.Text);
            _partido.TirosAlArcoVisitante = Convert.ToInt32(txtTirosAlArcoVisitante.Text);
            _partido.PasesCorrectosLocal = Convert.ToInt32(txtPasesCorrectosLocal.Text);
            _partido.PasesCorrectosVisitante = Convert.ToInt32(txtPaseCorrectosVisitante.Text);
            _partido.PosesionLocal = Convert.ToInt32(txtPosesionLocal.Text);
            _partido.PosesionVisitante = Convert.ToInt32(txtPosesionVisitante.Text);

            return _partido;
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
        #endregion
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Entidades.PartidoEstadistica _partido = CargarEntidad();
                int idPartido  = FutbolPartidoEstadisticaNeg.GuardarPartido(_partido);
                if (idPartido > 0)
                {

                    ProgressBar();
                    const string message2 = "Se registro el partido exitosamente.";
                    const string caption2 = "Éxito";
                    var result2 = MessageBox.Show(message2, caption2,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            { }
        }
    }
}
