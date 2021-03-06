﻿using System;
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
    public partial class DisposicionTacticaWF : Form
    {
        private List<string> listAlineacion;
        private int idEquipos;
        private int idPartidos;
        private int MarcadorLocal;
        public DisposicionTacticaWF(List<string> listAlineacion, int idEquipo, int idPartido, int MarcadorLocal)
        {
            InitializeComponent();
            this.listAlineacion = listAlineacion;
            listaRecibida = listAlineacion;
            this.idEquipos = idEquipo;
            this.idPartidos = idPartido;
            this.MarcadorLocal = MarcadorLocal;
        }
        private void DisposicionTacticaWF_Load(object sender, EventArgs e)
        {
            try
            {
                CargarComboSistemaFutbol11();
                CargarComboJugadores();
                CargarComboMinutos();
            }
            catch (Exception ex)
            { }
        }
        public static List<string> listaRecibida;
        private void CargarComboJugadores()
        {
            string[] Jugador = listaRecibida.ToArray();
            cmbArquero.Items.Add("Seleccione");
            cmbArquero.Items.Clear();
            foreach (string item in Jugador)
            {
                cmbArquero.Text = "Seleccione";
                cmbArquero.Items.Add(item.ToString());
            }

            /////// Defensores
            string[] LD = listaRecibida.ToArray(); ;
            cmbLD.Items.Add("Seleccione");
            cmbLD.Items.Clear();
            foreach (string item in LD)
            {
                cmbLD.Text = "Seleccione";
                cmbLD.Items.Add(item);
            }
            string[] DFD = listaRecibida.ToArray();
            cmbDFD.Items.Add("Seleccione");
            cmbDFD.Items.Clear();
            foreach (string item in DFD)
            {
                cmbDFD.Text = "Seleccione";
                cmbDFD.Items.Add(item);
            }
            string[] LIB = listaRecibida.ToArray();
            cmbLIB.Items.Add("Seleccione");
            cmbLIB.Items.Clear();
            foreach (string item in LIB)
            {
                cmbLIB.Text = "Seleccione";
                cmbLIB.Items.Add(item);
            }
            string[] DFI = listaRecibida.ToArray();
            cmbDFI.Items.Add("Seleccione");
            cmbDFI.Items.Clear();
            foreach (string item in DFI)
            {
                cmbDFI.Text = "Seleccione";
                cmbDFI.Items.Add(item);
            }
            string[] LI = listaRecibida.ToArray();
            cmbLI.Items.Add("Seleccione");
            cmbLI.Items.Clear();
            foreach (string item in LI)
            {
                cmbLI.Text = "Seleccione";
                cmbLI.Items.Add(item);
            }

            /////// Volantes
            string[] VD = listaRecibida.ToArray(); ;
            cmbVD.Items.Add("Seleccione");
            cmbVD.Items.Clear();
            foreach (string item in VD)
            {
                cmbVD.Text = "Seleccione";
                cmbVD.Items.Add(item);
            }
            string[] VID = listaRecibida.ToArray();
            cmbVID.Items.Add("Seleccione");
            cmbVID.Items.Clear();
            foreach (string item in VID)
            {
                cmbVID.Text = "Seleccione";
                cmbVID.Items.Add(item);
            }
            string[] MC = listaRecibida.ToArray();
            cmbMC.Items.Add("Seleccione");
            cmbMC.Items.Clear();
            foreach (string item in MC)
            {
                cmbMC.Text = "Seleccione";
                cmbMC.Items.Add(item);
            }
            string[] VII = listaRecibida.ToArray();
            cmbVII.Items.Add("Seleccione");
            cmbVII.Items.Clear();
            foreach (string item in VII)
            {
                cmbVII.Text = "Seleccione";
                cmbVII.Items.Add(item);
            }
            string[] VI = listaRecibida.ToArray();
            cmbVI.Items.Add("Seleccione");
            cmbVI.Items.Clear();
            foreach (string item in VI)
            {
                cmbVI.Text = "Seleccione";
                cmbVI.Items.Add(item);
            }
            string[] MP = listaRecibida.ToArray();
            cmbMP.Items.Add("Seleccione");
            cmbMP.Items.Clear();
            foreach (string item in MP)
            {
                cmbMP.Text = "Seleccione";
                cmbMP.Items.Add(item);
            }

            /////// Delanteros
            string[] ED = listaRecibida.ToArray(); ;
            cmbED.Items.Add("Seleccione");
            cmbED.Items.Clear();
            foreach (string item in ED)
            {
                cmbED.Text = "Seleccione";
                cmbED.Items.Add(item);
            }
            string[] CD1 = listaRecibida.ToArray();
            cmbCD1.Items.Add("Seleccione");
            cmbCD1.Items.Clear();
            foreach (string item in CD1)
            {
                cmbCD1.Text = "Seleccione";
                cmbCD1.Items.Add(item);
            }
            string[] CD = listaRecibida.ToArray();
            cmbCD.Items.Add("Seleccione");
            cmbCD.Items.Clear();
            foreach (string item in CD)
            {
                cmbCD.Text = "Seleccione";
                cmbCD.Items.Add(item);
            }
            string[] CD2 = listaRecibida.ToArray();
            cmbCD2.Items.Add("Seleccione");
            cmbCD2.Items.Clear();
            foreach (string item in CD2)
            {
                cmbCD2.Text = "Seleccione";
                cmbCD2.Items.Add(item);
            }
            string[] EI = listaRecibida.ToArray();
            cmbEI.Items.Add("Seleccione");
            cmbEI.Items.Clear();
            foreach (string item in EI)
            {
                cmbEI.Text = "Seleccione";
                cmbEI.Items.Add(item);
            }

            /////// Suplentes
            string[] Sup1 = listaRecibida.ToArray(); ;
            cmbSup1.Items.Add("Seleccione");
            cmbSup1.Items.Clear();
            foreach (string item in Sup1)
            {
                cmbSup1.Text = "Seleccione";
                cmbSup1.Items.Add(item);
            }
            string[] Sup2 = listaRecibida.ToArray();
            cmbSup2.Items.Add("Seleccione");
            cmbSup2.Items.Clear();
            foreach (string item in Sup2)
            {
                cmbSup2.Text = "Seleccione";
                cmbSup2.Items.Add(item);
            }
            string[] Sup3 = listaRecibida.ToArray();
            cmbSup3.Items.Add("Seleccione");
            cmbSup3.Items.Clear();
            foreach (string item in Sup3)
            {
                cmbSup3.Text = "Seleccione";
                cmbSup3.Items.Add(item);
            }
            string[] Sup4 = listaRecibida.ToArray();
            cmbSup4.Items.Add("Seleccione");
            cmbSup4.Items.Clear();
            foreach (string item in Sup4)
            {
                cmbSup4.Text = "Seleccione";
                cmbSup4.Items.Add(item);
            }
            string[] Sup5 = listaRecibida.ToArray();
            cmbSup5.Items.Add("Seleccione");
            cmbSup5.Items.Clear();
            foreach (string item in Sup5)
            {
                cmbSup5.Text = "Seleccione";
                cmbSup5.Items.Add(item);
            }
            string[] Sup6 = listaRecibida.ToArray();
            cmbSup6.Items.Add("Seleccione");
            cmbSup6.Items.Clear();
            foreach (string item in Sup6)
            {
                cmbSup6.Text = "Seleccione";
                cmbSup6.Items.Add(item);
            }
            string[] Sup7 = listaRecibida.ToArray();
            cmbSup7.Items.Add("Seleccione");
            cmbSup7.Items.Clear();
            foreach (string item in Sup7)
            {
                cmbSup7.Text = "Seleccione";
                cmbSup7.Items.Add(item);
            }
        }
        #region Botones
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                BloquearPantalla();
                ProgressBar();
                List<string> listaEstadistica = new List<string>();
                string SistemaTactico = cmbTactica.Text;
                listaEstadistica = CargarEntidad();
                bool Exito = FutbolEstadisticaJugadorNeg.GuardarEstadisticaJugador(listaEstadistica, SistemaTactico, idEquipos, idPartidos);
                if (Exito == true)
                {
                    const string message2 = "Se registro la formación del equipo exitosamente.";
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
        #region Funciones       
        private void AsignarMinutosJugadoresTitulares(string minutos)
        {
            ////// Arqueros
            txtMinARQ.Text = minutos;
            ////// Defensores
            txtMinLD.Text = minutos;
            txtMinDFD.Text = minutos;
            txtMinLIB.Text = minutos;
            txtMinDFI.Text = minutos;
            txtMinLI.Text = minutos;
            ////// Volantes
            txtMinVD.Text = minutos;
            txtMinVID.Text = minutos;
            txtMinVII.Text = minutos;
            txtMinVI.Text = minutos;
            txtMinMC.Text = minutos;
            txtMinMP.Text = minutos;
            ////// Delanteros
            txtMinCD1.Text = minutos;
            txtMinCD2.Text = minutos;
            txtMinED.Text = minutos;
            txtMinEI.Text = minutos;
            txtMinCD.Text = minutos;
        }
        private void CargarComboMinutos()
        {
            string[] Minutos = Clase_Maestra.ValoresConstantes.MinutosDePartido;
            cmbMinutos.Items.Add("Seleccione");
            cmbMinutos.Items.Clear();
            foreach (string item in Minutos)
            {
                cmbMinutos.Text = "Seleccione";
                cmbMinutos.Items.Add(item);
            }
        }
        private void ValidarJugadorYaExistente(string Jugador)
        {
            List<int> lista = new List<int>();
            if (idListaJugadoresCargado != null)
            {
                lista = idListaJugadoresCargado;
            }
            var valor = Jugador;
            string var = valor;
            string Id = var.Split(',')[0];
            string var2 = var.Split(',')[1];
            string Apellido = var2.Split(' ')[0];
            string Nombre = var2.Split(' ')[1];
            int idJugador = Convert.ToInt32(Id);
            if (idListaJugadoresCargado != null)
            {
                foreach (var item in idListaJugadoresCargado)
                {
                    if (item == idJugador)
                    {
                        const string message = "El Jugador seleccionado ya fue asignado en otra posición.";
                        const string caption = "Atención";
                        var result = MessageBox.Show(message, caption,
                                                     MessageBoxButtons.OK,
                                                   MessageBoxIcon.Exclamation);
                        throw new Exception();
                    }
                }
            }
            lista.Add(idJugador);
            idListaJugadoresCargado = lista;
        }
        private void CargarComboSistemaFutbol11()
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
        private void CargarComboSistemaFutbol7()
        {
            string[] Pierna = Clase_Maestra.ValoresConstantes.DisposicionTacticaFutbol7;
            cmbTactica.Items.Add("Seleccione");
            cmbTactica.Items.Clear();
            foreach (string item in Pierna)
            {
                cmbTactica.Text = "Seleccione";
                cmbTactica.Items.Add(item);
            }
        }
        private void CargarComboSistemaFutbol5()
        {
            string[] Pierna = Clase_Maestra.ValoresConstantes.DisposicionTacticaFutbol5;
            cmbTactica.Items.Add("Seleccione");
            cmbTactica.Items.Clear();
            foreach (string item in Pierna)
            {
                cmbTactica.Text = "Seleccione";
                cmbTactica.Items.Add(item);
            }
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
        private void HabiltarCamposTactica1433()
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
            grbVD.Visible = false;
            grbVID.Visible = true;
            grbVII.Visible = true;
            grbVI.Visible = false;
            grbMC.Visible = true;
            grbMP.Visible = false;
            ////// Volantes Combos
            cmbVD.Visible = false;
            cmbVID.Visible = true;
            cmbVII.Visible = true;
            cmbVI.Visible = false;
            cmbMC.Visible = true;
            cmbMP.Visible = false;

            ////// Delanteros
            grbCD1.Visible = false;
            grbCD2.Visible = false;
            grbED.Visible = true;
            grbEI.Visible = true;
            grbCD.Visible = true;
            ////// Volantes Combos
            cmbCD1.Visible = false;
            cmbCD2.Visible = false;
            cmbED.Visible = true;
            cmbEI.Visible = true;
            cmbCD.Visible = true;
        }
        private void HabiltarCamposTactica14132()
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
            grbVD.Visible = false;
            grbVID.Visible = false;
            grbVII.Visible = false;
            grbVI.Visible = false;
            grbMC.Visible = true;
            grbMP.Visible = true;
            ////// Volantes Combos
            cmbVD.Visible = false;
            cmbVID.Visible = false;
            cmbVII.Visible = false;
            cmbVI.Visible = false;
            cmbMC.Visible = true;
            cmbMP.Visible = true;

            ////// Delanteros
            grbCD1.Visible = true;
            grbCD2.Visible = true;
            grbED.Visible = true;
            grbEI.Visible = true;
            grbCD.Visible = false;
            ////// Volantes Combos
            cmbCD1.Visible = true;
            cmbCD2.Visible = true;
            cmbED.Visible = true;
            cmbEI.Visible = true;
            cmbCD.Visible = false;
        }
        private void HabiltarCamposTactica14231()
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
            grbVD.Visible = false;
            grbVID.Visible = true;
            grbVII.Visible = true;
            grbVI.Visible = false;
            grbMC.Visible = false;
            grbMP.Visible = true;
            ////// Volantes Combos
            cmbVD.Visible = false;
            cmbVID.Visible = true;
            cmbVII.Visible = true;
            cmbVI.Visible = false;
            cmbMC.Visible = false;
            cmbMP.Visible = true;

            ////// Delanteros
            grbCD1.Visible = false;
            grbCD2.Visible = false;
            grbED.Visible = true;
            grbEI.Visible = true;
            grbCD.Visible = true;
            ////// Volantes Combos
            cmbCD1.Visible = false;
            cmbCD2.Visible = false;
            cmbED.Visible = true;
            cmbEI.Visible = true;
            cmbCD.Visible = true;
        }
        private void HabiltarCamposTactica14312()
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
            grbVID.Visible = false;
            grbVII.Visible = false;
            grbVI.Visible = true;
            grbMC.Visible = true;
            grbMP.Visible = true;
            ////// Volantes Combos
            cmbVD.Visible = true;
            cmbVID.Visible = false;
            cmbVII.Visible = false;
            cmbVI.Visible = true;
            cmbMC.Visible = true;
            cmbMP.Visible = true;

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
        private void HabiltarCamposTactica1532()
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
            grbLibero.Visible = true;
            grbDFI.Visible = true;
            grbLI.Visible = true;
            ////// Defensores Combos
            cmbLD.Visible = true;
            cmbDFD.Visible = true;
            cmbLIB.Visible = true;
            cmbDFI.Visible = true;
            cmbLI.Visible = true;

            ////// Volantes
            grbVD.Visible = false;
            grbVID.Visible = true;
            grbVII.Visible = true;
            grbVI.Visible = false;
            grbMC.Visible = true;
            grbMP.Visible = false;
            ////// Volantes Combos
            cmbVD.Visible = false;
            cmbVID.Visible = true;
            cmbVII.Visible = true;
            cmbVI.Visible = false;
            cmbMC.Visible = true;
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
        private void HabiltarCamposTactica15212()
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
            grbLibero.Visible = true;
            grbDFI.Visible = true;
            grbLI.Visible = true;
            ////// Defensores Combos
            cmbLD.Visible = true;
            cmbDFD.Visible = true;
            cmbLIB.Visible = true;
            cmbDFI.Visible = true;
            cmbLI.Visible = true;

            ////// Volantes
            grbVD.Visible = false;
            grbVID.Visible = true;
            grbVII.Visible = true;
            grbVI.Visible = false;
            grbMC.Visible = false;
            grbMP.Visible = true;
            ////// Volantes Combos
            cmbVD.Visible = false;
            cmbVID.Visible = true;
            cmbVII.Visible = true;
            cmbVI.Visible = false;
            cmbMC.Visible = false;
            cmbMP.Visible = true;

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
        private void HabiltarCamposTactica1343()
        {
            HabilitarSuplentes();
            grbCancha.Visible = true;
            grbSuplentes.Visible = true;

            ////// Arqueros
            grbArquero.Visible = true;
            cmbArquero.Visible = true;

            ////// Defensores
            grbLD.Visible = false;
            grbDFD.Visible = true;
            grbLibero.Visible = true;
            grbDFI.Visible = true;
            grbLI.Visible = false;
            ////// Defensores Combos
            cmbLD.Visible = false;
            cmbDFD.Visible = true;
            cmbLIB.Visible = true;
            cmbDFI.Visible = true;
            cmbLI.Visible = false;

            ////// Volantes
            grbVD.Visible = true;
            grbVID.Visible = true;
            grbVII.Visible = true;
            grbVI.Visible = true;
            grbMC.Visible = false;
            grbMP.Visible = false;
            ////// Volantes Combos
            cmbVD.Visible = false;
            cmbVID.Visible = true;
            cmbVII.Visible = true;
            cmbVI.Visible = true;
            cmbMC.Visible = false;
            cmbMP.Visible = false;

            ////// Delanteros
            grbCD1.Visible = false;
            grbCD2.Visible = false;
            grbED.Visible = true;
            grbEI.Visible = true;
            grbCD.Visible = true;
            ////// Volantes Combos
            cmbCD1.Visible = false;
            cmbCD2.Visible = false;
            cmbED.Visible = true;
            cmbEI.Visible = true;
            cmbCD.Visible = true;
        }
        private void HabiltarCamposTactica13412()
        {
            HabilitarSuplentes();
            grbCancha.Visible = true;
            grbSuplentes.Visible = true;

            ////// Arqueros
            grbArquero.Visible = true;
            cmbArquero.Visible = true;

            ////// Defensores
            grbLD.Visible = false;
            grbDFD.Visible = true;
            grbLibero.Visible = true;
            grbDFI.Visible = true;
            grbLI.Visible = false;
            ////// Defensores Combos
            cmbLD.Visible = false;
            cmbDFD.Visible = true;
            cmbLIB.Visible = true;
            cmbDFI.Visible = true;
            cmbLI.Visible = false;

            ////// Volantes
            grbVD.Visible = true;
            grbVID.Visible = true;
            grbVII.Visible = true;
            grbVI.Visible = true;
            grbMC.Visible = false;
            grbMP.Visible = true;
            ////// Volantes Combos
            cmbVD.Visible = false;
            cmbVID.Visible = true;
            cmbVII.Visible = true;
            cmbVI.Visible = true;
            cmbMC.Visible = false;
            cmbMP.Visible = true;

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
        private void HabiltarCamposTactica13313()
        {
            HabilitarSuplentes();
            grbCancha.Visible = true;
            grbSuplentes.Visible = true;

            ////// Arqueros
            grbArquero.Visible = true;
            cmbArquero.Visible = true;

            ////// Defensores
            grbLD.Visible = false;
            grbDFD.Visible = true;
            grbLibero.Visible = true;
            grbDFI.Visible = true;
            grbLI.Visible = false;
            ////// Defensores Combos
            cmbLD.Visible = false;
            cmbDFD.Visible = true;
            cmbLIB.Visible = true;
            cmbDFI.Visible = true;
            cmbLI.Visible = false;

            ////// Volantes
            grbVD.Visible = false;
            grbVID.Visible = true;
            grbVII.Visible = true;
            grbVI.Visible = false;
            grbMC.Visible = true;
            grbMP.Visible = true;
            ////// Volantes Combos
            cmbVD.Visible = false;
            cmbVID.Visible = true;
            cmbVII.Visible = true;
            cmbVI.Visible = false;
            cmbMC.Visible = true;
            cmbMP.Visible = true;

            ////// Delanteros
            grbCD1.Visible = false;
            grbCD2.Visible = false;
            grbED.Visible = true;
            grbEI.Visible = true;
            grbCD.Visible = true;
            ////// Volantes Combos
            cmbCD1.Visible = false;
            cmbCD2.Visible = false;
            cmbED.Visible = true;
            cmbEI.Visible = true;
            cmbCD.Visible = true;
        }
        //////////Fútbol 7
        private void HabiltarCamposTactica1312()
        {
            HabilitarSuplentesFutbol7();
            grbCancha.Visible = true;
            grbSuplentes.Visible = true;

            ////// Arqueros
            grbArquero.Visible = true;
            cmbArquero.Visible = true;

            ////// Defensores
            grbLD.Visible = true;
            grbDFD.Visible = false;
            grbLibero.Visible = true;
            grbDFI.Visible = false;
            grbLI.Visible = true;
            ////// Defensores Combos
            cmbLD.Visible = true;
            cmbDFD.Visible = false;
            cmbLIB.Visible = true;
            cmbDFI.Visible = false;
            cmbLI.Visible = true;

            ////// Volantes
            grbVD.Visible = false;
            grbVID.Visible = false;
            grbVII.Visible = false;
            grbVI.Visible = false;
            grbMC.Visible = true;
            grbMP.Visible = false;
            ////// Volantes Combos
            cmbVD.Visible = false;
            cmbVID.Visible = false;
            cmbVII.Visible = false;
            cmbVI.Visible = false;
            cmbMC.Visible = true;
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
        private void HabiltarCamposTactica1222()
        {
            HabilitarSuplentesFutbol7();
            grbCancha.Visible = true;
            grbSuplentes.Visible = true;

            ////// Arqueros
            grbArquero.Visible = true;
            cmbArquero.Visible = true;

            ////// Defensores
            grbLD.Visible = false;
            grbDFD.Visible = true;
            grbLibero.Visible = false;
            grbDFI.Visible = true;
            grbLI.Visible = false;
            ////// Defensores Combos
            cmbLD.Visible = false;
            cmbDFD.Visible = true;
            cmbLIB.Visible = false;
            cmbDFI.Visible = true;
            cmbLI.Visible = false;

            ////// Volantes
            grbVD.Visible = false;
            grbVID.Visible = true;
            grbVII.Visible = true;
            grbVI.Visible = false;
            grbMC.Visible = false;
            grbMP.Visible = false;
            ////// Volantes Combos
            cmbVD.Visible = false;
            cmbVID.Visible = true;
            cmbVII.Visible = true;
            cmbVI.Visible = false;
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
        private void HabiltarCamposTactica1231()
        {
            HabilitarSuplentesFutbol7();
            grbCancha.Visible = true;
            grbSuplentes.Visible = true;

            ////// Arqueros
            grbArquero.Visible = true;
            cmbArquero.Visible = true;

            ////// Defensores
            grbLD.Visible = false;
            grbDFD.Visible = true;
            grbLibero.Visible = false;
            grbDFI.Visible = true;
            grbLI.Visible = false;
            ////// Defensores Combos
            cmbLD.Visible = false;
            cmbDFD.Visible = true;
            cmbLIB.Visible = false;
            cmbDFI.Visible = true;
            cmbLI.Visible = false;

            ////// Volantes
            grbVD.Visible = true;
            grbVID.Visible = false;
            grbVII.Visible = false;
            grbVI.Visible = true;
            grbMC.Visible = true;
            grbMP.Visible = false;
            ////// Volantes Combos
            cmbVD.Visible = true;
            cmbVID.Visible = false;
            cmbVII.Visible = false;
            cmbVI.Visible = true;
            cmbMC.Visible = true;
            cmbMP.Visible = false;

            ////// Delanteros
            grbCD1.Visible = false;
            grbCD2.Visible = false;
            grbED.Visible = false;
            grbEI.Visible = false;
            grbCD.Visible = true;
            ////// Volantes Combos
            cmbCD1.Visible = false;
            cmbCD2.Visible = false;
            cmbED.Visible = false;
            cmbEI.Visible = false;
            cmbCD.Visible = true;
        }
        private void HabiltarCamposTactica1132()
        {
            HabilitarSuplentesFutbol7();
            grbCancha.Visible = true;
            grbSuplentes.Visible = true;

            ////// Arqueros
            grbArquero.Visible = true;
            cmbArquero.Visible = true;

            ////// Defensores
            grbLD.Visible = false;
            grbDFD.Visible = false;
            grbLibero.Visible = true;
            grbDFI.Visible = false;
            grbLI.Visible = false;
            ////// Defensores Combos
            cmbLD.Visible = false;
            cmbDFD.Visible = false;
            cmbLIB.Visible = true;
            cmbDFI.Visible = false;
            cmbLI.Visible = false;

            ////// Volantes
            grbVD.Visible = true;
            grbVID.Visible = false;
            grbVII.Visible = false;
            grbVI.Visible = true;
            grbMC.Visible = true;
            grbMP.Visible = false;
            ////// Volantes Combos
            cmbVD.Visible = true;
            cmbVID.Visible = false;
            cmbVII.Visible = false;
            cmbVI.Visible = true;
            cmbMC.Visible = true;
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
        //////////Fútbol 5
        private void HabiltarCamposTactica1121()
        {
            HabilitarSuplentesFutbol5();
            grbCancha.Visible = true;
            grbSuplentes.Visible = true;

            ////// Arqueros
            grbArquero.Visible = true;
            cmbArquero.Visible = true;

            ////// Defensores
            grbLD.Visible = false;
            grbDFD.Visible = false;
            grbLibero.Visible = true;
            grbDFI.Visible = false;
            grbLI.Visible = false;
            ////// Defensores Combos
            cmbLD.Visible = false;
            cmbDFD.Visible = false;
            cmbLIB.Visible = true;
            cmbDFI.Visible = false;
            cmbLI.Visible = false;

            ////// Volantes
            grbVD.Visible = false;
            grbVID.Visible = true;
            grbVII.Visible = true;
            grbVI.Visible = false;
            grbMC.Visible = false;
            grbMP.Visible = false;
            ////// Volantes Combos
            cmbVD.Visible = false;
            cmbVID.Visible = true;
            cmbVII.Visible = true;
            cmbVI.Visible = false;
            cmbMC.Visible = false;
            cmbMP.Visible = false;

            ////// Delanteros
            grbCD1.Visible = false;
            grbCD2.Visible = false;
            grbED.Visible = false;
            grbEI.Visible = false;
            grbCD.Visible = true;
            ////// Volantes Combos
            cmbCD1.Visible = false;
            cmbCD2.Visible = false;
            cmbED.Visible = false;
            cmbEI.Visible = false;
            cmbCD.Visible = true;
        }
        private void HabiltarCamposTactica1211()
        {
            HabilitarSuplentesFutbol5();
            grbCancha.Visible = true;
            grbSuplentes.Visible = true;

            ////// Arqueros
            grbArquero.Visible = true;
            cmbArquero.Visible = true;

            ////// Defensores
            grbLD.Visible = false;
            grbDFD.Visible = true;
            grbLibero.Visible = false;
            grbDFI.Visible = true;
            grbLI.Visible = false;
            ////// Defensores Combos
            cmbLD.Visible = false;
            cmbDFD.Visible = true;
            cmbLIB.Visible = false;
            cmbDFI.Visible = true;
            cmbLI.Visible = false;

            ////// Volantes
            grbVD.Visible = false;
            grbVID.Visible = false;
            grbVII.Visible = false;
            grbVI.Visible = false;
            grbMC.Visible = true;
            grbMP.Visible = false;
            ////// Volantes Combos
            cmbVD.Visible = false;
            cmbVID.Visible = false;
            cmbVII.Visible = false;
            cmbVI.Visible = false;
            cmbMC.Visible = true;
            cmbMP.Visible = false;

            ////// Delanteros
            grbCD1.Visible = false;
            grbCD2.Visible = false;
            grbED.Visible = false;
            grbEI.Visible = false;
            grbCD.Visible = true;
            ////// Volantes Combos
            cmbCD1.Visible = false;
            cmbCD2.Visible = false;
            cmbED.Visible = false;
            cmbEI.Visible = false;
            cmbCD.Visible = true;
        }
        private void HabilitarSuplentes()
        {
            cmbSup1.Visible = true;
            cmbSup2.Visible = true;
            cmbSup3.Visible = true;
            cmbSup4.Visible = true;
            cmbSup5.Visible = true;
            cmbSup6.Visible = true;
            cmbSup7.Visible = true;
            grbSup1.Visible = true;
            grbSup2.Visible = true;
            grbSup3.Visible = true;
            grbSup4.Visible = true;
            grbSup5.Visible = true;
            grbSup6.Visible = true;
            grbSup7.Visible = true;
        }
        private void HabilitarSuplentesFutbol7()
        {
            cmbSup1.Visible = true;
            cmbSup2.Visible = true;
            cmbSup3.Visible = true;
            cmbSup4.Visible = true;
            cmbSup5.Visible = true;
            cmbSup6.Visible = false;
            cmbSup7.Visible = false;
            grbSup1.Visible = true;
            grbSup2.Visible = true;
            grbSup3.Visible = true;
            grbSup4.Visible = true;
            grbSup5.Visible = true;
            grbSup6.Visible = false;
            grbSup7.Visible = false;
        }
        private void HabilitarSuplentesFutbol5()
        {
            cmbSup1.Visible = true;
            cmbSup2.Visible = true;
            cmbSup3.Visible = true;
            cmbSup4.Visible = false;
            cmbSup5.Visible = false;
            cmbSup6.Visible = false;
            cmbSup7.Visible = false;
            grbSup1.Visible = true;
            grbSup2.Visible = true;
            grbSup3.Visible = true;
            grbSup4.Visible = false;
            grbSup5.Visible = false;
            grbSup6.Visible = false;
            grbSup7.Visible = false;
        }
        private void chcFutbol11_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chcFutbol11.Checked == true)
                {
                    CargarComboSistemaFutbol11();
                    chcFutbol5.Checked = false;
                    chcFutbol7.Checked = false;
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void chcFutbol7_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chcFutbol7.Checked == true)
                {
                    CargarComboSistemaFutbol7();
                    chcFutbol5.Checked = false;
                    chcFutbol11.Checked = false;
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void chcFutbol5_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chcFutbol5.Checked == true)
                {
                    CargarComboSistemaFutbol5();
                    chcFutbol11.Checked = false;
                    chcFutbol7.Checked = false;
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void LimpiarCampos()
        {
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
            btnCancelar.Visible = false;
            grbCancha.Visible = false;
            grbSuplentes.Visible = false;
            chcFutbol11.Checked = true;
            LimpiarCamposJugadores();
            idListaJugadoresCargado.Clear();
            btnVolver.Enabled = true;
        }
        private void LimpiarCamposJugadores()
        {
            pictureArquero.Image = null;
            txtMinARQ.Clear();
            txtGolesARQ.Text = "0";
            txtAmarillaARQ.Text = "0";
            txtRojasARQ.Text = "0";

            pictureLD.Image = null;
            txtMinLD.Clear();
            txtGolesLD.Text = "0";
            txtAmarillaLD.Text = "0";
            txtRojasLD.Text = "0";

            pictureDFD.Image = null;
            txtMinDFD.Clear();
            txtGolesDFD.Text = "0";
            txtAmarillaDFD.Text = "0";
            txtRojasDFD.Text = "0";

            pictureLIB.Image = null;
            txtMinLIB.Clear();
            txtGolesLIB.Text = "0";
            txtAmarillaLIB.Text = "0";
            txtRojasLIB.Text = "0";

            pictureDFI.Image = null;
            txtMinDFI.Clear();
            txtGolesDFI.Text = "0";
            txtAmarillaDFI.Text = "0";
            txtRojasDFI.Text = "0";

            pictureLI.Image = null;
            txtMinLI.Clear();
            txtGolesLI.Text = "0";
            txtAmarillaLI.Text = "0";
            txtRojasLI.Text = "0";

            pictureVD.Image = null;
            txtMinVD.Clear();
            txtGolesVD.Text = "0";
            txtAmarillaVD.Text = "0";
            txtRojasVD.Text = "0";

            pictureVID.Image = null;
            txtMinVID.Clear();
            txtGolesVID.Text = "0";
            txtAmarillaVID.Text = "0";
            txtRojasVID.Text = "0";

            pictureMC.Image = null;
            txtMinMC.Clear();
            txtGolesMC.Text = "0";
            txtAmarillaMC.Text = "0";
            txtRojasMC.Text = "0";

            pictureVII.Image = null;
            txtMinVII.Clear();
            txtGolesVII.Text = "0";
            txtAmarillaVII.Text = "0";
            txtRojasVII.Text = "0";

            pictureVI.Image = null;
            txtMinVI.Clear();
            txtGolesVI.Text = "0";
            txtAmarillaVI.Text = "0";
            txtRojasVI.Text = "0";

            pictureMP.Image = null;
            txtMinMP.Clear();
            txtGolesMP.Text = "0";
            txtAmarillaMP.Text = "0";
            txtRojasMP.Text = "0";

            pictureED.Image = null;
            txtMinED.Clear();
            txtGolesED.Text = "0";
            txtAmarillaED.Text = "0";
            txtRojasED.Text = "0";

            pictureCD1.Image = null;
            txtMinCD1.Clear();
            txtGolesCD1.Text = "0";
            txtAmarillaCD1.Text = "0";
            txtRojasCD1.Text = "0";

            pictureCD.Image = null;
            txtMinCD.Clear();
            txtGolesCD.Text = "0";
            txtAmarillaCD.Text = "0";
            txtRojasCD.Text = "0";

            pictureCD2.Image = null;
            txtMinCD2.Clear();
            txtGolesCD2.Text = "0";
            txtAmarillaCD2.Text = "0";
            txtRojasCD2.Text = "0";

            pictureEI.Image = null;
            txtMinEI.Clear();
            txtGolesEI.Text = "0";
            txtAmarillaEI.Text = "0";
            txtRojasEI.Text = "0";

            pictureSup1.Image = null;
            txtMinSup1.Clear();
            txtGolesSup1.Text = "0";
            txtAmarillasSup1.Text = "0";
            txtRojasSup1.Text = "0";

            pictureSup2.Image = null;
            txtMinSup2.Clear();
            txtGolesSup2.Text = "0";
            txtAmarillasSup2.Text = "0";
            txtRojasSup2.Text = "0";

            pictureSup3.Image = null;
            txtMinSup3.Clear();
            txtGolesSup3.Text = "0";
            txtAmarillasSup3.Text = "0";
            txtRojasSup3.Text = "0";

            pictureSup4.Image = null;
            txtMinSup4.Clear();
            txtGolesSup4.Text = "0";
            txtAmarillasSup4.Text = "0";
            txtRojasSup4.Text = "0";

            pictureSup5.Image = null;
            txtMinSup5.Clear();
            txtGolesSup5.Text = "0";
            txtAmarillasSup5.Text = "0";
            txtRojasSup5.Text = "0";

            pictureSup6.Image = null;
            txtMinSup6.Clear();
            txtGolesSup6.Text = "0";
            txtAmarillasSup6.Text = "0";
            txtRojasSup6.Text = "0";

            pictureSup7.Image = null;
            txtMinSup7.Clear();
            txtGolesSup7.Text = "0";
            txtAmarillasSup7.Text = "0";
            txtRojasSup7.Text = "0";

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
        private void BloquearPantalla()
        {
            grbCancha.Enabled = false;
            grbSuplentes.Enabled = false;
            grbDuaracionPartido.Enabled = false;
            grbTipo.Enabled = false;
            grbSistemaTactico.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnVolver.Enabled = false;
        }
        private List<string> CargarEntidad()
        {
            int TotalGoles = 0;

            List<string> listaString = new List<string>();
            string id = "";
            string Minutos = "";
            string Goles = "";
            string Amarilla = "";
            string Roja = "";
            string Cadena = "";
            string Puesto = "";

            if (lblARQ.Text != "@LD")
            {
                id = lblARQ.Text;
                Minutos = txtMinARQ.Text;
                Goles = txtGolesARQ.Text;
                int gol = Convert.ToInt32(Goles);
                TotalGoles = gol + TotalGoles;
                Amarilla = txtAmarillaARQ.Text;
                Roja = txtRojasARQ.Text;
                Puesto = "ARQ";
                Cadena = id + "," + Minutos + "-" + Goles + "." + Amarilla + "+" + Roja + ";" + Puesto;
                listaString.Add(Cadena);
            }

            if (lblLD.Text != "@LD")
            {
                id = lblLD.Text;
                Minutos = txtMinLD.Text;
                Goles = txtGolesLD.Text;
                int gol = Convert.ToInt32(Goles);
                TotalGoles = gol + TotalGoles;
                Amarilla = txtAmarillaLD.Text;
                Roja = txtRojasLD.Text;
                Puesto = "LD";
                Cadena = id + "," + Minutos + "-" + Goles + "." + Amarilla + "+" + Roja + ";" + Puesto;
                listaString.Add(Cadena);
            }


            if (lblDFD.Text != "@LD")
            {
                id = lblDFD.Text;
                Minutos = txtMinDFD.Text;
                Goles = txtGolesDFD.Text;
                int gol = Convert.ToInt32(Goles);
                TotalGoles = gol + TotalGoles;
                Amarilla = txtAmarillaDFD.Text;
                Roja = txtRojasDFD.Text;
                Puesto = "DFD";
                Cadena = id + "," + Minutos + "-" + Goles + "." + Amarilla + "+" + Roja + ";" + Puesto;
                listaString.Add(Cadena);
            }


            if (lblLIB.Text != "@LD")
            {
                id = lblLIB.Text;
                Minutos = txtMinLIB.Text;
                Goles = txtGolesLIB.Text;
                int gol = Convert.ToInt32(Goles);
                TotalGoles = gol + TotalGoles;
                Amarilla = txtAmarillaLIB.Text;
                Roja = txtRojasLIB.Text;
                Puesto = "LIB";
                Cadena = id + "," + Minutos + "-" + Goles + "." + Amarilla + "+" + Roja + ";" + Puesto;
                listaString.Add(Cadena);
            }

            if (lblDFI.Text != "@LD")
            {
                id = lblDFI.Text;
                Minutos = txtMinDFI.Text;
                Goles = txtGolesDFI.Text;
                int gol = Convert.ToInt32(Goles);
                TotalGoles = gol + TotalGoles;
                Amarilla = txtAmarillaDFI.Text;
                Roja = txtRojasDFI.Text;
                Puesto = "DFI";
                Cadena = id + "," + Minutos + "-" + Goles + "." + Amarilla + "+" + Roja + ";" + Puesto;
                listaString.Add(Cadena);
            }


            if (lblLI.Text != "@LD")
            {
                id = lblLI.Text;
                Minutos = txtMinLI.Text;
                Goles = txtGolesLI.Text;
                int gol = Convert.ToInt32(Goles);
                TotalGoles = gol + TotalGoles;
                Amarilla = txtAmarillaLI.Text;
                Roja = txtRojasLI.Text;
                Puesto = "LI";
                Cadena = id + "," + Minutos + "-" + Goles + "." + Amarilla + "+" + Roja + ";" + Puesto;
                listaString.Add(Cadena);
            }

            if (lblVD.Text != "@LD")
            {
                id = lblVD.Text;
                Minutos = txtMinVD.Text;
                Goles = txtGolesVD.Text;
                int gol = Convert.ToInt32(Goles);
                TotalGoles = gol + TotalGoles;
                Amarilla = txtAmarillaVD.Text;
                Roja = txtRojasVD.Text;
                Puesto = "VD";
                Cadena = id + "," + Minutos + "-" + Goles + "." + Amarilla + "+" + Roja + ";" + Puesto;
                listaString.Add(Cadena);
            }

            if (lblVID.Text != "@LD")
            {
                id = lblVID.Text;
                Minutos = txtMinVID.Text;
                Goles = txtGolesVID.Text;
                int gol = Convert.ToInt32(Goles);
                TotalGoles = gol + TotalGoles;
                Amarilla = txtAmarillaVID.Text;
                Roja = txtRojasVID.Text;
                Puesto = "VID";
                Cadena = id + "," + Minutos + "-" + Goles + "." + Amarilla + "+" + Roja + ";" + Puesto;
                listaString.Add(Cadena);
            }


            if (lblMC.Text != "@LD")
            {
                id = lblMC.Text;
                Minutos = txtMinMC.Text;
                Goles = txtGolesMC.Text;
                int gol = Convert.ToInt32(Goles);
                TotalGoles = gol + TotalGoles;
                Amarilla = txtAmarillaMC.Text;
                Roja = txtRojasMC.Text;
                Puesto = "MC";
                Cadena = id + "," + Minutos + "-" + Goles + "." + Amarilla + "+" + Roja + ";" + Puesto;
                listaString.Add(Cadena);
            }
            if (lblVII.Text != "@LD")
            {
                id = lblVII.Text;
                Minutos = txtMinVII.Text;
                Goles = txtGolesVII.Text;
                int gol = Convert.ToInt32(Goles);
                TotalGoles = gol + TotalGoles;
                Amarilla = txtAmarillaVII.Text;
                Roja = txtRojasVII.Text;
                Puesto = "VII";
                Cadena = id + "," + Minutos + "-" + Goles + "." + Amarilla + "+" + Roja + ";" + Puesto;
                listaString.Add(Cadena);
            }

            if (lblVI.Text != "@LD")
            {
                id = lblVI.Text;
                Minutos = txtMinVI.Text;
                Goles = txtGolesVI.Text;
                int gol = Convert.ToInt32(Goles);
                TotalGoles = gol + TotalGoles;
                Amarilla = txtAmarillaVI.Text;
                Roja = txtRojasVI.Text;
                Puesto = "VI";
                Cadena = id + "," + Minutos + "-" + Goles + "." + Amarilla + "+" + Roja + ";" + Puesto;
                listaString.Add(Cadena);
            }
            if (lblMP.Text != "@LD")
            {
                id = lblMP.Text;
                Minutos = txtMinMP.Text;
                Goles = txtGolesMP.Text;
                int gol = Convert.ToInt32(Goles);
                TotalGoles = gol + TotalGoles;
                Amarilla = txtAmarillaMP.Text;
                Roja = txtRojasMP.Text;
                Puesto = "MP";
                Cadena = id + "," + Minutos + "-" + Goles + "." + Amarilla + "+" + Roja + ";" + Puesto;
                listaString.Add(Cadena);
            }
            if (lblED.Text != "@LD")
            {
                id = lblED.Text;
                Minutos = txtMinED.Text;
                Goles = txtGolesED.Text;
                int gol = Convert.ToInt32(Goles);
                TotalGoles = gol + TotalGoles;
                Amarilla = txtAmarillaED.Text;
                Puesto = "ED";
                Cadena = id + "," + Minutos + "-" + Goles + "." + Amarilla + "+" + Roja + ";" + Puesto;
                listaString.Add(Cadena);
            }
            if (lblCD1.Text != "@LD")
            {
                id = lblCD1.Text;
                Minutos = txtMinCD1.Text;
                Goles = txtGolesCD1.Text;
                int gol = Convert.ToInt32(Goles);
                TotalGoles = gol + TotalGoles;
                Amarilla = txtAmarillaCD1.Text;
                Roja = txtRojasCD1.Text;
                Puesto = "CD1";
                Cadena = id + "," + Minutos + "-" + Goles + "." + Amarilla + "+" + Roja + ";" + Puesto;
                listaString.Add(Cadena);
            }
            if (lblCD.Text != "@LD")
            {
                id = lblCD.Text;
                Minutos = txtMinCD.Text;
                Goles = txtGolesCD.Text;
                int gol = Convert.ToInt32(Goles);
                TotalGoles = gol + TotalGoles;
                Amarilla = txtAmarillaCD.Text;
                Roja = txtRojasCD.Text;
                Puesto = "CD";
                Cadena = id + "," + Minutos + "-" + Goles + "." + Amarilla + "+" + Roja + ";" + Puesto;
                listaString.Add(Cadena);
            }
            if (lblCD2.Text != "@LD")
            {
                id = lblCD2.Text;
                Minutos = txtMinCD2.Text;
                Goles = txtGolesCD2.Text;
                int gol = Convert.ToInt32(Goles);
                TotalGoles = gol + TotalGoles;
                Amarilla = txtAmarillaCD2.Text;
                Roja = txtRojasCD2.Text;
                Puesto = "CD2";
                Cadena = id + "," + Minutos + "-" + Goles + "." + Amarilla + "+" + Roja + ";" + Puesto;
                listaString.Add(Cadena);
            }
            if (lblEI.Text != "@LD")
            {
                id = lblEI.Text;
                Minutos = txtMinEI.Text;
                Goles = txtGolesEI.Text;
                int gol = Convert.ToInt32(Goles);
                TotalGoles = gol + TotalGoles;
                Amarilla = txtAmarillaEI.Text;
                Roja = txtRojasEI.Text;
                Puesto = "EI";
                Cadena = id + "," + Minutos + "-" + Goles + "." + Amarilla + "+" + Roja + ";" + Puesto;
                listaString.Add(Cadena);
            }
            if (lblSup1.Text != "@LD")
            {
                id = lblSup1.Text;
                Minutos = txtMinSup1.Text;
                Goles = txtGolesSup1.Text;
                int gol = Convert.ToInt32(Goles);
                TotalGoles = gol + TotalGoles;
                Amarilla = txtAmarillasSup1.Text;
                Roja = txtRojasSup1.Text;
                Puesto = "SUP1";
                Cadena = id + "," + Minutos + "-" + Goles + "." + Amarilla + "+" + Roja + ";" + Puesto;
                listaString.Add(Cadena);
            }
            if (lblSup2.Text != "@LD")
            {
                id = lblSup2.Text;
                Minutos = txtMinSup2.Text;
                Goles = txtGolesSup2.Text;
                int gol = Convert.ToInt32(Goles);
                TotalGoles = gol + TotalGoles;
                Amarilla = txtAmarillasSup2.Text;
                Roja = txtRojasSup2.Text;
                Puesto = "SUP2";
                Cadena = id + "," + Minutos + "-" + Goles + "." + Amarilla + "+" + Roja + ";" + Puesto;
                listaString.Add(Cadena);
            }
            if (lblSup3.Text != "@LD")
            {
                id = lblSup3.Text;
                Minutos = txtMinSup3.Text;
                Goles = txtGolesSup3.Text;
                int gol = Convert.ToInt32(Goles);
                TotalGoles = gol + TotalGoles;
                Amarilla = txtAmarillasSup3.Text;
                Roja = txtRojasSup3.Text;
                Puesto = "SUP3";
                Cadena = id + "," + Minutos + "-" + Goles + "." + Amarilla + "+" + Roja + ";" + Puesto;
                listaString.Add(Cadena);
            }
            if (lblSup4.Text != "@LD")
            {
                id = lblSup4.Text;
                Minutos = txtMinSup4.Text;
                Goles = txtGolesSup4.Text;
                int gol = Convert.ToInt32(Goles);
                TotalGoles = gol + TotalGoles;
                Amarilla = txtAmarillasSup4.Text;
                Roja = txtRojasSup4.Text;
                Puesto = "SUP4";
                Cadena = id + "," + Minutos + "-" + Goles + "." + Amarilla + "+" + Roja + ";" + Puesto;
                listaString.Add(Cadena);
            }
            if (lblSup5.Text != "@LD")
            {
                id = lblSup5.Text;
                Minutos = txtMinSup5.Text;
                Goles = txtGolesSup5.Text;
                int gol = Convert.ToInt32(Goles);
                TotalGoles = gol + TotalGoles;
                Amarilla = txtAmarillasSup5.Text;
                Roja = txtRojasSup5.Text;
                Puesto = "SUP5";
                Cadena = id + "," + Minutos + "-" + Goles + "." + Amarilla + "+" + Roja + ";" + Puesto;
                listaString.Add(Cadena);
            }
            if (lblSup6.Text != "@LD")
            {
                id = lblSup6.Text;
                Minutos = txtMinSup6.Text;
                Goles = txtGolesSup6.Text;
                int gol = Convert.ToInt32(Goles);
                TotalGoles = gol + TotalGoles;
                Amarilla = txtAmarillasSup6.Text;
                Roja = txtRojasSup6.Text;
                Puesto = "SUP6";
                Cadena = id + "," + Minutos + "-" + Goles + "." + Amarilla + "+" + Roja + ";" + Puesto;
                listaString.Add(Cadena);
            }
            if (lblSup7.Text != "@LD")
            {
                id = lblSup7.Text;
                Minutos = txtMinSup7.Text;
                Goles = txtGolesSup7.Text;
                int gol = Convert.ToInt32(Goles);
                TotalGoles = gol + TotalGoles;
                Amarilla = txtAmarillasSup7.Text;
                Roja = txtRojasSup7.Text;
                Puesto = "SUP7";
                Cadena = id + "," + Minutos + "-" + Goles + "." + Amarilla + "+" + Roja + ";" + Puesto;
                listaString.Add(Cadena);
            }
            if (TotalGoles > MarcadorLocal)
            { }
            return listaString;
        }
        #endregion
        #region Eventos Combos
        public static List<int> idListaJugadoresCargado;
        private int idEquipo;
        private int idPartido;
        private void txtRojasARQ_TextChanged(object sender, EventArgs e)
        {
            string Roja = txtRojasARQ.Text;
            int Expulsion = Convert.ToInt32(Roja);
            if (Expulsion > 1)
            {
                const string message = "Solo se puede cargar 1 Roja por jugador en un mismo partido.";
                const string caption = "Atención";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                txtRojasARQ.Text = "0";
            }
        }
        private void txtRojasLD_TextChanged(object sender, EventArgs e)
        {
            string Roja = txtRojasLD.Text;
            int Expulsion = Convert.ToInt32(Roja);
            if (Expulsion > 1)
            {
                const string message = "Solo se puede cargar 1 Roja por jugador en un mismo partido.";
                const string caption = "Atención";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                txtRojasLD.Text = "0";
            }
        }
        private void txtRojasDFD_TextChanged(object sender, EventArgs e)
        {
            string Roja = txtRojasDFD.Text;
            int Expulsion = Convert.ToInt32(Roja);
            if (Expulsion > 1)
            {
                const string message = "Solo se puede cargar 1 Roja por jugador en un mismo partido.";
                const string caption = "Atención";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                txtRojasDFD.Text = "0";
            }
        }
        private void txtRojasLIB_TextChanged(object sender, EventArgs e)
        {
            string Roja = txtRojasLIB.Text;
            int Expulsion = Convert.ToInt32(Roja);
            if (Expulsion > 1)
            {
                const string message = "Solo se puede cargar 1 Roja por jugador en un mismo partido.";
                const string caption = "Atención";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                txtRojasLIB.Text = "0";
            }
        }
        private void txtRojasDFI_TextChanged(object sender, EventArgs e)
        {
            string Roja = txtRojasDFI.Text;
            int Expulsion = Convert.ToInt32(Roja);
            if (Expulsion > 1)
            {
                const string message = "Solo se puede cargar 1 Roja por jugador en un mismo partido.";
                const string caption = "Atención";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                txtRojasDFI.Text = "0";
            }
        }
        private void txtRojasLI_TextChanged(object sender, EventArgs e)
        {
            string Roja = txtRojasLI.Text;
            int Expulsion = Convert.ToInt32(Roja);
            if (Expulsion > 1)
            {
                const string message = "Solo se puede cargar 1 Roja por jugador en un mismo partido.";
                const string caption = "Atención";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                txtRojasLI.Text = "0";
            }
        }
        private void txtRojasVD_TextChanged(object sender, EventArgs e)
        {
            string Roja = txtRojasVD.Text;
            int Expulsion = Convert.ToInt32(Roja);
            if (Expulsion > 1)
            {
                const string message = "Solo se puede cargar 1 Roja por jugador en un mismo partido.";
                const string caption = "Atención";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                txtRojasVD.Text = "0";
            }
        }
        private void txtRojasVID_TextChanged(object sender, EventArgs e)
        {
            string Roja = txtRojasVID.Text;
            int Expulsion = Convert.ToInt32(Roja);
            if (Expulsion > 1)
            {
                const string message = "Solo se puede cargar 1 Roja por jugador en un mismo partido.";
                const string caption = "Atención";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                txtRojasVID.Text = "0";
            }
        }
        private void txtRojasMC_TextChanged(object sender, EventArgs e)
        {
            string Roja = txtRojasMC.Text;
            int Expulsion = Convert.ToInt32(Roja);
            if (Expulsion > 1)
            {
                const string message = "Solo se puede cargar 1 Roja por jugador en un mismo partido.";
                const string caption = "Atención";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                txtRojasMC.Text = "0";
            }
        }
        private void txtRojasVII_TextChanged(object sender, EventArgs e)
        {
            string Roja = txtRojasVII.Text;
            int Expulsion = Convert.ToInt32(Roja);
            if (Expulsion > 1)
            {
                const string message = "Solo se puede cargar 1 Roja por jugador en un mismo partido.";
                const string caption = "Atención";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                txtRojasVII.Text = "0";
            }
        }
        private void txtRojasVI_TextChanged(object sender, EventArgs e)
        {
            string Roja = txtRojasVI.Text;
            int Expulsion = Convert.ToInt32(Roja);
            if (Expulsion > 1)
            {
                const string message = "Solo se puede cargar 1 Roja por jugador en un mismo partido.";
                const string caption = "Atención";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                txtRojasVI.Text = "0";
            }
        }
        private void txtRojasED_TextChanged(object sender, EventArgs e)
        {
            string Roja = txtRojasED.Text;
            int Expulsion = Convert.ToInt32(Roja);
            if (Expulsion > 1)
            {
                const string message = "Solo se puede cargar 1 Roja por jugador en un mismo partido.";
                const string caption = "Atención";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                txtRojasED.Text = "0";
            }
        }
        private void txtRojasMP_TextChanged(object sender, EventArgs e)
        {
            string Roja = txtRojasMP.Text;
            int Expulsion = Convert.ToInt32(Roja);
            if (Expulsion > 1)
            {
                const string message = "Solo se puede cargar 1 Roja por jugador en un mismo partido.";
                const string caption = "Atención";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                txtRojasMP.Text = "0";
            }
        }
        private void txtRojasEI_TextChanged(object sender, EventArgs e)
        {
            string Roja = txtRojasEI.Text;
            int Expulsion = Convert.ToInt32(Roja);
            if (Expulsion > 1)
            {
                const string message = "Solo se puede cargar 1 Roja por jugador en un mismo partido.";
                const string caption = "Atención";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                txtRojasEI.Text = "0";
            }
        }
        private void txtRojasCD1_TextChanged(object sender, EventArgs e)
        {
            string Roja = txtRojasCD1.Text;
            int Expulsion = Convert.ToInt32(Roja);
            if (Expulsion > 1)
            {
                const string message = "Solo se puede cargar 1 Roja por jugador en un mismo partido.";
                const string caption = "Atención";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                txtRojasCD1.Text = "0";
            }
        }
        private void txtRojasCD_TextChanged(object sender, EventArgs e)
        {
            string Roja = txtRojasCD.Text;
            int Expulsion = Convert.ToInt32(Roja);
            if (Expulsion > 1)
            {
                const string message = "Solo se puede cargar 1 Roja por jugador en un mismo partido.";
                const string caption = "Atención";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                txtRojasCD.Text = "0";
            }
        }
        private void txtRojasCD2_TextChanged(object sender, EventArgs e)
        {
            string Roja = txtRojasCD2.Text;
            int Expulsion = Convert.ToInt32(Roja);
            if (Expulsion > 1)
            {
                const string message = "Solo se puede cargar 1 Roja por jugador en un mismo partido.";
                const string caption = "Atención";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                txtRojasCD2.Text = "0";
            }
        }
        private void txtRojasSup1_TextChanged(object sender, EventArgs e)
        {
            string Roja = txtRojasSup1.Text;
            int Expulsion = Convert.ToInt32(Roja);
            if (Expulsion > 1)
            {
                const string message = "Solo se puede cargar 1 Roja por jugador en un mismo partido.";
                const string caption = "Atención";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                txtRojasSup1.Text = "0";
            }
        }
        private void txtRojasSup2_TextChanged(object sender, EventArgs e)
        {
            string Roja = txtRojasSup2.Text;
            int Expulsion = Convert.ToInt32(Roja);
            if (Expulsion > 1)
            {
                const string message = "Solo se puede cargar 1 Roja por jugador en un mismo partido.";
                const string caption = "Atención";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                txtRojasSup2.Text = "0";
            }
        }
        private void txtRojasSup3_TextChanged(object sender, EventArgs e)
        {
            string Roja = txtRojasSup3.Text;
            int Expulsion = Convert.ToInt32(Roja);
            if (Expulsion > 1)
            {
                const string message = "Solo se puede cargar 1 Roja por jugador en un mismo partido.";
                const string caption = "Atención";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                txtRojasSup3.Text = "0";
            }
        }
        private void txtRojasSup4_TextChanged(object sender, EventArgs e)
        {
            string Roja = txtRojasSup4.Text;
            int Expulsion = Convert.ToInt32(Roja);
            if (Expulsion > 1)
            {
                const string message = "Solo se puede cargar 1 Roja por jugador en un mismo partido.";
                const string caption = "Atención";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                txtRojasSup4.Text = "0";
            }
        }
        private void txtRojasSup5_TextChanged(object sender, EventArgs e)
        {
            string Roja = txtRojasSup5.Text;
            int Expulsion = Convert.ToInt32(Roja);
            if (Expulsion > 1)
            {
                const string message = "Solo se puede cargar 1 Roja por jugador en un mismo partido.";
                const string caption = "Atención";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                txtRojasSup5.Text = "0";
            }
        }
        private void txtRojasSup6_TextChanged(object sender, EventArgs e)
        {
            string Roja = txtRojasSup6.Text;
            int Expulsion = Convert.ToInt32(Roja);
            if (Expulsion > 1)
            {
                const string message = "Solo se puede cargar 1 Roja por jugador en un mismo partido.";
                const string caption = "Atención";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                txtRojasSup6.Text = "0";
            }
        }
        private void txtRojasSup7_TextChanged(object sender, EventArgs e)
        {
            string Roja = txtRojasSup7.Text;
            int Expulsion = Convert.ToInt32(Roja);
            if (Expulsion > 1)
            {
                const string message = "Solo se puede cargar 1 Roja por jugador en un mismo partido.";
                const string caption = "Atención";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                txtRojasSup7.Text = "0";
            }
        }
        private void cmbMinutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string Minutos = cmbMinutos.Text;
                AsignarMinutosJugadoresTitulares(Minutos);

            }
            catch (Exception ex)
            { }
        }
        private void cmbTactica_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string Tactica = cmbTactica.Text;
                if (Tactica == "1-4-4-2")
                {
                    HabiltarCamposTactica1442();
                }
                if (Tactica == "1-4-3-1-2")
                {
                    HabiltarCamposTactica14312();
                }
                if (Tactica == "1-4-2-3-1")
                {
                    HabiltarCamposTactica14231();
                }
                if (Tactica == "1-4-1-3-2")
                {
                    HabiltarCamposTactica14132();
                }
                if (Tactica == "1-4-3-3")
                {
                    HabiltarCamposTactica1433();
                }
                if (Tactica == "1-5-3-2")
                {
                    HabiltarCamposTactica1532();
                }
                if (Tactica == "1-5-2-1-2")
                {
                    HabiltarCamposTactica15212();
                }
                if (Tactica == "1-3-4-3")
                {
                    HabiltarCamposTactica1343();
                }
                if (Tactica == "1-3-4-1-2")
                {
                    HabiltarCamposTactica13412();
                }
                if (Tactica == "1-3-3-1-3")
                {
                    HabiltarCamposTactica13313();
                }
                ////// Fútbol 7
                if (Tactica == "1-3-1-2")
                {
                    HabiltarCamposTactica1312();
                }
                if (Tactica == "1-2-3-1")
                {
                    HabiltarCamposTactica1231();
                }
                if (Tactica == "1-2-2-2")
                {
                    HabiltarCamposTactica1222();
                }
                if (Tactica == "1-1-3-2")
                {
                    HabiltarCamposTactica1132();
                }
                ////// Fútbol 5
                if (Tactica == "1-1-2-1")
                {
                    HabiltarCamposTactica1121();
                }
                if (Tactica == "1-2-1-1")
                {
                    HabiltarCamposTactica1211();
                }
            }
            catch (Exception ex)
            { }
        }
        private void cmbArquero_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string Jugador = cmbArquero.Text;
                ValidarJugadorYaExistente(Jugador);
                var valor = Jugador;
                string var = valor;
                string Id = var.Split(',')[0];
                string var2 = var.Split(',')[1];
                string Apellido = var2.Split(' ')[0];
                string Nombre = var2.Split(' ')[1];
                int idJugador = Convert.ToInt32(Id);
                grbArquero.Text = Apellido + " " + Nombre;
                pictureArquero.Visible = true;
                lblARQ.Text = Id;
                byte[] ImagenJugador = JugadoresNeg.BuscarImagenJugador(idJugador);
                if (ImagenJugador != null)
                {
                    Bitmap foto1 = Clases_Maestras.Funciones.byteToBipmap(ImagenJugador);
                    pictureArquero.Image = foto1;
                }
                else
                {
                    pictureArquero.Image = Image.FromFile("C:\\ProFuSo\\Silueta Jugador.jpg");
                }
            }
            catch (Exception ex)
            { }
        }
        private void cmbLD_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                /////Aca Cambiar
                string Jugador = cmbLD.Text;
                ValidarJugadorYaExistente(Jugador);
                var valor = Jugador;
                string var = valor;
                string Id = var.Split(',')[0];
                string var2 = var.Split(',')[1];
                string Apellido = var2.Split(' ')[0];
                string Nombre = var2.Split(' ')[1];
                int idJugador = Convert.ToInt32(Id);
                grbLD.Text = Apellido + " " + Nombre;
                pictureLD.Visible = true;
                lblLD.Text = Id;
                byte[] ImagenJugador = JugadoresNeg.BuscarImagenJugador(idJugador);
                if (ImagenJugador != null)
                {
                    Bitmap foto1 = Clases_Maestras.Funciones.byteToBipmap(ImagenJugador);
                    pictureLD.Image = foto1;
                }
                else
                {
                    pictureLD.Image = Image.FromFile("C:\\ProFuSo\\Silueta Jugador.jpg");
                }
            }
            catch (Exception ex)
            { }
        }
        private void cmbDFD_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string Jugador = cmbDFD.Text;
                ValidarJugadorYaExistente(Jugador);
                var valor = Jugador;
                string var = valor;
                string Id = var.Split(',')[0];
                string var2 = var.Split(',')[1];
                string Apellido = var2.Split(' ')[0];
                string Nombre = var2.Split(' ')[1];
                int idJugador = Convert.ToInt32(Id);
                grbDFD.Text = Apellido + " " + Nombre;
                pictureDFD.Visible = true;
                /////Aca Cambiar
                lblDFD.Text = Id;
                byte[] ImagenJugador = JugadoresNeg.BuscarImagenJugador(idJugador);
                if (ImagenJugador != null)
                {
                    Bitmap foto1 = Clases_Maestras.Funciones.byteToBipmap(ImagenJugador);
                    /////Aca Cambiar
                    pictureDFD.Image = foto1;
                }
                else
                {
                    /////Aca Cambiar
                    pictureDFD.Image = Image.FromFile("C:\\ProFuSo\\Silueta Jugador.jpg");
                }
            }
            catch (Exception ex)
            { }
        }
        private void cmbLIB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string Jugador = cmbLIB.Text;
                ValidarJugadorYaExistente(Jugador);
                var valor = Jugador;
                string var = valor;
                string Id = var.Split(',')[0];
                string var2 = var.Split(',')[1];
                string Apellido = var2.Split(' ')[0];
                string Nombre = var2.Split(' ')[1];
                int idJugador = Convert.ToInt32(Id);
                grbLibero.Text = Apellido + " " + Nombre;
                pictureLIB.Visible = true;
                /////Aca Cambiar
                lblLIB.Text = Id;
                byte[] ImagenJugador = JugadoresNeg.BuscarImagenJugador(idJugador);
                if (ImagenJugador != null)
                {
                    Bitmap foto1 = Clases_Maestras.Funciones.byteToBipmap(ImagenJugador);
                    /////Aca Cambiar
                    pictureLIB.Image = foto1;
                }
                else
                {
                    /////Aca Cambiar
                    pictureLIB.Image = Image.FromFile("C:\\ProFuSo\\Silueta Jugador.jpg");
                }
            }
            catch (Exception ex)
            { }
        }
        private void cmbDFI_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<int> lista = new List<int>();
                /////Aca Cambiar
                string Jugador = cmbDFI.Text;
                ValidarJugadorYaExistente(Jugador);
                var valor = Jugador;
                string var = valor;
                string Id = var.Split(',')[0];
                string var2 = var.Split(',')[1];
                string Apellido = var2.Split(' ')[0];
                string Nombre = var2.Split(' ')[1];
                int idJugador = Convert.ToInt32(Id);
                grbDFI.Text = Apellido + " " + Nombre;
                pictureDFI.Visible = true;
                /////Aca Cambiar
                lblDFI.Text = Id;
                byte[] ImagenJugador = JugadoresNeg.BuscarImagenJugador(idJugador);
                if (ImagenJugador != null)
                {
                    Bitmap foto1 = Clases_Maestras.Funciones.byteToBipmap(ImagenJugador);
                    /////Aca Cambiar
                    pictureDFI.Image = foto1;
                }
                else
                {
                    /////Aca Cambiar
                    pictureDFI.Image = Image.FromFile("C:\\ProFuSo\\Silueta Jugador.jpg");
                }
            }
            catch (Exception ex)
            { }
        }
        private void cmbLI_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<int> lista = new List<int>();
                /////Aca Cambiar
                string Jugador = cmbLI.Text;
                ValidarJugadorYaExistente(Jugador);
                var valor = Jugador;
                string var = valor;
                string Id = var.Split(',')[0];
                string var2 = var.Split(',')[1];
                string Apellido = var2.Split(' ')[0];
                string Nombre = var2.Split(' ')[1];
                int idJugador = Convert.ToInt32(Id);
                grbLI.Text = Apellido + " " + Nombre;
                pictureLI.Visible = true;
                /////Aca Cambiar
                lblLI.Text = Id;
                byte[] ImagenJugador = JugadoresNeg.BuscarImagenJugador(idJugador);
                if (ImagenJugador != null)
                {
                    Bitmap foto1 = Clases_Maestras.Funciones.byteToBipmap(ImagenJugador);
                    /////Aca Cambiar
                    pictureLI.Image = foto1;
                }
                else
                {
                    /////Aca Cambiar
                    pictureLI.Image = Image.FromFile("C:\\ProFuSo\\Silueta Jugador.jpg");
                }
            }
            catch (Exception ex)
            { }
        }
        private void cmbVD_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<int> lista = new List<int>();
                /////Aca Cambiar
                string Jugador = cmbVD.Text;
                ValidarJugadorYaExistente(Jugador);
                var valor = Jugador;
                string var = valor;
                string Id = var.Split(',')[0];
                string var2 = var.Split(',')[1];
                string Apellido = var2.Split(' ')[0];
                string Nombre = var2.Split(' ')[1];
                int idJugador = Convert.ToInt32(Id);
                grbVD.Text = Apellido + " " + Nombre;
                pictureVD.Visible = true;
                /////Aca Cambiar
                lblVD.Text = Id;
                byte[] ImagenJugador = JugadoresNeg.BuscarImagenJugador(idJugador);
                if (ImagenJugador != null)
                {
                    Bitmap foto1 = Clases_Maestras.Funciones.byteToBipmap(ImagenJugador);
                    /////Aca Cambiar
                    pictureVD.Image = foto1;
                }
                else
                {
                    /////Aca Cambiar
                    pictureVD.Image = Image.FromFile("C:\\ProFuSo\\Silueta Jugador.jpg");
                }
            }
            catch (Exception ex)
            { }
        }
        private void cmbVID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                /////Aca Cambiar
                string Jugador = cmbVID.Text;
                ValidarJugadorYaExistente(Jugador);
                var valor = Jugador;
                string var = valor;
                string Id = var.Split(',')[0];
                string var2 = var.Split(',')[1];
                string Apellido = var2.Split(' ')[0];
                string Nombre = var2.Split(' ')[1];
                int idJugador = Convert.ToInt32(Id);
                /////Aca Cambiar
                grbVID.Text = Apellido + " " + Nombre;
                pictureVID.Visible = true;
                /////Aca Cambiar
                lblVID.Text = Id;
                byte[] ImagenJugador = JugadoresNeg.BuscarImagenJugador(idJugador);
                if (ImagenJugador != null)
                {
                    Bitmap foto1 = Clases_Maestras.Funciones.byteToBipmap(ImagenJugador);
                    /////Aca Cambiar
                    pictureVID.Image = foto1;
                }
                else
                {
                    /////Aca Cambiar
                    pictureVID.Image = Image.FromFile("C:\\ProFuSo\\Silueta Jugador.jpg");
                }
            }
            catch (Exception ex)
            { }
        }
        private void cmbMC_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                /////Aca Cambiar
                string Jugador = cmbMC.Text;
                ValidarJugadorYaExistente(Jugador);
                var valor = Jugador;
                string var = valor;
                string Id = var.Split(',')[0];
                string var2 = var.Split(',')[1];
                string Apellido = var2.Split(' ')[0];
                string Nombre = var2.Split(' ')[1];
                int idJugador = Convert.ToInt32(Id);
                grbMC.Text = Apellido + " " + Nombre;
                pictureMC.Visible = true;
                /////Aca Cambiar
                lblMC.Text = Id;
                byte[] ImagenJugador = JugadoresNeg.BuscarImagenJugador(idJugador);
                if (ImagenJugador != null)
                {
                    Bitmap foto1 = Clases_Maestras.Funciones.byteToBipmap(ImagenJugador);
                    /////Aca Cambiar
                    pictureMC.Image = foto1;
                }
                else
                {
                    /////Aca Cambiar
                    pictureMC.Image = Image.FromFile("C:\\ProFuSo\\Silueta Jugador.jpg");
                }
            }
            catch (Exception ex)
            { }
        }
        private void cmbVII_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                /////Aca Cambiar
                string Jugador = cmbVII.Text;
                ValidarJugadorYaExistente(Jugador);
                var valor = Jugador;
                string var = valor;
                string Id = var.Split(',')[0];
                string var2 = var.Split(',')[1];
                string Apellido = var2.Split(' ')[0];
                string Nombre = var2.Split(' ')[1];
                int idJugador = Convert.ToInt32(Id);
                grbVII.Text = Apellido + " " + Nombre;
                pictureVII.Visible = true;
                /////Aca Cambiar
                lblVII.Text = Id;
                byte[] ImagenJugador = JugadoresNeg.BuscarImagenJugador(idJugador);
                if (ImagenJugador != null)
                {
                    Bitmap foto1 = Clases_Maestras.Funciones.byteToBipmap(ImagenJugador);
                    /////Aca Cambiar
                    pictureVII.Image = foto1;
                }
                else
                {
                    /////Aca Cambiar
                    pictureVII.Image = Image.FromFile("C:\\ProFuSo\\Silueta Jugador.jpg");
                }
            }
            catch (Exception ex)
            { }
        }
        private void cmbVI_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                /////Aca Cambiar
                string Jugador = cmbVI.Text;
                ValidarJugadorYaExistente(Jugador);
                var valor = Jugador;
                string var = valor;
                string Id = var.Split(',')[0];
                string var2 = var.Split(',')[1];
                string Apellido = var2.Split(' ')[0];
                string Nombre = var2.Split(' ')[1];
                int idJugador = Convert.ToInt32(Id);
                grbVI.Text = Apellido + " " + Nombre;
                pictureVI.Visible = true;
                /////Aca Cambiar
                lblVI.Text = Id;
                byte[] ImagenJugador = JugadoresNeg.BuscarImagenJugador(idJugador);
                if (ImagenJugador != null)
                {
                    Bitmap foto1 = Clases_Maestras.Funciones.byteToBipmap(ImagenJugador);
                    /////Aca Cambiar
                    pictureVI.Image = foto1;
                }
                else
                {
                    /////Aca Cambiar
                    pictureVI.Image = Image.FromFile("C:\\ProFuSo\\Silueta Jugador.jpg");
                }
            }
            catch (Exception ex)
            { }
        }
        private void cmbMP_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                /////Aca Cambiar
                string Jugador = cmbMP.Text;
                ValidarJugadorYaExistente(Jugador);
                var valor = Jugador;
                string var = valor;
                string Id = var.Split(',')[0];
                string var2 = var.Split(',')[1];
                string Apellido = var2.Split(' ')[0];
                string Nombre = var2.Split(' ')[1];
                int idJugador = Convert.ToInt32(Id);
                grbMP.Text = Apellido + " " + Nombre;
                pictureMP.Visible = true;
                /////Aca Cambiar
                lblMP.Text = Id;
                byte[] ImagenJugador = JugadoresNeg.BuscarImagenJugador(idJugador);
                if (ImagenJugador != null)
                {
                    Bitmap foto1 = Clases_Maestras.Funciones.byteToBipmap(ImagenJugador);
                    /////Aca Cambiar
                    pictureMP.Image = foto1;
                }
                else
                {
                    /////Aca Cambiar
                    pictureMP.Image = Image.FromFile("C:\\ProFuSo\\Silueta Jugador.jpg");
                }
            }
            catch (Exception ex)
            { }
        }
        private void cmbED_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                /////Aca Cambiar
                string Jugador = cmbED.Text;
                ValidarJugadorYaExistente(Jugador);
                var valor = Jugador;
                string var = valor;
                string Id = var.Split(',')[0];
                string var2 = var.Split(',')[1];
                string Apellido = var2.Split(' ')[0];
                string Nombre = var2.Split(' ')[1];
                int idJugador = Convert.ToInt32(Id);
                grbED.Text = Apellido + " " + Nombre;
                pictureED.Visible = true;
                /////Aca Cambiar
                lblED.Text = Id;
                byte[] ImagenJugador = JugadoresNeg.BuscarImagenJugador(idJugador);
                if (ImagenJugador != null)
                {
                    Bitmap foto1 = Clases_Maestras.Funciones.byteToBipmap(ImagenJugador);
                    /////Aca Cambiar
                    pictureED.Image = foto1;
                }
                else
                {
                    /////Aca Cambiar
                    pictureED.Image = Image.FromFile("C:\\ProFuSo\\Silueta Jugador.jpg");
                }

            }
            catch (Exception ex)
            { }
        }
        private void cmbCD1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                /////Aca Cambiar
                string Jugador = cmbCD1.Text;
                ValidarJugadorYaExistente(Jugador);
                var valor = Jugador;
                string var = valor;
                string Id = var.Split(',')[0];
                string var2 = var.Split(',')[1];
                string Apellido = var2.Split(' ')[0];
                string Nombre = var2.Split(' ')[1];
                int idJugador = Convert.ToInt32(Id);
                grbCD1.Text = Apellido + " " + Nombre;
                pictureCD1.Visible = true;
                /////Aca Cambiar
                lblCD1.Text = Id;
                byte[] ImagenJugador = JugadoresNeg.BuscarImagenJugador(idJugador);
                if (ImagenJugador != null)
                {
                    Bitmap foto1 = Clases_Maestras.Funciones.byteToBipmap(ImagenJugador);
                    /////Aca Cambiar
                    pictureCD1.Image = foto1;
                }
                else
                {
                    /////Aca Cambiar
                    pictureCD1.Image = Image.FromFile("C:\\ProFuSo\\Silueta Jugador.jpg");
                }
            }
            catch (Exception ex)
            { }
        }
        private void cmbCD_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                /////Aca Cambiar
                string Jugador = cmbCD.Text;
                ValidarJugadorYaExistente(Jugador);
                var valor = Jugador;
                string var = valor;
                string Id = var.Split(',')[0];
                string var2 = var.Split(',')[1];
                string Apellido = var2.Split(' ')[0];
                string Nombre = var2.Split(' ')[1];
                int idJugador = Convert.ToInt32(Id);
                grbCD.Text = Apellido + " " + Nombre;
                pictureCD.Visible = true;
                /////Aca Cambiar
                lblCD.Text = Id;
                byte[] ImagenJugador = JugadoresNeg.BuscarImagenJugador(idJugador);
                if (ImagenJugador != null)
                {
                    Bitmap foto1 = Clases_Maestras.Funciones.byteToBipmap(ImagenJugador);
                    /////Aca Cambiar
                    pictureCD.Image = foto1;
                }
                else
                {
                    /////Aca Cambiar
                    pictureCD.Image = Image.FromFile("C:\\ProFuSo\\Silueta Jugador.jpg");
                }
            }
            catch (Exception ex)
            { }
        }
        private void cmbCD2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                /////Aca Cambiar
                string Jugador = cmbCD2.Text;
                ValidarJugadorYaExistente(Jugador);
                var valor = Jugador;
                string var = valor;
                string Id = var.Split(',')[0];
                string var2 = var.Split(',')[1];
                string Apellido = var2.Split(' ')[0];
                string Nombre = var2.Split(' ')[1];
                int idJugador = Convert.ToInt32(Id);
                grbCD2.Text = Apellido + " " + Nombre;
                pictureCD2.Visible = true;
                /////Aca Cambiar
                lblCD2.Text = Id;
                byte[] ImagenJugador = JugadoresNeg.BuscarImagenJugador(idJugador);
                if (ImagenJugador != null)
                {
                    Bitmap foto1 = Clases_Maestras.Funciones.byteToBipmap(ImagenJugador);
                    /////Aca Cambiar
                    pictureCD2.Image = foto1;
                }
                else
                {
                    /////Aca Cambiar
                    pictureCD2.Image = Image.FromFile("C:\\ProFuSo\\Silueta Jugador.jpg");
                }
            }
            catch (Exception ex)
            { }
        }
        private void cmbEI_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                /////Aca Cambiar
                string Jugador = cmbEI.Text;
                ValidarJugadorYaExistente(Jugador);
                var valor = Jugador;
                string var = valor;
                string Id = var.Split(',')[0];
                string var2 = var.Split(',')[1];
                string Apellido = var2.Split(' ')[0];
                string Nombre = var2.Split(' ')[1];
                int idJugador = Convert.ToInt32(Id);
                grbEI.Text = Apellido + " " + Nombre;
                pictureEI.Visible = true;
                /////Aca Cambiar
                lblEI.Text = Id;
                byte[] ImagenJugador = JugadoresNeg.BuscarImagenJugador(idJugador);
                if (ImagenJugador != null)
                {
                    Bitmap foto1 = Clases_Maestras.Funciones.byteToBipmap(ImagenJugador);
                    /////Aca Cambiar
                    pictureEI.Image = foto1;
                }
                else
                {
                    /////Aca Cambiar
                    pictureEI.Image = Image.FromFile("C:\\ProFuSo\\Silueta Jugador.jpg");
                }
            }
            catch (Exception ex)
            { }
        }
        private void cmbSup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                /////Aca Cambiar
                string Jugador = cmbSup1.Text;
                ValidarJugadorYaExistente(Jugador);
                var valor = Jugador;
                string var = valor;
                string Id = var.Split(',')[0];
                string var2 = var.Split(',')[1];
                string Apellido = var2.Split(' ')[0];
                string Nombre = var2.Split(' ')[1];
                int idJugador = Convert.ToInt32(Id);
                grbSup1.Text = Apellido + " " + Nombre;
                pictureSup1.Visible = true;
                /////Aca Cambiar
                lblSup1.Text = Id;
                byte[] ImagenJugador = JugadoresNeg.BuscarImagenJugador(idJugador);
                if (ImagenJugador != null)
                {
                    Bitmap foto1 = Clases_Maestras.Funciones.byteToBipmap(ImagenJugador);
                    /////Aca Cambiar
                    pictureSup1.Image = foto1;
                }
                else
                {
                    /////Aca Cambiar
                    pictureSup1.Image = Image.FromFile("C:\\ProFuSo\\Silueta Jugador.jpg");
                }
            }
            catch (Exception ex)
            { }
        }
        private void cmbSup2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                /////Aca Cambiar
                string Jugador = cmbSup2.Text;
                ValidarJugadorYaExistente(Jugador);
                var valor = Jugador;
                string var = valor;
                string Id = var.Split(',')[0];
                string var2 = var.Split(',')[1];
                string Apellido = var2.Split(' ')[0];
                string Nombre = var2.Split(' ')[1];
                int idJugador = Convert.ToInt32(Id);
                grbSup2.Text = Apellido + " " + Nombre;
                pictureSup2.Visible = true;
                /////Aca Cambiar
                lblSup2.Text = Id;
                byte[] ImagenJugador = JugadoresNeg.BuscarImagenJugador(idJugador);
                if (ImagenJugador != null)
                {
                    Bitmap foto1 = Clases_Maestras.Funciones.byteToBipmap(ImagenJugador);
                    /////Aca Cambiar
                    pictureSup2.Image = foto1;
                }
                else
                {
                    /////Aca Cambiar
                    pictureSup2.Image = Image.FromFile("C:\\ProFuSo\\Silueta Jugador.jpg");
                }
            }
            catch (Exception ex)
            { }
        }
        private void cmbSup3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                /////Aca Cambiar
                string Jugador = cmbSup3.Text;
                ValidarJugadorYaExistente(Jugador);
                var valor = Jugador;
                string var = valor;
                string Id = var.Split(',')[0];
                string var2 = var.Split(',')[1];
                string Apellido = var2.Split(' ')[0];
                string Nombre = var2.Split(' ')[1];
                int idJugador = Convert.ToInt32(Id);
                grbSup3.Text = Apellido + " " + Nombre;
                pictureSup3.Visible = true;
                /////Aca Cambiar
                lblSup3.Text = Id;
                byte[] ImagenJugador = JugadoresNeg.BuscarImagenJugador(idJugador);
                if (ImagenJugador != null)
                {
                    Bitmap foto1 = Clases_Maestras.Funciones.byteToBipmap(ImagenJugador);
                    /////Aca Cambiar
                    pictureSup3.Image = foto1;
                }
                else
                {
                    /////Aca Cambiar
                    pictureSup3.Image = Image.FromFile("C:\\ProFuSo\\Silueta Jugador.jpg");
                }
            }
            catch (Exception ex)
            { }
        }
        private void cmbSup4_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                /////Aca Cambiar
                string Jugador = cmbSup4.Text;
                ValidarJugadorYaExistente(Jugador);
                var valor = Jugador;
                string var = valor;
                string Id = var.Split(',')[0];
                string var2 = var.Split(',')[1];
                string Apellido = var2.Split(' ')[0];
                string Nombre = var2.Split(' ')[1];
                int idJugador = Convert.ToInt32(Id);
                grbSup4.Text = Apellido + " " + Nombre;
                pictureSup4.Visible = true;
                /////Aca Cambiar
                lblSup4.Text = Id;
                byte[] ImagenJugador = JugadoresNeg.BuscarImagenJugador(idJugador);
                if (ImagenJugador != null)
                {
                    Bitmap foto1 = Clases_Maestras.Funciones.byteToBipmap(ImagenJugador);
                    /////Aca Cambiar
                    pictureSup4.Image = foto1;
                }
                else
                {
                    /////Aca Cambiar
                    pictureSup4.Image = Image.FromFile("C:\\ProFuSo\\Silueta Jugador.jpg");
                }
            }
            catch (Exception ex)
            { }
        }
        private void cmbSup5_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                /////Aca Cambiar
                string Jugador = cmbSup5.Text;
                ValidarJugadorYaExistente(Jugador);
                var valor = Jugador;
                string var = valor;
                string Id = var.Split(',')[0];
                string var2 = var.Split(',')[1];
                string Apellido = var2.Split(' ')[0];
                string Nombre = var2.Split(' ')[1];
                int idJugador = Convert.ToInt32(Id);
                grbSup5.Text = Apellido + " " + Nombre;
                pictureSup5.Visible = true;
                /////Aca Cambiar
                lblSup5.Text = Id;
                byte[] ImagenJugador = JugadoresNeg.BuscarImagenJugador(idJugador);
                if (ImagenJugador != null)
                {
                    Bitmap foto1 = Clases_Maestras.Funciones.byteToBipmap(ImagenJugador);
                    /////Aca Cambiar
                    pictureSup5.Image = foto1;
                }
                else
                {
                    /////Aca Cambiar
                    pictureSup5.Image = Image.FromFile("C:\\ProFuSo\\Silueta Jugador.jpg");
                }
            }
            catch (Exception ex)
            { }
        }
        private void cmbSup6_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                /////Aca Cambiar
                string Jugador = cmbSup6.Text;
                ValidarJugadorYaExistente(Jugador);
                var valor = Jugador;
                string var = valor;
                string Id = var.Split(',')[0];
                string var2 = var.Split(',')[1];
                string Apellido = var2.Split(' ')[0];
                string Nombre = var2.Split(' ')[1];
                int idJugador = Convert.ToInt32(Id);
                grbSup6.Text = Apellido + " " + Nombre;
                pictureSup6.Visible = true;
                /////Aca Cambiar
                lblSup6.Text = Id;
                byte[] ImagenJugador = JugadoresNeg.BuscarImagenJugador(idJugador);
                if (ImagenJugador != null)
                {
                    Bitmap foto1 = Clases_Maestras.Funciones.byteToBipmap(ImagenJugador);
                    /////Aca Cambiar
                    pictureSup6.Image = foto1;
                }
                else
                {
                    /////Aca Cambiar
                    pictureSup6.Image = Image.FromFile("C:\\ProFuSo\\Silueta Jugador.jpg");
                }
            }
            catch (Exception ex)
            { }
        }
        private void cmbSup7_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                /////Aca Cambiar
                string Jugador = cmbSup7.Text;
                ValidarJugadorYaExistente(Jugador);
                var valor = Jugador;
                string var = valor;
                string Id = var.Split(',')[0];
                string var2 = var.Split(',')[1];
                string Apellido = var2.Split(' ')[0];
                string Nombre = var2.Split(' ')[1];
                int idJugador = Convert.ToInt32(Id);
                grbSup7.Text = Apellido + " " + Nombre;
                pictureSup7.Visible = true;
                /////Aca Cambiar
                lblSup7.Text = Id;
                byte[] ImagenJugador = JugadoresNeg.BuscarImagenJugador(idJugador);
                if (ImagenJugador != null)
                {
                    Bitmap foto1 = Clases_Maestras.Funciones.byteToBipmap(ImagenJugador);
                    /////Aca Cambiar
                    pictureSup7.Image = foto1;
                }
                else
                {
                    /////Aca Cambiar
                    pictureSup7.Image = Image.FromFile("C:\\ProFuSo\\Silueta Jugador.jpg");
                }
            }
            catch (Exception ex)
            { }
        }
        private void txtAmarillaARQ_TextChanged(object sender, EventArgs e)
        {
            string Amarilla = txtAmarillaARQ.Text;
            if (!string.IsNullOrEmpty(Amarilla))
            {
                int Amonestado = Convert.ToInt32(Amarilla);
                if (Amonestado > 0)
                {
                    if (Amonestado > 2)
                    {
                        const string message = "Solo se puede cargar 2 Amarillas por jugador en un mismo partido.";
                        const string caption = "Atención";
                        var result = MessageBox.Show(message, caption,
                                                     MessageBoxButtons.OK,
                                                   MessageBoxIcon.Exclamation);
                        Amonestado = 0;
                        txtRojasARQ.Text = "0";
                    }
                    if (Amonestado == 2)
                    {
                        txtRojasARQ.Text = "1";
                    }
                    if (Amonestado == 1 || Amonestado == 0)
                    {
                        txtRojasARQ.Text = "0";
                    }
                    if (Amonestado == 0)
                    {
                        txtAmarillaARQ.Text = "0";
                    }
                }
                if (Amonestado == 0)
                {
                    txtAmarillaARQ.Text = "0";
                    txtRojasARQ.Text = "0";
                }
            }
            else { txtAmarillaARQ.Text = "0"; }
        }
        private void txtAmarillaLD_TextChanged(object sender, EventArgs e)
        {
            string Amarilla = txtAmarillaLD.Text;
            if (!string.IsNullOrEmpty(Amarilla))
            {
                int Amonestado = Convert.ToInt32(Amarilla);
                if (Amonestado > 0)
                {
                    if (Amonestado > 2)
                    {
                        const string message = "Solo se puede cargar 2 Amarillas por jugador en un mismo partido.";
                        const string caption = "Atención";
                        var result = MessageBox.Show(message, caption,
                                                     MessageBoxButtons.OK,
                                                   MessageBoxIcon.Exclamation);
                        Amonestado = 0;
                        txtRojasLD.Text = "0";
                    }
                    if (Amonestado == 2)
                    {
                        txtRojasLD.Text = "1";
                    }
                    if (Amonestado == 1 || Amonestado == 0)
                    {
                        txtRojasLD.Text = "0";
                    }
                    if (Amonestado == 0)
                    {
                        txtAmarillaLD.Text = "0";
                    }
                }
                if (Amonestado == 0)
                {
                    txtAmarillaLD.Text = "0";
                    txtRojasLD.Text = "0";
                }
            }
            else { txtAmarillaLD.Text = "0"; }
        }
        private void txtAmarillaDFD_TextChanged(object sender, EventArgs e)
        {
            string Amarilla = txtAmarillaDFD.Text;
            if (!string.IsNullOrEmpty(Amarilla))
            {
                int Amonestado = Convert.ToInt32(Amarilla);
                if (Amonestado > 0)
                {
                    if (Amonestado > 2)
                    {
                        const string message = "Solo se puede cargar 2 Amarillas por jugador en un mismo partido.";
                        const string caption = "Atención";
                        var result = MessageBox.Show(message, caption,
                                                     MessageBoxButtons.OK,
                                                   MessageBoxIcon.Exclamation);
                        Amonestado = 0;
                        txtRojasDFD.Text = "0";
                    }
                    if (Amonestado == 2)
                    {
                        txtRojasDFD.Text = "1";
                    }
                    if (Amonestado == 1 || Amonestado == 0)
                    {
                        txtRojasDFD.Text = "0";
                    }
                    if (Amonestado == 0)
                    {
                        txtAmarillaDFD.Text = "0";
                    }
                }
                if (Amonestado == 0)
                {
                    txtAmarillaDFD.Text = "0";
                    txtRojasDFD.Text = "0";
                }
            }
            else { txtAmarillaDFD.Text = "0"; }
        }
        private void txtAmarillaLIB_TextChanged(object sender, EventArgs e)
        {
            string Amarilla = txtAmarillaLIB.Text;
            if (!string.IsNullOrEmpty(Amarilla))
            {
                int Amonestado = Convert.ToInt32(Amarilla);
                if (Amonestado > 0)
                {
                    if (Amonestado > 2)
                    {
                        const string message = "Solo se puede cargar 2 Amarillas por jugador en un mismo partido.";
                        const string caption = "Atención";
                        var result = MessageBox.Show(message, caption,
                                                     MessageBoxButtons.OK,
                                                   MessageBoxIcon.Exclamation);
                        Amonestado = 0;
                        txtRojasLIB.Text = "0";
                    }
                    if (Amonestado == 2)
                    {
                        txtRojasLIB.Text = "1";
                    }
                    if (Amonestado == 1 || Amonestado == 0)
                    {
                        txtRojasLIB.Text = "0";
                    }
                    if (Amonestado == 0)
                    {
                        txtAmarillaLIB.Text = "0";
                    }
                }
                if (Amonestado == 0)
                {
                    txtAmarillaLIB.Text = "0";
                    txtRojasLIB.Text = "0";
                }
            }
            else { txtAmarillaLIB.Text = "0"; }
        }
        private void txtAmarillaDFI_TextChanged(object sender, EventArgs e)
        {
            string Amarilla = txtAmarillaDFI.Text;
            if (!string.IsNullOrEmpty(Amarilla))
            {
                int Amonestado = Convert.ToInt32(Amarilla);
                if (Amonestado > 0)
                {
                    if (Amonestado > 2)
                    {
                        const string message = "Solo se puede cargar 2 Amarillas por jugador en un mismo partido.";
                        const string caption = "Atención";
                        var result = MessageBox.Show(message, caption,
                                                     MessageBoxButtons.OK,
                                                   MessageBoxIcon.Exclamation);
                        Amonestado = 0;
                        txtRojasDFI.Text = "0";
                    }
                    if (Amonestado == 2)
                    {
                        txtRojasDFI.Text = "1";
                    }
                    if (Amonestado == 1 || Amonestado == 0)
                    {
                        txtRojasDFI.Text = "0";
                    }
                    if (Amonestado == 0)
                    {
                        txtAmarillaDFI.Text = "0";
                    }
                }
                if (Amonestado == 0)
                {
                    txtAmarillaDFI.Text = "0";
                    txtRojasDFI.Text = "0";
                }
            }
            else { txtAmarillaDFI.Text = "0"; }
        }
        private void txtAmarillaLI_TextChanged(object sender, EventArgs e)
        {
            string Amarilla = txtAmarillaLI.Text;
            if (!string.IsNullOrEmpty(Amarilla))
            {
                int Amonestado = Convert.ToInt32(Amarilla);
                if (Amonestado > 0)
                {
                    if (Amonestado > 2)
                    {
                        const string message = "Solo se puede cargar 2 Amarillas por jugador en un mismo partido.";
                        const string caption = "Atención";
                        var result = MessageBox.Show(message, caption,
                                                     MessageBoxButtons.OK,
                                                   MessageBoxIcon.Exclamation);
                        Amonestado = 0;
                        txtRojasLI.Text = "0";
                    }
                    if (Amonestado == 2)
                    {
                        txtRojasLI.Text = "1";
                    }
                    if (Amonestado == 1 || Amonestado == 0)
                    {
                        txtRojasLI.Text = "0";
                    }
                    if (Amonestado == 0)
                    {
                        txtAmarillaLI.Text = "0";
                    }
                }
                if (Amonestado == 0)
                {
                    txtAmarillaLI.Text = "0";
                    txtRojasLI.Text = "0";
                }
            }
            else { txtAmarillaLI.Text = "0"; }
        }
        private void txtAmarillaVD_TextChanged(object sender, EventArgs e)
        {
            string Amarilla = txtAmarillaVD.Text;
            if (!string.IsNullOrEmpty(Amarilla))
            {
                int Amonestado = Convert.ToInt32(Amarilla);
                if (Amonestado > 0)
                {
                    if (Amonestado > 2)
                    {
                        const string message = "Solo se puede cargar 2 Amarillas por jugador en un mismo partido.";
                        const string caption = "Atención";
                        var result = MessageBox.Show(message, caption,
                                                     MessageBoxButtons.OK,
                                                   MessageBoxIcon.Exclamation);
                        Amonestado = 0;
                        txtRojasVD.Text = "0";
                    }
                    if (Amonestado == 2)
                    {
                        txtRojasVD.Text = "1";
                    }
                    if (Amonestado == 1 || Amonestado == 0)
                    {
                        txtRojasVD.Text = "0";
                    }
                    if (Amonestado == 0)
                    {
                        txtAmarillaVD.Text = "0";
                    }
                }
                if (Amonestado == 0)
                {
                    txtAmarillaVD.Text = "0";
                    txtRojasVD.Text = "0";
                }
            }
            else { txtAmarillaVD.Text = "0"; }
        }
        private void txtAmarillaVID_TextChanged(object sender, EventArgs e)
        {
            string Amarilla = txtAmarillaVID.Text;
            if (!string.IsNullOrEmpty(Amarilla))
            {
                int Amonestado = Convert.ToInt32(Amarilla);
                if (Amonestado > 0)
                {
                    if (Amonestado > 2)
                    {
                        const string message = "Solo se puede cargar 2 Amarillas por jugador en un mismo partido.";
                        const string caption = "Atención";
                        var result = MessageBox.Show(message, caption,
                                                     MessageBoxButtons.OK,
                                                   MessageBoxIcon.Exclamation);
                        Amonestado = 0;
                        txtRojasVID.Text = "0";
                    }
                    if (Amonestado == 2)
                    {
                        txtRojasVID.Text = "1";
                    }
                    if (Amonestado == 1 || Amonestado == 0)
                    {
                        txtRojasVID.Text = "0";
                    }
                    if (Amonestado == 0)
                    {
                        txtAmarillaVID.Text = "0";
                    }
                }
                if (Amonestado == 0)
                {
                    txtAmarillaVID.Text = "0";
                    txtRojasVID.Text = "0";
                }
            }
            else { txtAmarillaVID.Text = "0"; }
        }
        private void txtAmarillaMC_TextChanged(object sender, EventArgs e)
        {
            string Amarilla = txtAmarillaMC.Text;
            if (!string.IsNullOrEmpty(Amarilla))
            {
                int Amonestado = Convert.ToInt32(Amarilla);
                if (Amonestado > 0)
                {
                    if (Amonestado > 2)
                    {
                        const string message = "Solo se puede cargar 2 Amarillas por jugador en un mismo partido.";
                        const string caption = "Atención";
                        var result = MessageBox.Show(message, caption,
                                                     MessageBoxButtons.OK,
                                                   MessageBoxIcon.Exclamation);
                        Amonestado = 0;
                        txtRojasMC.Text = "0";
                    }
                    if (Amonestado == 2)
                    {
                        txtRojasMC.Text = "1";
                    }
                    if (Amonestado == 1 || Amonestado == 0)
                    {
                        txtRojasMC.Text = "0";
                    }
                    if (Amonestado == 0)
                    {
                        txtAmarillaMC.Text = "0";
                    }
                }
                if (Amonestado == 0)
                {
                    txtAmarillaMC.Text = "0";
                    txtRojasMC.Text = "0";
                }
            }
            else { txtAmarillaMC.Text = "0"; }
        }
        private void txtAmarillaVII_TextChanged(object sender, EventArgs e)
        {
            string Amarilla = txtAmarillaVII.Text;
            if (!string.IsNullOrEmpty(Amarilla))
            {
                int Amonestado = Convert.ToInt32(Amarilla);
                if (Amonestado > 0)
                {
                    if (Amonestado > 2)
                    {
                        const string message = "Solo se puede cargar 2 Amarillas por jugador en un mismo partido.";
                        const string caption = "Atención";
                        var result = MessageBox.Show(message, caption,
                                                     MessageBoxButtons.OK,
                                                   MessageBoxIcon.Exclamation);
                        Amonestado = 0;
                        txtRojasVII.Text = "0";
                    }
                    if (Amonestado == 2)
                    {
                        txtRojasVII.Text = "1";
                    }
                    if (Amonestado == 1 || Amonestado == 0)
                    {
                        txtRojasVII.Text = "0";
                    }
                    if (Amonestado == 0)
                    {
                        txtAmarillaVII.Text = "0";
                    }
                }
                if (Amonestado == 0)
                {
                    txtAmarillaVII.Text = "0";
                    txtRojasVII.Text = "0";
                }
            }
            else { txtAmarillaVII.Text = "0"; }
        }
        private void txtAmarillaVI_TextChanged(object sender, EventArgs e)
        {
            string Amarilla = txtAmarillaVI.Text;
            if (!string.IsNullOrEmpty(Amarilla))
            {
                int Amonestado = Convert.ToInt32(Amarilla);
                if (Amonestado > 0)
                {
                    if (Amonestado > 2)
                    {
                        const string message = "Solo se puede cargar 2 Amarillas por jugador en un mismo partido.";
                        const string caption = "Atención";
                        var result = MessageBox.Show(message, caption,
                                                     MessageBoxButtons.OK,
                                                   MessageBoxIcon.Exclamation);
                        Amonestado = 0;
                        txtRojasVI.Text = "0";
                    }
                    if (Amonestado == 2)
                    {
                        txtRojasVI.Text = "1";
                    }
                    if (Amonestado == 1 || Amonestado == 0)
                    {
                        txtRojasVI.Text = "0";
                    }
                    if (Amonestado == 0)
                    {
                        txtAmarillaVI.Text = "0";
                    }
                }
                if (Amonestado == 0)
                {
                    txtAmarillaVI.Text = "0";
                    txtRojasVI.Text = "0";
                }
            }
            else { txtAmarillaVI.Text = "0"; }
        }
        private void txtAmarillaED_TextChanged(object sender, EventArgs e)
        {
            string Amarilla = txtAmarillaED.Text;
            if (!string.IsNullOrEmpty(Amarilla))
            {
                int Amonestado = Convert.ToInt32(Amarilla);
                if (Amonestado > 0)
                {
                    if (Amonestado > 2)
                    {
                        const string message = "Solo se puede cargar 2 Amarillas por jugador en un mismo partido.";
                        const string caption = "Atención";
                        var result = MessageBox.Show(message, caption,
                                                     MessageBoxButtons.OK,
                                                   MessageBoxIcon.Exclamation);
                        Amonestado = 0;
                        txtRojasED.Text = "0";
                    }
                    if (Amonestado == 2)
                    {
                        txtRojasED.Text = "1";
                    }
                    if (Amonestado == 1 || Amonestado == 0)
                    {
                        txtRojasED.Text = "0";
                    }
                    if (Amonestado == 0)
                    {
                        txtAmarillaED.Text = "0";
                    }
                }
                if (Amonestado == 0)
                {
                    txtAmarillaED.Text = "0";
                    txtRojasED.Text = "0";
                }
            }
            else { txtAmarillaED.Text = "0"; }
        }
        private void txtAmarillaMP_TextChanged(object sender, EventArgs e)
        {
            string Amarilla = txtAmarillaMP.Text;
            if (!string.IsNullOrEmpty(Amarilla))
            {
                int Amonestado = Convert.ToInt32(Amarilla);
                if (Amonestado > 0)
                {
                    if (Amonestado > 2)
                    {
                        const string message = "Solo se puede cargar 2 Amarillas por jugador en un mismo partido.";
                        const string caption = "Atención";
                        var result = MessageBox.Show(message, caption,
                                                     MessageBoxButtons.OK,
                                                   MessageBoxIcon.Exclamation);
                        Amonestado = 0;
                        txtRojasMP.Text = "0";
                    }
                    if (Amonestado == 2)
                    {
                        txtRojasMP.Text = "1";
                    }
                    if (Amonestado == 1 || Amonestado == 0)
                    {
                        txtRojasMP.Text = "0";
                    }
                    if (Amonestado == 0)
                    {
                        txtAmarillaMP.Text = "0";
                    }
                }
                if (Amonestado == 0)
                {
                    txtAmarillaMP.Text = "0";
                    txtRojasMP.Text = "0";
                }
            }
            else { txtAmarillaMP.Text = "0"; }
        }
        private void txtAmarillaEI_TextChanged(object sender, EventArgs e)
        {
            string Amarilla = txtAmarillaEI.Text;
            if (!string.IsNullOrEmpty(Amarilla))
            {
                int Amonestado = Convert.ToInt32(Amarilla);
                if (Amonestado > 0)
                {
                    if (Amonestado > 2)
                    {
                        const string message = "Solo se puede cargar 2 Amarillas por jugador en un mismo partido.";
                        const string caption = "Atención";
                        var result = MessageBox.Show(message, caption,
                                                     MessageBoxButtons.OK,
                                                   MessageBoxIcon.Exclamation);
                        Amonestado = 0;
                        txtRojasEI.Text = "0";
                    }
                    if (Amonestado == 2)
                    {
                        txtRojasEI.Text = "1";
                    }
                    if (Amonestado == 1 || Amonestado == 0)
                    {
                        txtRojasEI.Text = "0";
                    }
                    if (Amonestado == 0)
                    {
                        txtAmarillaEI.Text = "0";
                    }
                }
                if (Amonestado == 0)
                {
                    txtAmarillaEI.Text = "0";
                    txtRojasEI.Text = "0";
                }
            }
            else { txtAmarillaEI.Text = "0"; }
        }
        private void txtAmarillaCD1_TextChanged(object sender, EventArgs e)
        {
            string Amarilla = txtAmarillaCD1.Text;
            if (!string.IsNullOrEmpty(Amarilla))
            {
                int Amonestado = Convert.ToInt32(Amarilla);
                if (Amonestado > 0)
                {
                    if (Amonestado > 2)
                    {
                        const string message = "Solo se puede cargar 2 Amarillas por jugador en un mismo partido.";
                        const string caption = "Atención";
                        var result = MessageBox.Show(message, caption,
                                                     MessageBoxButtons.OK,
                                                   MessageBoxIcon.Exclamation);
                        Amonestado = 0;
                        txtRojasCD1.Text = "0";
                    }
                    if (Amonestado == 2)
                    {
                        txtRojasCD1.Text = "1";
                    }
                    if (Amonestado == 1 || Amonestado == 0)
                    {
                        txtRojasCD1.Text = "0";
                    }
                    if (Amonestado == 0)
                    {
                        txtAmarillaCD1.Text = "0";
                    }
                }
                if (Amonestado == 0)
                {
                    txtAmarillaCD1.Text = "0";
                    txtRojasCD1.Text = "0";
                }
            }
            else { txtAmarillaCD1.Text = "0"; }
        }
        private void txtAmarillaCD_TextChanged(object sender, EventArgs e)
        {
            string Amarilla = txtAmarillaCD.Text;
            if (!string.IsNullOrEmpty(Amarilla))
            {
                int Amonestado = Convert.ToInt32(Amarilla);
                if (Amonestado > 0)
                {
                    if (Amonestado > 2)
                    {
                        const string message = "Solo se puede cargar 2 Amarillas por jugador en un mismo partido.";
                        const string caption = "Atención";
                        var result = MessageBox.Show(message, caption,
                                                     MessageBoxButtons.OK,
                                                   MessageBoxIcon.Exclamation);
                        Amonestado = 0;
                        txtRojasCD.Text = "0";
                    }
                    if (Amonestado == 2)
                    {
                        txtRojasCD.Text = "1";
                    }
                    if (Amonestado == 1 || Amonestado == 0)
                    {
                        txtRojasCD.Text = "0";
                    }
                    if (Amonestado == 0)
                    {
                        txtAmarillaCD.Text = "0";
                    }
                }
                if (Amonestado == 0)
                {
                    txtAmarillaCD.Text = "0";
                    txtRojasCD.Text = "0";
                }
            }
            else { txtAmarillaCD.Text = "0"; }
        }
        private void txtAmarillaCD2_TextChanged(object sender, EventArgs e)
        {
            string Amarilla = txtAmarillaCD2.Text;
            if (!string.IsNullOrEmpty(Amarilla))
            {
                int Amonestado = Convert.ToInt32(Amarilla);
                if (Amonestado > 0)
                {
                    if (Amonestado > 2)
                    {
                        const string message = "Solo se puede cargar 2 Amarillas por jugador en un mismo partido.";
                        const string caption = "Atención";
                        var result = MessageBox.Show(message, caption,
                                                     MessageBoxButtons.OK,
                                                   MessageBoxIcon.Exclamation);
                        Amonestado = 0;
                        txtRojasCD2.Text = "0";
                    }
                    if (Amonestado == 2)
                    {
                        txtRojasCD2.Text = "1";
                    }
                    if (Amonestado == 1 || Amonestado == 0)
                    {
                        txtRojasCD2.Text = "0";
                    }
                    if (Amonestado == 0)
                    {
                        txtAmarillaCD2.Text = "0";
                    }
                }
                if (Amonestado == 0)
                {
                    txtAmarillaCD2.Text = "0";
                    txtRojasCD2.Text = "0";
                }
            }
            else { txtAmarillaCD2.Text = "0"; }
        }
        private void txtAmarillasSup1_TextChanged(object sender, EventArgs e)
        {
            string Amarilla = txtAmarillasSup1.Text;
            if (!string.IsNullOrEmpty(Amarilla))
            {
                int Amonestado = Convert.ToInt32(Amarilla);
                if (Amonestado > 0)
                {
                    if (Amonestado > 2)
                    {
                        const string message = "Solo se puede cargar 2 Amarillas por jugador en un mismo partido.";
                        const string caption = "Atención";
                        var result = MessageBox.Show(message, caption,
                                                     MessageBoxButtons.OK,
                                                   MessageBoxIcon.Exclamation);
                        Amonestado = 0;
                        txtRojasSup1.Text = "0";
                    }
                    if (Amonestado == 2)
                    {
                        txtRojasSup1.Text = "1";
                    }
                    if (Amonestado == 1 || Amonestado == 0)
                    {
                        txtRojasSup1.Text = "0";
                    }
                    if (Amonestado == 0)
                    {
                        txtAmarillasSup1.Text = "0";
                    }
                }
                if (Amonestado == 0)
                {
                    txtAmarillasSup1.Text = "0";
                    txtRojasSup1.Text = "0";
                }
            }
            else { txtAmarillasSup1.Text = "0"; }
        }
        private void txtAmarillasSup2_TextChanged(object sender, EventArgs e)
        {
            string Amarilla = txtAmarillasSup2.Text;
            if (!string.IsNullOrEmpty(Amarilla))
            {
                int Amonestado = Convert.ToInt32(Amarilla);
                if (Amonestado > 0)
                {
                    if (Amonestado > 2)
                    {
                        const string message = "Solo se puede cargar 2 Amarillas por jugador en un mismo partido.";
                        const string caption = "Atención";
                        var result = MessageBox.Show(message, caption,
                                                     MessageBoxButtons.OK,
                                                   MessageBoxIcon.Exclamation);
                        Amonestado = 0;
                        txtRojasSup2.Text = "0";
                    }
                    if (Amonestado == 2)
                    {
                        txtRojasSup2.Text = "1";
                    }
                    if (Amonestado == 1 || Amonestado == 0)
                    {
                        txtRojasSup2.Text = "0";
                    }
                    if (Amonestado == 0)
                    {
                        txtAmarillasSup2.Text = "0";
                    }
                }
                if (Amonestado == 0)
                {
                    txtAmarillasSup2.Text = "0";
                    txtRojasSup2.Text = "0";
                }
            }
            else { txtAmarillasSup2.Text = "0"; }
        }
        private void txtAmarillasSup3_TextChanged(object sender, EventArgs e)
        {
            string Amarilla = txtAmarillasSup3.Text;
            if (!string.IsNullOrEmpty(Amarilla))
            {
                int Amonestado = Convert.ToInt32(Amarilla);
                if (Amonestado > 0)
                {
                    if (Amonestado > 2)
                    {
                        const string message = "Solo se puede cargar 2 Amarillas por jugador en un mismo partido.";
                        const string caption = "Atención";
                        var result = MessageBox.Show(message, caption,
                                                     MessageBoxButtons.OK,
                                                   MessageBoxIcon.Exclamation);
                        Amonestado = 0;
                        txtRojasSup3.Text = "0";
                    }
                    if (Amonestado == 2)
                    {
                        txtRojasSup3.Text = "1";
                    }
                    if (Amonestado == 1 || Amonestado == 0)
                    {
                        txtRojasSup3.Text = "0";
                    }
                    if (Amonestado == 0)
                    {
                        txtAmarillasSup3.Text = "0";
                    }
                }
                if (Amonestado == 0)
                {
                    txtAmarillasSup3.Text = "0";
                    txtRojasSup3.Text = "0";
                }
            }
            else { txtAmarillasSup3.Text = "0"; }
        }
        private void txtAmarillasSup4_TextChanged(object sender, EventArgs e)
        {
            string Amarilla = txtAmarillasSup4.Text;
            if (!string.IsNullOrEmpty(Amarilla))
            {
                int Amonestado = Convert.ToInt32(Amarilla);
                if (Amonestado > 0)
                {
                    if (Amonestado > 2)
                    {
                        const string message = "Solo se puede cargar 2 Amarillas por jugador en un mismo partido.";
                        const string caption = "Atención";
                        var result = MessageBox.Show(message, caption,
                                                     MessageBoxButtons.OK,
                                                   MessageBoxIcon.Exclamation);
                        Amonestado = 0;
                        txtRojasSup4.Text = "0";
                    }
                    if (Amonestado == 2)
                    {
                        txtRojasSup4.Text = "1";
                    }
                    if (Amonestado == 1 || Amonestado == 0)
                    {
                        txtRojasSup4.Text = "0";
                    }
                    if (Amonestado == 0)
                    {
                        txtAmarillasSup4.Text = "0";
                    }
                }
                if (Amonestado == 0)
                {
                    txtAmarillasSup4.Text = "0";
                    txtRojasSup4.Text = "0";
                }
            }
            else { txtAmarillasSup4.Text = "0"; }
        }
        private void txtAmarillasSup5_TextChanged(object sender, EventArgs e)
        {
            string Amarilla = txtAmarillasSup5.Text;
            if (!string.IsNullOrEmpty(Amarilla))
            {
                int Amonestado = Convert.ToInt32(Amarilla);
                if (Amonestado > 0)
                {
                    if (Amonestado > 2)
                    {
                        const string message = "Solo se puede cargar 2 Amarillas por jugador en un mismo partido.";
                        const string caption = "Atención";
                        var result = MessageBox.Show(message, caption,
                                                     MessageBoxButtons.OK,
                                                   MessageBoxIcon.Exclamation);
                        Amonestado = 0;
                        txtRojasSup5.Text = "0";
                    }
                    if (Amonestado == 2)
                    {
                        txtRojasSup5.Text = "1";
                    }
                    if (Amonestado == 1 || Amonestado == 0)
                    {
                        txtRojasSup5.Text = "0";
                    }
                    if (Amonestado == 0)
                    {
                        txtAmarillasSup5.Text = "0";
                    }
                }
                if (Amonestado == 0)
                {
                    txtAmarillasSup5.Text = "0";
                    txtRojasSup5.Text = "0";
                }
            }
            else { txtAmarillasSup5.Text = "0"; }
        }
        private void txtAmarillasSup6_TextChanged(object sender, EventArgs e)
        {
            string Amarilla = txtAmarillasSup6.Text;
            if (!string.IsNullOrEmpty(Amarilla))
            {
                int Amonestado = Convert.ToInt32(Amarilla);
                if (Amonestado > 0)
                {
                    if (Amonestado > 2)
                    {
                        const string message = "Solo se puede cargar 2 Amarillas por jugador en un mismo partido.";
                        const string caption = "Atención";
                        var result = MessageBox.Show(message, caption,
                                                     MessageBoxButtons.OK,
                                                   MessageBoxIcon.Exclamation);
                        Amonestado = 0;
                        txtRojasSup6.Text = "0";
                    }
                    if (Amonestado == 2)
                    {
                        txtRojasSup6.Text = "1";
                    }
                    if (Amonestado == 1 || Amonestado == 0)
                    {
                        txtRojasSup6.Text = "0";
                    }
                    if (Amonestado == 0)
                    {
                        txtAmarillasSup6.Text = "0";
                    }
                }
                if (Amonestado == 0)
                {
                    txtAmarillasSup6.Text = "0";
                    txtRojasSup6.Text = "0";
                }
            }
            else { txtAmarillasSup6.Text = "0"; }
        }
        private void txtAmarillasSup7_TextChanged(object sender, EventArgs e)
        {
            string Amarilla = txtAmarillasSup7.Text;
            if (!string.IsNullOrEmpty(Amarilla))
            {
                int Amonestado = Convert.ToInt32(Amarilla);
                if (Amonestado > 0)
                {
                    if (Amonestado > 2)
                    {
                        const string message = "Solo se puede cargar 2 Amarillas por jugador en un mismo partido.";
                        const string caption = "Atención";
                        var result = MessageBox.Show(message, caption,
                                                     MessageBoxButtons.OK,
                                                   MessageBoxIcon.Exclamation);
                        Amonestado = 0;
                        txtRojasSup7.Text = "0";
                    }
                    if (Amonestado == 2)
                    {
                        txtRojasSup7.Text = "1";
                    }
                    if (Amonestado == 1 || Amonestado == 0)
                    {
                        txtRojasSup7.Text = "0";
                    }
                    if (Amonestado == 0)
                    {
                        txtAmarillasSup7.Text = "0";
                    }
                }
                if (Amonestado == 0)
                {
                    txtAmarillasSup7.Text = "0";
                    txtRojasSup7.Text = "0";
                }
            }
            else { txtAmarillasSup7.Text = "0"; }
        }
        #endregion   
    }
}
