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
                if (groupBox3.Visible == true)
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
        #endregion
        #region Funciones
        private void LimpiarCampos()
        {
            txtNombreEquipo.Clear();
            txtNombreEstadio.Clear();
            txtDireccion.Clear();
            pictureBox1 = null;
        }
        private Equipos CargarEntidad()
        {
            Equipos _equipo = new Equipos();
            _equipo.NombreEquipo = txtNombreEquipo.Text;
            //_equipo.Escudo = pictureBox1.Text;
            _equipo.NombreEquipo = txtNombreEquipo.Text;
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
            pictureBox1 = null;
        }
        private void FuncionesBotonHabilitarBuscar()
        {
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
    }
    #endregion

}

