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
    public partial class EstadisticaJugadorWF : MasterWF
    {
        public EstadisticaJugadorWF()
        {
            InitializeComponent();
        }

        private void EstadisticaJugadorWF_Load(object sender, EventArgs e)
        {
            try
            {
                txtBuscarApellidoNombre.Focus();
                txtBuscarApellidoNombre.AutoCompleteCustomSource = Clases_Maestras.AutoCompletePorJugadores.Autocomplete();
                txtBuscarApellidoNombre.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtBuscarApellidoNombre.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch (Exception ex)
            { }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionBuscarEstadisticaGeneral();
            }
            catch (Exception ex)
            { }
        }
        private void FuncionBuscarEstadisticaGeneral()
        {
            BuscarJugadorIngresado();
            HabilitarFiltrosDeBusqueda();
            List<JugadorEstadisticaPartido> _estadistica = new List<JugadorEstadisticaPartido>();
            int idJugador = Convert.ToInt32(lblIdJugador.Text);
            _estadistica = JugadoresNeg.BuscarEstadisticaGeneralPorJugador(idJugador);
            if (_estadistica.Count > 0)
            {
                grbJugador1.Visible = true;
                lblPartido.Visible = true;
                lblPartidosJugadosFijo.Visible = true;
                var estadistica = _estadistica.First();
                lblPartido.Text = Convert.ToString(estadistica.PJ);
                lblMinutos.Text = Convert.ToString(estadistica.Minutos);
                lblGoles.Text = Convert.ToString(estadistica.Goles);
                lblAmarillas.Text = Convert.ToString(estadistica.Amarillas);
                lblRojas.Text = Convert.ToString(estadistica.Rojas);
                if (estadistica.Entrenamientos > 0)
                { lblEntrenamientos.Text = Convert.ToString(estadistica.Entrenamientos); }
                else
                { lblEntrenamientos.Text = "0"; }
            }
        }
        private void BuscarJugadorIngresado()
        {
            List<Jugadores> _jugadores = new List<Jugadores>();
            string ApellidoNombre = txtBuscarApellidoNombre.Text;
            _jugadores = JugadoresNeg.BuscarJugadoresPorApellidoYNombre(ApellidoNombre);
            if (_jugadores.Count > 0)
            {
                var jugador = _jugadores.First();
                if (jugador.Imagen != null)
                {
                    Bitmap foto1 = Clases_Maestras.Funciones.byteToBipmap(jugador.Imagen);
                    pictureBox1.Image = foto1;
                }
                else
                {
                    pictureBox1.Image = Image.FromFile("C:\\ProFuSo\\Silueta Jugador.jpg");
                    pictureBox1.Visible = true;
                }
                lblIdJugador.Text = Convert.ToString(jugador.idJugador);
                grbJugador1.Text = jugador.Apellido + " " + jugador.Nombre;
            }
        }
        private void HabilitarFiltrosDeBusqueda()
        {
            chcGeneral.Visible = true;
            chcPartido.Visible = true;
            chcTorneo.Visible = true;
            chcEntrenamiento.Visible = true;
        }
        private void chcGeneral_CheckedChanged(object sender, EventArgs e)
        {
            if (chcGeneral.Checked == true)
            {
                chcTorneo.Checked = false;
                chcPartido.Checked = false;
                chcEntrenamiento.Checked = false;
                cmbTorneo.Visible = false;
                cmbLiga.Visible = false;
                lblTorneo.Visible = false;
                lblLiga.Visible = false;
                lblEquipo.Visible = false;
                txtEquipo.Visible = false;
                btnBuscarPorFiltro.Visible = false;
            }
        }
        private void chcTorneo_CheckedChanged(object sender, EventArgs e)
        {
            if (chcTorneo.Checked == true)
            {
                chcGeneral.Checked = false;
                chcPartido.Checked = false;
                chcEntrenamiento.Checked = false;
                cmbTorneo.Visible = true;
                cmbLiga.Visible = true;
                lblTorneo.Visible = true;
                lblLiga.Visible = true;
                lblEquipo.Visible = false;
                txtEquipo.Visible = false;
                CargarComboLiga();
                btnBuscarPorFiltro.Visible = true;
                grbJugador1.Visible = false;
            }
        }
        private void chcPartido_CheckedChanged(object sender, EventArgs e)
        {
            if (chcPartido.Checked == true)
            {
                chcGeneral.Checked = false;
                chcTorneo.Checked = false;
                chcEntrenamiento.Checked = false;
                cmbTorneo.Visible = false;
                cmbLiga.Visible = false;
                lblTorneo.Visible = false;
                lblLiga.Visible = false;
                lblEquipo.Visible = true;
                txtEquipo.Visible = true;
                btnBuscarPorFiltro.Visible = true;
                grbJugador1.Visible = false;
                txtEquipo.Focus();
                txtEquipo.AutoCompleteCustomSource = Clases_Maestras.AutoCompletePorEquipo.Autocomplete();
                txtEquipo.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtEquipo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
        }
        private void chcEntrenamiento_CheckedChanged(object sender, EventArgs e)
        {
            if (chcEntrenamiento.Checked == true)
            {
                BuscarJugadorIngresado();
                chcGeneral.Checked = false;
                chcTorneo.Checked = false;
                chcPartido.Checked = false;
                cmbTorneo.Visible = false;
                cmbLiga.Visible = false;
                lblTorneo.Visible = false;
                lblLiga.Visible = false;
                lblEquipo.Visible = false;
                txtEquipo.Visible = false;
                btnBuscarPorFiltro.Visible = false;
                grbJugador1.Visible = false;
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
        private void CargarComboLiga()
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
        private void btnBuscarPorFiltro_Click(object sender, EventArgs e)
        {
            if (chcTorneo.Checked == true)
            {
                if (cmbLiga.Text != "Seleccione" && cmbTorneo.Text != "Seleccione")
                {
                    var torneo = cmbTorneo.Text;
                    string var = torneo;
                    string Torneo = var.Split('-')[0];
                    string Temporada = var.Split('-')[1];
                    string TorneoFinal = Torneo;
                    string LigaFinal = cmbLiga.Text;
                    string TemporadaFinal = Temporada;
                    BuscarJugadorIngresado();
                    int idJugador = Convert.ToInt32(lblIdJugador.Text);
                    List<JugadorEstadisticaPartido> _estadistica = new List<JugadorEstadisticaPartido>();
                    _estadistica = JugadoresNeg.BuscarEstadisticPorTorneoPorJugador(idJugador, TorneoFinal, LigaFinal, TemporadaFinal);
                    if (_estadistica.Count > 0)
                    {
                        grbJugador1.Visible = true;
                        lblPartido.Visible = true;
                        lblPartidosJugadosFijo.Visible = true;
                        var estadistica = _estadistica.First();
                        lblPartido.Text = Convert.ToString(estadistica.PJ);
                        lblMinutos.Text = Convert.ToString(estadistica.Minutos);
                        lblGoles.Text = Convert.ToString(estadistica.Goles);
                        lblAmarillas.Text = Convert.ToString(estadistica.Amarillas);
                        lblRojas.Text = Convert.ToString(estadistica.Rojas);
                        if (estadistica.Entrenamientos > 0)
                        { lblEntrenamientos.Text = Convert.ToString(estadistica.Entrenamientos); }
                        else
                        { lblEntrenamientos.Text = "0"; }
                    }

                }
            }
            if (chcPartido.Checked == true)
            {
                if (txtEquipo.Text != "" & txtEquipo.Text != null)
                {
                    var equipo = txtEquipo.Text;
                    BuscarJugadorIngresado();
                    int idJugador = Convert.ToInt32(lblIdJugador.Text);
                    List<JugadorEstadisticaPartido> _estadistica = new List<JugadorEstadisticaPartido>();
                    _estadistica = JugadoresNeg.BuscarEstadisticPorEquipoPorJugador(idJugador, equipo);
                    if (_estadistica.Count > 0)
                    {
                        grbJugador1.Visible = true;
                        lblPartido.Visible = true;
                        lblPartidosJugadosFijo.Visible = true;
                        var estadistica = _estadistica.First();
                        lblPartido.Text = Convert.ToString(estadistica.PJ);
                        lblMinutos.Text = Convert.ToString(estadistica.Minutos);
                        lblGoles.Text = Convert.ToString(estadistica.Goles);
                        lblAmarillas.Text = Convert.ToString(estadistica.Amarillas);
                        lblRojas.Text = Convert.ToString(estadistica.Rojas);
                        if (estadistica.Entrenamientos > 0)
                        { lblEntrenamientos.Text = Convert.ToString(estadistica.Entrenamientos); }
                        else
                        { lblEntrenamientos.Text = "0"; }
                    }

                }
            }
        }
    }
}

