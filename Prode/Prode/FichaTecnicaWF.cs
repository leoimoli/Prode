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
        public static int idJugadorStatic;
        public FichaTecnicaWF(int idJugador)
        {
            InitializeComponent();
            this.idJugador = idJugador;
            idJugadorStatic = idJugador;
        }

        private void FichaTecnicaWF_Load(object sender, EventArgs e)
        {
            try
            {
                Funcion = 0;
                if (idJugadorStatic > 0)
                {
                    Funcion = 1;
                    groupBox1.Visible = false;
                    List<Jugadores> _jugadores = new List<Jugadores>();
                    _jugadores = JugadoresNeg.BuscarJugadoresPorId(idJugadorStatic);
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
                        List<FichaTecnica> _fichaTecnica = new List<FichaTecnica>();
                        int idJugador = Convert.ToInt32(lblId.Text);
                        _fichaTecnica = JugadoresNeg.BuscarFichaTecnica(idJugador);
                        if (_fichaTecnica.Count > 0)
                        {
                            Funcion = 2;
                            HabilitarCamposConDatos(_fichaTecnica);
                        }
                        else
                        {
                            Funcion = 1;
                            HabilitarCampos();
                        }
                    }
                }
                else
                {
                    txtBuscarApellidoNombre.AutoCompleteCustomSource = Clases_Maestras.AutoCompletePorJugadores.Autocomplete();
                    txtBuscarApellidoNombre.AutoCompleteMode = AutoCompleteMode.Suggest;
                    txtBuscarApellidoNombre.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    txtBuscarApellidoNombre.Focus();
                }
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
                    Entidades.FichaTecnica _fichaJugadores = CargarEntidad();
                    bool Exito = false;
                    if (Funcion == 1)
                    {
                        Exito = JugadoresNeg.GuardarFichaTecnicaJugador(_fichaJugadores);
                        if (Exito == true)
                        {
                            ProgressBar();
                            const string message2 = "Se registro la ficha del jugador exitosamente.";
                            const string caption2 = "Éxito";
                            var result2 = MessageBox.Show(message2, caption2,
                                                         MessageBoxButtons.OK,
                                                         MessageBoxIcon.Asterisk);
                            LimpiarCampos();
                        }

                    }
                    else
                    {
                        if (Funcion == 2)
                        {
                            Exito = JugadoresNeg.EditarFichaTecnicaJugador(_fichaJugadores);
                            if (Exito == true)
                            {
                                ProgressBar();
                                const string message2 = "Se edito la ficha del jugador exitosamente.";
                                const string caption2 = "Éxito";
                                var result2 = MessageBox.Show(message2, caption2,
                                                             MessageBoxButtons.OK,
                                                             MessageBoxIcon.Asterisk);
                                LimpiarCampos();
                            }
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

        /// 0 = Nada;
        /// 1 = Guardar;
        /// 2 = Editar;

        public static int Funcion;
        private int idJugador;
        private void LimpiarCampos()
        {
            CargarCombos();
            pictureBox1.Visible = false;
            lblJugadorEdit.Visible = false;
            lblJugador.Visible = false;
            groupBox1.Visible = true;
            txtBuscarApellidoNombre.Focus();
            groupBox2.Visible = false;
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
            cmbPosicion.Enabled = false;
            cmbPosicion.Text = "Seleccione";

            txtVelocidad.BackColor = Color.White;
            txtResistencia.BackColor = Color.White;
            txtSalto.BackColor = Color.White;
            txtFuerza.BackColor = Color.White;

            txtControles.BackColor = Color.White;
            txtRegates.BackColor = Color.White;
            txtPaseCorto.BackColor = Color.White;
            txtPaseLargo.BackColor = Color.White;
            txtDefinicion.BackColor = Color.White;
            txtRemates.BackColor = Color.White;
            txtPelotaParada.BackColor = Color.White;
            txtMarca.BackColor = Color.White;

            txtDisciplinaTactica.BackColor = Color.White;
            txtNivelOfensivo.BackColor = Color.White;
            txtNivelDefensivo.BackColor = Color.White;

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
        private FichaTecnica CargarEntidad()
        {
            FichaTecnica _fichaJugadores = new FichaTecnica();
            _fichaJugadores.PosicionDeCampo = cmbPosicion.Text;
            _fichaJugadores.PiernaHabil = cmbPierna.Text;
            if (cmbVelocidad.Text == "Seleccione")
            {
                _fichaJugadores.Velocidad = "0";
            }
            else
            {
                _fichaJugadores.Velocidad = cmbVelocidad.Text;
            }
            if (cmbResistencia.Text == "Seleccione")
            {
                _fichaJugadores.Resistencia = "0";
            }
            else
            {
                _fichaJugadores.Resistencia = cmbResistencia.Text;
            }

            if (cmbSalto.Text == "Seleccione")
            {
                _fichaJugadores.Salto = "0";
            }
            else
            {
                _fichaJugadores.Salto = cmbSalto.Text;
            }

            if (cmbFuerza.Text == "Seleccione")
            {
                _fichaJugadores.Fuerza = "0";
            }
            else
            {
                _fichaJugadores.Fuerza = cmbFuerza.Text;
            }

            if (cmbControles.Text == "Seleccione")
            {
                _fichaJugadores.ControlDeBalon = "0";
            }
            else
            {
                _fichaJugadores.ControlDeBalon = cmbControles.Text;
            }

            if (cmbRegates.Text == "Seleccione")
            {
                _fichaJugadores.Regates = "0";
            }
            else
            {
                _fichaJugadores.Regates = cmbRegates.Text;
            }
            if (cmbPaseCorto.Text == "Seleccione")
            {
                _fichaJugadores.PaseCorto = "0";
            }
            else
            {
                _fichaJugadores.PaseCorto = cmbPaseCorto.Text;
            }
            if (cmbPaseLargo.Text == "Seleccione")
            {
                _fichaJugadores.PaseLargo = "0";
            }
            else
            {
                _fichaJugadores.PaseLargo = cmbPaseLargo.Text;
            }
            if (cmbDefinicion.Text == "Seleccione")
            {
                _fichaJugadores.Definicion = "0";
            }
            else
            {
                _fichaJugadores.Definicion = cmbDefinicion.Text;
            }
            if (cmbRemates.Text == "Seleccione")
            {
                _fichaJugadores.Remate = "0";
            }
            else
            {
                _fichaJugadores.Remate = cmbRemates.Text;
            }
            if (cmbPelotaParada.Text == "Seleccione")
            {
                _fichaJugadores.TiroLibre = "0";
            }
            else
            {
                _fichaJugadores.TiroLibre = cmbPelotaParada.Text;
            }
            if (cmbMarca.Text == "Seleccione")
            {
                _fichaJugadores.Marcaje = "0";
            }
            else
            {
                _fichaJugadores.Marcaje = cmbMarca.Text;
            }
            if (cmbDisciplinaTactica.Text == "Seleccione")
            {
                _fichaJugadores.DisciplinaTactica = "0";
            }
            else
            {
                _fichaJugadores.DisciplinaTactica = cmbDisciplinaTactica.Text;
            }
            if (cmbNivelDefensivo.Text == "Seleccione")
            {
                _fichaJugadores.NivelDefensivo = "0";
            }
            else
            {
                _fichaJugadores.NivelDefensivo = cmbNivelDefensivo.Text;
            }
            if (cmbNivelOfensivo.Text == "Seleccione")
            {
                _fichaJugadores.NivelOfensivo = "0";
            }
            else
            {
                _fichaJugadores.NivelOfensivo = cmbNivelOfensivo.Text;
            }
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
                else
                {
                    pictureBox1.Image = Image.FromFile("C:\\ProFuSo\\Silueta Jugador.jpg");
                    pictureBox1.Visible = true;
                }
                List<FichaTecnica> _fichaTecnica = new List<FichaTecnica>();
                int idJugador = Convert.ToInt32(lblId.Text);
                _fichaTecnica = JugadoresNeg.BuscarFichaTecnica(idJugador);
                if (_fichaTecnica.Count > 0)
                {
                    Funcion = 2;
                    HabilitarCamposConDatos(_fichaTecnica);
                }
                else
                {
                    Funcion = 1;
                    HabilitarCampos();
                }
            }

        }
        private void HabilitarCamposConDatos(List<FichaTecnica> _fichaTecnica)
        {
            groupBox2.Visible = true;
            var ficha = _fichaTecnica.First();
            CargarCombos();
            cmbPierna.Text = ficha.PiernaHabil;
            string posicion = ficha.PosicionDeCampo;
            cmbPosicion.Text = ficha.PosicionDeCampo;

            if (posicion == "ARQ")
            { cmbPuesto.Text = "Arquero"; }
            if (posicion == "DFC" || posicion == "LIB" || posicion == "LD" || posicion == "LI")
            { cmbPuesto.Text = "Defensor"; }
            if (posicion == "VC" || posicion == "VI" || posicion == "VD" || posicion == "MP")
            { cmbPuesto.Text = "Mediocampista"; }
            if (posicion == "ED" || posicion == "EI" || posicion == "CD")
            { cmbPuesto.Text = "Delantero"; }


            cmbVelocidad.Text = ficha.Velocidad;
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

            cmbResistencia.Text = ficha.Resistencia;
            int ValorComboResistencia = Convert.ToInt32(cmbResistencia.Text);
            if (ValorComboResistencia == 0 || ValorComboResistencia <= 2)
            {
                txtResistencia.BackColor = Color.Red;
            }
            if (ValorComboResistencia == 3 || ValorComboResistencia >= 3 && ValorComboResistencia <= 6)
            {
                txtResistencia.BackColor = Color.Orange;
            }
            if (ValorComboResistencia == 7 || ValorComboResistencia >= 7 && ValorComboResistencia <= 10)
            {
                txtResistencia.BackColor = Color.Green;
            }

            cmbSalto.Text = ficha.Salto;
            int ValorComboSalto = Convert.ToInt32(cmbSalto.Text);
            if (ValorComboSalto == 0 || ValorComboSalto <= 2)
            {
                txtSalto.BackColor = Color.Red;
            }
            if (ValorComboSalto == 3 || ValorComboSalto >= 3 && ValorComboSalto <= 6)
            {
                txtSalto.BackColor = Color.Orange;
            }
            if (ValorComboSalto == 7 || ValorComboSalto >= 7 && ValorComboSalto <= 10)
            {
                txtSalto.BackColor = Color.Green;
            }


            cmbFuerza.Text = ficha.Fuerza;
            int ValorComboFuerza = Convert.ToInt32(cmbFuerza.Text);
            if (ValorComboFuerza == 0 || ValorComboFuerza <= 2)
            {
                txtFuerza.BackColor = Color.Red;
            }
            if (ValorComboFuerza == 3 || ValorComboFuerza >= 3 && ValorComboFuerza <= 6)
            {
                txtFuerza.BackColor = Color.Orange;
            }
            if (ValorComboFuerza == 7 || ValorComboFuerza >= 7 && ValorComboFuerza <= 10)
            {
                txtFuerza.BackColor = Color.Green;
            }

            cmbControles.Text = ficha.ControlDeBalon;
            int ValorComboControles = Convert.ToInt32(cmbControles.Text);
            if (ValorComboControles == 0 || ValorComboControles <= 2)
            {
                txtControles.BackColor = Color.Red;
            }
            if (ValorComboControles == 3 || ValorComboControles >= 3 && ValorComboControles <= 6)
            {
                txtControles.BackColor = Color.Orange;
            }
            if (ValorComboControles == 7 || ValorComboControles >= 7 && ValorComboControles <= 10)
            {
                txtControles.BackColor = Color.Green;
            }

            cmbRegates.Text = ficha.Regates;
            int ValorComboRegates = Convert.ToInt32(cmbRegates.Text);
            if (ValorComboRegates == 0 || ValorComboRegates <= 2)
            {
                txtRegates.BackColor = Color.Red;
            }
            if (ValorComboRegates == 3 || ValorComboRegates >= 3 && ValorComboRegates <= 6)
            {
                txtRegates.BackColor = Color.Orange;
            }
            if (ValorComboRegates == 7 || ValorComboRegates >= 7 && ValorComboRegates <= 10)
            {
                txtRegates.BackColor = Color.Green;
            }
            cmbPaseCorto.Text = ficha.PaseCorto;
            int ValorComboPaseCorto = Convert.ToInt32(cmbPaseCorto.Text);
            if (ValorComboPaseCorto == 0 || ValorComboPaseCorto <= 2)
            {
                txtPaseCorto.BackColor = Color.Red;
            }
            if (ValorComboPaseCorto == 3 || ValorComboPaseCorto >= 3 && ValorComboPaseCorto <= 6)
            {
                txtPaseCorto.BackColor = Color.Orange;
            }
            if (ValorComboPaseCorto == 7 || ValorComboPaseCorto >= 7 && ValorComboPaseCorto <= 10)
            {
                txtPaseCorto.BackColor = Color.Green;
            }

            cmbPaseLargo.Text = ficha.PaseLargo;
            int ValorComboPaseLargo = Convert.ToInt32(cmbPaseLargo.Text);
            if (ValorComboPaseLargo == 0 || ValorComboPaseLargo <= 2)
            {
                txtPaseLargo.BackColor = Color.Red;
            }
            if (ValorComboPaseLargo == 3 || ValorComboPaseLargo >= 3 && ValorComboPaseLargo <= 6)
            {
                txtPaseLargo.BackColor = Color.Orange;
            }
            if (ValorComboPaseLargo == 7 || ValorComboPaseLargo >= 7 && ValorComboPaseLargo <= 10)
            {
                txtPaseLargo.BackColor = Color.Green;
            }

            cmbDefinicion.Text = ficha.Definicion;
            int ValorComboDefinicion = Convert.ToInt32(cmbDefinicion.Text);
            if (ValorComboDefinicion == 0 || ValorComboDefinicion <= 2)
            {
                txtDefinicion.BackColor = Color.Red;
            }
            if (ValorComboDefinicion == 3 || ValorComboDefinicion >= 3 && ValorComboDefinicion <= 6)
            {
                txtDefinicion.BackColor = Color.Orange;
            }
            if (ValorComboDefinicion == 7 || ValorComboDefinicion >= 7 && ValorComboDefinicion <= 10)
            {
                txtDefinicion.BackColor = Color.Green;
            }

            cmbRemates.Text = ficha.Remate;
            int ValorComboRemates = Convert.ToInt32(cmbRemates.Text);
            if (ValorComboRemates == 0 || ValorComboRemates <= 2)
            {
                txtRemates.BackColor = Color.Red;
            }
            if (ValorComboRemates == 3 || ValorComboRemates >= 3 && ValorComboRemates <= 6)
            {
                txtRemates.BackColor = Color.Orange;
            }
            if (ValorComboRemates == 7 || ValorComboRemates >= 7 && ValorComboRemates <= 10)
            {
                txtRemates.BackColor = Color.Green;
            }
            cmbPelotaParada.Text = ficha.TiroLibre;
            int ValorComboPelotaParada = Convert.ToInt32(cmbPelotaParada.Text);
            if (ValorComboPelotaParada == 0 || ValorComboPelotaParada <= 2)
            {
                txtPelotaParada.BackColor = Color.Red;
            }
            if (ValorComboPelotaParada == 3 || ValorComboPelotaParada >= 3 && ValorComboPelotaParada <= 6)
            {
                txtPelotaParada.BackColor = Color.Orange;
            }
            if (ValorComboPelotaParada == 7 || ValorComboPelotaParada >= 7 && ValorComboPelotaParada <= 10)
            {
                txtPelotaParada.BackColor = Color.Green;
            }
            cmbMarca.Text = ficha.Marcaje;
            int ValorComboMarca = Convert.ToInt32(cmbMarca.Text);
            if (ValorComboMarca == 0 || ValorComboMarca <= 2)
            {
                txtMarca.BackColor = Color.Red;
            }
            if (ValorComboMarca == 3 || ValorComboMarca >= 3 && ValorComboMarca <= 6)
            {
                txtMarca.BackColor = Color.Orange;
            }
            if (ValorComboMarca == 7 || ValorComboMarca >= 7 && ValorComboMarca <= 10)
            {
                txtMarca.BackColor = Color.Green;
            }
            cmbDisciplinaTactica.Text = ficha.DisciplinaTactica;
            int ValorComboDisciplinaTactica = Convert.ToInt32(cmbDisciplinaTactica.Text);
            if (ValorComboDisciplinaTactica == 0 || ValorComboDisciplinaTactica <= 2)
            {
                txtDisciplinaTactica.BackColor = Color.Red;
            }
            if (ValorComboDisciplinaTactica == 3 || ValorComboDisciplinaTactica >= 3 && ValorComboDisciplinaTactica <= 6)
            {
                txtDisciplinaTactica.BackColor = Color.Orange;
            }
            if (ValorComboDisciplinaTactica == 7 || ValorComboDisciplinaTactica >= 7 && ValorComboDisciplinaTactica <= 10)
            {
                txtDisciplinaTactica.BackColor = Color.Green;
            }
            cmbNivelDefensivo.Text = ficha.NivelDefensivo;
            int ValorComboNivelDefensivo = Convert.ToInt32(cmbNivelDefensivo.Text);
            if (ValorComboNivelDefensivo == 0 || ValorComboNivelDefensivo <= 2)
            {
                txtNivelDefensivo.BackColor = Color.Red;
            }
            if (ValorComboNivelDefensivo == 3 || ValorComboNivelDefensivo >= 3 && ValorComboNivelDefensivo <= 6)
            {
                txtNivelDefensivo.BackColor = Color.Orange;
            }
            if (ValorComboNivelDefensivo == 7 || ValorComboNivelDefensivo >= 7 && ValorComboNivelDefensivo <= 10)
            {
                txtNivelDefensivo.BackColor = Color.Green;
            }
            cmbNivelOfensivo.Text = ficha.NivelOfensivo;
            int ValorComboNivelOfensivo = Convert.ToInt32(cmbNivelOfensivo.Text);
            if (ValorComboNivelOfensivo == 0 || ValorComboNivelOfensivo <= 2)
            {
                txtNivelOfensivo.BackColor = Color.Red;
            }
            if (ValorComboNivelOfensivo == 3 || ValorComboNivelOfensivo >= 3 && ValorComboNivelOfensivo <= 6)
            {
                txtNivelOfensivo.BackColor = Color.Orange;
            }
            if (ValorComboNivelOfensivo == 7 || ValorComboNivelOfensivo >= 7 && ValorComboNivelOfensivo <= 10)
            {
                txtNivelOfensivo.BackColor = Color.Green;
            }
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
            cmbPuesto.DropDownStyle = ComboBoxStyle.DropDownList;
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
                cmbVelocidad.DropDownStyle = ComboBoxStyle.DropDownList;
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
                cmbResistencia.DropDownStyle = ComboBoxStyle.DropDownList;
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
                cmbSalto.DropDownStyle = ComboBoxStyle.DropDownList;
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
                cmbFuerza.DropDownStyle = ComboBoxStyle.DropDownList;
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
                cmbControles.DropDownStyle = ComboBoxStyle.DropDownList;
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
                cmbRegates.DropDownStyle = ComboBoxStyle.DropDownList;
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
                cmbPaseCorto.DropDownStyle = ComboBoxStyle.DropDownList;
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
                cmbPaseLargo.DropDownStyle = ComboBoxStyle.DropDownList;
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
                cmbDefinicion.DropDownStyle = ComboBoxStyle.DropDownList;
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
                cmbRemates.DropDownStyle = ComboBoxStyle.DropDownList;
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
                cmbPelotaParada.DropDownStyle = ComboBoxStyle.DropDownList;
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
                cmbMarca.DropDownStyle = ComboBoxStyle.DropDownList;
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
                cmbDisciplinaTactica.DropDownStyle = ComboBoxStyle.DropDownList;
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
                cmbNivelDefensivo.DropDownStyle = ComboBoxStyle.DropDownList;
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
                cmbNivelOfensivo.DropDownStyle = ComboBoxStyle.DropDownList;
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
        private void cmbPosicion_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPosicion.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void cmbPierna_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPierna.DropDownStyle = ComboBoxStyle.DropDownList;
        }

    }
    #endregion
}
