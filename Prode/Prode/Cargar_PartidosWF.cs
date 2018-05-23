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
    public partial class Cargar_PartidosWF : Form
    {
        public Cargar_PartidosWF()
        {
            InitializeComponent();
        }

        private void Cargar_PartidosWF_Load(object sender, EventArgs e)
        {
            CargarCombosSeleccionesMundial();
            CargarComboEstadios();
        }

        private void CargarComboEstadios()
        {
            string[] Perfiles = Clase_Maestra.ValoresConstantes.Estadios;
            cmbEstadio.Items.Add("Seleccione");
            cmbEstadio.Items.Clear();
            foreach (string item in Perfiles)
            {
                cmbEstadio.Text = "Seleccione";
                cmbEstadio.Items.Add(item);
            }
        }

        private void CargarCombosSeleccionesMundial()
        {
            List<string> Selecciones = new List<string>();
            Selecciones = Negocio.Consultar.CargarComboSelecciones();
            if (Selecciones.Count > 0)
            {
                comboBox1.Items.Add("Seleccione");
                comboBox1.Items.Clear();
                foreach (string item in Selecciones)
                {
                    comboBox1.Text = "Seleccione";
                    comboBox1.Items.Add(item);
                }
            }
            if (comboBox1.Items.Count > 0)
            {
                comboBox2.Items.Add("Seleccione");
                comboBox2.Items.Clear();
                foreach (string item in Selecciones)
                {
                    comboBox2.Text = "Seleccione";
                    comboBox2.Items.Add(item);
                }
            }

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int Equipo1 = Convert.ToInt32(comboBox1.Text.Split(';')[0].ToString());
            int Equipo2 = Convert.ToInt32(comboBox2.Text.Split(';')[0].ToString());
            string Estadio = cmbEstadio.Text;
            DateTime Fecha = dateTimePicker1.Value;
           bool Exito =  Negocio.Insert.GuardarPartido(Equipo1, Equipo2,Estadio,Fecha);
        }
    }
}
