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
    public partial class AsignarJugadorEquipoWF : Form
    {
        public AsignarJugadorEquipoWF()
        {
            InitializeComponent();
        }
        private void AsignarJugadorEquipoWF_Load(object sender, EventArgs e)
        {
            txtBuscarApellidoNombre.AutoCompleteCustomSource = Clases_Maestras.AutoCompletePorJugadores.Autocomplete();
            txtBuscarApellidoNombre.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtBuscarApellidoNombre.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtBuscarApellidoNombre.Focus();
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
        private void dgvPlantel_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvPlantel.Columns[e.ColumnIndex].Name == "Ver" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell BotonVer = this.dgvPlantel.Rows[e.RowIndex].Cells["Ver"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\" + @"lupa.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 5, e.CellBounds.Top + 5);
                this.dgvPlantel.Rows[e.RowIndex].Height = icoAtomico.Height + 6;
                this.dgvPlantel.Columns[e.ColumnIndex].Width = icoAtomico.Width + 6;
                e.Handled = true;
            }
        }
        private void ClickBoton(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPlantel.CurrentCell.ColumnIndex == 4)
            {
                //var apellido = Convert.ToString(this.dgvPlantel.CurrentRow.Cells[1].Value);
                //var Nombre = Convert.ToString(this.dgvPlantel.CurrentRow.Cells[2].Value);
                //var Aciertos = Convert.ToString(this.dgvPlantel.CurrentRow.Cells[3].Value);
                //var NroJugada = Convert.ToString(this.dgvPlantel.CurrentRow.Cells[4].Value);
                //var ApellidoNombre = apellido + " " + Nombre;
                //ResultadoJugadaPorApostadorWF _resultado = new ResultadoJugadaPorApostadorWF(Aciertos, ApellidoNombre, NroJugada, ListaEstatica);
                //_resultado.Show();
            }
        }
        private void btnBuscarEquipos_Click(object sender, EventArgs e)
        {
            try
            {
                List<Equipos> _equipo = new List<Equipos>();
                var NombreEquipo = txtBuscar.Text;
                _equipo = EquiposNeg.BuscarEquipoPorNombre(NombreEquipo);
                if (_equipo.Count > 0)
                {
                    lblPlantel.Visible = true;
                    var Equipo = _equipo.First();
                    List<PlantelActual> _plantel = new List<PlantelActual>();
                    lblIdEquipo.Text = Convert.ToString(Equipo.idEquipo);
                    _plantel = EquiposNeg.BuscarPlantelActual(Equipo.idEquipo);
                    ListaPlantel = _plantel;
                }
            }
            catch (Exception ex)
            { }
        }
        private void btnAsignar_Click(object sender, EventArgs e)
        {
            try
            {
                bool Exito = false;
                int idJugador = Convert.ToInt32(lblId.Text);
                int idEquipoSeleccionado = Convert.ToInt32(lblIdEquipo.Text);
                if (idEquipoSeleccionado <= 0)
                {
                    const string message = "Debe seleccionar un equipo al que asignar el jugador.";
                    const string caption = "Error";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.OK,
                                               MessageBoxIcon.Exclamation);
                    throw new Exception();
                }
                string jugador = lblJugadorEdit.Text;
                var Mensaje = "Desae asignar el jugador '" + jugador + "' al equipo '" + txtBuscar.Text + "' ?";

                string message2 = Mensaje;
                const string caption2 = "Asignar Jugador";
                var result2 = MessageBox.Show(message2, caption2,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
                {
                    if (result2 == DialogResult.Yes)
                    {
                        Exito = EquiposNeg.AsignarJugarNuevoEquipo(idJugador, idEquipoSeleccionado);
                        if (Exito == true)
                        {
                            ProgressBar();
                            const string message3 = "Se asigno el jugador exitosamente.";
                            const string caption3 = "Éxito";
                            var result3 = MessageBox.Show(message3, caption3,
                                                         MessageBoxButtons.OK,
                                                         MessageBoxIcon.Asterisk);
                            LimpiarCampos();
                        }
                    }
                    else
                    {
                    }
                }
            }
            catch (Exception ex)
            { }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            JugadoresWF _jugadores = new JugadoresWF();
            _jugadores.Show();
            Hide();
        }
        #endregion
        #region Funciones
        private void LimpiarCampos()
        {
            dgvPlantel.Rows.Clear();
            groupBox2.Visible = false;
            txtBuscarApellidoNombre.Clear();
            txtBuscarApellidoNombre.Focus();
            lblJugadorEdit.Text = "";
            lblJugador.Visible = false;
            lblJugadorEdit.Visible = false;
            lblId.Text = "0";
            lblIdEquipo.Text = "0";
            pictureBox1.Visible = false;
            groupBox1.Visible = true;
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
                groupBox2.Visible = true;
                txtBuscar.Focus();
                txtBuscar.AutoCompleteCustomSource = Clases_Maestras.AutoCompletePorEquipo.Autocomplete();
                txtBuscar.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtBuscar.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtBuscar.Focus();
            }
        }
        public List<Entidades.PlantelActual> ListaPlantel
        {
            set
            {
                if (value.Count > 0)
                {
                    if (value != dgvPlantel.DataSource && dgvPlantel.DataSource != null)
                    {
                        dgvPlantel.Columns.Clear();
                        dgvPlantel.Refresh();
                    }
                    dgvPlantel.Visible = true;

                    dgvPlantel.ReadOnly = true;
                    dgvPlantel.RowHeadersVisible = false;
                    dgvPlantel.DataSource = value;

                    dgvPlantel.Columns[0].HeaderText = "Nro.Identificador";
                    dgvPlantel.Columns[0].Width = 130;
                    dgvPlantel.Columns[0].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvPlantel.Columns[0].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvPlantel.Columns[0].HeaderCell.Style.ForeColor = Color.White;
                    dgvPlantel.Columns[0].Visible = false;

                    dgvPlantel.Columns[1].HeaderText = "Posición de Campo";
                    dgvPlantel.Columns[1].Width = 80;
                    dgvPlantel.Columns[1].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvPlantel.Columns[1].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvPlantel.Columns[1].HeaderCell.Style.ForeColor = Color.White;

                    dgvPlantel.Columns[2].HeaderText = "Apellido";
                    dgvPlantel.Columns[2].Width = 150;
                    dgvPlantel.Columns[2].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvPlantel.Columns[2].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvPlantel.Columns[2].HeaderCell.Style.ForeColor = Color.White;

                    dgvPlantel.Columns[3].HeaderText = "Nombre";
                    dgvPlantel.Columns[3].Width = 150;
                    dgvPlantel.Columns[3].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvPlantel.Columns[3].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvPlantel.Columns[3].HeaderCell.Style.ForeColor = Color.White;

                    DataGridViewButtonColumn BotonVer = new DataGridViewButtonColumn();
                    BotonVer.Name = "Ver";
                    BotonVer.HeaderText = "Ver";
                    this.dgvPlantel.Columns.Add(BotonVer);
                    dgvPlantel.Columns[4].Width = 80;
                    dgvPlantel.Columns[4].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvPlantel.Columns[4].HeaderCell.Style.Font = new Font("Tahoma", 10, FontStyle.Bold);
                    dgvPlantel.Columns[4].HeaderCell.Style.ForeColor = Color.White;
                }
            }
        }
    }
    #endregion
}

