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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Prode
{
    public partial class ConsultarFechaWF : MasterWF
    {
        public ConsultarFechaWF()
        {
            InitializeComponent();
        }

        private void ConsultarFechaWF_Load(object sender, EventArgs e)
        {
            FuncionesBotonHabilitarBuscar();
            CargarCombos();
        }
        #region Botones
        private void btnExcel_Click(object sender, EventArgs e)
        {
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridView1.MultiSelect = true;
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
            //Open an excel instance and paste the copied data
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Fecha> _fecha = new List<Fecha>();
                var torneo = cmbTorneo.Text;
                string var = torneo;
                string Torneo = var.Split('-')[0];
                string Temporada = var.Split('-')[1];
                string NroFecha = txtFecha.Text;
                _fecha = FechaNeg.BuscarFechaExistente(Torneo, Temporada, NroFecha);
                if (_fecha.Count > 0)
                {
                    dataGridView1.Visible = true;
                    for (int i = 0; i < _fecha.Count; i++)
                    {
                        dataGridView1.Rows.Add(_fecha[i].idPartido, _fecha[i].DiaPartido, _fecha[i].Estadio, " ", _fecha[i].EquipoLocal, " ", _fecha[i].EquipoVisitante, " ");
                    }
                }
            }
            catch (Exception ex)
            { }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            InicioWF _inicio = new InicioWF();
            _inicio.Show();
            Hide();
        }
        private void btnPdf_Click(object sender, EventArgs e)
        {
            ProgressBar();
            List<Fecha> _jugada = new List<Fecha>();
            _jugada = ObtenerDatosParaPdf();
            Document documentoPDF = new Document();
            var prueba =
            PdfWriter.GetInstance(documentoPDF, new FileStream("C:/'" + cmbTorneo.Text + " Nro.Factura " + txtFecha.Text + "'.pdf", FileMode.Create));
            documentoPDF.Open();
            Paragraph p1 = new Paragraph("Día " + "          " + "Estadio " + "          " + "Local" + "                    " + " Equipo" + "                    " + "Empate" + "                    " + "Equipo" + "                    " + "Visitante", FontFactory.GetFont(FontFactory.TIMES, 11, iTextSharp.text.Font.NORMAL));
            Paragraph p2 = new Paragraph();
            List<Paragraph> PruebaParagraph = new List<Paragraph>();
            //int partidosCount = _jugada.Count;
            for (int i = 0; i < _jugada.Count; i++)
            {
                p2.Clear();

                p2 = new Paragraph(_jugada[i].Dia.ToShortDateString() + "     " + _jugada[i].Estadio + "     " + _jugada[i].CondicionLocal + "                    " + _jugada[i].EquipoLocal + "                    " + _jugada[i].CondicionEmpate + "                    " + _jugada[i].EquipoVisitante + "                    " + _jugada[i].CondicionVisitante, FontFactory.GetFont(FontFactory.TIMES, 6, iTextSharp.text.Font.NORMAL));
                PruebaParagraph.Add(p2);
            }
            documentoPDF.Add(p1);
            if (PruebaParagraph.Count > 0)
            {
                for (int i = 0; i < PruebaParagraph.Count; i++)
                {
                    documentoPDF.Add(PruebaParagraph[i]);
                }
            }
            // documentoPDF.Add(new Paragraph(lblNombreEdit.Text +" "+ lblCuitEdit.Text, FontFactory.GetFont(FontFactory.TIMES, 11, iTextSharp.text.Font.NORMAL)));
            // documentoPDF.AddAuthor(groupBox2.Text);
            documentoPDF.AddAuthor(cmbTorneo.Text);
            documentoPDF.AddCreator("AjpdSoft Convertir texto a PDF - www.ajpdsoft.com");
            documentoPDF.AddKeywords(label1.Text);
            documentoPDF.AddSubject(cmbTorneo.Text);
            documentoPDF.AddTitle("Hola");
            documentoPDF.AddCreationDate();
            //'Cerramos el objeto documento, guardamos y creamos el PDF
            documentoPDF.Close();
            //System.Diagnostics.Process.Start(lblNombreEdit.Text);
            const string message2 = "Se realizo la exportación exitosamente.";
            const string caption2 = "Éxito";
            var result2 = MessageBox.Show(message2, caption2,
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Asterisk);          
        }
        private List<Fecha> ObtenerDatosParaPdf()
        {
            List<Fecha> _lista = new List<Fecha>();
            for (int fila = 0; fila < dataGridView1.Rows.Count - 1; fila++)
            {
                Fecha _jugada = new Fecha();
                string idPartido = dataGridView1.Rows[fila].Cells[0].Value.ToString();
                string Fecha = dataGridView1.Rows[fila].Cells[1].Value.ToString();
                string Estadio = dataGridView1.Rows[fila].Cells[2].Value.ToString();
                string Local = dataGridView1.Rows[fila].Cells[3].Value.ToString();
                string EquipoLocal = dataGridView1.Rows[fila].Cells[4].Value.ToString();
                string Empate = dataGridView1.Rows[fila].Cells[5].Value.ToString();
                string EquipoVisitante = dataGridView1.Rows[fila].Cells[6].Value.ToString();
                string Visitante = dataGridView1.Rows[fila].Cells[7].Value.ToString();
                _jugada.idPartido = Convert.ToInt32(idPartido);
                _jugada.Dia = Convert.ToDateTime(Fecha);
                _jugada.Estadio = Estadio;
                _jugada.CondicionLocal = Local;
                _jugada.EquipoLocal = EquipoLocal;
                _jugada.CondicionEmpate = Empate;
                _jugada.EquipoVisitante = EquipoVisitante;
                _jugada.CondicionVisitante = Visitante;
                _lista.Add(_jugada);

            }
            return _lista;
        }
        #endregion
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
        private void CargarCombos()
        {
            List<string> Torneo = new List<string>();
            Torneo = TorneoNeg.CargarComboTorneos();
            cmbTorneo.Items.Clear();
            cmbTorneo.Text = "Seleccione";
            cmbTorneo.Items.Add("Seleccione");
            foreach (string item in Torneo)
            {
                cmbTorneo.Text = "Seleccione";
                cmbTorneo.Items.Add(item);
            }
        }
        private void FuncionesBotonHabilitarBuscar()
        {
            cmbTorneo.Focus();
        }
        private void txtFecha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    List<Fecha> _fecha = new List<Fecha>();
                    var torneo = cmbTorneo.Text;
                    string var = torneo;
                    string Torneo = var.Split('-')[0];
                    string Temporada = var.Split('-')[1];
                    string NroFecha = txtFecha.Text;
                    _fecha = FechaNeg.BuscarFechaExistente(Torneo, Temporada, NroFecha);
                    if (_fecha.Count > 0)
                    {
                        dataGridView1.Visible = true;
                        for (int i = 0; i < _fecha.Count; i++)
                        {
                            dataGridView1.Rows.Add(_fecha[i].idPartido, _fecha[i].DiaPartido, _fecha[i].Estadio, " ", _fecha[i].EquipoLocal, " ", _fecha[i].EquipoVisitante, " ");
                        }
                    }
                }
                catch (Exception ex)
                { }
            }
        }
        #endregion


    }
}
