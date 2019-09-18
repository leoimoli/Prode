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
    public partial class ApostadoresWF : Form
    {
        public ApostadoresWF()
        {
            InitializeComponent();
        }
        private void ApostadoresWF_Load(object sender, EventArgs e)
        {
            FuncionesHabilitarPantallaDeInicio();
        }
        #region Funciones
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
        private void FuncionesHabilitarPantallaDeInicio()
        {
            txtApellido.Focus();
            CargarComboSexo();
        }
        private void CargarComboSexo()
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
        private Apostadores CargarEntidad()
        {
            Apostadores _apostadores = new Apostadores();
            _apostadores.Apellido = txtApellido.Text;
            _apostadores.Nombre = txtNombre.Text;
            _apostadores.Dni = txtDni.Text;
            _apostadores.Sexo = cmbSexo.Text;
            _apostadores.Telefono = txtTelefono.Text;
            _apostadores.Email = txtEmail.Text;
            return _apostadores;
        }
        private void LimpiarCampos()
        {
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
            txtApellido.Clear();
            txtNombre.Clear();
            txtDni.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            CargarComboSexo();
        }
        #endregion
        #region Bototnes
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtApellido.Clear();
            txtNombre.Clear();
            txtDni.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            CargarComboSexo();
            txtApellido.Focus();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            CargarJugadasWF _jugadas = new CargarJugadasWF();
            _jugadas.Show();
            Hide();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Entidades.Apostadores _apostador = CargarEntidad();
                bool Exito = ApostadoresNeg.GuardarApostador(_apostador);
                if (Exito == true)
                {
                    ProgressBar();
                    const string message2 = "Se registro la fecha exitosamente.";
                    const string caption2 = "Éxito";
                    var result2 = MessageBox.Show(message2, caption2,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Asterisk);
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            { }
        }       
        #endregion
    }
}
