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
        #endregion
        #region Funciones
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
                foreach (var item in value)
                {
                    if (item.Imagen == null)
                    {

                        string path = "";
                        path = "C:\\ProFuSo\\Silueta Jugador.jpg";
                        var imagen = Image.FromFile(path);
                        //imagen.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {

                    }
                    if (value.Count > 0)
                    {
                        if (value != dgvPlantel.DataSource && dgvPlantel.DataSource != null)
                        {
                            dgvPlantel.Columns.Clear();
                            dgvPlantel.Refresh();
                        }
                        dgvPlantel.Visible = true;
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

                        dgvPlantel.Columns[1].HeaderText = "Apellido";
                        dgvPlantel.Columns[1].Width = 150;
                        dgvPlantel.Columns[1].HeaderCell.Style.BackColor = Color.DarkBlue;
                        dgvPlantel.Columns[1].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                        dgvPlantel.Columns[1].HeaderCell.Style.ForeColor = Color.White;

                        dgvPlantel.Columns[2].HeaderText = "Nombre";
                        dgvPlantel.Columns[2].Width = 150;
                        dgvPlantel.Columns[2].HeaderCell.Style.BackColor = Color.DarkBlue;
                        dgvPlantel.Columns[2].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                        dgvPlantel.Columns[2].HeaderCell.Style.ForeColor = Color.White;

                        dgvPlantel.Columns[3].HeaderText = "Posición";
                        dgvPlantel.Columns[3].Width = 80;
                        dgvPlantel.Columns[3].HeaderCell.Style.BackColor = Color.DarkBlue;
                        dgvPlantel.Columns[3].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                        dgvPlantel.Columns[3].HeaderCell.Style.ForeColor = Color.White;

                        dgvPlantel.Columns[4].HeaderText = "Foto";
                        dgvPlantel.Columns[4].Width = 100;
                        dgvPlantel.Columns[4].HeaderCell.Style.BackColor = Color.DarkBlue;
                        dgvPlantel.Columns[4].HeaderCell.Style.Font = new Font("Tahoma", 10, FontStyle.Bold);
                        dgvPlantel.Columns[4].HeaderCell.Style.ForeColor = Color.White;
                        ((DataGridViewImageColumn)dgvPlantel.Columns[4]).ImageLayout = DataGridViewImageCellLayout.Stretch;                  
                    }
                }
            }
        }
        #endregion

        private void btnBuscarEquipos_Click(object sender, EventArgs e)
        {
            try
            {
                List<Equipos> _equipo = new List<Equipos>();
                var NombreEquipo = txtBuscar.Text;
                _equipo = EquiposNeg.BuscarEquipoPorNombre(NombreEquipo);
                if (_equipo.Count > 0)
                {
                    var Equipo = _equipo.First();
                    List<PlantelActual> _plantel = new List<PlantelActual>();
                    _plantel = EquiposNeg.BuscarPlantelActual(Equipo.idEquipo);
                    ListaPlantel = _plantel;
                }
            }
            catch (Exception ex)
            { }
        }
    }
}
