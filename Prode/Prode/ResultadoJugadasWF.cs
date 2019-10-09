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
                if (e.KeyCode == Keys.Enter)
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
            }
            catch (Exception ex)
            { }
        }
        public static List<ResultadoApuestas> Lista;
        public List<Entidades.ResultadoApuestas> ListaResultadosApuestas
        {
            set
            {
                if (value.Count > 0)
                {
                    Lista = value;
                    if (value != dgvResultaApostadores.DataSource && dgvResultaApostadores.DataSource != null)
                    {
                        dgvResultaApostadores.Columns.Clear();
                        dgvResultaApostadores.Refresh();
                    }
                    dgvResultaApostadores.Visible = true;
                    dgvResultaApostadores.ReadOnly = true;
                    dgvResultaApostadores.RowHeadersVisible = false;
                    dgvResultaApostadores.DataSource = value;

                    dgvResultaApostadores.Columns[0].HeaderText = "Nro.Identificador";
                    dgvResultaApostadores.Columns[0].Width = 130;
                    dgvResultaApostadores.Columns[0].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvResultaApostadores.Columns[0].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvResultaApostadores.Columns[0].HeaderCell.Style.ForeColor = Color.White;
                    dgvResultaApostadores.Columns[0].Visible = false;

                    dgvResultaApostadores.Columns[1].HeaderText = "Apellido";
                    dgvResultaApostadores.Columns[1].Width = 150;
                    dgvResultaApostadores.Columns[1].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvResultaApostadores.Columns[1].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvResultaApostadores.Columns[1].HeaderCell.Style.ForeColor = Color.White;

                    dgvResultaApostadores.Columns[2].HeaderText = "Nombre";
                    dgvResultaApostadores.Columns[2].Width = 150;
                    dgvResultaApostadores.Columns[2].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvResultaApostadores.Columns[2].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvResultaApostadores.Columns[2].HeaderCell.Style.ForeColor = Color.White;

                    dgvResultaApostadores.Columns[3].HeaderText = "Aciertos";
                    dgvResultaApostadores.Columns[3].Width = 80;
                    dgvResultaApostadores.Columns[3].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvResultaApostadores.Columns[3].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvResultaApostadores.Columns[3].HeaderCell.Style.ForeColor = Color.White;

                    DataGridViewButtonColumn BotonVer = new DataGridViewButtonColumn();
                    BotonVer.Name = "Ver";
                    BotonVer.HeaderText = "Ver";
                    this.dgvResultaApostadores.Columns.Add(BotonVer);
                    dgvResultaApostadores.Columns[28].Width = 80;
                    dgvResultaApostadores.Columns[28].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvResultaApostadores.Columns[28].HeaderCell.Style.Font = new Font("Tahoma", 10, FontStyle.Bold);
                    dgvResultaApostadores.Columns[28].HeaderCell.Style.ForeColor = Color.White;
                }
            }
        }
        #endregion
        #region Botones
        private void dgvResultaApostadores_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvResultaApostadores.Columns[e.ColumnIndex].Name == "Ver" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell BotonVer = this.dgvResultaApostadores.Rows[e.RowIndex].Cells["Ver"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\" + @"lupa.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 5, e.CellBounds.Top + 5);
                this.dgvResultaApostadores.Rows[e.RowIndex].Height = icoAtomico.Height + 6;
                this.dgvResultaApostadores.Columns[e.ColumnIndex].Width = icoAtomico.Width + 6;
                e.Handled = true;
            }
        }
        private void ClickBoton(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvResultaApostadores.CurrentCell.ColumnIndex == 28)
            {
                var idsubCliente = Convert.ToString(this.dgvResultaApostadores.CurrentRow.Cells[0].Value);
                //_vista.Show();
                Hide();
            }
        }
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
                ListaResultadosApuestas = ApostadoresNeg.BuscarAciertos(Torneo, Temporada, NroFecha);
            }
            catch (Exception ex)
            { }
        }
        #endregion
    }
}
