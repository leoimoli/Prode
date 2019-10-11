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
using Prode.Entidades;
using Prode.Clases_Maestras;

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
            if (equipoLocal != "Seleccione")
            {
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
                    string EstadioLocal = EquiposNeg.BuscarEstadioPorEquipoLocalSeleccionado(equipoLocal);
                    if (EstadioLocal != null)
                    {
                        cmbEstadio.Text = EstadioLocal;
                    }
                }
            }
        }
        private void cmbVisitante_SelectedIndexChanged(object sender, EventArgs e)
        {
            string equipoVisitante = cmbVisitante.Text;
            if (equipoVisitante != "Seleccione")
            {
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
        }
        private void LimpiarCamposDeCarga()
        {
            CargarCombos();
            txtFecha.Clear();
            dtFecha.Value = DateTime.Now;
            pictureBoxLocal.Image = null;
            pictureBoxVisitante.Image = null;
            txtValor.Clear();
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
        private void LimpiarTodo()
        {
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
            LimpiarCamposDeCarga();
            //dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            groupBox1.Enabled = true;
            dataGridView1.Enabled = true;
        }
        private List<Fecha> CargarEntidad()
        {
            Fecha _fecha = new Fecha();
            var torneo = cmbTorneo.Text;
            string var = torneo;
            string Torneo = var.Split('-')[0];
            string Temporada = var.Split('-')[1];
            _fecha.Torneo = Torneo;
            _fecha.NroFecha = txtFecha.Text;
            int idusuarioLogueado = Sesion.UsuarioLogueado.IdUsuario;
            List<Entidades.Fecha> listaFechaEstatica = new List<Fecha>();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                Fecha listaFecha = new Fecha();
                DateTime dia = Convert.ToDateTime(this.dataGridView1.Rows[i].Cells[0].Value.ToString());
                string estadio = Convert.ToString(this.dataGridView1.Rows[i].Cells[1].Value.ToString());
                string equipoLocal = Convert.ToString(this.dataGridView1.Rows[i].Cells[3].Value.ToString());
                string equipoVisitante = Convert.ToString(this.dataGridView1.Rows[i].Cells[5].Value.ToString());
                string campeonato = _fecha.Torneo;
                string temporada = Temporada;
                string nroFecha = _fecha.NroFecha;
                listaFecha.Dia = dia;
                listaFecha.Estadio = estadio;
                listaFecha.EquipoLocal = equipoLocal;
                listaFecha.EquipoVisitante = equipoVisitante;
                listaFecha.Torneo = campeonato;
                listaFecha.Temporada = temporada;
                listaFecha.NroFecha = nroFecha;
                listaFecha.ValorJugada = Convert.ToDecimal(txtValor.Text);
                listaFechaEstatica.Add(listaFecha);
            }

            return listaFechaEstatica;
        }
        #endregion
        #region Botones
        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                var torneo = cmbTorneo.Text;
                string var = torneo;
                string Torneo = var.Split('-')[0];
                string Temporada = var.Split('-')[1];
                bool FechaValida = TorneoNeg.ValidarFecha(txtFecha.Text, Torneo, Temporada);
                bool NroFechaValido = TorneoNeg.ValidarNroFechaExistente(txtFecha.Text, Torneo, Temporada);
                if (FechaValida == false)
                {
                    const string message2 = "Ya se alcanzo el máximo de fechas predispuesta para el torneo seleccionado.";
                    const string caption2 = "Error";
                    var result2 = MessageBox.Show(message2, caption2,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
                    throw new Exception();
                }
                if (NroFechaValido == false)
                {
                    const string message2 = "Ya existe una fecha con el mismo número para el torneo seleccionado.";
                    const string caption2 = "Error";
                    var result2 = MessageBox.Show(message2, caption2,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
                    throw new Exception();
                }
                else
                {
                    string fecha = dtFecha.Value.ToShortDateString();
                    dataGridView1.Rows.Add(fecha, cmbEstadio.Text, " ", cmbLocal.Text, " ", cmbVisitante.Text, " ");
                }
            }
            catch (Exception ex)
            { }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCamposDeCarga();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            LimpiarTodo();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                BloquearPantalla();
                List<Fecha> _Fecha = CargarEntidad();
                if (_Fecha.Count > 0)
                {
                    bool Exito = FechaNeg.GuardarFecha(_Fecha);
                    if (Exito == true)
                    {
                        ProgressBar();
                        const string message2 = "Se registro la fecha exitosamente.";
                        const string caption2 = "Éxito";
                        var result2 = MessageBox.Show(message2, caption2,
                                                     MessageBoxButtons.OK,
                                                     MessageBoxIcon.Asterisk);
                        LimpiarTodo();
                    }
                }

                else
                {
                    const string message = "No se ingreso información para cargar.";
                    const string caption = "Atención";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.OK,
                                               MessageBoxIcon.Exclamation);
                    throw new Exception();
                }
            }
            catch (Exception ex)
            { }
        }
        private void BloquearPantalla()
        {
            groupBox1.Enabled = false;
            dataGridView1.Enabled = false;
        }
        #endregion
    }
}
