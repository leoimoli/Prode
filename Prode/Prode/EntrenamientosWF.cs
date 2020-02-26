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
    public partial class EntrenamientosWF : MasterWF
    {
        public EntrenamientosWF()
        {
            InitializeComponent();
        }

        private void EntrenamientosWF_Load(object sender, EventArgs e)
        {
            try
            {
                CargaCombos();
            }
            catch (Exception ex)
            { }
        }
        private void CargaCombos()
        {
            string[] Horarios = Clase_Maestra.ValoresConstantes.Hora;
            cmbHora.Items.Add("Seleccione");
            cmbHora.Items.Clear();
            foreach (string item in Horarios)
            {
                cmbHora.Text = "Seleccione";
                cmbHora.Items.Add(item);
            }
            string[] Lugar = Clase_Maestra.ValoresConstantes.Lugar;
            cmbLugar.Items.Add("Seleccione");
            cmbLugar.Items.Clear();
            foreach (string item in Lugar)
            {
                cmbLugar.Text = "Seleccione";
                cmbLugar.Items.Add(item);
            }
        }
        private void btnFutbol_Click(object sender, EventArgs e)
        {
            MenuFutbolWF _futbol = new MenuFutbolWF();
            _futbol.Show();
            Hide();
        }
        private void btnNuevoPartido_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            btnGuardar.Visible = true;
            btnCancelar.Visible = true;            
        }
        private void btnEtapa1_Click(object sender, EventArgs e)
        {
            try
            {
                grbEtapa1.Visible = true;
                btnEtapa2.Visible = true;
            }
            catch (Exception ex)
            { }
        }
        private void btnEtapa2_Click(object sender, EventArgs e)
        {
            try
            {
                grbEtapa2.Visible = true;
                btnEtapa3.Visible = true;
            }
            catch (Exception ex)
            { }
        }
        private void btnEtapa3_Click(object sender, EventArgs e)
        {
            try
            {
                grbEtapa3.Visible = true;
            }
            catch (Exception ex)
            { }
        }
    }
}
