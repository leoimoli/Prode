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
        private void btnCargar1_Click(object sender, EventArgs e)
        {
            int Existe = 0;
            string valor = listBox2.SelectedItem.ToString();
            List<string> listaExistente = new List<string>();

            foreach (var item in listBox1.Items)
            {
                string valorItem = Convert.ToString(item);
                listaExistente.Add(valorItem);
            }
            foreach (var item in listaExistente)
            {
                string ValorExistente = Convert.ToString(item);
                if (valor == ValorExistente)
                {
                    Existe = 1;
                }
            }
            if (Existe == 0)
            {
                listBox1.Items.Add(listBox2.SelectedItem.ToString());
            }
        }
        private void btnQuitar1_Click(object sender, EventArgs e)
        {
            string valorQuitar;
            if (listBox1.SelectedItem != null)
            {
                valorQuitar = listBox1.SelectedItem.ToString();
                listBox1.Items.Remove(valorQuitar);
            }
            else
            {
                const string message2 = "Debe seleccionar un elemento para borrar.";
                const string caption2 = "Atención";
                var result2 = MessageBox.Show(message2, caption2,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Exclamation);
            }
        }
        private void btnCargar2_Click(object sender, EventArgs e)
        {
            int Existe = 0;
            string valor = listBox4.SelectedItem.ToString();
            List<string> listaExistente = new List<string>();

            foreach (var item in listBox3.Items)
            {
                string valorItem = Convert.ToString(item);
                listaExistente.Add(valorItem);
            }
            foreach (var item in listaExistente)
            {
                string ValorExistente = Convert.ToString(item);
                if (valor == ValorExistente)
                {
                    Existe = 1;
                }
            }
            if (Existe == 0)
            {
                listBox3.Items.Add(listBox4.SelectedItem.ToString());
            }
        }
        private void btnCargar3_Click(object sender, EventArgs e)
        {
            int Existe = 0;
            string valor = listBox6.SelectedItem.ToString();
            List<string> listaExistente = new List<string>();

            foreach (var item in listBox5.Items)
            {
                string valorItem = Convert.ToString(item);
                listaExistente.Add(valorItem);
            }
            foreach (var item in listaExistente)
            {
                string ValorExistente = Convert.ToString(item);
                if (valor == ValorExistente)
                {
                    Existe = 1;
                }
            }
            if (Existe == 0)
            {
                listBox5.Items.Add(listBox6.SelectedItem.ToString());
            }
        }
        private void btnQuitar2_Click(object sender, EventArgs e)
        {
            string valorQuitar;
            if (listBox3.SelectedItem != null)
            {
                valorQuitar = listBox3.SelectedItem.ToString();
                listBox1.Items.Remove(valorQuitar);
            }
            else
            {
                const string message2 = "Debe seleccionar un elemento para borrar.";
                const string caption2 = "Atención";
                var result2 = MessageBox.Show(message2, caption2,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Exclamation);
            }
        }
        private void btnQuitar3_Click(object sender, EventArgs e)
        {
            string valorQuitar;
            if (listBox5.SelectedItem != null)
            {
                valorQuitar = listBox5.SelectedItem.ToString();
                listBox1.Items.Remove(valorQuitar);
            }
            else
            {
                const string message2 = "Debe seleccionar un elemento para borrar.";
                const string caption2 = "Atención";
                var result2 = MessageBox.Show(message2, caption2,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Exclamation);
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Entidades.Entre _apostador = CargarEntidad();
                bool Exito = ApostadoresNeg.GuardarApostador(_apostador);
            }
            catch(Exception ex)
            { }
        }
    }
}
