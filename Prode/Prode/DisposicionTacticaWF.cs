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
    public partial class DisposicionTacticaWF : Form
    {
        private List<string> listAlineacion;
        public DisposicionTacticaWF(List<string> listAlineacion)
        {
            InitializeComponent();
            this.listAlineacion = listAlineacion;
            listaRecibida = listAlineacion;
        }
        private void DisposicionTacticaWF_Load(object sender, EventArgs e)
        {
            try
            {
                CargarComboSistema();
                CargarComboJugadores();
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
        #endregion
        #region Funciones
        private void ValidarJugadorYaExistente(string Jugador)
        {
            List<int> lista = new List<int>();
            if (idListaJugadoresCargado != null)
            { lista = idListaJugadoresCargado; }
            var valor = Jugador;
            string var = valor;
            string Id = var.Split(',')[0];
            string var2 = var.Split(',')[1];
            string Apellido = var2.Split(' ')[0];
            string Nombre = var2.Split(' ')[1];
            int idJugador = Convert.ToInt32(Id);
            lista.Add(idJugador);
            //lista = idListaJugadoresCargado;
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
            idListaJugadoresCargado = lista;
        }
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
        #endregion
        #region Eventos Combos
        public static List<int> idListaJugadoresCargado;
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
        #endregion

    }
}
