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
            List<int> ListaIdPartidos = new List<int>();
            foreach (var item in listaEstatica)
            {
                int id = item.idPartido;
                ListaIdPartidos.Add(id);
            }
            ListaResultados = ResultadoNeg.BuscarDetalleApuestaPorPartido(nroJugada, ListaIdPartidos);

        }
        public static List<EstadoResultado> ListaEstadosJugados;
        public List<Entidades.EstadoResultado> ListaResultados
        {
            set
            {
                ListaEstadosJugados = value;
                if (value.Count > 0)
                {
                    //if (value != dataGridView1.DataSource && dataGridView1.DataSource != null)
                    //{
                    //    dataGridView1.Columns.Clear();
                    //    dataGridView1.Refresh();
                    //}
                    dataGridView1.Visible = true;
                    dataGridView1.ReadOnly = true;
                    dataGridView1.RowHeadersVisible = false;
                    dataGridView1.DataSource = listaEstatica;


                    dataGridView1.Columns[0].HeaderText = "idPartido";
                    dataGridView1.Columns[0].Width = 130;
                    dataGridView1.Columns[0].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dataGridView1.Columns[0].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dataGridView1.Columns[0].Visible = false;

                    dataGridView1.Columns[1].HeaderText = "idEquipoLocal";
                    dataGridView1.Columns[1].Width = 150;
                    dataGridView1.Columns[1].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dataGridView1.Columns[1].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dataGridView1.Columns[1].HeaderCell.Style.ForeColor = Color.White;
                    dataGridView1.Columns[1].Visible = false;

                    dataGridView1.Columns[2].HeaderText = "idVisitante";
                    dataGridView1.Columns[2].Width = 150;
                    dataGridView1.Columns[2].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dataGridView1.Columns[2].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dataGridView1.Columns[2].HeaderCell.Style.ForeColor = Color.White;
                    dataGridView1.Columns[2].Visible = false;

                    dataGridView1.Columns[3].HeaderText = "Equipo Local";
                    dataGridView1.Columns[3].Width = 180;
                    dataGridView1.Columns[3].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dataGridView1.Columns[3].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dataGridView1.Columns[3].HeaderCell.Style.ForeColor = Color.White;

                    dataGridView1.Columns[4].HeaderText = "Marcado Local";
                    dataGridView1.Columns[4].Width = 100;
                    dataGridView1.Columns[4].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dataGridView1.Columns[4].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dataGridView1.Columns[4].HeaderCell.Style.ForeColor = Color.White;

                    dataGridView1.Columns[5].HeaderText = "Marcador Visitante";
                    dataGridView1.Columns[5].Width = 100;
                    dataGridView1.Columns[5].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dataGridView1.Columns[5].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dataGridView1.Columns[5].HeaderCell.Style.ForeColor = Color.White;

                    dataGridView1.Columns[6].HeaderText = "Equipo Visitante";
                    dataGridView1.Columns[6].Width = 180;
                    dataGridView1.Columns[6].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dataGridView1.Columns[6].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dataGridView1.Columns[6].HeaderCell.Style.ForeColor = Color.White;

                    dataGridView1.Columns[7].HeaderText = "idTipoResultado";
                    dataGridView1.Columns[7].Width = 80;
                    dataGridView1.Columns[7].Visible = false;

                    dataGridView1.Columns[8].HeaderText = "Usuario";
                    dataGridView1.Columns[8].Width = 80;
                    dataGridView1.Columns[8].Visible = false;

                    for (int i = 0; i < value.Count; i++)
                    {
                        if (value[i].Estado == 1)
                        {
                            dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Green;
                        }
                        else
                        {
                            dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                        }
                    }
                }
            }
        }

        //private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    //if (dataGridView1.Columns[e.ColumnIndex].Name == "FollowedUp" && e.Value != null && e.Value.ToString() == "No")
        //    //{
        //    //    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
        //    //}

        //    foreach (var item in ListaEstadosJugados)
        //    {
        //        if (item.Estado == 1 && dataGridView1.Columns[e.ColumnIndex].Name == "idPartido" && e.Value != null && e.Value.ToString() == Convert.ToString(item.idPartido))
        //        {
        //            dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Green;
        //        }
        //        else
        //        {
        //            dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
        //        }
        //    }
        //}

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
