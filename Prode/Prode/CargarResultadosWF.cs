using Prode.Clases_Maestras;
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
    public partial class CargarResultadosWF : MasterWF
    {
        public CargarResultadosWF()
        {
            InitializeComponent();
        }
        private void CargarResultadosWF_Load(object sender, EventArgs e)
        {
            FuncionesBotonHabilitarBuscar();
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
        }
        private void FuncionesBotonHabilitarBuscar()
        {
            cmbTorneo.Focus();
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
                            dataGridView1.Rows.Add(_fecha[i].idPartido, _fecha[i].DiaPartido, _fecha[i].Estadio, " ", _fecha[i].EquipoLocal, _fecha[i].EquipoVisitante, " ");
                        }
                    }
                }
                catch (Exception ex)
                { }
            }
        }
        private List<Resultados> CargarEntidadResultado()
        {
            List<Resultados> _lista = new List<Resultados>();
            for (int fila = 0; fila < dataGridView1.Rows.Count - 1; fila++)
            {
                string Local = "";
                string Visitante = "";
                Resultados _resultado = new Resultados();
                string idPartido = dataGridView1.Rows[fila].Cells[0].Value.ToString();
                if (dataGridView1.Rows[fila].Cells[3].Value.ToString() == " ")
                { Local = "0"; }
                Local = dataGridView1.Rows[fila].Cells[3].Value.ToString();
                _resultado.EquipoLocal = dataGridView1.Rows[fila].Cells[4].Value.ToString();
                _resultado.EquipoVisitante = dataGridView1.Rows[fila].Cells[5].Value.ToString();
                if (dataGridView1.Rows[fila].Cells[6].Value.ToString() == " ")
                { Visitante = "0"; }
                Visitante = dataGridView1.Rows[fila].Cells[6].Value.ToString();
                _resultado.idPartido = Convert.ToInt32(idPartido);

                ///// Realizo trabajo de logica segun marcador
                _resultado.MarcadorLocal = Convert.ToInt32(Local);
                _resultado.MarcadorVisitante = Convert.ToInt32(Visitante);
                if (_resultado.MarcadorLocal > _resultado.MarcadorVisitante)
                {
                    _resultado.idTipoResultado = 1;
                }
                if (_resultado.MarcadorLocal == _resultado.MarcadorVisitante)
                {
                    _resultado.idTipoResultado = 3;
                }
                if (_resultado.MarcadorLocal < _resultado.MarcadorVisitante)
                {
                    _resultado.idTipoResultado = 2;
                }
                int idusuarioLogueado = Sesion.UsuarioLogueado.IdUsuario;
                _resultado.idUsuario = idusuarioLogueado;

                _lista.Add(_resultado);
            }
            return _lista;
        }
        private void LimpiarTodo()
        {
            groupBox2.Enabled = true;
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
            CargarCombos();
            txtFecha.Clear();
            //dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            
        }
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (dataGridView1.CurrentCell.ColumnIndex == 3 || dataGridView1.CurrentCell.ColumnIndex == 6) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
        }
        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion
        #region Botones
        private void btnBuscar_Click(object sender, EventArgs e)
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
                        dataGridView1.Rows.Add(_fecha[i].idPartido, _fecha[i].DiaPartido, _fecha[i].Estadio, " ", _fecha[i].EquipoLocal, _fecha[i].EquipoVisitante, " ");
                    }
                }
            }
            catch (Exception ex)
            { }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                groupBox2.Enabled = false;
                List<Resultados> _listaResultado = new List<Resultados>();
                _listaResultado = CargarEntidadResultado();
                bool Exito = ResultadoNeg.GaurdarResultados(_listaResultado);
                if (Exito == true)
                {
                    ProgressBar();
                    const string message2 = "Se registraron los resultados exitosamente.";
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
        #endregion
    }
}
