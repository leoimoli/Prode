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
            IdBoton = 0;
            IdBoton = 1;
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
            txtBuscarApellidoNombre.AutoCompleteCustomSource = Clases_Maestras.AutoCompletePorJugadores.Autocomplete();
            txtBuscarApellidoNombre.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtBuscarApellidoNombre.AutoCompleteSource = AutoCompleteSource.CustomSource;
            IdBoton = 0;
            IdBoton = 2;
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
            txtBuscarApellidoNombre.AutoCompleteCustomSource = Clases_Maestras.AutoCompletePorJugadores.Autocomplete();
            txtBuscarApellidoNombre.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtBuscarApellidoNombre.AutoCompleteSource = AutoCompleteSource.CustomSource;
            IdBoton = 0;
            IdBoton = 3;
            ///// Visible True
            groupBox2.Visible = true;
            lblDniOApellidoNombre.Visible = true;
            txtBuscarApellidoNombre.Visible = true;
            btnBuscar.Visible = true;
            ///// Visible False
            btnGuardar.Visible = false;
            btnCancelar.Visible = false;
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
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
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
            _jugadores.Imagen = Imagen;
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
        private void FuncionBuscarJugador()
        {
            if (IdBoton == 2)
            {
                btnEliminar.Visible = false;
                List<Jugadores> _jugadores = new List<Jugadores>();
                string ApellidoNombre = txtBuscarApellidoNombre.Text;
                _jugadores = JugadoresNeg.BuscarJugadoresPorApellidoYNombre(ApellidoNombre);
                if (_jugadores.Count > 0)
                {
                    var jugador = _jugadores.First();
                    txtApellido.Text = jugador.Apellido;
                    txtNombre.Text = jugador.Nombre;
                    cmbSexo.Text = jugador.Sexo;
                    txtDni.Text = jugador.Dni;
                    txtApodo.Text = jugador.Apodo;
                    dtFechaNacimiento.Value = jugador.FechaNacimiento;
                    txtAltura.Text = jugador.Altura;
                    txtPeso.Text = jugador.Peso;
                    if (jugador.Imagen != null)
                    {
                        Bitmap foto1 = Clases_Maestras.Funciones.byteToBipmap(jugador.Imagen);
                        pictureBox1.Image = foto1;
                    }
                    lblIdJugador.Text = Convert.ToString(jugador.idJugador);
                    HabilitarCamposEditables();
                }
            }
            if (IdBoton == 3)
            {
                btnEliminar.Visible = false;
                List<Jugadores> _jugadores = new List<Jugadores>();
                string ApellidoNombre = txtBuscarApellidoNombre.Text;
                _jugadores = JugadoresNeg.BuscarJugadoresPorApellidoYNombre(ApellidoNombre);
                if (_jugadores.Count > 0)
                {
                    btnEliminar.Visible = true;
                    var jugador = _jugadores.First();
                    txtApellido.Text = jugador.Apellido;
                    txtNombre.Text = jugador.Nombre;
                    cmbSexo.Text = jugador.Sexo;
                    txtDni.Text = jugador.Dni;
                    txtApodo.Text = jugador.Apodo;
                    dtFechaNacimiento.Value = jugador.FechaNacimiento;
                    txtAltura.Text = jugador.Altura;
                    txtPeso.Text = jugador.Peso;
                    if (jugador.Imagen != null)
                    {
                        Bitmap foto1 = Clases_Maestras.Funciones.byteToBipmap(jugador.Imagen);
                        pictureBox1.Image = foto1;
                    }
                    lblIdJugador.Text = Convert.ToString(jugador.idJugador);
                    HabilitarCamposEliminar();
                }
            }
        }
        private void HabilitarCamposEliminar()
        {
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
            txtApellido.Visible = true;
            txtNombre.Visible = true;
            txtDni.Visible = true;
            cmbSexo.Visible = true;
            txtApodo.Visible = true;
            dtFechaNacimiento.Visible = true;
            txtAltura.Visible = true;
            txtPeso.Visible = true;
            pictureBox1.Visible = true;

            ///// Campos NO editables
            txtApellido.Enabled = false;
            txtNombre.Enabled = false;
            cmbSexo.Enabled = false;
            txtDni.Enabled = false;
            txtApodo.Enabled = false;
            dtFechaNacimiento.Enabled = false;
            txtAltura.Enabled = false;
            txtPeso.Enabled = false;
            pictureBox1.Enabled = false;
        }
        private void HabilitarCamposEditables()
        {
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

            ///// Campos NO editables
            txtApellido.Enabled = false;
            txtNombre.Enabled = false;
            cmbSexo.Enabled = false;
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
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionBuscarJugador();
            }
            catch (Exception ex)
            { }
        }
        public static int IdBoton;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                Entidades.Jugadores _jugadores = CargarEntidad();
                if (IdBoton == 1)
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
                        FuncionesBotonNuevoJugador();
                    }
                    else
                    {
                    }
                }
                if (IdBoton == 2)
                {
                    int idjugador = Convert.ToInt32(lblIdJugador.Text);
                    bool Exito = JugadoresNeg.EditarJugador(_jugadores, idjugador);
                    if (Exito == true)
                    {
                        ProgressBar();
                        const string message2 = "Se edito el jugador exitosamente.";
                        const string caption2 = "Éxito";
                        var result2 = MessageBox.Show(message2, caption2,
                                                     MessageBoxButtons.OK,
                                                     MessageBoxIcon.Asterisk);
                        LimpiarCamposBotonCancelar();
                        FuncionesBotonEditar();
                    }
                    else
                    {
                    }
                }
            }
            catch (Exception ex)
            { }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idjugador = Convert.ToInt32(lblIdJugador.Text);
            const string message = "Desea eliminar el jugador seleccionado?";
            const string caption = "Eliminar Jugador";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            {
                if (result == DialogResult.Yes)
                {
                    bool Exito = JugadoresNeg.EliminarJugador(idjugador);
                    if (Exito == true)
                    {
                        ProgressBar();
                        const string message2 = "Se eliminó el jugador exitosamente.";
                        const string caption2 = "Éxito";
                        var result2 = MessageBox.Show(message2, caption2,
                                                     MessageBoxButtons.OK,
                                                     MessageBoxIcon.Asterisk);
                        LimpiarCamposBotonCancelar();
                        FuncionesBotonEliminarJugadorMenu();
                        btnEliminar.Visible = false;
                    }
                }

                else
                { }
            }
        }
        #endregion          
    }
}
