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
using Prode.Negocio;

namespace Prode
{
    public partial class ResultadoJugadaPorApostadorWF : Form
    {
        private string aciertos;
        private string apellidoNombre;
        private List<Resultados> listaEstatica;
        private string nroJugada;

        public ResultadoJugadaPorApostadorWF(string aciertos, string apellidoNombre, string nroJugada, List<Resultados> listaEstatica)
        {
            InitializeComponent();
            this.aciertos = aciertos;
            this.apellidoNombre = apellidoNombre;
            this.nroJugada = nroJugada;
            this.listaEstatica = listaEstatica;
        }

        private void ResultadoJugadaPorApostadorWF_Load(object sender, EventArgs e)
        {
            lblAciertos.Text = aciertos;
            lblApellidoNombre.Text = apellidoNombre;
            ListaResultados = ResultadoNeg.BuscarDetalleApuestaPorPartido(listaEstatica, nroJugada);

        }
        public List<Entidades.Resultados> ListaResultados
        {
            set
            {
                if (value.Count > 0)
                {
                    if (value != dataGridView1.DataSource && dataGridView1.DataSource != null)
                    {
                        dataGridView1.Columns.Clear();
                        dataGridView1.Refresh();
                    }
                    dataGridView1.Visible = true;
                    dataGridView1.ReadOnly = true;
                    dataGridView1.RowHeadersVisible = false;
                    dataGridView1.DataSource = value;

                    dataGridView1.Columns[0].HeaderText = "Nro.Identificador";
                    dataGridView1.Columns[0].Width = 130;
                    dataGridView1.Columns[0].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dataGridView1.Columns[0].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dataGridView1.Columns[0].HeaderCell.Style.ForeColor = Color.White;

                    dataGridView1.Columns[1].HeaderText = "Apellido";
                    dataGridView1.Columns[1].Width = 150;
                    dataGridView1.Columns[1].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dataGridView1.Columns[1].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dataGridView1.Columns[1].HeaderCell.Style.ForeColor = Color.White;

                    dataGridView1.Columns[2].HeaderText = "Nombre";
                    dataGridView1.Columns[2].Width = 150;
                    dataGridView1.Columns[2].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dataGridView1.Columns[2].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dataGridView1.Columns[2].HeaderCell.Style.ForeColor = Color.White;

                    dataGridView1.Columns[3].HeaderText = "Aciertos";
                    dataGridView1.Columns[3].Width = 80;
                    dataGridView1.Columns[3].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dataGridView1.Columns[3].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dataGridView1.Columns[3].HeaderCell.Style.ForeColor = Color.White;

                }
            }
        }
    }
}
