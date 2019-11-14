using Prode.Entidades;
using Prode.Negocio;
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
    public partial class AlineacionEquipoWF : Form
    {
        public AlineacionEquipoWF()
        {
            InitializeComponent();
        }

        private void AlineacionEquipoWF_Load(object sender, EventArgs e)
        {
            try
            {
                txtBuscarNombrePartido.AutoCompleteCustomSource = Clases_Maestras.AutoCompletePorPartido.Autocomplete();
                txtBuscarNombrePartido.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtBuscarNombrePartido.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtBuscarNombrePartido.Focus();
            }
            catch (Exception ex) { }
        }
        #region Botones
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string Partido = txtBuscarNombrePartido.Text;
                List<DetallePartido> _partido = new List<DetallePartido>();
                _partido = FutbolPartidoEstadisticaNeg.BuscarPartidoPorNombre(Partido);
                if (_partido.Count > 0)
                {
                    groupBox1.Visible = false;
                    grbDatosPartido.Visible = true;
                    var partido = _partido.First();
                    if (partido.EscudoLocal != null)
                    {
                        Bitmap foto1 = Clases_Maestras.Funciones.byteToBipmap(partido.EscudoLocal);
                        pictureBox1.Image = foto1;
                        pictureBox1.Visible = true;
                    }
                    else
                    {
                        pictureBox1.Image = Image.FromFile("C:\\ProFuSo\\Silueta Equipo.jpg");
                        pictureBox1.Visible = true;
                    }

                    if (partido.EscudoVisitante != null)
                    {
                        Bitmap foto2 = Clases_Maestras.Funciones.byteToBipmap(partido.EscudoVisitante);
                        pictureBox2.Image = foto2;
                        pictureBox2.Visible = true;
                    }
                    else
                    {
                        pictureBox2.Image = Image.FromFile("C:\\ProFuSo\\Silueta Equipo.jpg");
                        pictureBox2.Visible = true;
                    }

                }
            }
            catch (Exception ex) { }
        }
        #endregion
        #region Funciones
        #endregion

    }
}
