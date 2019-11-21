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
    public partial class DisposicionTacticaWF : Form
    {
        public DisposicionTacticaWF()
        {
            InitializeComponent();
        }

        private void DisposicionTacticaWF_Load(object sender, EventArgs e)
        {
            try
            {
                CargarComboSistema();
            }
            catch (Exception ex)
            { }
        }
        #region Botones
        #endregion
        #region Funciones
        private void CargarComboSistema()
        {
            string[] Pierna = Clase_Maestra.ValoresConstantes.DisposicionTactica;
            cmbTactica.Items.Add("Seleccione");
            cmbTactica.Items.Clear();
            foreach (string item in Pierna)
            {
                cmbTactica.Text = "Seleccione";
                cmbTactica.Items.Add(item);
            }
        }
        #endregion

        private void cmbTactica_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string Tactica = cmbTactica.Text;
                if (Tactica == "1-4-4-2")
                {
                    HabiltarCamposTactica1442();
                }
            }
            catch (Exception ex)
            { }
        }
        private void HabiltarCamposTactica1442()
        {
            HabilitarSuplentes();
            grbCancha.Visible = true;
            grbSuplentes.Visible = true;

            ////// Arqueros
            grbArquero.Visible = true;
            cmbArquero.Visible = true;

            ////// Defensores
            grbLD.Visible = true;
            grbDFD.Visible = true;
            grbLibero.Visible = false;
            grbDFI.Visible = true;
            grbLI.Visible = true;
            ////// Defensores Combos
            cmbLD.Visible = true;
            cmbDFD.Visible = true;
            cmbLIB.Visible = false;
            cmbDFI.Visible = true;
            cmbLI.Visible = true;

            ////// Volantes
            grbVD.Visible = true;
            grbVID.Visible = true;
            grbVII.Visible = true;
            grbVI.Visible = true;
            grbMC.Visible = false;
            grbMP.Visible = false;
            ////// Volantes Combos
            cmbVD.Visible = true;
            cmbVID.Visible = true;
            cmbVII.Visible = true;
            cmbVI.Visible = true;
            cmbMC.Visible = false;
            cmbMP.Visible = false;

            ////// Delanteros
            grbCD1.Visible = true;
            grbCD2.Visible = true;
            grbED.Visible = false;
            grbEI.Visible = false;
            grbCD.Visible = false;
            ////// Volantes Combos
            cmbCD1.Visible = true;
            cmbCD2.Visible = true;
            cmbED.Visible = false;
            cmbEI.Visible = false;
            cmbCD.Visible = false;

        }
        private void HabilitarSuplentes()
        {
            grbSup1.Visible = true;
            grbSup2.Visible = true;
            grbSup3.Visible = true;
            grbSup4.Visible = true;
            grbSup5.Visible = true;
            grbSup6.Visible = true;
            grbSup7.Visible = true;
        }
    }
}
