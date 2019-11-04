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
    public partial class FichaTecnicaWF : Form
    {
        public FichaTecnicaWF()
        {
            InitializeComponent();
        }

        private void FichaTecnicaWF_Load(object sender, EventArgs e)
        {
            try
            {
                EsEditar = 0;
                txtBuscarApellidoNombre.AutoCompleteCustomSource = Clases_Maestras.AutoCompletePorJugadores.Autocomplete();
                txtBuscarApellidoNombre.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtBuscarApellidoNombre.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtBuscarApellidoNombre.Focus();
            }
            catch (Exception ex)
            { }
        }

        #region Botones
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    FuncionBuscarJugador();
                }
                catch (Exception ex)
                { }
            }
            catch (Exception ex)
            { }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    if (EsEditar == 1)
                    {
                        Entidades.FichaTecnica _fichaJugadores = CargarEntidad();
                        bool Exito = JugadoresNeg.GuardarFichaTecnicaJugador(_fichaJugadores);
                        if (Exito == true)
                        {
                            ProgressBar();
                            const string message2 = "Se registro la ficha del jugador exitosamente.";
                            const string caption2 = "Éxito";
                            var result2 = MessageBox.Show(message2, caption2,
                                                         MessageBoxButtons.OK,
                                                         MessageBoxIcon.Asterisk);
                            //LimpiarCamposBotonCancelar();
                            //FuncionesBotonNuevoJugador();
                        }
                        else
                        {
                        }
                    }
                }
                catch (Exception ex)
                { }
            }
            catch (Exception ex)
            { }
        }    
        #endregion
        #region Funciones
        public static int EsEditar;
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
        private FichaTecnica CargarEntidad()
        {
            FichaTecnica _fichaJugadores = new FichaTecnica();
            _fichaJugadores.PosicionDeCampo = cmbPosicion.Text;
            _fichaJugadores.PiernaHabil = cmbPierna.Text;
            _fichaJugadores.Velocidad = cmbVelocidad.Text;
            _fichaJugadores.Resistencia = cmbResistencia.Text;
            _fichaJugadores.Salto = cmbSalto.Text;
            _fichaJugadores.Fuerza = cmbFuerza.Text;
            _fichaJugadores.ControlDeBalon = cmbControles.Text;
            _fichaJugadores.Regates = cmbRegates.Text;
            _fichaJugadores.PaseCorto = cmbPaseCorto.Text;
            _fichaJugadores.PaseLargo = cmbPaseLargo.Text;
            _fichaJugadores.Definicion = cmbDefinicion.Text;
            _fichaJugadores.Remate = cmbRemates.Text;
            _fichaJugadores.TiroLibre = cmbPelotaParada.Text;
            _fichaJugadores.Marcaje = cmbMarca.Text;
            _fichaJugadores.DisciplinaTactica = cmbDisciplinaTactica.Text;
            _fichaJugadores.NivelDefensivo = cmbNivelDefensivo.Text;
            _fichaJugadores.NivelOfensivo = cmbNivelOfensivo.Text;
            _fichaJugadores.IdJugador = Convert.ToInt32(lblId.Text);
            return _fichaJugadores;
        }
        private void FuncionBuscarJugador()
        {
            List<Jugadores> _jugadores = new List<Jugadores>();
            string ApellidoNombre = txtBuscarApellidoNombre.Text;
            _jugadores = JugadoresNeg.BuscarJugadoresPorApellidoYNombre(ApellidoNombre);
            if (_jugadores.Count > 0)
            {
                groupBox1.Visible = false;
                lblJugador.Visible = true;
                lblJugadorEdit.Visible = true;
                var jugador = _jugadores.First();
                lblJugadorEdit.Text = jugador.Apellido + "," + " " + jugador.Nombre;
                lblId.Text = Convert.ToString(jugador.idJugador);
                if (jugador.Imagen != null)
                {
                    Bitmap foto1 = Clases_Maestras.Funciones.byteToBipmap(jugador.Imagen);
                    pictureBox1.Image = foto1;
                    pictureBox1.Visible = true;
                }
                List<Jugadores> _fichaTecnica = new List<Jugadores>();
                int idJugador = Convert.ToInt32(lblId.Text);
                _fichaTecnica = JugadoresNeg.BuscarFichaTecnica(idJugador);
                if (_fichaTecnica.Count > 0)
                {
                    EsEditar = 2;
                    HabilitarCamposConDatos();
                }
                else
                {
                    EsEditar = 1;
                    HabilitarCampos();
                }
            }
            #endregion
        }
        private void HabilitarCamposConDatos()
        {

        }
        private void HabilitarCampos()
        {
            groupBox2.Visible = true;
            CargarCombos();
        }
        private void CargarCombos()
        {
            List<string> Puestos = new List<string>();
            Puestos = JugadoresNeg.CargarComboPuestos();
            cmbPuesto.Items.Clear();
            cmbPuesto.Text = "Seleccione";
            cmbPuesto.Items.Add("Seleccione");
            foreach (string item in Puestos)
            {
                cmbPuesto.Text = "Seleccione";
                cmbPuesto.Items.Add(item);
            }

            string[] Pierna = Clase_Maestra.ValoresConstantes.PiernaHabil;
            cmbPierna.Items.Add("Seleccione");
            cmbPierna.Items.Clear();
            foreach (string item in Pierna)
            {
                cmbPierna.Text = "Seleccione";
                cmbPierna.Items.Add(item);
            }

            string[] Habilidades = Clase_Maestra.ValoresConstantes.Habilidades;
            cmbVelocidad.Items.Add("Seleccione");
            cmbVelocidad.Items.Clear();
            foreach (string item in Habilidades)
            {
                cmbVelocidad.Text = "Seleccione";
                cmbVelocidad.Items.Add(item);
            }

            cmbResistencia.Items.Add("Seleccione");
            cmbResistencia.Items.Clear();
            foreach (string item in Habilidades)
            {
                cmbResistencia.Text = "Seleccione";
                cmbResistencia.Items.Add(item);
            }

            cmbSalto.Items.Add("Seleccione");
            cmbSalto.Items.Clear();
            foreach (string item in Habilidades)
            {
                cmbSalto.Text = "Seleccione";
                cmbSalto.Items.Add(item);
            }

            cmbFuerza.Items.Add("Seleccione");
            cmbFuerza.Items.Clear();
            foreach (string item in Habilidades)
            {
                cmbFuerza.Text = "Seleccione";
                cmbFuerza.Items.Add(item);
            }

            cmbControles.Items.Add("Seleccione");
            cmbControles.Items.Clear();
            foreach (string item in Habilidades)
            {
                cmbControles.Text = "Seleccione";
                cmbControles.Items.Add(item);
            }

            cmbRegates.Items.Add("Seleccione");
            cmbRegates.Items.Clear();
            foreach (string item in Habilidades)
            {
                cmbRegates.Text = "Seleccione";
                cmbRegates.Items.Add(item);
            }

            cmbPaseCorto.Items.Add("Seleccione");
            cmbPaseCorto.Items.Clear();
            foreach (string item in Habilidades)
            {
                cmbPaseCorto.Text = "Seleccione";
                cmbPaseCorto.Items.Add(item);
            }

            cmbPaseLargo.Items.Add("Seleccione");
            cmbPaseLargo.Items.Clear();
            foreach (string item in Habilidades)
            {
                cmbPaseLargo.Text = "Seleccione";
                cmbPaseLargo.Items.Add(item);
            }

            cmbDefinicion.Items.Add("Seleccione");
            cmbDefinicion.Items.Clear();
            foreach (string item in Habilidades)
            {
                cmbDefinicion.Text = "Seleccione";
                cmbDefinicion.Items.Add(item);
            }

            cmbRemates.Items.Add("Seleccione");
            cmbRemates.Items.Clear();
            foreach (string item in Habilidades)
            {
                cmbRemates.Text = "Seleccione";
                cmbRemates.Items.Add(item);
            }

            cmbPelotaParada.Items.Add("Seleccione");
            cmbPelotaParada.Items.Clear();
            foreach (string item in Habilidades)
            {
                cmbPelotaParada.Text = "Seleccione";
                cmbPelotaParada.Items.Add(item);
            }


            cmbMarca.Items.Add("Seleccione");
            cmbMarca.Items.Clear();
            foreach (string item in Habilidades)
            {
                cmbMarca.Text = "Seleccione";
                cmbMarca.Items.Add(item);
            }

            cmbDisciplinaTactica.Items.Add("Seleccione");
            cmbDisciplinaTactica.Items.Clear();
            foreach (string item in Habilidades)
            {
                cmbDisciplinaTactica.Text = "Seleccione";
                cmbDisciplinaTactica.Items.Add(item);
            }

            cmbNivelDefensivo.Items.Add("Seleccione");
            cmbNivelDefensivo.Items.Clear();
            foreach (string item in Habilidades)
            {
                cmbNivelDefensivo.Text = "Seleccione";
                cmbNivelDefensivo.Items.Add(item);
            }

            cmbNivelOfensivo.Items.Add("Seleccione");
            cmbNivelOfensivo.Items.Clear();
            foreach (string item in Habilidades)
            {
                cmbNivelOfensivo.Text = "Seleccione";
                cmbNivelOfensivo.Items.Add(item);
            }
        }
        private void cmbPuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Puesto = cmbPuesto.Text;
            if (Puesto != "Seleccione")
            {
                List<string> Posiciones = new List<string>();
                Posiciones = JugadoresNeg.BuscarPosicionesPorPuestoSeleccionado(Puesto);
                if (Posiciones.Count > 0)
                {
                    cmbPosicion.Enabled = true;
                    cmbPosicion.Items.Clear();
                    cmbPosicion.Text = "Seleccione";
                    cmbPosicion.Items.Add("Seleccione");
                    foreach (string item in Posiciones)
                    {
                        cmbPosicion.Text = "Seleccione";
                        cmbPosicion.Items.Add(item);
                    }
                }
            }
        }
        private void cmbVelocidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int ValorCombo = Convert.ToInt32(cmbVelocidad.Text);
                if (ValorCombo == 0 || ValorCombo <= 2)
                {
                    txtVelocidad.BackColor = Color.Red;
                }
                if (ValorCombo == 3 || ValorCombo >= 3 && ValorCombo <= 6)
                {
                    txtVelocidad.BackColor = Color.Orange;
                }
                if (ValorCombo == 7 || ValorCombo >= 7 && ValorCombo <= 10)
                {
                    txtVelocidad.BackColor = Color.Green;
                }
            }
            catch (Exception ex)
            { }
        }
        private void cmbResistencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int ValorCombo = Convert.ToInt32(cmbResistencia.Text);
                if (ValorCombo == 0 || ValorCombo <= 2)
                {
                    txtResistencia.BackColor = Color.Red;
                }
                if (ValorCombo == 3 || ValorCombo >= 3 && ValorCombo <= 6)
                {
                    txtResistencia.BackColor = Color.Orange;
                }
                if (ValorCombo == 7 || ValorCombo >= 7 && ValorCombo <= 10)
                {
                    txtResistencia.BackColor = Color.Green;
                }
            }
            catch (Exception ex)
            { }
        }
        private void cmbSalto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int ValorCombo = Convert.ToInt32(cmbSalto.Text);
                if (ValorCombo == 0 || ValorCombo <= 2)
                {
                    txtSalto.BackColor = Color.Red;
                }
                if (ValorCombo == 3 || ValorCombo >= 3 && ValorCombo <= 6)
                {
                    txtSalto.BackColor = Color.Orange;
                }
                if (ValorCombo == 7 || ValorCombo >= 7 && ValorCombo <= 10)
                {
                    txtSalto.BackColor = Color.Green;
                }
            }
            catch (Exception ex)
            { }
        }
        private void cmbFuerza_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int ValorCombo = Convert.ToInt32(cmbFuerza.Text);
                if (ValorCombo == 0 || ValorCombo <= 2)
                {
                    txtFuerza.BackColor = Color.Red;
                }
                if (ValorCombo == 3 || ValorCombo >= 3 && ValorCombo <= 6)
                {
                    txtFuerza.BackColor = Color.Orange;
                }
                if (ValorCombo == 7 || ValorCombo >= 7 && ValorCombo <= 10)
                {
                    txtFuerza.BackColor = Color.Green;
                }
            }
            catch (Exception ex)
            { }
        }
        private void cmbControles_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int ValorCombo = Convert.ToInt32(cmbControles.Text);
                if (ValorCombo == 0 || ValorCombo <= 2)
                {
                    txtControles.BackColor = Color.Red;
                }
                if (ValorCombo == 3 || ValorCombo >= 3 && ValorCombo <= 6)
                {
                    txtControles.BackColor = Color.Orange;
                }
                if (ValorCombo == 7 || ValorCombo >= 7 && ValorCombo <= 10)
                {
                    txtControles.BackColor = Color.Green;
                }
            }
            catch (Exception ex)
            { }
        }
        private void cmbRegates_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int ValorCombo = Convert.ToInt32(cmbRegates.Text);
                if (ValorCombo == 0 || ValorCombo <= 2)
                {
                    txtRegates.BackColor = Color.Red;
                }
                if (ValorCombo == 3 || ValorCombo >= 3 && ValorCombo <= 6)
                {
                    txtRegates.BackColor = Color.Orange;
                }
                if (ValorCombo == 7 || ValorCombo >= 7 && ValorCombo <= 10)
                {
                    txtRegates.BackColor = Color.Green;
                }
            }
            catch (Exception ex)
            { }
        }
        private void cmbPaseCorto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int ValorCombo = Convert.ToInt32(cmbPaseCorto.Text);
                if (ValorCombo == 0 || ValorCombo <= 2)
                {
                    txtPaseCorto.BackColor = Color.Red;
                }
                if (ValorCombo == 3 || ValorCombo >= 3 && ValorCombo <= 6)
                {
                    txtPaseCorto.BackColor = Color.Orange;
                }
                if (ValorCombo == 7 || ValorCombo >= 7 && ValorCombo <= 10)
                {
                    txtPaseCorto.BackColor = Color.Green;
                }
            }
            catch (Exception ex)
            { }
        }
        private void cmbPaseLargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int ValorCombo = Convert.ToInt32(cmbPaseLargo.Text);
                if (ValorCombo == 0 || ValorCombo <= 2)
                {
                    txtPaseLargo.BackColor = Color.Red;
                }
                if (ValorCombo == 3 || ValorCombo >= 3 && ValorCombo <= 6)
                {
                    txtPaseLargo.BackColor = Color.Orange;
                }
                if (ValorCombo == 7 || ValorCombo >= 7 && ValorCombo <= 10)
                {
                    txtPaseLargo.BackColor = Color.Green;
                }
            }
            catch (Exception ex)
            { }
        }
        private void cmbDefinicion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int ValorCombo = Convert.ToInt32(cmbDefinicion.Text);
                if (ValorCombo == 0 || ValorCombo <= 2)
                {
                    txtDefinicion.BackColor = Color.Red;
                }
                if (ValorCombo == 3 || ValorCombo >= 3 && ValorCombo <= 6)
                {
                    txtDefinicion.BackColor = Color.Orange;
                }
                if (ValorCombo == 7 || ValorCombo >= 7 && ValorCombo <= 10)
                {
                    txtDefinicion.BackColor = Color.Green;
                }
            }
            catch (Exception ex)
            { }
        }
        private void cmbRemates_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int ValorCombo = Convert.ToInt32(cmbRemates.Text);
                if (ValorCombo == 0 || ValorCombo <= 2)
                {
                    txtRemates.BackColor = Color.Red;
                }
                if (ValorCombo == 3 || ValorCombo >= 3 && ValorCombo <= 6)
                {
                    txtRemates.BackColor = Color.Orange;
                }
                if (ValorCombo == 7 || ValorCombo >= 7 && ValorCombo <= 10)
                {
                    txtRemates.BackColor = Color.Green;
                }
            }
            catch (Exception ex)
            { }
        }
        private void cmbPelotaParada_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int ValorCombo = Convert.ToInt32(cmbPelotaParada.Text);
                if (ValorCombo == 0 || ValorCombo <= 2)
                {
                    txtPelotaParada.BackColor = Color.Red;
                }
                if (ValorCombo == 3 || ValorCombo >= 3 && ValorCombo <= 6)
                {
                    txtPelotaParada.BackColor = Color.Orange;
                }
                if (ValorCombo == 7 || ValorCombo >= 7 && ValorCombo <= 10)
                {
                    txtPelotaParada.BackColor = Color.Green;
                }
            }
            catch (Exception ex)
            { }
        }
        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int ValorCombo = Convert.ToInt32(cmbMarca.Text);
                if (ValorCombo == 0 || ValorCombo <= 2)
                {
                    txtMarca.BackColor = Color.Red;
                }
                if (ValorCombo == 3 || ValorCombo >= 3 && ValorCombo <= 6)
                {
                    txtMarca.BackColor = Color.Orange;
                }
                if (ValorCombo == 7 || ValorCombo >= 7 && ValorCombo <= 10)
                {
                    txtMarca.BackColor = Color.Green;
                }
            }
            catch (Exception ex)
            { }
        }
        private void cmbDisciplinaTactica_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int ValorCombo = Convert.ToInt32(cmbDisciplinaTactica.Text);
                if (ValorCombo == 0 || ValorCombo <= 2)
                {
                    txtDisciplinaTactica.BackColor = Color.Red;
                }
                if (ValorCombo == 3 || ValorCombo >= 3 && ValorCombo <= 6)
                {
                    txtDisciplinaTactica.BackColor = Color.Orange;
                }
                if (ValorCombo == 7 || ValorCombo >= 7 && ValorCombo <= 10)
                {
                    txtDisciplinaTactica.BackColor = Color.Green;
                }
            }
            catch (Exception ex)
            { }
        }
        private void cmbNivelDefensivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int ValorCombo = Convert.ToInt32(cmbNivelDefensivo.Text);
                if (ValorCombo == 0 || ValorCombo <= 2)
                {
                    txtNivelDefensivo.BackColor = Color.Red;
                }
                if (ValorCombo == 3 || ValorCombo >= 3 && ValorCombo <= 6)
                {
                    txtNivelDefensivo.BackColor = Color.Orange;
                }
                if (ValorCombo == 7 || ValorCombo >= 7 && ValorCombo <= 10)
                {
                    txtNivelDefensivo.BackColor = Color.Green;
                }
            }
            catch (Exception ex)
            { }
        }
        private void cmbNivelOfensivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int ValorCombo = Convert.ToInt32(cmbNivelOfensivo.Text);
                if (ValorCombo == 0 || ValorCombo <= 2)
                {
                    txtNivelOfensivo.BackColor = Color.Red;
                }
                if (ValorCombo == 3 || ValorCombo >= 3 && ValorCombo <= 6)
                {
                    txtNivelOfensivo.BackColor = Color.Orange;
                }
                if (ValorCombo == 7 || ValorCombo >= 7 && ValorCombo <= 10)
                {
                    txtNivelOfensivo.BackColor = Color.Green;
                }
            }
            catch (Exception ex)
            { }
        }
    }
}
