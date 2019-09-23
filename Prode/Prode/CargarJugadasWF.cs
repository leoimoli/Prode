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
    public partial class CargarJugadasWF : MasterWF
    {
        public CargarJugadasWF()
        {
            InitializeComponent();
        }
        private void CargarJugadasWF_Load(object sender, EventArgs e)
        {
            FuncionesBotonHabilitarBuscar();
            CargarCombos();
        }
        #region Funciones     
        private List<Jugada> CargarEntidadJugada()
        {
            List<Jugada> _lista = new List<Jugada>();
            for (int fila = 0; fila < dataGridView1.Rows.Count - 1; fila++)
            {
                Jugada _jugada = new Jugada();
                string idPartido = dataGridView1.Rows[fila].Cells[0].Value.ToString();
                string Local = dataGridView1.Rows[fila].Cells[3].Value.ToString();
                string Empate = dataGridView1.Rows[fila].Cells[5].Value.ToString();
                string Visitante = dataGridView1.Rows[fila].Cells[7].Value.ToString();
                _jugada.idPartido = Convert.ToInt32(idPartido);
                if (Local == "x")
                {
                    _jugada.idResultado = 1;
                }
                if (Empate == "x")
                {
                    _jugada.idResultado = 3;
                }
                if (Visitante == "x")
                {
                    _jugada.idResultado = 2;
                }
                _jugada.idApostador = Convert.ToInt32(lblidApostador.Text);
                _lista.Add(_jugada);
            }
            return _lista;
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
            txtBuscarApellidoNombre.AutoCompleteCustomSource = Clases_Maestras.AutoCompletePorApostadores.Autocomplete();
            txtBuscarApellidoNombre.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtBuscarApellidoNombre.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtBuscarApellidoNombre.Focus();
        }
        private void FuncionBuscarApostador()
        {
            List<Apostadores> _apostadores = new List<Apostadores>();
            string ApellidoNombre = txtBuscarApellidoNombre.Text;
            _apostadores = ApostadoresNeg.BuscarApostadorPorApellidoYNombre(ApellidoNombre);
            if (_apostadores.Count > 0)
            {
                groupBox2.Visible = true;
                var apostador = _apostadores.First();
                lblApellidoNombreEdit.Text = ApellidoNombre;
                lblDniEdit.Text = apostador.Dni;
                lblidApostador.Text = Convert.ToString(apostador.idApostador);
            }
            else
            {
                const string message = "Desea agregar un nuevo Persona ?";
                const string caption = "Persona Inexistente";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
                {
                    if (result == DialogResult.Yes)
                    {
                        ApostadoresWF _apostador = new ApostadoresWF();
                        _apostador.Show();
                        Hide();
                    }
                    else
                    { }
                }
            }
        }
        private void txtFecha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    List<Fecha> _fecha = new List<Fecha>();
                    var torneo = cmbTorneo.Text;
                    string var = torneo;
                    string Torneo = var.Split('-')[0];
                    string Temporada = var.Split('-')[1];
                    string NroFecha = txtFecha.Text;
                    _fecha = FechaNeg.BuscarFechaExistente(Torneo, Temporada, NroFecha);
                    if (_fecha.Count > 0)
                    {
                        dataGridView1.Visible = true;
                        for (int i = 0; i < _fecha.Count; i++)
                        {
                            dataGridView1.Rows.Add(_fecha[i].idPartido, _fecha[i].DiaPartido, _fecha[i].Estadio, " ", _fecha[i].EquipoLocal, " ", _fecha[i].EquipoVisitante, " ");
                        }
                    }
                }
                catch (Exception ex)
                { }
            }
        }
        private void txtBuscarApellidoNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FuncionBuscarApostador();
            }
        }
        private void LimpiarTodo()
        {
            dataGridView1.DataSource = null;
            txtFecha.Clear();
            CargarCombos();
            groupBox2.Visible = false;
            txtBuscarApellidoNombre.Focus();
            lblApellidoNombreEdit.Text = "";
            lblDniEdit.Text = "";
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
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
        #region Botones
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Jugada> _listaJugada = new List<Jugada>();
                _listaJugada = CargarEntidadJugada();
                bool Exito = JugadaNeg.GuardarJugada(_listaJugada);
                if (Exito == true)
                {
                    ProgressBar();
                    const string message2 = "Se registro la jugada exitosamente.";
                    const string caption2 = "Éxito";
                    var result2 = MessageBox.Show(message2, caption2,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Asterisk);
                    LimpiarTodo();
                }
            }
            catch (Exception ex)
            { }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            LimpiarTodo();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionBuscarApostador();
            }
            catch (Exception ex)
            { }

        }
        #endregion


    }
}
