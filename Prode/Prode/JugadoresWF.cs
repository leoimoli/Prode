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
using System.IO;
using Prode.Clases_Maestras;
using Prode.Negocio;

namespace Prode
{
    public partial class JugadoresWF : MasterWF
    {
        public JugadoresWF()
        {
            InitializeComponent();
        }
        private void JugadoresWF_Load(object sender, EventArgs e)
        {
            try
            {
                CargarCombos();
            }
            catch (Exception ex)
            { }
        }
        #region Funciones
        private void CargarCombos()
        {
            string[] Años = Clase_Maestra.ValoresConstantes.Sexo;
            cmbSexo.Items.Add("Seleccione");
            cmbSexo.Items.Clear();
            foreach (string item in Años)
            {
                cmbSexo.Text = "Seleccione";
                cmbSexo.Items.Add(item);
            }
        }
        private void FuncionesBotonNuevoJugador()
        {
            ///// Visible False          
            lblDniOApellidoNombre.Visible = false;
            txtBuscarApellidoNombre.Visible = false;
            btnBuscar.Visible = false;
            lblTexto.Visible = false;
            ///// Visible True
            groupBox2.Visible = true;
            lblApellido.Visible = true;
            lblNombre.Visible = true;
            lblDni.Visible = true;
            lblSexo.Visible = true;
            lblPeso.Visible = true;
            lblAltura.Visible = true;
            lblImagen.Visible = true;
            lblFechaNacimiento.Visible = true;
            lblApodo.Visible = true;
            btnCargarImagen.Visible = true;
            btnGuardar.Visible = true;
            btnCancelar.Visible = true;
            txtApellido.Visible = true;
            txtNombre.Visible = true;
            txtDni.Visible = true;
            cmbSexo.Visible = true;
            txtApodo.Visible = true;
            dtFechaNacimiento.Visible = true;
            txtAltura.Visible = true;
            txtPeso.Visible = true;
            pictureBox1.Visible = true;
            ///// Otras
            txtApellido.Focus();
            groupBox2.Text = "Nuevo Jugador";
            txtBuscarApellidoNombre.Clear();

        }
        private void FuncionesBotonEditar()
        {
            ///// Visible True
            groupBox2.Visible = true;
            lblDniOApellidoNombre.Visible = true;
            txtBuscarApellidoNombre.Visible = true;
            btnBuscar.Visible = true;
            ///// Visible False
            lblTexto.Visible = false;
            lblApellido.Visible = false;
            lblNombre.Visible = false;
            lblDni.Visible = false;
            lblSexo.Visible = false;
            lblPeso.Visible = false;
            lblAltura.Visible = false;
            lblImagen.Visible = false;
            lblFechaNacimiento.Visible = false;
            lblApodo.Visible = false;
            btnCargarImagen.Visible = false;
            btnGuardar.Visible = false;
            btnCancelar.Visible = false;
            txtApellido.Visible = false;
            txtNombre.Visible = false;
            txtDni.Visible = false;
            cmbSexo.Visible = false;
            txtApodo.Visible = false;
            dtFechaNacimiento.Visible = false;
            txtAltura.Visible = false;
            txtPeso.Visible = false;
            pictureBox1.Visible = false;
            ///// Otras
            txtBuscarApellidoNombre.Clear();
            txtBuscarApellidoNombre.Focus();
            groupBox2.Text = "Editar Jugador";
        }
        private void FuncionesBotonEliminarJugadorMenu()
        {
            ///// Visible True
            groupBox2.Visible = true;
            lblDniOApellidoNombre.Visible = true;
            txtBuscarApellidoNombre.Visible = true;
            btnBuscar.Visible = true;
            btnCancelar.Visible = true;
            ///// Visible False
            lblTexto.Visible = false;
            lblApellido.Visible = false;
            lblNombre.Visible = false;
            lblDni.Visible = false;
            lblSexo.Visible = false;
            lblPeso.Visible = false;
            lblAltura.Visible = false;
            lblImagen.Visible = false;
            lblFechaNacimiento.Visible = false;
            lblApodo.Visible = false;
            btnCargarImagen.Visible = false;
            btnGuardar.Visible = false;
            btnCancelar.Visible = false;
            txtApellido.Visible = false;
            txtNombre.Visible = false;
            txtDni.Visible = false;
            cmbSexo.Visible = false;
            txtApodo.Visible = false;
            dtFechaNacimiento.Visible = false;
            txtAltura.Visible = false;
            txtPeso.Visible = false;
            pictureBox1.Visible = false;
            ///// Otras
            txtBuscarApellidoNombre.Clear();
            txtBuscarApellidoNombre.Focus();
            groupBox2.Text = "Eliminar Jugador";
        }
        private void LimpiarCamposBotonCancelar()
        {
            txtBuscarApellidoNombre.Clear();
            txtApellido.Clear();
            txtNombre.Clear();
            txtDni.Clear();
            CargarCombos();
            txtApodo.Clear();
            dtFechaNacimiento.Value = DateTime.Now;
            txtPeso.Clear();
            txtAltura.Clear();
            pictureBox1.Image = null;
        }
        private void txtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar que la tecla presionada no sea CTRL u otra tecla no numerica
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // Si deseas, puedes permitir numeros decimales (o float)
            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar que la tecla presionada no sea CTRL u otra tecla no numerica
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // Si deseas, puedes permitir numeros decimales (o float)
            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar que la tecla presionada no sea CTRL u otra tecla no numerica
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // Si deseas, puedes permitir numeros decimales (o float)
            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private Jugadores CargarEntidad()
        {
            Jugadores _jugadores = new Jugadores();
            _jugadores.Apellido = txtApellido.Text;
            _jugadores.Nombre = txtNombre.Text;
            _jugadores.Dni = txtDni.Text;
            _jugadores.Sexo = cmbSexo.Text;
            _jugadores.Apodo = txtApodo.Text;
            _jugadores.FechaNacimiento = dtFechaNacimiento.Value;
            _jugadores.Altura = txtAltura.Text;
            _jugadores.Peso = txtPeso.Text;
            byte[] Imagen = null;
            MemoryStream ms = new MemoryStream();
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                Imagen = ms.ToArray();
            }
            int idusuarioLogueado = Sesion.UsuarioLogueado.IdUsuario;
            _jugadores.idUsuario = idusuarioLogueado;
            return _jugadores;
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
        private void btnJugador_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionesBotonNuevoJugador();
            }
            catch (Exception ex)
            { }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionesBotonEditar();
            }
            catch (Exception ex)
            { }
        }
        private void btnEliminarJugadorMenu_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionesBotonEliminarJugadorMenu();
            }
            catch (Exception ex)
            { }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarCamposBotonCancelar();
            }
            catch (Exception ex)
            {

            }
        }
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
                    pictureBox1.Text = path;
                    pictureBox1.ImageLocation = pictureBox1.Text;
                }

                urla = path;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        #endregion
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                bool Guardar = true;
                bool Editar = false;
                bool Eliminar = false;
                Entidades.Jugadores _jugadores = CargarEntidad();
                if (Guardar == true)
                {
                    int idJugador = JugadoresNeg.GuardarJugador(_jugadores);
                    if (idJugador > 0)
                    {
                        ProgressBar();
                        const string message2 = "Se registro el jugador exitosamente.";
                        const string caption2 = "Éxito";
                        var result2 = MessageBox.Show(message2, caption2,
                                                     MessageBoxButtons.OK,
                                                     MessageBoxIcon.Asterisk);
                        LimpiarCamposBotonCancelar();
                    }
                    else
                    {
                    }
                }
                if (Editar == true)
                {
                }
                if (Eliminar == true)
                {
                }
            }
            catch (Exception ex)
            { }
        }      
    }
}
