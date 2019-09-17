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
            InicioWF _inicio = new InicioWF();
            _inicio.Show();
            Hide();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Entidades.Apostadores _apostador = CargarEntidad();
                bool Exito = ApostadoresNeg.GuardarApostador(_apostador);
            }
            catch (Exception ex)
            { }
        }
        #endregion
    }
}
