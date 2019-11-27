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
    public partial class AlineacionEquipoWF : Form
    {
        public AlineacionEquipoWF()
        {
            InitializeComponent();
        }

        private void AlineacionEquipoWF_Load(object sender, EventArgs e)
        {
            try
            {
                txtBuscarNombrePartido.AutoCompleteCustomSource = Clases_Maestras.AutoCompletePorPartido.Autocomplete();
                txtBuscarNombrePartido.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtBuscarNombrePartido.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtBuscarNombrePartido.Focus();


            }
            catch (Exception ex) { }
        }
        #region Botones
        public static int idPartido;
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string Partido = txtBuscarNombrePartido.Text;
                List<DetallePartido> _partido = new List<DetallePartido>();
                _partido = FutbolPartidoEstadisticaNeg.BuscarPartidoPorNombre(Partido);
                if (_partido.Count > 0)
                {
                    groupBox1.Visible = false;
                    grbDatosPartido.Visible = true;
                    var partido = _partido.First();
                    if (partido.EscudoLocal != null)
                    {
                        Bitmap foto1 = Clases_Maestras.Funciones.byteToBipmap(partido.EscudoLocal);
                        pictureBox1.Image = foto1;
                        pictureBox1.Visible = true;
                    }
                    else
                    {
                        pictureBox1.Image = Image.FromFile("C:\\ProFuSo\\Silueta Equipo.jpg");
                        pictureBox1.Visible = true;
                    }

                    if (partido.EscudoVisitante != null)
                    {
                        Bitmap foto2 = Clases_Maestras.Funciones.byteToBipmap(partido.EscudoVisitante);
                        pictureBox2.Image = foto2;
                        pictureBox2.Visible = true;
                    }
                    else
                    {
                        pictureBox2.Image = Image.FromFile("C:\\ProFuSo\\Silueta Equipo.jpg");
                        pictureBox2.Visible = true;
                    }

                    lblEstadioEdit.Text = partido.Estadio;
                    if (lblEstadioEdit.Text != null)
                    {
                        int cantidadLetras = lblEstadioEdit.Text.Length;
                        if (cantidadLetras > 8 & cantidadLetras < 10)
                        {
                            lblEstadioEdit.Font = new Font(lblEstadioEdit.Font.Name, 9);
                        }
                        if (cantidadLetras > 10 & cantidadLetras < 15)
                        {
                            lblEstadioEdit.Font = new Font(lblEstadioEdit.Font.Name, 8);
                        }
                        if (cantidadLetras > 15)
                        {
                            lblEstadioEdit.Font = new Font(lblEstadioEdit.Font.Name, 7);
                        }
                        if (cantidadLetras > 30)
                        {
                            lblEstadioEdit.Font = new Font(lblEstadioEdit.Font.Name, 6);
                        }
                    }
                    var marcador = partido.Marcador;
                    string var = marcador;
                    string Local = var.Split('-')[0];
                    string Visitante = var.Split('-')[1];
                    lblResultadoLocal.Text = Local;
                    lblResultadoVisitante.Text = Visitante;
                    lblDiaEdit.Text = partido.FechaPartido.ToShortDateString();
                    lblIdLocal.Text = Convert.ToString(partido.idEquipoLocal);
                    lblIdVistante.Text = Convert.ToString(partido.idEquipoVisitante);                   
                    idPartido = partido.idPartido;
                    HabilitarListasJugadores();
                }
            }
            catch (Exception ex) { }
        }
        public static List<string> ListaLocalesStatic;
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();
            try
            {
                if (listLocal.Items.Count > 0)
                {
                    foreach (var item in listLocal.Items)
                    {
                        lista.Add(item.ToString());
                    }
                    if (lista.Count > 0 & lista.Count <= 18)
                    {
                        string ValorIngresado = txtJugadoresLocales.Text;
                        if (!lista.Any(x => x.ToString() == ValorIngresado))
                        {
                            listLocal.Items.Add(ValorIngresado);
                            txtJugadoresLocales.Clear();
                            txtJugadoresLocales.Focus();
                        }
                        else
                        {
                            const string message = "El jugador seleccionado ya fue cargado en la lista.";
                            const string caption = "Atención";
                            var result = MessageBox.Show(message, caption,
                                                         MessageBoxButtons.OK,
                                                       MessageBoxIcon.Exclamation);
                            throw new Exception();
                            txtJugadoresLocales.Clear();
                            txtJugadoresLocales.Focus();
                        }
                    }
                    else
                    {

                        const string message = "Ya se alcanzo la cantidad maxima de jugadores permitidos por partido.";
                        const string caption = "Atención";
                        var result = MessageBox.Show(message, caption,
                                                     MessageBoxButtons.OK,
                                                   MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    string ValorIngresado = txtJugadoresLocales.Text;
                    listLocal.Items.Add(ValorIngresado);
                    txtJugadoresLocales.Clear();
                    txtJugadoresLocales.Focus();
                }

            }
            catch (Exception ex)
            { }
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                const string message = "Desea confirmar la Alineación seleccionada?";
                const string caption = "Confirmar alineación";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
                {
                    if (result == DialogResult.Yes)
                    {
                        List<string> lista = new List<string>();
                        foreach (var item in listLocal.Items)
                        {
                            var valor = item.ToString();
                            string var = valor;
                            string Apellido = var.Split(' ')[0];
                            string var2 = var.Split(' ')[1];
                            string Nombre = var2.Split(',')[0];
                            string Id = var2.Split(',')[1];
                            lista.Add(Id + "," + Apellido + " " + Nombre);
                        }
                        if (lista.Count > 0)
                        {
                            int idEquipo = Convert.ToInt32(lblIdLocal.Text);
                            DisposicionTacticaWF _disposicion = new DisposicionTacticaWF(lista, idEquipo, idPartido);
                            _disposicion.Show();
                        }
                    }
                }
            }
            catch (Exception ex)
            { }
        }
        private void btnAgregarVisitante_Click(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();
            try
            {
                if (listVisitantes.Items.Count > 0)
                {
                    foreach (var item in listVisitantes.Items)
                    {
                        lista.Add(item.ToString());
                    }
                    if (lista.Count > 0 & lista.Count <= 18)
                    {
                        string ValorIngresado = txtJugadoresVisitantes.Text;
                        if (!lista.Any(x => x.ToString() == ValorIngresado))
                        {
                            listVisitantes.Items.Add(ValorIngresado);
                            txtJugadoresVisitantes.Clear();
                            txtJugadoresVisitantes.Focus();
                        }
                        else
                        {
                            const string message = "El jugador seleccionado ya fue cargado en la lista.";
                            const string caption = "Atención";
                            var result = MessageBox.Show(message, caption,
                                                         MessageBoxButtons.OK,
                                                       MessageBoxIcon.Exclamation);
                            throw new Exception();
                            txtJugadoresVisitantes.Clear();
                            txtJugadoresVisitantes.Focus();
                        }
                    }
                    else
                    {

                        const string message = "Ya se alcanzo la cantidad maxima de jugadores permitidos por partido.";
                        const string caption = "Atención";
                        var result = MessageBox.Show(message, caption,
                                                     MessageBoxButtons.OK,
                                                   MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    string ValorIngresado = txtJugadoresVisitantes.Text;
                    listVisitantes.Items.Add(ValorIngresado);
                    txtJugadoresVisitantes.Clear();
                    txtJugadoresVisitantes.Focus();
                }

            }
            catch (Exception ex)
            { }
        }
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                listLocal.Items.RemoveAt(listLocal.SelectedIndex);
            }
            catch (Exception ex)
            { }
        }
        private void btnQuitarVisitante_Click(object sender, EventArgs e)
        {
            try
            {
                listVisitantes.Items.RemoveAt(listVisitantes.SelectedIndex);
            }
            catch (Exception ex)
            { }
        }
        #endregion
        #region Funciones
        private void HabilitarListasJugadores()
        {
            grbLocal.Visible = true;
            grbVisitante.Visible = true;
            int idEquipoLocal = Convert.ToInt32(lblIdLocal.Text);
            txtJugadoresLocales.AutoCompleteCustomSource = Clases_Maestras.AutoCompleteJugadores.Autocomplete(idEquipoLocal);
            txtJugadoresLocales.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtJugadoresLocales.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtJugadoresLocales.Focus();

            int idEquipoVisitante = Convert.ToInt32(lblIdVistante.Text);
            txtJugadoresVisitantes.AutoCompleteCustomSource = Clases_Maestras.AutoCompleteJugadores.Autocomplete(idEquipoVisitante);
            txtJugadoresVisitantes.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtJugadoresVisitantes.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }
        #endregion

        private void button3_Click(object sender, EventArgs e)
        {
            MenuFutbolWF _futbol = new MenuFutbolWF();
            _futbol.Show();
            Hide();
        }
    }
}
