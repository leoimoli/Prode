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
            ValorCheck = 1;
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
                BuscarEquipoPlantelPorNombre();

            }
            catch (Exception ex)
            { }
        }
        private void BuscarEquipoPlantelPorNombre()
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
        private void btnAsignar_Click(object sender, EventArgs e)
        {
            try
            {
                bool Exito = false;
                if (ValorCheck == 1)
                {
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
                if (ValorCheck == 2)
                {
                    List<int> ListaId = new List<int>();
                    DataGridViewCheckBoxCell oCell;
                    foreach (DataGridViewRow row in dgvMasiva.Rows)
                    {
                        oCell = row.Cells[3] as DataGridViewCheckBoxCell;
                        bool bChecked = (null != oCell && null != oCell.Value && true == (bool)oCell.Value);
                        if (true == bChecked)
                        {
                            int Valor = Convert.ToInt32(row.Cells[0].Value.ToString());
                            ListaId.Add(Valor);
                        }
                    }
                    if (ListaId.Count > 0)
                    {
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
                        var Mensaje = "Desae asignar los jugadores seleccionados al equipo '" + txtBuscar.Text + "' ?";

                        string message2 = Mensaje;
                        const string caption2 = "Asignar Jugador";
                        var result2 = MessageBox.Show(message2, caption2,
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

                        {
                            if (result2 == DialogResult.Yes)
                            {
                                Exito = EquiposNeg.CargaMasivaDeAsignaciones(ListaId, idEquipoSeleccionado);
                                if (Exito == true)
                                {
                                    ProgressBar();
                                    const string message3 = "Se asignaron los jugadores seleccionados exitosamente.";
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
            BuscarEquipoPlantelPorNombre();
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
            dgvMasiva.Visible = false;
            chcPersonal.Checked = true;
            groupBox1.Visible = true;
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
                    lblTotal.Visible = true;
                    lblTotalEdit.Visible = true;
                    lblTotalEdit.Text = Convert.ToString(value.Count);
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
        private void chcPersonal_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chcPersonal.Checked == true)
                {
                    ValorCheck = 1;
                    dgvMasiva.Visible = false;
                    chcMasiva.Checked = false;
                    groupBox1.Visible = true;
                    txtBuscarApellidoNombre.Focus();
                }
            }
            catch (Exception ex)
            { }
        }
        public static int ValorCheck;
        private void chcMasiva_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chcMasiva.Checked == true)
                {
                    groupBox2.Visible = false;
                    LimpiarCampos();
                    ValorCheck = 2;
                    chcPersonal.Checked = false;
                    groupBox1.Visible = false;
                    lblJugador.Visible = false;
                    lblJugadorEdit.Visible = false;
                    pictureBox1.Visible = false;
                    ListaResultados = JugadoresNeg.BuscarJugadoresSinAsignar();
                }
            }
            catch (Exception ex)
            { }
        }
        public List<Entidades.AlineacionEquipo> ListaResultados
        {
            set
            {
                if (value.Count > 0)
                {

                    groupBox2.Visible = true;
                    txtBuscar.Focus();
                    txtBuscar.AutoCompleteCustomSource = Clases_Maestras.AutoCompletePorEquipo.Autocomplete();
                    txtBuscar.AutoCompleteMode = AutoCompleteMode.Suggest;
                    txtBuscar.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    txtBuscar.Focus();
                    if (value != dgvMasiva.DataSource && dgvMasiva.DataSource != null)
                    {
                        dgvMasiva.Columns.Clear();
                        dgvMasiva.Refresh();
                    }
                    dgvMasiva.Visible = true;
                    dgvMasiva.ReadOnly = true;
                    dgvMasiva.RowHeadersVisible = false;
                    dgvMasiva.DataSource = value;

                    dgvMasiva.Columns[0].HeaderText = "Nro.Identificador";
                    dgvMasiva.Columns[0].Width = 130;
                    dgvMasiva.Columns[0].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvMasiva.Columns[0].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvMasiva.Columns[0].HeaderCell.Style.ForeColor = Color.White;
                    dgvMasiva.Columns[0].Visible = false;

                    dgvMasiva.Columns[1].HeaderText = "Apellido";
                    dgvMasiva.Columns[1].Width = 150;
                    dgvMasiva.Columns[1].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvMasiva.Columns[1].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvMasiva.Columns[1].HeaderCell.Style.ForeColor = Color.White;

                    dgvMasiva.Columns[2].HeaderText = "Nombre";
                    dgvMasiva.Columns[2].Width = 150;
                    dgvMasiva.Columns[2].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvMasiva.Columns[2].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvMasiva.Columns[2].HeaderCell.Style.ForeColor = Color.White;

                    DataGridViewCheckBoxColumn Seleccionar = new DataGridViewCheckBoxColumn();
                    Seleccionar.Name = "Seleccionar";
                    Seleccionar.HeaderText = "Seleccionar";
                    this.dgvMasiva.Columns.Add(Seleccionar);
                    dgvMasiva.Columns[3].Width = 100;
                    dgvMasiva.Columns[3].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvMasiva.Columns[3].HeaderCell.Style.Font = new Font("Tahoma", 10, FontStyle.Bold);
                    dgvMasiva.Columns[3].HeaderCell.Style.ForeColor = Color.White;
                }
                else
                {
                    const string message3 = "No se encontraron jugadores disponibles para ser asignados.";
                    const string caption3 = "Atención";
                    var result3 = MessageBox.Show(message3, caption3,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Exclamation);
                }
            }
        }
        private void dgvMasiva_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCheckBoxCell ch1 = new DataGridViewCheckBoxCell();
            ch1 = (DataGridViewCheckBoxCell)dgvMasiva.Rows[dgvMasiva.CurrentRow.Index].Cells[3];

            if (ch1.Value == null)
                ch1.Value = false;
            switch (ch1.Value.ToString())
            {
                case "True":
                    ch1.Value = false;
                    break;
                case "False":
                    ch1.Value = true;
                    break;
            }
        }
        #endregion
    }
}

