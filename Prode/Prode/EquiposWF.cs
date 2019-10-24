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
using Prode.Clases_Maestras;
using System.IO;

namespace Prode
{
    public partial class EquiposWF : MasterWF
    {
        public EquiposWF()
        {
            InitializeComponent();
        }
        private void EquiposWF_Load(object sender, EventArgs e)
        {
            FuncionesBotonHabilitarBuscar();
        }
        #region Botones
        public static string urla;
        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            try
            {
                string path = "";
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                DialogResult result = openFileDialog1.ShowDialog();
                path = openFileDialog1.FileName;
                if (path != "")
                {

                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    var imagen = Image.FromFile(path);
                    //if (imagen.Size.Height > 1024 || imagen.Size.Width > 1024)
                    //{
                    //    throw new Exception("EL TAMAÑO DE LA IMAGEN SUPERA EL PERMITIDO(1024x1024)");
                    //}
                    pictureBox1.Image = Image.FromFile(path);
                }
                if (result == DialogResult.OK)
                {
                    byte[] Imagen = null;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        Imagen = ms.ToArray();

                    }
                }
                else
                {
                    txtImagen.Text = path;
                    pictureBox1.ImageLocation = txtImagen.Text;
                }

                urla = path;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        private void btnNuevoEquipo_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionesBotonNuevoCliente();

            }
            catch (Exception ex)
            {
                const string message = "Error en el sistema. Intente nuevamente o comuniquese con el administrador.";
                const string caption = "Atención";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Warning);
                throw new Exception();
            }
        }
        private void btnHabilitarBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionesBotonHabilitarBuscar();
            }
            catch (Exception ex)
            {

            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionesBotonEditar();
            }
            catch (Exception ex)
            {
                const string message = "Error en el sistema. Intente nuevamente o comuniquese con el administrador.";
                const string caption = "Atención";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Warning);
                throw new Exception();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionesBotonCancelar();
            }
            catch (Exception ex)
            {
                const string message = "Error en el sistema. Intente nuevamente o comuniquese con el administrador.";
                const string caption = "Atención";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Warning);
                throw new Exception();
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Entidades.Equipos _equipo = CargarEntidad();
                if (groupBox3.Visible == true & groupBox3.Enabled == true)
                {
                    bool Exito = EquiposNeg.EditarEquipo(_equipo);
                    if (Exito == true)
                    {
                        ProgressBar();
                        const string message2 = "La edición del Equipo se registro exitosamente.";
                        const string caption2 = "Éxito";
                        var result2 = MessageBox.Show(message2, caption2,
                                                     MessageBoxButtons.OK,
                                                     MessageBoxIcon.Asterisk);
                        LimpiarCampos();
                    }
                }
                else
                {

                    bool Exito = EquiposNeg.GurdarEquipo(_equipo);
                    if (Exito == true)
                    {
                        ProgressBar();
                        const string message2 = "Se registro el equipo exitosamente.";
                        const string caption2 = "Éxito";
                        var result2 = MessageBox.Show(message2, caption2,
                                                     MessageBoxButtons.OK,
                                                     MessageBoxIcon.Asterisk);
                        LimpiarCampos();
                    }
                    else
                    {

                    }
                }
            }
            catch { }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Equipos> _equipo = new List<Equipos>();
                var nombreRazonSocial = txtBuscar.Text;
                _equipo = EquiposNeg.BuscarEquipoPorNombre(nombreRazonSocial);
                if (_equipo.Count > 0)
                {
                    var equipo = _equipo.First();
                    txtNombreEquipo.Text = equipo.NombreEquipo;
                    txtNombreEstadio.Text = equipo.NombreEstadio;
                    txtDireccion.Text = equipo.Direccion;
                    if (equipo.Escudo != null)
                    {
                        Bitmap foto1 = Clases_Maestras.Funciones.byteToBipmap(equipo.Escudo);
                        pictureBox1.Image = foto1;
                    }
                    btnEditar.Visible = true;
                    btnEliminar.Visible = true;
                    btnEstadisticas.Visible = true;
                }
                else
                {
                    txtBuscar.Focus();
                    const string message = "No existe ningun cliente con el nombre o razón social ingresado.";
                    const string caption = "Atención";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.OK,
                                               MessageBoxIcon.Exclamation);
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region Funciones
        private void LimpiarCampos()
        {
            txtNombreEquipo.Clear();
            txtNombreEstadio.Clear();
            txtDireccion.Clear();
            pictureBox1.Image = null;
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
            pictureBox1.Image = null;
        }
        private Equipos CargarEntidad()
        {
            Equipos _equipo = new Equipos();
            _equipo.NombreEquipo = txtNombreEquipo.Text;
            byte[] Imagen = null;
            MemoryStream ms = new MemoryStream();
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                Imagen = ms.ToArray();
            }
            _equipo.Escudo = Imagen;
            _equipo.NombreEstadio = txtNombreEstadio.Text;
            _equipo.Direccion = txtDireccion.Text;
            int idusuarioLogueado = Sesion.UsuarioLogueado.IdUsuario;
            _equipo.idUsuario = idusuarioLogueado;
            return _equipo;
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
        private void FuncionesBotonEditar()
        {
            groupBox1.Enabled = true;
            groupBox1.Text = "Editar Equipo";
        }
        private void FuncionesBotonNuevoCliente()
        {
            txtBuscar.Clear();
            groupBox3.Enabled = false;
            LimpiarCamposBotonNuevoCliente();
            groupBox1.Enabled = true;
            txtNombreEquipo.Focus();
            groupBox1.Text = "Nuevo Equipo";
            btnHabilitarBuscar.Visible = true;
        }
        private void LimpiarCamposBotonNuevoCliente()
        {
            txtNombreEquipo.Clear();
            txtNombreEstadio.Clear();
            txtDireccion.Clear();
            DateTime fecha = DateTime.Now;
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
            groupBox1.Enabled = false;
            pictureBox1.Image = null;
        }
        private void FuncionesBotonHabilitarBuscar()
        {
            txtBuscar.AutoCompleteCustomSource = Clases_Maestras.AutoCompletePorEquipo.Autocomplete();
            txtBuscar.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtBuscar.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtBuscar.Focus();
            groupBox3.Enabled = true;
            groupBox1.Enabled = false;
            LimpiarCampos();
        }
        private void FuncionesBotonCancelar()
        {
            txtNombreEstadio.Clear();
            txtNombreEquipo.Clear();
            txtDireccion.Clear();
            pictureBox1 = null;
        }
        #endregion

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuJuegosWF _juego = new MenuJuegosWF();
            _juego.Show();
            Hide();
        }
    }
}

